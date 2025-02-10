using CharityProject.DAL;
using CharityProject.ViewModels.Campaign;
using CharityProject.ViewModels.Donation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DonationController(CharityDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Donations.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(DonationCreateVM vm)
        {
            return View(vm);
        }
        public async Task<IActionResult> Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(DonationUpdateVM vm)
        {
            return View(vm);
        }
        public async Task<IActionResult> Delete(int id)
        {

            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(DonationDeleteVM vm)
        {

            return View(vm);
        }

    }
}
