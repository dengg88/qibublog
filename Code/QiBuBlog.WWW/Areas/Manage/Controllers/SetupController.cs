﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QiBuBlog.WWW.Controllers;

namespace QiBuBlog.WWW.Areas.Manage.Controllers
{
    public class SetupController : BaseController
    {
        //
        // GET: /Manage/Setup/

        public ActionResult Index()
        {
            return View();
        }

    }
}
