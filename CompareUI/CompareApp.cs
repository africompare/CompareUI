using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Linq;
using System;
using Microsoft.AspNetCore.Localization;
using AfriCompare.Data.APIObjs;

namespace CompareUI
{
    //public static class CompareApp
    //{
    //    private static IHttpContextAccessor _httpContextAccessor;
    //    public static IList<KeyValuePair<string, string>> SetRequestInfo(IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor;
    //        string service = _httpContextAccessor.HttpContext.Request.Query["service"];
    //        string userSection = _httpContextAccessor.HttpContext.Request.Query["area"];

    //        /**/if ((null != service) && (null != userSection))
    //        {
    //            _httpContextAccessor.HttpContext.Session.SetString("service", service);
    //            _httpContextAccessor.HttpContext.Session.SetString("section", userSection);
    //        }

    //        IList<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();

    //        if ((null != service) && (null != userSection))
    //        {
    //            result.Add(new KeyValuePair<string, string>(key: "service", value: service));
    //            result.Add(new KeyValuePair<string, string>(key: "section", value: userSection));
    //        }
    //        return result;
    //    }
    //    public static IList<KeyValuePair<string, string>> GetRequestInfo(IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor;

    //        string service =null;
    //        string userSection = null ;
    //        IList <KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
    //        if (_httpContextAccessor != null) {
    //              service = _httpContextAccessor.HttpContext.Session.GetString("service");
    //              userSection = _httpContextAccessor.HttpContext.Session.GetString("section");
    //        }
          
    //        if ((null != service) && (null != userSection))
    //        {
    //            result.Add(new KeyValuePair<string, string>(key: "service", value: service));
    //            result.Add(new KeyValuePair<string, string>(key: "section", value: userSection)); 
    //        }
    //        return result;
    //    }

    //    //public static void PostLogin(IHttpContextAccessor httpContextAccessor)
    //    //{
    //    //    _httpContextAccessor = httpContextAccessor;
    //    //    var myCookie = CookieRequestCultureProvider.DefaultCookieName;

    //    //    //HttpCookie myAuthCookie = Context.Request.Cookies[myCookie];  
    //    //    var myAuthCookie = _httpContextAccessor.HttpContext.Request.Cookies[myCookie];

    //    //    string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["key"];

    //    //    //read cookie from Request object  
    //    //    string cookieValueFromReq = _httpContextAccessor.HttpContext.Request.Cookies["Key"];

    //    //    //SetUserData("username");
    //    //}
       
    //    public static UserProfileResult GetUserData(string userName, IHttpContextAccessor httpContextAccessor)
    //    {
    //        return httpContextAccessor.HttpContext.Session.GetObjectFromJson<UserProfileResult>(userName);
    //    }
       
    //    public static void  SetUserData(UserProfileResult userData, IHttpContextAccessor httpContextAccessor)
    //    {
    //          httpContextAccessor.HttpContext.Session.SetObjectAsJson(userData.user.Email,userData);
    //    }

    //    public static void SetCookie(string key, string value, bool isPersistent, IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor; 
    //        CookieOptions options = new CookieOptions();
    //        if (isPersistent)
    //            options.Expires = DateTime.Now.AddDays(1);
    //        else
    //            options.Expires = DateTime.Now.AddSeconds(10);
    //        _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, options);
    //    }

    //    public static void SetCookie(string key, string value, int? expireTime, IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor;
    //        CookieOptions option = new CookieOptions();

    //        if (expireTime.HasValue)
    //            option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
    //        else
    //            option.Expires = DateTime.Now.AddMilliseconds(10);

    //        _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, option);
    //    }

    //    public static string GetCookie(string key, IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor;
    //        return _httpContextAccessor.HttpContext.Request.Cookies[key];
    //    }

    //    public static void RemoveCookie(string key, IHttpContextAccessor httpContextAccessor)
    //    {
    //        _httpContextAccessor = httpContextAccessor;
    //        _httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
    //    }
    //}
    //public class UserSession
    //{
    //    public UserSession()
    //    {

    //    }
    //    public IList<KeyValuePair<string, string>> GetRequestInfo { get; set; }
    //    public string UserId { get; set; }
    //    public string UserName { get; set; }
    //    public string Email { get; set; }
    //    public string AccessToken { get; set; }
    //    public string RefreshToken { get; set; }
    //}
}
