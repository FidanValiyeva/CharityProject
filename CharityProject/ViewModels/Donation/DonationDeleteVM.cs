using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.Donation
{
    public class DonationDeleteVM
    {
        [Required]
        public int Id { get; set; }
    }
}
