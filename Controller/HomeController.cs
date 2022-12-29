using Microsoft.AspNetCore.Mvc;

namespace NewAuthorizationSample.Controller
{
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("PostCount")]
        public IActionResult PostCount(string item)
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
