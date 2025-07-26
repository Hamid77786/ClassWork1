using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;

namespace ClassWorkTemplate.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
