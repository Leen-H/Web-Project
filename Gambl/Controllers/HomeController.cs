using Microsoft.AspNetCore.Mvc;

namespace Gambl.Controllers
{
    public class HomeController:Controller{
        public IActionResult Index(){
            return View();
        }

    }
}