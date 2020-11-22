using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CompareUI.Models;
using Microsoft.AspNetCore.Authorization;
 
namespace AfriCompare.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
  
        // GET: Register
        public ActionResult AccessDenied()
        {
            return View();
        } 
    }
}
