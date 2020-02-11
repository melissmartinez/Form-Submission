using Microsoft.AspNetCore.Mvc;
using formsubmission.Models;

namespace formsubmission.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(User newUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}