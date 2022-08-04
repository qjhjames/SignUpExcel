using Microsoft.AspNetCore.Mvc;
using SignUpExcel.Models;
using System.Diagnostics;

namespace SignUpExcel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public string InputNum() {
            try
            {
                string web_path = _webHostEnvironment.WebRootPath;
                ExcuteMsg excuteMsg = new ExcuteMsg();
                InputInfo inputInfo = new InputInfo();
                excuteMsg.addExcelData(web_path + "/excelFiles/", inputInfo);
            }
            catch (Exception ex) { 
              
            }
            return "success";
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