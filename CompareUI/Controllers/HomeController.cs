using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using AfriCompare.Data.APIObjs;
using Microsoft.AspNetCore.Mvc;
using CompareHelper.Request;
using System.Diagnostics;
using CompareUI.Models;
using System.Text.Json;
using ApiHandshake;
using System.Linq;
using System.Web;
using CompareUI;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace AfriCompare.Controllers
{
    [Authorize (Roles ="customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
         
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)//, SignInManager<ApplicationUser> signInManager)
        {
            _httpContextAccessor = httpContextAccessor;
            //_signInManager = signInManager;
            _logger = logger;
            // SecurityStore.SecurityCore.
        }

         public IActionResult Index()
        {
            //var userData = MvcApplication.GetUserData(User.Identity.Name) ?? new UserData(); 
            //if (userData.UserId < 1) { return Json(new { IsSuccessful = false, Error = "Your session has expired", IsAuthenticated = false }); }
            //if (model == null)
            //{
            //    return Json(new { IsSuccessful = false, Error = "Your session has expired", IsAuthenticated = false });
            //} 
            return View();
        }
 
        public IActionResult Quotes()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult SignOut()
        {
            if (SecurityStore.SecurityCore == null)
            {
                SecurityStore.SecurityCore = new PortalSecurityCore(null, _httpContextAccessor);
            }
            
            SecurityStore.SecurityCore.SignOut(HttpContext);

            return  RedirectToAction("Index");
        }

        [AllowAnonymous]
        public IActionResult BasicInfo()
        {
            ViewBag.role = CompareApp.SetRequestInfo(_httpContextAccessor).Where(kvp => kvp.Key == "section").FirstOrDefault().Value;
            return View();
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult ProcessLogin(UserLoginRequest model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.Email) || model.Email.Length < 2)
                {
                    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Invalid Email" }, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                    });
                }

                if (string.IsNullOrEmpty(model.Password) || model.Password.Length < 2)
                {
                    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Invalid Password" });
                }

                SecurityStore.SecurityCore = new PortalSecurityCore(model, _httpContextAccessor);
                var response = _httpContextAccessor.HttpContext.Session.GetObjectFromJson<ApiHandshake.ItemResponseObj<UserProfileResult>>("loginresponse");

                if (null==response ||!response.IsSuccessful)
                {
                    return Json(new { IsSuccessful = false, IsReload = false, Error = response==null?"unknown error occured":response.DebugMessage }, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                    });
                }

                SecurityStore.SecurityCore.SignIn(HttpContext);

                return Json(new { IsAuthenticated = true, IsSuccessful = true, IsReload = false, Error = "", Role = response.Items[0].Role }, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false,
                });
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Debug, $"{ex.StackTrace} ==> {ex.Source}  ==> {ex.Message}");
                return Json(new { IsAuthenticated = true, IsSuccessful = true, IsReload = false, Error = "Process Error Occurred! Please try again later" });
            }
        }

        //var userData = MvcApplication.GetUserData(User.Identity.Name) ?? new UserData(); if (userData.UserId < 1) { return Json(new { IsSuccessful = false, Error = "Your session has expired", IsAuthenticated = false }); }

        //if (model == null)
        //{
        //    return Json(new { IsSuccessful = false, Error = "Your session has expired", IsAuthenticated = false });
        //}

        [AllowAnonymous]
        [HttpGet]
        public IActionResult ConfirmEmail(EmailConfirmationRequest model)
        {
            if (string.IsNullOrEmpty(model.UserId) || model.UserId.Length < 2)
            {
                return View("ConfirmEmailFail", null);
            }

            if (string.IsNullOrEmpty(model.Token) || model.Token.Length < 2)
            {
                return View("ConfirmEmailFail", null);
            }

            var response = WebAPI<AuthenticationResult, EmailConfirmationRequest>.Consume(SharedEndpoints.ConfirmEmail, model, "");
            if (!response.IsSuccessful)
            {
                return View("ConfirmEmailFail", response.DebugMessage);
            }

            return View();
        }

        [AllowAnonymous]
        public JsonResult ProcessAddBasicInfo(UserRegistrationRequest model)
        {
            try
            {
                if (string.IsNullOrEmpty(model.FullName) || model.FullName.Length < 2)
                {
                    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Invalid FullName" }, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                    });
                }

                if (string.IsNullOrEmpty(model.City) || model.City.Length < 2)
                {
                    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Invalid City" });
                }

                if (string.IsNullOrEmpty(model.PhoneNumber) || model.PhoneNumber.Length < 2)
                {
                    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Invalid PhoneNumber" });
                }

                if (string.IsNullOrEmpty(model.Salutation) || model.Salutation.Length < 2)
                {
                    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Invalid Salutation" });
                }

                //model.AdminUserId = userData.UserId;
                //model.Status = model.StatusVal ? 1 : 0;

                //if (Session["_AssignmentList_"] is List<AssignmentObj> previousAssignmentList)
                //{
                //    if (previousAssignmentList.Count(x => x.Name.ToLower().Trim().ToStandardHash() == model.Name.ToLower().Trim().ToStandardHash()) > 0)
                //        return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Assignment Information  Already Exist!" });
                //} 
                //var response = AssignmentService.AddAssignment(model, userData.Username);
                //if (response?.Status == null)
                //{
                //    return Json(new { IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Error Occurred! Please try again later" });
                //} 
                string confirmLink = Url.Action("ConfirmEmail", "Home", new { userId = "{userId}", token = "{token}" }, Request.Scheme);
                model.ConfirmationLink = HttpUtility.UrlDecode(confirmLink);

                //Extract role from query string
                //var paramList = CompareApp.GetRequestInfo(_httpContextAccessor);
                //var role =paramList.Where(kvp => kvp.Value == "section").FirstOrDefault().Value ;
                // model.Role = role;

                var response = WebAPI<AuthenticationResult, UserRegistrationRequest>.Consume(SharedEndpoints.Register, model, model.Email);

                if (!response.IsSuccessful)
                {
                    return Json(new { IsSuccessful = false, IsReload = false, Error = response.DebugMessage }, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                    });
                }
                //add to coockie
                return Json(new { IsAuthenticated = true, IsSuccessful = true, IsReload = false, Error = "" }, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = false,
                });
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Debug, $"{ex.StackTrace} ==> {ex.Source}  ==> {ex.Message}");
                return Json(new { IsAuthenticated = true, IsSuccessful = true, IsReload = false, Error = "Process Error Occurred! Please try again later" });
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
