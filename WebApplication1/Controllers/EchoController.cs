namespace WebApplication1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json.Linq;
    using Microshaoft.WebApi.ModelBinders;
    using Microshaoft; 

    [ConstrainedRoute("api/[controller]")]
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpDelete]
        [HttpGet]
        [HttpHead]
        [HttpOptions]
        [HttpPatch]
        [HttpPost]
        [HttpPut]
        [Route("Echo/{* }")]
        public ActionResult Echo
                (
                     [ModelBinder(typeof(JTokenModelBinder))]
                        JToken parameters //= null!
                )
        {
            return
                new JsonResult
                    (
                        parameters
                    );
        }


        [HttpDelete]
        [HttpGet]
        [HttpHead]
        [HttpOptions]
        [HttpPatch]
        [HttpPost]
        [HttpPut]
        [Route("Echo/{* }")]
        public ActionResult Echo
        (
        )
        {
            return
                new JsonResult
                    (
                        null
                    );
        }


        [HttpDelete]
        [HttpGet]
        [HttpHead]
        [HttpOptions]
        [HttpPatch]
        [HttpPost]
        [HttpPut]
        [Route("Echo/{* }")]
        public async Task<ActionResult> EchoAsync
                (
                     [ModelBinder(typeof(JTokenModelBinder))]
                        JToken parameters //= null!
                )
        {
            return
                await
                    Task
                        .FromResult
                            (
                                new JsonResult
                                    (
                                        parameters
                                    )
                            );
                
        }
 
        [HttpDelete]
        [HttpGet]
        [HttpHead]
        [HttpOptions]
        [HttpPatch]
        [HttpPost]
        [HttpPut]
        [Route("Echo/{* }")]
        public async Task<ActionResult> EchoAsync
                (
                )
        {
            return
                await
                    EchoAsync(null!);

        }

    }
}