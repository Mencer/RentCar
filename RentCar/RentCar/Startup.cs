using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentCar.Startup))]
namespace RentCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           
        }
    }
}
