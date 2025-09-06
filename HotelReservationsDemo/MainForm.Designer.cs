namespace HotelReservationsDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			btnAddReservation = new Button();
			label5 = new Label();
			dtCheckOut = new DateTimePicker();
			label4 = new Label();
			label3 = new Label();
			dtCheckIn = new DateTimePicker();
			label2 = new Label();
			numGuests = new NumericUpDown();
			label1 = new Label();
			listServices = new ListBox();
			comboRoomType = new ComboBox();
			panel2 = new Panel();
			label6 = new Label();
			lblTotal = new Label();
			btnExportCsv = new Button();
			btnRemove = new Button();
			gridReservations = new DataGridView();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)numGuests).BeginInit();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)gridReservations).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.Teal;
			panel1.Controls.Add(btnAddReservation);
			panel1.Controls.Add(label5);
			panel1.Controls.Add(dtCheckOut);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(dtCheckIn);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(numGuests);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(listServices);
			panel1.Controls.Add(comboRoomType);
			panel1.Location = new Point(2, 3);
			panel1.Margin = new Padding(3, 4, 3, 4);
			panel1.Name = "panel1";
			panel1.Size = new Size(373, 775);
			panel1.TabIndex = 0;
			// 
			// btnAddReservation
			// 
			btnAddReservation.Location = new Point(3, 707);
			btnAddReservation.Margin = new Padding(3, 4, 3, 4);
			btnAddReservation.Name = "btnAddReservation";
			btnAddReservation.Size = new Size(366, 49);
			btnAddReservation.TabIndex = 10;
			btnAddReservation.Text = "Agregar reserva ➜";
			btnAddReservation.UseVisualStyleBackColor = true;
			btnAddReservation.Click += btnAddReservation_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.White;
			label5.Location = new Point(6, 324);
			label5.Name = "label5";
			label5.Size = new Size(146, 20);
			label5.TabIndex = 9;
			label5.Text = "Servicios adicionales";
			// 
			// dtCheckOut
			// 
			dtCheckOut.Format = DateTimePickerFormat.Short;
			dtCheckOut.Location = new Point(3, 269);
			dtCheckOut.Margin = new Padding(3, 4, 3, 4);
			dtCheckOut.Name = "dtCheckOut";
			dtCheckOut.Size = new Size(365, 27);
			dtCheckOut.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.White;
			label4.Location = new Point(6, 245);
			label4.Name = "label4";
			label4.Size = new Size(76, 20);
			label4.TabIndex = 7;
			label4.Text = "Check-out";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.White;
			label3.Location = new Point(6, 169);
			label3.Name = "label3";
			label3.Size = new Size(66, 20);
			label3.TabIndex = 6;
			label3.Text = "Check-in";
			// 
			// dtCheckIn
			// 
			dtCheckIn.Format = DateTimePickerFormat.Short;
			dtCheckIn.Location = new Point(3, 196);
			dtCheckIn.Margin = new Padding(3, 4, 3, 4);
			dtCheckIn.Name = "dtCheckIn";
			dtCheckIn.Size = new Size(365, 27);
			dtCheckIn.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(3, 99);
			label2.Name = "label2";
			label2.Size = new Size(82, 20);
			label2.TabIndex = 4;
			label2.Text = "Huéspedes";
			// 
			// numGuests
			// 
			numGuests.Location = new Point(3, 123);
			numGuests.Margin = new Padding(3, 4, 3, 4);
			numGuests.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			numGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numGuests.Name = "numGuests";
			numGuests.Size = new Size(366, 27);
			numGuests.TabIndex = 3;
			numGuests.Value = new decimal(new int[] { 2, 0, 0, 0 });
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.White;
			label1.Location = new Point(3, 32);
			label1.Name = "label1";
			label1.Size = new Size(134, 20);
			label1.TabIndex = 2;
			label1.Text = "Tipo de habitación";
			// 
			// listServices
			// 
			listServices.FormattingEnabled = true;
			listServices.Location = new Point(3, 361);
			listServices.Margin = new Padding(3, 4, 3, 4);
			listServices.Name = "listServices";
			listServices.SelectionMode = SelectionMode.MultiExtended;
			listServices.Size = new Size(365, 164);
			listServices.TabIndex = 1;
			// 
			// comboRoomType
			// 
			comboRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
			comboRoomType.FormattingEnabled = true;
			comboRoomType.Location = new Point(3, 56);
			comboRoomType.Margin = new Padding(3, 4, 3, 4);
			comboRoomType.Name = "comboRoomType";
			comboRoomType.Size = new Size(365, 28);
			comboRoomType.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.BackColor = Color.White;
			panel2.Controls.Add(label6);
			panel2.Controls.Add(lblTotal);
			panel2.Controls.Add(btnExportCsv);
			panel2.Controls.Add(btnRemove);
			panel2.Controls.Add(gridReservations);
			panel2.Location = new Point(381, 3);
			panel2.Margin = new Padding(3, 4, 3, 4);
			panel2.Name = "panel2";
			panel2.Size = new Size(891, 775);
			panel2.TabIndex = 1;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
			label6.Location = new Point(3, 9);
			label6.Name = "label6";
			label6.Size = new Size(424, 57);
			label6.TabIndex = 4;
			label6.Text = "Sistema de Reservas";
			// 
			// lblTotal
			// 
			lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			lblTotal.AutoSize = true;
			lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblTotal.Location = new Point(19, 196);
			lblTotal.Name = "lblTotal";
			lblTotal.Size = new Size(98, 20);
			lblTotal.TabIndex = 3;
			lblTotal.Text = "Total: Q 0.00";
			// 
			// btnExportCsv
			// 
			btnExportCsv.BackColor = Color.FromArgb(0, 192, 192);
			btnExportCsv.Location = new Point(785, 199);
			btnExportCsv.Margin = new Padding(3, 4, 3, 4);
			btnExportCsv.Name = "btnExportCsv";
			btnExportCsv.Size = new Size(94, 31);
			btnExportCsv.TabIndex = 2;
			btnExportCsv.Text = "Exportar CSV";
			btnExportCsv.UseVisualStyleBackColor = false;
			btnExportCsv.Click += btnExportCsv_Click;
			// 
			// btnRemove
			// 
			btnRemove.BackColor = Color.FromArgb(255, 128, 128);
			btnRemove.Location = new Point(693, 199);
			btnRemove.Margin = new Padding(3, 4, 3, 4);
			btnRemove.Name = "btnRemove";
			btnRemove.Size = new Size(86, 31);
			btnRemove.TabIndex = 1;
			btnRemove.Text = "Quitar";
			btnRemove.UseVisualStyleBackColor = false;
			btnRemove.Click += btnRemove_Click;
			// 
			// gridReservations
			// 
			gridReservations.AllowUserToAddRows = false;
			gridReservations.AllowUserToOrderColumns = true;
			gridReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			gridReservations.Location = new Point(3, 244);
			gridReservations.Margin = new Padding(3, 4, 3, 4);
			gridReservations.Name = "gridReservations";
			gridReservations.RowHeadersWidth = 51;
			gridReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			gridReservations.Size = new Size(885, 527);
			gridReservations.TabIndex = 0;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1273, 775);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Margin = new Padding(3, 4, 3, 4);
			Name = "MainForm";
			Text = "Reservas de Hotel";
			Load += MainForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)numGuests).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)gridReservations).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private ComboBox comboRoomType;
        private Panel panel2;
        private ListBox listServices;
        private DataGridView gridReservations;
        private Label label4;
        private Label label3;
        private DateTimePicker dtCheckIn;
        private Label label2;
        private NumericUpDown numGuests;
        private Label label1;
        private DateTimePicker dtCheckOut;
        private Button btnAddReservation;
        private Label label5;
        private Button btnExportCsv;
        private Button btnRemove;
        private Label lblTotal;
        private Label label6;
	}
}
