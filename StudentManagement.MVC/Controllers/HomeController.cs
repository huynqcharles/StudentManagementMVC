using Microsoft.AspNetCore.Mvc;
using StudentManagement.MVC.Models;
using StudentManagement.MVC.Services;
using System.Diagnostics;

namespace StudentManagement.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return RedirectToAction("Index", "Student");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}