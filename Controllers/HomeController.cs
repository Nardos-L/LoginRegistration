using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register/user")]
        public IActionResult RegisterUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("RegisterSuccess", new {
                    firstName = newUser.FirstName,
                    lastName = newUser.LastName,
                    email = newUser.Email,
                    password = newUser.Password,
                    passwordConfirm = newUser.PasswordConfirm
                });
            }
            return View("Index");
        }
        [HttpPost("login/user")]
        public IActionResult LoginUser(LoginUser logedUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("LoginSuccess");
            }
            return View("Index");
        }
        [HttpGet("RegisterSuccess")]
        public IActionResult RegisterSuccess(string firstName ,string lastName,string email,string password,string passwordConfirm )
        {
            User registerSuccess = new User()

            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Password = password,
                PasswordConfirm = passwordConfirm
            };

            return View("Success",registerSuccess);
        }

        [HttpGet("LoginSuccess")]
        public IActionResult LoginSuccess()
        {
            return View("Success");
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
