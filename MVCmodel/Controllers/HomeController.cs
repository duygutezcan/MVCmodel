using Microsoft.AspNetCore.Mvc;
using MVCmodel.Models;
using System.Diagnostics;

namespace MVCmodel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Webmaster _webmaster;
        private readonly Webmaster _webmaster1;
        private readonly List<Webmaster>_webmasters;

        public HomeController(ILogger<HomeController> logger,Webmaster webmaster, List<Webmaster> webmasters, Webmaster webmaster1)

        {
            _logger = logger;
            _webmaster = webmaster;
            _webmaster1 = webmaster;
            _webmasters = webmasters;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            //1.yol A) ViewBag
           
            _webmaster.Ad = "Duygu";
            _webmaster.Mail = "dyg@hotmail.com";
            _webmaster.Id = 1;
            _webmaster.Soyad = "Tezcan Kantar";
            ViewBag.Id = _webmaster.Id;
            ViewBag.Ad = _webmaster.Ad;
            ViewBag.Soyad = _webmaster.Soyad;
            ViewBag.Mail = _webmaster.Mail;

            //1.yol B) ViewBag
            ViewBag.Webmaster = _webmaster;
            return View();
        }

        public IActionResult Contact2()
        {

            _webmaster.Ad = "Duygu";
            _webmaster.Mail = "dyg@hotmail.com";
            _webmaster.Id = 1;
            _webmaster.Soyad = "Tezcan Kantar";
            return View(_webmaster);
        }

        public IActionResult PersonelListe(Webmaster _webmaster, List<Webmaster> _webmasters, Webmaster _webmaster1)
        {

            _webmaster.Ad = "Duygu";
            _webmaster.Mail = "dyg@hotmail.com";
            _webmaster.Id = 1;
            _webmaster.Soyad = "Tezcan Kantar";
            _webmasters.Add(_webmaster);


            _webmaster1.Ad = "Yeşim";
            _webmaster1.Mail = "ysm@hotmail.com";
            _webmaster1.Id = 2;
            _webmaster1.Soyad = "Gerdan";
            _webmasters.Add(_webmaster1);
            return View(_webmasters);

            //   2.yol
            // ViewBag.Liste = (_webmasters);
            //   return View(_webmasters);

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}