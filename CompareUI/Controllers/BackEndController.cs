using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CompareUI.Models;

namespace AfriCompareAdmin.Controllers
{
    public class BackEndController : Controller
    {
        // GET: BackEnd
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: login
        public ActionResult Login()
        {
            return View();
        }
        
        // GET: Register
        public ActionResult Signin()
        {
            return View();
        }

        // GET: Register
        public ActionResult BlankPage()
        {
            return View();
        }
    }
}