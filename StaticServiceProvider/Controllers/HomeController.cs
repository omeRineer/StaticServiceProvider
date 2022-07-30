using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using StaticServiceProvider.Business;

namespace StaticServiceProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;
        public HomeController()
        {
            
            _homeService = StaticServiceProvider.ServiceTool.StaticServiceProvider.GetService<IHomeService>();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_homeService.SomeMethod());
        }
    }
}
