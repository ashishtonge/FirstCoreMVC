using Firstcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Firstcore.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // GET: Controllers
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserName == "Admin" && model.Password == "Admin123")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invaild Username and Password.");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}
