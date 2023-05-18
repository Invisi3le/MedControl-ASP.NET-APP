using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedControl.Models;
using MedControl.Data;

namespace MedControl.Pages.Appointment
{
    [BindProperties]
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
            
        public async Task <IActionResult> OnPost() { 
            
            await _db.Appointments.AddAsync(Appointment);
            await _db.SaveChangesAsync();
            TempData["success"] = "Wizyta zosta³a dodana";
            return RedirectToPage("AppointmentsList");
            
        }
    }
}
