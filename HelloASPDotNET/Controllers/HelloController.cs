using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='lang' id='lang'>" +
                "   <option value=''>--Choose a language--</option>" +
                "   <option value='english'>English</option>" +
                "   <option value='french'>Francois</option>" +
                "   <option value='portugese'>Portugese</option>" +
                "   <option value='chinese'>Chinese</option>" +
                "   <option value='spanish'>Spanish</option>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html, "text/html");
        }

        public static string CreateMessage(string name, string lang)
        {
            string helloTranslation = "";
            switch (lang)
            {
                case "french":
                    helloTranslation = "Bonjour";
                    break;
                case "english":
                    helloTranslation = "Hello";
                    break;
                case "portugese":
                    helloTranslation = "Ola";
                    break;
                case "chinese":
                    helloTranslation = "Nihao";
                    break;
                case "spanish":
                    helloTranslation = "Hola";
                    break;
                default:
                    name = "STUPID";
                    helloTranslation = "Nice job";
                    break;
            }
            return $"<h1>{helloTranslation}, {name}!</h1>";
        }

        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        // POST: /<controller>/welcome
        [HttpGet("welcome/{name?}")]
        [HttpPost]
        public IActionResult Welcome(string name = "World", string lang = "english")
        {
            return Content(CreateMessage(name, lang) + "<h3>Return to <a href='https://1.bp.blogspot.com/-MV9UMQk-BdM/U_Ledrs4IYI/AAAAAAAABAQ/AY4uldzgIh4/s1600/1901281_10203148410166011_9139677304055698594_n.jpg'>Hellworld</a>. Wait I mean <a href='/../helloworld'>helloworld</a></h3>", "text/html");
        }
    }
}
