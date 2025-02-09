using System.Diagnostics;
using CharityProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharityProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }  
    }
}
