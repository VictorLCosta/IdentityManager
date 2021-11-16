using System;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
