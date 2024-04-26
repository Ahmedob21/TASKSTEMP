using Microsoft.AspNetCore.Mvc;

namespace TASKSTEMP.Controllers
{
    public class adminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Analytics()
        {
            return View();
        }

        public IActionResult Chat() 
        {
            return View();
        }

        public IActionResult Contact() 
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Email_Inbox()
        {
            return View();
        }

        public IActionResult Email_Detail()
        {
            return View();
        }

        public IActionResult Email_Compose()
        {
            return View();
        }

        public IActionResult Alert()
        {
            return View();
        }
    }
}
