using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.Volunteer
{
    public class VolunteerDeleteVM
    {
        [Required]
        public int Id { get; set; }
    }
}
