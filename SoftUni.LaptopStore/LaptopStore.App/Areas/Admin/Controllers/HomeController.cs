﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.App.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}