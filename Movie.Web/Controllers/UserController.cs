using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Movie.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly Contract.Services.IUserService _userService;

        public UserController(Contract.Services.IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
    }
}