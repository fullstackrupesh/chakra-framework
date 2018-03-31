using System.Web.Mvc;

namespace Chakra.Web.Areas.Static
{
    public class StaticAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Static";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Static_default",
                "Static/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}