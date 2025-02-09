using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.ContactMessage
{
    public class ContactMessageCreateVM
    {
        [Required, MaxLength(100, ErrorMessage = "Ad maksimum 100 simvol ola bilər.")]
        public string Name { get; set; }

        [Required, EmailAddress(ErrorMessage = "Düzgün email formatı daxil edin.")]
        public string Email { get; set; }

        [Required, MaxLength(200, ErrorMessage = "Mövzu maksimum 200 simvol ola bilər.")]
        public string Subject { get; set; }

        [Required, MaxLength(2000, ErrorMessage = "Mesaj maksimum 2000 simvol ola bilər.")]
        public string Message { get; set; }
    }
}
