using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Phase2Section5._9.Errors;
using System.Net;

namespace Phase2Section5._9.Controllers
{
    [AllowAnonymous]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public ErrorsController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [Route("error")]
        public MyErrorResponse Error()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var exception = context.Error;
            int code;

            if (exception is HttpStatusException) code =
                     (int)((HttpStatusException)exception).Status;
            else
            {
                exception = new HttpStatusException(HttpStatusCode.InternalServerError,
                    "Internal Server Error Occured");
                code = 500;
            }

            Response.StatusCode = code;

            return new MyErrorResponse(exception, 
                _env.EnvironmentName);
        }
    }
}
