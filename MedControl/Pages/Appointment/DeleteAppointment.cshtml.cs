using MedControl.Data;
using MedControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedControl.Pages.Appointment
{
    public class DeleteAppointmentModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        
        public AppointmentModel Appointment { get; set; }

        public DeleteAppointmentModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Appointment = _db.Appointments.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            var appointmentFromDb = _db.Appointments.Find(Appointment.Id);
            if (appointmentFromDb != null)
            {
                _db.Appointments.Remove(appointmentFromDb);
                await _db.SaveChangesAsync();
                TempData["success"] = "Appointment deleted successfully";
                return RedirectToPage("AppointmentsList");
            }


            return Page();
        }
    }
}
