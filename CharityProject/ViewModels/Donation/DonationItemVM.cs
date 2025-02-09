namespace CharityProject.ViewModels.Donation
{
    public class DonationItemVM
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public decimal Amount { get; set; }
        public string CampaignName { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
