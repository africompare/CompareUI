using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
//using GlobalLitePortalHelper.APIObjs;
//using GlobalLitePortalHelper.APIObjs.BusinessObj;
//using GlobalLitePortalHelper.APIServices;
//using XPLUG.WEBTOOLKIT;

namespace GlobalLitePortal.Controllers.Data
{
    public class OBusinessDataProviderController : Controller
    {
        private readonly ILogger<OBusinessDataProviderController> _logger;

        public OBusinessDataProviderController(ILogger<OBusinessDataProviderController> logger)
        {
            _logger = logger;
        }

        public object StudentService { get; private set; }
        public object CourseService { get; private set; }

        //public ActionResult LoadCourses()
        //{
        //    var add = new NameValueObject { Id = 0, Name = "-- Empty Course List --" };
        //    try
        //    {
        //        //var userData = MvcApplication.GetUserData(User.Identity.Name);
        //        if (userData == null || userData.UserId < 1)
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        var searchObj = new CourseSearchObj
        //        {
        //            AdminUserId = userData.UserId,
        //            Status = 0,
        //        };

        //        var retVal = CourseService.LoadCourses(searchObj, userData.Username);
        //        if (retVal?.Status == null)
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        if (!retVal.Status.IsSuccessful)
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        if (!retVal.Courses.Any())
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        var parentTabs = retVal.Courses.Where(c => c.Status == 1).OrderBy(c => c.Name);
        //        add = new NameValueObject { Id = 0, Name = "-- Select Course  --" };

        //        var jsonitem = parentTabs.Select(o => new NameValueObject { Id = o.CourseId, Name = o.Name }).ToList();
        //        jsonitem.Insert(0, add);
        //        return Json(jsonitem, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.Log(LogLevel.Debug, $"{ex.StackTrace} ==> {ex.Source}  ==> {ex.Message}");
        //        return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //    } 
        //}
        //public ActionResult LoadStudents(int? TrainingId, int CourseId)
        //{
        //    var add = new NameValueObject { Id = 0, Name = "-- Empty student List --" };
        //    try
        //    {
        //        var userData = MvcApplication.GetUserData(User.Identity.Name);
        //        if (userData == null || userData.UserId < 1)
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        var searchObj = new StudentSearchObj
        //        {
        //            AdminUserId = userData.UserId,
        //            Status = 1,
        //        };

        //        if (TrainingId > 0)
        //        {
        //            var a = 2;
        //        }

        //        if (CourseId > 0)
        //        {
        //            var b = 2;
        //        }

        //        var retVal = StudentService.LoadStudents(searchObj, userData.Username);
        //        if (retVal?.Status == null)
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        if (!retVal.Status.IsSuccessful)
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        if (!retVal.Students.Any())
        //        {
        //            return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //        }

        //        //var parentTabs = retVal.Students.Where(c => c.Status == 1).OrderBy(c => c.Surname);
        //        var parentTabs = retVal.Students.OrderBy(c => c.Surname);
        //        add = new NameValueObject { Id = 0, Name = "-- Select Student  --" };

        //        var jsonitem = parentTabs.Select(o => new NameValueObject { Id = o.StudentId, Name = $"{o.Surname}, {o.Othernames}" }).ToList();
        //        //jsonitem.Insert(0, add);
        //        return Json(jsonitem, JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.Log(LogLevel.Debug, $"{ex.StackTrace} ==> {ex.Source}  ==> {ex.Message}");
        //        return Json(new List<NameValueObject> { add }, JsonRequestBehavior.AllowGet);
        //    }
        //}
    }
}