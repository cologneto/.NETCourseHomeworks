using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactsAPI.Startup))]
namespace ContactsAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
