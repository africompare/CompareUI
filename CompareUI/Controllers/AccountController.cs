using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CompareUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ApiHandshake;

namespace AfriCompare.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AccountController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }
  
        // GET: Register
        public ActionResult AccessDenied()
        {
            var userData = SecurityStore.GetUserData(_httpContextAccessor);
            if (null != userData&& !string.IsNullOrEmpty(userData.Role))
            {
                return RedirectToAction("Index", "Home", new { Area = userData.Role });
            }

            return View();
        } 
    }
}
