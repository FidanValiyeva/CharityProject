using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.Donor
{
    public class DonorDeleteVM
    {
        [Required]
        public int Id { get; set; }
    }
}
