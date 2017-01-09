using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(src.App_Start.Startup))]
namespace src.App_Start
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
		}
	}
}
