﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormAction.Models;

namespace FormAction.Controllers
{
    public class HomeController : Controller
    {

        protected override IActionInvoker CreateActionInvoker()
        {
            return new FormActionActionInvoker();
        }

        public ActionResult Index()
        {
            return View();
        }

        [FormAction]
        public ActionResult Login(LoginModel model)
        {
            return View("Login", model);
        }

        [FormAction("Forgot")]
        public ActionResult DoesntMatterWhatThisIs(LoginModel model)
        {
            return View("Forgot", model);
        }

        [FormAction(FormActionMode.Normal)]
        public ActionResult Three(LoginModel model)
        {
            return View("Three", model);
        }
    }
}
