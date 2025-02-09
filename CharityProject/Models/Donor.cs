using System.ComponentModel.DataAnnotations;

namespace CharityProject.Models
{
    public class Donor : BaseEntity 
    {
        [Required(ErrorMessage = "Ad və soyad tələb olunur."),
       MaxLength(100, ErrorMessage = "Ad maksimum 100 simvol ola bilər.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email tələb olunur."),
         EmailAddress(ErrorMessage = "Düzgün email formatı daxil edin.")]
        public string Email { get; set; }

        [MaxLength(200, ErrorMessage = "Ünvan maksimum 200 simvol ola bilər.")]
        public string? Address { get; set; }

        [MaxLength(500, ErrorMessage = "Mesaj maksimum 500 simvol ola bilər.")]
        public string? Message { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        public List<Donation> Donations { get; set; } = new List<Donation>();
    }
}
