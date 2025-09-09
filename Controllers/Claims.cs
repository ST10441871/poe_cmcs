using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using poe_cmcs.Models;

namespace poe_cmcs.Controllers
{
    public class ClaimsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ClaimsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy(string contacts, string email,string claims)
        {
            ViewBag.claiming = claims;
            ViewBag.digits = contacts;
            ViewBag.email = "sakashima_yokoshimahapofusagari51@kyoto.jpn";
            return View();
        }

    }

}
