using System;
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
			ViewBag.Message = "Who am I and why you should care.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Liam Hanrahan.";

			return View();
		}

		public ActionResult Blog()
		{
			//Show Wordpress Blog
			return View();
		}
	}
}