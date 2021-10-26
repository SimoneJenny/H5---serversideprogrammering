using AspNetCoreMVCTest1.Codes;
using AspNetCoreMVCTest1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreMVCTest1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHashing _hashings;

        public HomeController(ILogger<HomeController> logger, IHashing hashings)
        {
            _logger = logger;
            _hashings = hashings;
        }

        public IActionResult Index(string bruger, string mypassword)
        {
            IndexModel? indexmodel = null;
            string hashedvalueasstring = null;
            if (mypassword != null)
            {
                string hashvaluestrings = _hashings.BcryptHash(mypassword); //MD5
                //string to = _hashings.Teskfelt2();
                indexmodel = new IndexModel() { hashvaluestring = hashvaluestrings, OriginalTxt = mypassword };
            }

            string brugernavn = bruger;
            string password = hashedvalueasstring;


            return View(model: indexmodel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}