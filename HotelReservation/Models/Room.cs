namespace HotelReservation.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int? Capacity { get; set; }
        public string? Type { get; set; }
        public bool IsVacant { get; set; }
        public decimal PricePerNightAdult { get; set; }
        public decimal PricePerNightChild { get; set; }
        public virtual ICollection<Reservation>? Reservations { get; set; }
    }
}
