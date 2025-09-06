using HotelReservationsDemo.Data;
using HotelReservationsDemo.Models;
using System.ComponentModel;
using System.Text;

namespace HotelReservationsDemo
{
	public partial class MainForm : Form
	{
		private BindingList<ReservationItem> _reservations = new();
		private RoomType[] _roomTypes = Array.Empty<RoomType>();
		private Service[] _services = Array.Empty<Service>();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// 1) Cargar datos
			_roomTypes = SeedData.GetRoomTypes().ToArray();
			_services = SeedData.GetServices().ToArray();

			// 2) ComboBox: tipos de habitación
			comboRoomType.DataSource = _roomTypes;
			comboRoomType.DisplayMember = nameof(RoomType.Name);
			comboRoomType.ValueMember = nameof(RoomType.Id);
			comboRoomType.SelectedIndex = 0;

			// 3) ListBox: servicios
			listServices.Items.Clear();
			foreach (Service service in _services) {
				listServices.Items.Add(service);
			}

			// 4) Fechas por defecto
			dtCheckIn.Value = DateTime.Today;
			dtCheckOut.Value = DateTime.Today.AddDays(1);

			// 5) DataGridView
			gridReservations.AutoGenerateColumns = false;
			gridReservations.AllowUserToAddRows = false;
			gridReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridReservations.MultiSelect = true;
			gridReservations.DataSource = _reservations;

			// Aquí las creamos por código para que tengan formato:
			gridReservations.Columns.Clear();
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.Room),
				HeaderText = "Habitación",
				ReadOnly = true,
				AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			});
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.Nights),
				HeaderText = "Noches",
				ReadOnly = true,
				Width = 70
			});
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.Guests),
				HeaderText = "Huéspedes",
				ReadOnly = true,
				Width = 90
			});
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.RoomRate),
				HeaderText = "Tarifa/Noche",
				ReadOnly = true,
				Width = 110,
				DefaultCellStyle = { Format = "Q 0.00" }
			});
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.ServicesSubtotal),
				HeaderText = "SubTotal/Servicios",
				ReadOnly = true,
				Width = 90,
				DefaultCellStyle = { Format = "Q 0.00" }
			});
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.Services),
                HeaderText = "Servicios",
				ReadOnly = true,
                Width = 200
            });
			gridReservations.Columns.Add(new DataGridViewTextBoxColumn
			{
				DataPropertyName = nameof(ReservationItem.Subtotal),
				HeaderText = "Subtotal",
				ReadOnly = true,
				Width = 100,
				DefaultCellStyle = { Format = "Q 0.00" }
			});

			_reservations.ListChanged += (_, __) => UpdateTotal();
			UpdateTotal();
		}

		private void UpdateTotal()
		{
			decimal total = _reservations.Sum(r => r.Subtotal);
			lblTotal.Text = $"Total: Q {total:0.00}";
		}

		private void btnAddReservation_Click(object sender, EventArgs e)
		{
			if (comboRoomType.SelectedItem is not RoomType rt) return;

			var checkIn = dtCheckIn.Value.Date;
			var checkOut = dtCheckOut.Value.Date;

			if (checkOut <= checkIn)
			{
				MessageBox.Show("La fecha de salida debe ser posterior a la de entrada.",
								"Fechas inválidas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int nights = (checkOut - checkIn).Days;
			int guests = (int)numGuests.Value;
			if (nights < 1) nights = 1;
			if (guests < 1) guests = 1;

			// Sumar servicios
			List<Service> selectedServices = listServices.SelectedItems.Cast<Service>().ToList();
			decimal servicesSubtotal = selectedServices.Sum(s => s.Price);
			string servicesText = selectedServices.Count > 0
				? string.Join(", ", selectedServices.Select(s => s.Name))
				: "—";

			// Penalización opcional por huésped extra (si excede capacidad):
			decimal extraFee = 0m;
			if (guests > rt.Capacity)
			{
				int extra = guests - rt.Capacity;
				extraFee = extra * 35.00m * nights; // Q35 por extra x noche
			}

			ReservationItem item = new ReservationItem
			{
				Room = rt.Name,
				Guests = guests,
				Services = servicesText
			};
			item.Recalc(nights, rt.NightlyRate, servicesSubtotal + extraFee);

			_reservations.Add(item);

		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			List<DataGridViewRow> rows = gridReservations.SelectedRows.Cast<DataGridViewRow>().ToList();
			foreach (var r in rows)
				if (r.DataBoundItem is ReservationItem it) _reservations.Remove(it);
		}

		private void btnExportCsv_Click(object sender, EventArgs e)
		{

			if (_reservations.Count == 0)
			{
				MessageBox.Show("No hay reservas para exportar.");
				return;
			}

			using SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV|*.csv", FileName = $"reservas_{DateTime.Now:yyyyMMdd_HHmm}.csv" };
			if (sfd.ShowDialog() != DialogResult.OK) return;

			StringBuilder sb = new StringBuilder();
			sb.AppendLine("Habitacion,Noches,Huespedes,TarifaNoche,Servicios,Subtotal");

			foreach (ReservationItem r in _reservations)
				sb.AppendLine($"{r.Room},{r.Nights},{r.Guests},{r.RoomRate:0.00},{r.ServicesSubtotal:0.00},{r.Subtotal:0.00}");

			//string sb = "Habitacion;Noches;Huespedes;TarifaNoche;Servicios;Subtotal\n";

			//foreach (ReservationItem r in _reservations)
			//	sb+=$"{r.Room};{r.Nights};{r.Guests};{r.RoomRate:0.00};{r.ServicesSubtotal:0.00};{r.Subtotal:0.00}\n";

			//File.WriteAllText(sfd.FileName, sb, Encoding.UTF8);
			File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
			MessageBox.Show("Exportado con éxito.");

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
