using KeyedDIServices.Enums;
using KeyedDIServices.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedDIServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : Controller
    {
        [HttpGet("ServiceA")]
        public IActionResult ServiceA(
            [FromKeyedServices(DIKey.ServiceA)] IService service)
        {
            var result = service.Execute();

            return Ok(result);
        }

        [HttpGet("ServiceB")]
        public IActionResult ServiceB(
            [FromKeyedServices(DIKey.ServiceB)] IService service)
        {
            var result = service.Execute();

            return Ok(result);
        }

        [HttpGet("ServiceC")]
        public IActionResult ServiceC(
            [FromKeyedServices(DIKey.ServiceC)] IService service)
        {
            var result = service.Execute();

            return Ok(result);
        }
    }
}