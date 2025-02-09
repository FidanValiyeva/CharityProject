using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.Volunteer
{
    public class VolunteerCreateVM
    {
        [Required(ErrorMessage = "Ad və soyad tələb olunur."),
        MaxLength(100, ErrorMessage = "Ad maksimum 100 simvol ola bilər.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email tələb olunur."),
         EmailAddress(ErrorMessage = "Düzgün email formatı daxil edin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon nömrəsi tələb olunur."),
         Phone(ErrorMessage = "Düzgün telefon nömrəsi daxil edin.")]
        public string PhoneNumber { get; set; }

        [MaxLength(255, ErrorMessage = "Şəkil URL maksimum 255 simvol ola bilər.")]
        public string? ImageUrl { get; set; }

        [MaxLength(500, ErrorMessage = "Təsvir maksimum 500 simvol ola bilər.")]
        public string? Description { get; set; }

        public int? UserId { get; set; }
    }
}
