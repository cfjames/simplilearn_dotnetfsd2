using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Phase2Section2._12.ActionFilters
{
    public class ActionLoggingFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Log("OnActionExecuting", context.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Log("OnActionExecuted", context.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Log("OnResultExecuting", context.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Log("OnResultExecuted", context.RouteData);
        }

        private void Log(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            var message = $"{methodName}- controller:{controllerName} action:{actionName}";

            Debug.WriteLine(message);
        }
    }
}
