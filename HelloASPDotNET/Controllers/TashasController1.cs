using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class TashasController1 : Controller
    {
        [HttpGet]
        [Route("/tasha/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
