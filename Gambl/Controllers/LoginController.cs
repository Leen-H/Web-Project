
using Microsoft.AspNetCore.Mvc;
using Gambl.Data;
using Gambl.Models;

namespace Gambl.Controllers
{
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UserInfo user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }

       
        public IActionResult Admission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Admission(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserEmail == email && u.Password == password);
            if (user != null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.Message = "Invalid email or password.";
            return View();
        }
    }
}
