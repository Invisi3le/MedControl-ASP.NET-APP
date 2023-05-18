using MedControl.Data;
using MedControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedControl.Pages.Appointment
{
    public class DeleteAppointmentModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
     //   public AppointmentModel Appointment { get; set; }

        public DeleteAppointmentModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public int AppointmentId { get; set; }
       

        public AppointmentModel Appointment { get; set; }


        public async Task<IActionResult> OnGet(int id)
        {
            AppointmentId = id;
            var appointment = await _db.Appointments.FindAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            var appointment = await _db.Appointments.FindAsync(AppointmentId);
            if (appointment == null)
            {
                return NotFound();
            }

            _db.Appointments.Remove(appointment);
            await _db.SaveChangesAsync();
            TempData["success"] = "Appointment deleted successfully";

            return RedirectToPage("AppointmentsList");
        }
    }
}

