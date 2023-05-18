using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedControl.Models;
using MedControl.Data;

namespace MedControl.Pages.Appointment
{
    [BindProperties]
    public class EditAppointmentModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public AppointmentModel Appointment { get; set; }

        public EditAppointmentModel(ApplicationDbContext db)
        {
            _db = db;

        }

        public void OnGet(int id)
        {
            Appointment = _db.Appointments.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {

            _db.Appointments.Update(Appointment);
            await _db.SaveChangesAsync();
            TempData["success"] = "Wizyta zosta³a zedytowana";
            return RedirectToPage("AppointmentsList");

        }
    }
}