﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiamonLimeWebsite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Who am I and why you should care";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Liam Hanrahan";

			return View();
		}

		public ActionResult RazerComms()
		{
			ViewBag.Message = "Send in the clowns.";

			return View();
		}

		public ActionResult Directory()
		{
			ViewBag.Message = "List of commonly used links";

			return View();
		}

		public ActionResult Blog()
		{
			//Show Wordpress Blog
			return View();
		}
	}
}