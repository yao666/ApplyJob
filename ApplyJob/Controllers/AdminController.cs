﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplyJob.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult adminhome()
        {
            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
    }
}