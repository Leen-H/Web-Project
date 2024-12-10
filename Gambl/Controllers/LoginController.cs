using Microsoft.AspNetCore.Mvc;

namespace Gambl.Controllers
{
    public class LoginController:Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Admission(){
            return View();
        }
        public IActionResult SignUp(){
            return View();
        }

    }
}