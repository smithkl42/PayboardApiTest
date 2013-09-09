using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PayboardApiTest.Startup))]
namespace PayboardApiTest
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
