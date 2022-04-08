using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HotelReservation.Models;
using Microsoft.AspNetCore.Identity;

namespace HotelReservation.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public virtual ICollection<Reservation>? Reservations { get; set; }

    //public int Id { get; set; }
    //public string UserName { get; set; }
    //public string Password { get; set; }
    public string? FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string? LastName { get; set; }
    public string? SSN { get; set; }

    [DataType(DataType.Date)]
    public DateTime? HiredDate { get; set; }
    public bool IsAccountActive { get; set; }

    [DataType(DataType.Date)]
    public DateTime? FiredDate { get; set; }
}

