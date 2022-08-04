using Microsoft.AspNetCore.Mvc;
using SignUpExcel.Models;

namespace SignUpExcel.Controllers
{
    public class InputController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public InputController(ILogger<HomeController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string InputNum(int StudentMale,int StudentFemale,int TeacherMale,int TeacherFemale)
        {
            try
            {
                string web_path = _webHostEnvironment.WebRootPath;
                ExcuteMsg excuteMsg = new ExcuteMsg();
                InputInfo inputInfo = new InputInfo();
                inputInfo.StudentMale= StudentMale;
                inputInfo.StudentFemale = StudentFemale;
                inputInfo.TeacherFemale = TeacherFemale;
                inputInfo.TeacherMale = TeacherMale;
                excuteMsg.addExcelData(web_path + "/excelFiles/", inputInfo);
            }
            catch (Exception ex)
            {

            }
            return "success";
        }
    }
}
