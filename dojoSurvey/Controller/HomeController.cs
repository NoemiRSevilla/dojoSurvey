using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dojoSurvey.HomeController
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("method")]
        public ViewResult Submitted(string name, string dojo_location, string favorite_language, string comments)
        {
            ViewBag.name = name;
            ViewBag.dojo_location = dojo_location;
            ViewBag.favorite_language = favorite_language;
            ViewBag.comments = comments;
            return View();
        }
    }
}