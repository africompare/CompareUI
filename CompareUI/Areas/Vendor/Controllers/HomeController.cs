using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CompareUI.Models;
using Microsoft.AspNetCore.Authorization;
using ApiHandshake;
using System.Text.Json;
using AfriCompare.Data.APIObjs;
using Microsoft.AspNetCore.Http;

namespace AfriCompare.Vendor.Controllers
{
    [Area("Vendor")]
    [Authorize(Roles = "vendor")]

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)//, SignInManager<ApplicationUser> signInManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var userData = SecurityStore.GetUserData(_httpContextAccessor);

            if (null == userData)
            {
                return Redirect("~/Home/Login");
            } 
            //var model = new RefreshTokenRequest {   RefreshToken = "sdsds", Token = "dfsds" };
            //var response = WebAPI<string, RefreshTokenRequest>.Consume(CompareHelper.Request.SharedEndpoints.Test1, model, userData.Email);
            //var response2 = WebAPI<string, RefreshTokenRequest>.Consume(CompareHelper.Request.SharedEndpoints.Test2, model, userData.Email);
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

        public ActionResult ProductList()
        {
            ViewBag.Message = "Product List.";

            return View();
        }

        public ActionResult MySubscribers()
        {
            ViewBag.Message = "My Subscribers";

            return View();
        }

        public ActionResult Industry()
        {
            ViewBag.Message = "Industry";

            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Profile";

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
