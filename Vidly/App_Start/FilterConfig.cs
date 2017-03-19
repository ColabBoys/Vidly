using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // this below redirects users to an error page when the action throws an exception
            filters.Add(new HandleErrorAttribute());
            //apply the authorize tag globally so restricting all controller actions to customers who are logged in ONLY
            filters.Add(new AuthorizeAttribute());
            // if the below setting is called then the website will no longer be available using the http regular link ONLY via HTTPS
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
