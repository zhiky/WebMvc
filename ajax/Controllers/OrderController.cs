﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajax.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult OrderShow()
        {
            return View();
        }
    }
}