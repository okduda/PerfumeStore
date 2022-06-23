using Microsoft.AspNetCore.Mvc;

namespace PerfumeStore.Controllers
{
    public class AdminController : Controller
    {
        public AdminController()
        {
        }

        public IActionResult Index() 
        { 
            return View(); 
        } 

    }
}
