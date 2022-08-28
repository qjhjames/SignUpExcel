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
        [HttpGet]
        public string InputGuofang(string ClassStu,  int TeacherMale, int TeacherFemale)
        {
            try
            {
                string web_path = _webHostEnvironment.WebRootPath;
                List<ClassInfo> classInfos = new List<ClassInfo>();
                string[] tempStrBig = ClassStu.Split('u');
                foreach (string vals in tempStrBig)
                {
                    if (vals.Trim().Length > 0) {
                        string[] tempStrSmall = vals.Split('m');
                        ClassInfo classInfo = new ClassInfo();
                        classInfo.ClassName = tempStrSmall[0];
                        classInfo.StudentMale = int.Parse(tempStrSmall[1]);
                        classInfo.StudentFemale =int.Parse(tempStrSmall[2]);
                        classInfos.Add(classInfo);
                    }
                }
                ExcuteMsg excuteMsg = new ExcuteMsg();
               
                excuteMsg.addExcelData(web_path + "/excelFiles/", classInfos,TeacherMale,TeacherFemale);
            }
            catch (Exception ex)
            {

            }
            return "success";
        }
    }
}
