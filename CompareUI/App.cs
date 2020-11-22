//using AfriCompare.API.Controllers;
using AfriCompare.Data.APIObjs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Logging;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace CompareUI
{
    public class App
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<App> _logger;

        public App(ILogger<App> logger,IHttpContextAccessor httpContextAccessor)
        { 
            _logger =    logger; 
            _httpContextAccessor =httpContextAccessor;
        }
         public UserProfileResult UserData()
        {
            return null;
        }
        //public void Application_AuthenticateRequest(HttpRequest _request)
        //{
        //    var myCookie = CookieRequestCultureProvider.DefaultCookieName;  
        //    var myAuthCookie = _httpContextAccessor.HttpContext.Request.Cookies[myCookie]; 

        //    if (null == myAuthCookie)
        //    {
        //        _logger.LogInformation("failed because Authentication coockie was null");
        //        return;
        //    }

        //    FormsAuthenticationTicket myAuthTicket;
        //    try
        //    {
        //        myAuthTicket = FormsAuthentication.Decrypt(myAuthCookie.Value);
        //    }
        //    catch (Exception ex)
        //    {
        //        UtilTools.LogE(ex.StackTrace, ex.Source, ex.GetBaseException().Message);
        //        return;
        //    }

        //    if (null == myAuthTicket)
        //    {
        //        return;
        //    }

        //    var userDataSplit = myAuthTicket.UserData.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
        //    if (!userDataSplit.Any() || userDataSplit.Length != 3)
        //    {
        //        return;
        //    }

        //    if (!userDataSplit[0].Trim().IsNumeric() || !userDataSplit[1].Trim().IsNumeric())
        //    {
        //        return;
        //    }

        //    var roles = userDataSplit[2].Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //    if (!roles.Any())
        //    {
        //        return;

        //    }

        //    var id = new FormsIdentity(myAuthTicket);
        //    IPrincipal principal = new PortalPrincipal(id, roles);
        //    Context.User = principal;
        //}

        public void Set(string key, string value, bool isPersistent)
        {
            CookieOptions options = new CookieOptions();
            if (isPersistent)
                options.Expires = DateTime.Now.AddDays(1);
            else
                options.Expires = DateTime.Now.AddSeconds(10);
            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, options);
        }

        public void Set(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddMinutes(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddMilliseconds(10);

            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, option);
        }

        public string Get(string key)
        {
            return _httpContextAccessor.HttpContext.Request.Cookies[key];
        }

        public void Remove(string key)
        {
            _httpContextAccessor.HttpContext.Response.Cookies.Delete(key);
        }
    }
}
