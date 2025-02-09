using CharityProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CharityProject.DAL
{
    public class CharityDbContext:IdentityDbContext<User>
    {
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public CharityDbContext(DbContextOptions opt) : base(opt)
        {

        }
    }
}
