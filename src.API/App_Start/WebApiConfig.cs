using System;
using System.Collections.Generic;
using System.Web.Http;

namespace src.API
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "{controller}/{id}", // "api/{controller}/{id}"
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
