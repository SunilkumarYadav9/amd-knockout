﻿using System.IO;
using System.Web.Mvc;
using AMDKnockout.Helpers;

namespace AMDKnockout.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = DataRepository.GetData(new StreamReader(Server.MapPath("Data/Cards.json")));
            return View(data);
        }
    }
}