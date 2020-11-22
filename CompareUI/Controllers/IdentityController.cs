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
    public class IdentityController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IdentityController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }
        // GET: Register
        public ActionResult BlankPage()
        {
            return View();
        }
        //public JsonResult ProcessRegistration(AfriCompare.API.Controllers.UserRegistrationRequest model)
        //{
        //    return   Json(new {  IsAuthenticated = true, IsSuccessful = false, IsReload = false, Error = "Email is required" });
        //}

        [AllowAnonymous]
        public ActionResult ActivationConfirmation()
        {
            try
            {
                //ViewBag.Error = "";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error Occurred! Please try again later";
                _logger.Log( LogLevel.Critical, ex.Message);
                return View();
            }
        }

        [AllowAnonymous]
        public ActionResult Activation(UserActivationObj model)
        {
            //try
            //{
            //    if (model == null)
            //    {
            //        ViewBag.Error = "Invalid request session has expired";
            //        return View("LogInStudent", null, new GlobalLitePortalHelper.APIObjs.BusinessObj.StudentLoginObj());
            //    }

            //    if (string.IsNullOrEmpty(model.AccessToken) || model.AccessToken.Length < 5)
            //    {
            //        ViewBag.Error = "Invalid Access Token";
            //        return View("LogInStudent", null, new GlobalLitePortalHelper.APIObjs.BusinessObj.StudentLoginObj());
            //    }

            //    if (string.IsNullOrEmpty(model.EmailAddress) || model.EmailAddress.Length < 10)
            //    {
            //        ViewBag.Error = "Invalid EmailAddress";
            //        return View("LogInStudent", null, new GlobalLitePortalHelper.APIObjs.BusinessObj.StudentLoginObj());
            //    }

            //    var response = GlobalLitePortalHelper.APIServices.StudentService.Activate(model, model.EmailAddress);
            //    if (response?.Status == null)
            //    {
            //        ViewBag.Error = "Error Occurred! Please contact administrator.";
            //        return View("ActivationConfirmation");
            //    }

            //    if (!response.Status.IsSuccessful)
            //    {
            //        ViewBag.Message = "Your Accunt has been successfully activated";
            //        return View("ActivationConfirmation");
            //    }

            //    ViewBag.Message = "Your Account have been successfully activated";
               return View("ActivationConfirmation");//, null, new GlobalLitePortalHelper.APIObjs.BusinessObj.StudentLoginObj());

            //    //return RedirectToAction("LoginStudent", "StudentManager");
            //    //var regObj = new PluglexHelper.PortalObjs.RegUserObj
            //    //{
            //    //    AdminUserId = 1,
            //    //    Email = model.EmailAddress,
            //    //    FirstName = model.Othernames,
            //    //    LastName = model.Surname,
            //    //    MobileNumber = model.MobilePhone,
            //    //    Password = model.Password,
            //    //    UserType = (int)PluglexHelper.PortalObjs.UserType.App_User
            //    //};
            //    //var user = new PluglexHelper.PortalManager.PortalUserManager().AddUser(regObj,regObj.Email); 
            //}
            //catch (Exception ex)
            //{
            //    UtilTools.LogE(ex.StackTrace, ex.Source, ex.Message);
            //    ViewBag.Error = "Process Error Occurred! Please try again later";
            //    return View("LogInStudent", null, new GlobalLitePortalHelper.APIObjs.BusinessObj.StudentLoginObj());
            //}
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
