using System;
using System.Linq;
using CompareUI.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ApiHandshake;

namespace AfriCompare.Admin.Controllers
{
    [Authorize(Roles="admin")]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }


        public IActionResult Index()
        {
            var userData = SecurityStore.GetUserData(_httpContextAccessor);
            if (null == userData || string.IsNullOrEmpty(userData.Role))
            {
                return Redirect("~/Home/Login");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ProductApproval()
        {
            ViewBag.Message = "Product Approval";

            return View();
        }
        public ActionResult SubcriberAdmin()
        {
            ViewBag.Message = "Subscriber";

            return View();
        }
        public ActionResult Vendor()
        {
            ViewBag.Message = "Vendor";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
