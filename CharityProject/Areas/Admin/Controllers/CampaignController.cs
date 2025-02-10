using Microsoft.AspNetCore.Mvc;

namespace CharityProject.Areas.Admin.Controllers
{
    using CharityProject.DAL;
    using CharityProject.Enums;
    using CharityProject.Models;
    using CharityProject.ViewModels.Campaign;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

   
    [Area("Admin")]
    public class CampaignController(CharityDbContext _context, IWebHostEnvironment _env) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Campaigns.ToListAsync());
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CampaignCreateVM vm)
        {
            return View(vm);
        }
        public async Task<IActionResult> Update()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Update(CampaignUpdateVM vm)
        {
            return View(vm);
        }
        public async Task<IActionResult> Delete(int id)
        {

            return View(); 
        }
        [HttpGet]
        public async Task<IActionResult> Delete(CampaignDeleteVM vm)
        {

            return View(vm);
        }




    }

}
