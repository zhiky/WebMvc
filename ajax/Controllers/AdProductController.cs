﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class AdProductController : Controller
    {
        // GET: AdProduct
        public ActionResult AdShow()
        {
            return View();
        }
        public ActionResult Fill()
        {
            return View();
        }
    }
}