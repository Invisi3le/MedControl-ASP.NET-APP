using MedControl.Models;
using Microsoft.EntityFrameworkCore;

namespace MedControl.Data
{
    public class ApplicationDbContext : DbContext

    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<AppointmentModel> Appointments { get; set; }
    }
}
