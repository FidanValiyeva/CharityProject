using System.ComponentModel.DataAnnotations;

namespace CharityProject.ViewModels.ContactMessage
{
    public class ContactMessageDeleteVM
    {
        [Required]
        public int Id { get; set; }
    }
}
