using System;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(src.API.App_Start.Startup))]
namespace src.API.App_Start
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
