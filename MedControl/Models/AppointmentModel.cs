
using System.ComponentModel.DataAnnotations;

namespace MedControl.Models
{
    public class AppointmentModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DoctorName { get; set; }
        public DateTime Data { get; set; }
        public string Specialization { get; set; }
        public string Prescription { get; set; }
        public string Description { get; set; }

    }
}
