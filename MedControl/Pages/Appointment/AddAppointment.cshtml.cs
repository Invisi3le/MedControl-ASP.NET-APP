using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedControl.Models;
using MedControl.Data;

namespace MedControl.Pages.Appointment
{
    public class AddAppintmentModel : PageModel
    {
       private readonly ApplicationDbContext _db;
        public AppointmentModel Appointment { get; set; }

        public AddAppintmentModel(ApplicationDbContext db)
        {
            _db = db;
            
        }

        public void OnGet()
        {
        }
            
        public async Task <IActionResult> OnPost(AppointmentModel appointment) { 
            
            await _db.Appointments.AddAsync(appointment);
            await _db.SaveChangesAsync();
            return RedirectToPage("AppointmentsList");
            
        }
    }
}
