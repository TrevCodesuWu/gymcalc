using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(addingFieldsLogin.Startup))]
namespace addingFieldsLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
