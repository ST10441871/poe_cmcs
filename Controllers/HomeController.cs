using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using poe_cmcs.Models;

namespace poe_cmcs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string name,int age)
        {
            ViewBag.username = name;
            ViewBag.Age = age;
            //set phone number colomn
            ViewBag.PhoneNumber = +5558759856;
            ViewBag.Address = "1234 Sakura St, Kyoto, Japan";
            //seting the email colomn
            ViewBag.email = "sakashima_yokoshimahapofusagari51@kyoto.jpn";
            return View();
        }

        public IActionResult Privacy(string contacts,string email)
        {
            ViewBag.digits = contacts;
            ViewBag.email = "sakashima_yokoshimahapofusagari51@kyoto.jpn";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
