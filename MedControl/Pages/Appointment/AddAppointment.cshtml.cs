using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedControl.Models;

namespace MedControl.Pages.Appointment
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public AppointmentModel Appointment { get; set; }


        public void OnGet()
        {
        }

        public IActionResult OnPost() { 
            return RedirectToPage("AppointmentFinalView", new { Appointment.DoctorName, Appointment.Data, Appointment.Specialization, Appointment.Prescription, Appointment.Description
            }); //TU MOZE BYC B£¥D
        }
    }
}
