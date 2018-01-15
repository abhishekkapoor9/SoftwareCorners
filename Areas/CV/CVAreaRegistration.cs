using System.Web.Mvc;

namespace SoftwareCorners.Areas.CV
{
    public class CVAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CV";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CV_default",
                "CV/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}