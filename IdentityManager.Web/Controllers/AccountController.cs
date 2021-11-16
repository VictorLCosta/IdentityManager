using System;
using System.Threading.Tasks;
using IdentityManager.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            var model = new UserViewModel();
            return View(model);
        }
    }
}
