using System.ComponentModel.DataAnnotations;

namespace CharityProject.Models
{
    public class Donation : BaseEntity  
    {
        [Required(ErrorMessage = "Donor seçilməlidir.")]
        public int DonorId { get; set; }

        [Required]
        public Donor Donor { get; set; }

        [Required(ErrorMessage = "İanə məbləği boş ola bilməz."),
        Range(1, double.MaxValue, ErrorMessage = "İanə məbləği müsbət bir rəqəm olmalıdır.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Kampaniya seçilməlidir.")]
        public int CampaignId { get; set; }

        [Required]
        public Campaign Campaign { get; set; }
    }
}
