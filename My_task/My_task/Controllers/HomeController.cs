using Microsoft.AspNetCore.Mvc;
using My_task.Models;
using System.Diagnostics;

namespace My_task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        public IActionResult Index(Multiplication multiplication)
        {
   
            multiplication.Multiplicand = 1;
            
            return View(multiplication);
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}