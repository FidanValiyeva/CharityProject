using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.Donation
{
    public class DonationUpdateVM
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Donor seçilməlidir.")]
        public int DonorId { get; set; }

        [Required(ErrorMessage = "İanə məbləği boş ola bilməz.")]
        [Range(1, double.MaxValue, ErrorMessage = "İanə məbləği müsbət bir rəqəm olmalıdır.")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Kampaniya seçilməlidir.")]
        public int CampaignId { get; set; }
       
    }
}
