using HotelReservation.Areas.Identity.Data;
using HotelReservation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Data;

public class HotelReservationContext : IdentityDbContext<ApplicationUser>
{
    public virtual DbSet<Reservation> Reservations { get; set; }
    public virtual DbSet<Room> Rooms { get; set; }
    public virtual DbSet<Client> Clients { get; set; }

    public HotelReservationContext(DbContextOptions<HotelReservationContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .HasMany(u => u.Reservations)
            .WithOne(re => re.User)
            .HasForeignKey(re => re.UserId);

        builder.Entity<Room>()
            .HasMany(r => r.Reservations)
            .WithOne(re => re.Room)
            .HasForeignKey(re => re.RoomId);

        builder.Entity<Reservation>()
            .HasMany(r => r.Clients)
            .WithOne(c => c.Reservation)
            .HasForeignKey(c => c.ReservationId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();
    }
}
