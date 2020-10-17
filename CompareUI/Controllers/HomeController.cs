using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CompareUI.Models;
using ApiHandshake;
using AfriCompare.API.Controllers;
using CompareHelper.Request;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;
using System.Text.Json;

namespace AfriCompareAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quotes()
        {
            return View();
        }

        public IActionResult BasicInfo()
        {
            return View();
        } 

        public IActionResult Confirmation()
        {
            return View();
        } 
        
        public IActionResult Login()
        {
            return View();
        }
        public JsonResult ProcessAddBasicInfo(AfriCompare.API.Controllers.UserRegistrationRequest model)
        {
            try
            {
                //var userData = MvcApplication.GetUserData(User.Identity.Name) ?? new UserData();  if (userData.UserId < 1) { return Json(new { IsSuccessful = false, Error = "Your session has expired", IsAuthenticated = false }); }
                //if (model == null)
                //{
                //    return Json(new { IsSuccessful = false, Error = "Your session has expired", IsAuthenticated = false });
                //}

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
                model.ConfirmationLink = System.Net.WebUtility.UrlDecode(confirmLink);

                var response = WebAPI<AuthenticationResult, UserRegistrationRequest>.Consume(SharedEndpoints.Register, model, model.Email);

                if (!response.IsSuccessful)
                {
                    return Json(new { IsSuccessful = false, IsReload = false, Error = response.DebugMessage }, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = false,
                    });
                }

                return Json(new { IsAuthenticated = true, IsSuccessful = true, IsReload = false, Error = "" },new JsonSerializerOptions
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

        public IActionResult VendorInfo()
        {
            return View();
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
