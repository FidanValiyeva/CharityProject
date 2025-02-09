using CharityProject.ViewModels.Donation;

namespace CharityProject.ViewModels.Donor
{
    public class DonorItemVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public string? Message { get; set; }
        public int? UserId { get; set; }
        public List<DonationItemVM> Donations { get; set; } = new List<DonationItemVM>();
    }
}
