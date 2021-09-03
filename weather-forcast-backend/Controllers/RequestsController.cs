using Microsoft.AspNetCore.Mvc;

namespace weather_forcast_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RequestsController : ControllerBase
    {
        private readonly IMemStore _memStoreSingleton;
        public RequestsController(IMemStore memStore)
        {
            _memStoreSingleton = memStore;
        }

        [HttpGet]
        public IActionResult Index() => new JsonResult(_memStoreSingleton.GetAll());
        
    }
}
