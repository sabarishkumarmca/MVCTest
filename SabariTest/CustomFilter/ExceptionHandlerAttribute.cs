using SabariTest.Models;
using System;
using System.Web.Mvc;

namespace SabariTest.CustomFilter
{
    public class ExceptionHandlerAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {

                ExceptionLogger logger = new ExceptionLogger()
                {
                    ExceptionMessage = filterContext.Exception.Message,
                    ExceptionStackTrace = filterContext.Exception.StackTrace,
                    ControllName = filterContext.RouteData.Values["controller"].ToString(),
                    LogTime = DateTime.Now
                };
                DatabaseContext db = new DatabaseContext();
                db.ExceptionLoggers.Add(logger);
                db.SaveChanges(); 
                filterContext.ExceptionHandled = true;
            }
        }
    }
}