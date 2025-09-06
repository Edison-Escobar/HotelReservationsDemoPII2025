using System.ComponentModel;

namespace HotelReservationsDemo.Models
{
    public class ReservationItem : INotifyPropertyChanged
    {
        public string Room { get; set; } = "";
        public int Nights { get; set; }
        public int Guests { get; set; }
        public decimal RoomRate { get; set; }
        public decimal ServicesSubtotal { get; set; }
        public string Services { get; set; } = "";
        public decimal Subtotal => (RoomRate * Nights) + ServicesSubtotal;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnChanged(string p) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));

        public void Recalc(int nights, decimal roomRate, decimal servicesSubtotal)
        {
            Nights = nights; 
            RoomRate = roomRate; 
            ServicesSubtotal = servicesSubtotal;
            OnChanged(nameof(Nights)); 
            OnChanged(nameof(RoomRate));
            OnChanged(nameof(ServicesSubtotal)); 
            OnChanged(nameof(Subtotal));
        }
    }
}
