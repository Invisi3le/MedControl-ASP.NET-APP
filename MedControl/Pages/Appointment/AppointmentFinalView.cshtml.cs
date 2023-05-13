using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedControl.Pages.Appointment
{
    [BindProperties(SupportsGet = true)]
    public class AppointmentFinalViewModel : PageModel
    {
        public string DoctorName { get; set; }
        public string Data { get; set; }
        public string Specialization { get; set; }
        public string Prescription { get; set; }
        public string Description { get; set; }

        public void OnGet(string doctorName, DateTime data, string specialization, string prescription, string description)
        {
            DoctorName = doctorName;
            Data = data.ToString("dd/MM/yyyy");
            Specialization = specialization;
            Prescription = prescription;
            Description = description;
        }
    }
}
