using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace src.Controllers
{
	public class HomeController : Controller
	{
		/// <summary> URL: Home </summary>
		public ActionResult Index()
		{
			return View();
		}
	}
}
