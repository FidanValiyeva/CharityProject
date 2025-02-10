using CharityProject.DAL;
using CharityProject.ViewModels.Campaign;
using CharityProject.ViewModels.ContactMessage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactMessageController(CharityDbContext _context, IWebHostEnvironment _env) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactMessages.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ContactMessageCreateVM vm)
        {
            return View(vm);
        }
        public async Task<IActionResult> Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(ContactMessageUpdateVM vm)
        {
            return View(vm);
        }
       
    }
}
