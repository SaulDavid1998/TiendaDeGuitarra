using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TiendaDeGuitarra.Models;

namespace TiendaDeGuitarra.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

       

        
    }
}
