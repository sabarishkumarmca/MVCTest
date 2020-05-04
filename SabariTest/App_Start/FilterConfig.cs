using SabariTest.Controllers;
using SabariTest.CustomFilter;
 
using System.Web;
using System.Web.Mvc;

namespace SabariTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
          
            filters.Add(new ExceptionHandlerAttribute());
            //filters.Add(new HandleErrorAttribute());
        }
    }
}
