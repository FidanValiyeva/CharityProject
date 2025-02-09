namespace CharityProject.ViewModels.Volunteer
{
    public class VolunteerItemVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }
    }
}
