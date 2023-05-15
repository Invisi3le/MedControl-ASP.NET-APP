using MedControl.Data;
using MedControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MedControl.Pages.Appointment
{
    public class AppointmentsListModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public IEnumerable<AppointmentModel> Appointments { get; set; }

        public AppointmentsListModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Appointments = _db.Appointments;
        }
    }
}
