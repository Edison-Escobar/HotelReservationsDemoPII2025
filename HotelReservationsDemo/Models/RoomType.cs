namespace HotelReservationsDemo.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal NightlyRate { get; set; }
        public int Capacity { get; set; }
        public override string ToString() => $"{Name} (Q {NightlyRate:0.00}/noche, {Capacity} pax)";
    }
}
