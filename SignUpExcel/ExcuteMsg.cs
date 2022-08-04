
using MiniExcelLibs;
using SignUpExcel.Models;

namespace SignUpExcel
{
    public  class ExcuteMsg
    {
        public void addExcelData(string excelPath, InputInfo inputInfo)
        {
            List<StudentInfo> students = new List<StudentInfo>();
            if (inputInfo.StudentMale > 0) {
                for (int i = 0; i < inputInfo.StudentMale; i++) {
                    StudentInfo student= new StudentInfo();
                    student.Name = "学生";
                    student.Gender = "男";
                    student.IsTeacher = "否";
                    student.Country = "中国";
                    student.Province = "上海";
                    student.Nationality = "汉族";
                    students.Add(student);
                }
            }
            if (inputInfo.StudentFemale > 0)
            {
                for (int i = 0; i < inputInfo.StudentFemale; i++)
                {
                    StudentInfo student = new StudentInfo();
                    student.Name = "学生";
                    student.Gender = "女";
                    student.IsTeacher = "否";
                    student.Country = "中国";
                    student.Province = "上海";
                    student.Nationality = "汉族";
                    students.Add(student);
                }
            }
            if (inputInfo.TeacherMale > 0)
            {
                for (int i = 0; i < inputInfo.TeacherMale; i++)
                {
                    StudentInfo student = new StudentInfo();
                    student.Name = "老师";
                    student.Gender = "男";
                    student.IsTeacher = "是";
                    student.Country = "中国";
                    student.Province = "上海";
                    student.Nationality = "汉族";
                    students.Add(student);
                }
            }
            if (inputInfo.TeacherFemale > 0)
            {
                for (int i = 0; i < inputInfo.TeacherFemale; i++)
                {
                    StudentInfo student = new StudentInfo();
                    student.Name = "老师";
                    student.Gender = "女";
                    student.IsTeacher = "是";
                    student.Country = "中国";
                    student.Province = "上海";
                    student.Nationality = "汉族";
                    students.Add(student);
                }
            }
            var projects = students;

           var value = new { Projects = projects };
           string fileName = excelPath+"预生成研学活动人数名单-生成时间-" + DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒") + ".xlsx";
           MiniExcel.SaveAsByTemplateAsync(fileName, "muban.xlsx",value);
        }

    }
}
