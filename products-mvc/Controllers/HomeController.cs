﻿using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace products_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductManager _productManager;

        public HomeController(IProductManager productManager) 
        {
            _productManager = productManager;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}