﻿using CourseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseManager.Controllers
{
    public class HomeController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "修改此模板以快速启动你的 ASP.NET MVC 应用程序。";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "你的应用程序说明页。";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系方式页。";

            return View();
        }
        [ChildActionOnly]

        public ActionResult Partial1()
        {
            var site = new Websitelnfo();
            ViewBag.ActionLinks = db.ActionLink.ToList();
            ViewBag.Site = site;
            return PartialView("~/Views/Shared/Partial1.cshtml");
    }
        [ChildActionOnly]

        public ActionResult SideBar()
        {
            var sidebars = db.SideBars.ToList();
            ViewBag.Sidebars = sidebars;
            return PartialView("~/Views/Shared/SideBar.cshtml");
        }
}
}
