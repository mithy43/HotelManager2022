using HotelReservation.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public virtual Room? Room { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public virtual ICollection<Client>? Clients { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }
        public bool Breakfast { get; set; }
        public bool AllInclusive { get; set; }
        public double? Total { get; set; }
    }
}
