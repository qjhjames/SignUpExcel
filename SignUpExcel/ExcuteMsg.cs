
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
        public void addExcelData(string excelPath, List<ClassInfo> classInfos,int TeacherMaleNum,int TeacherFemalNum) {
            List<GuofangInfo> guofangInfos = new List<GuofangInfo>();
            int j = 1;
            foreach(ClassInfo info in classInfos)
            {
                for (int i = 0; i < info.StudentMale; i++) {
                    GuofangInfo guofang = new GuofangInfo();
                    guofang.Id = j;
                    guofang.ClassName = info.ClassName;
                    guofang.Name = "男学生";
                    guofang.Gender = "男";
                    guofang.Nation = "汉族";
                    guofang.IdCard = "130525200610224011";
                    guofang.IsForeigner = "否";
                    guofang.IsXinjiang = "否";
                    guofang.IsGangaotai = "否";
                    guofang.IsShaoshu = "否";
                    guofang.TeacherOrStudent = "学生";
                    guofangInfos.Add(guofang);
                    j++;
                }
                for (int i = 0; i < info.StudentFemale; i++)
                {
                    GuofangInfo guofang = new GuofangInfo();
                    guofang.Id = j;
                    guofang.ClassName = info.ClassName;
                    guofang.Name = "女学生";
                    guofang.Gender = "女";
                    guofang.Nation = "汉族";
                    guofang.IdCard = "130525200610224011";
                    guofang.IsForeigner = "否";
                    guofang.IsXinjiang = "否";
                    guofang.IsGangaotai = "否";
                    guofang.IsShaoshu = "否";
                    guofang.TeacherOrStudent = "学生";
                    guofangInfos.Add(guofang);
                    j++;
                }
            }
            for (int i = 0; i < TeacherMaleNum; i++) {
                GuofangInfo guofang = new GuofangInfo();
                guofang.Id = j;
                guofang.ClassName ="教师班";
                guofang.Name = "男教师";
                guofang.Gender = "男";
                guofang.Nation = "汉族";
                guofang.IdCard = "130525200610224011";
                guofang.IsForeigner = "否";
                guofang.IsXinjiang = "否";
                guofang.IsGangaotai = "否";
                guofang.IsShaoshu = "否";
                guofang.TeacherOrStudent = "教师";
                guofangInfos.Add(guofang);
                j++;
            }
            for (int i = 0; i < TeacherFemalNum; i++)
            {
                GuofangInfo guofang = new GuofangInfo();
                guofang.Id = j;
                guofang.ClassName = "教师班";
                guofang.Name = "女教师";
                guofang.Gender = "女";
                guofang.Nation = "汉族";
                guofang.IdCard = "130525200610224011";
                guofang.IsForeigner = "否";
                guofang.IsXinjiang = "否";
                guofang.IsGangaotai = "否";
                guofang.IsShaoshu = "否";
                guofang.TeacherOrStudent = "教师";
                guofangInfos.Add(guofang);
                j++;
            }
            var projects = guofangInfos;

            var value = new { Projects = projects };
            string fileName = excelPath + "预生成国防教育人数名单-生成时间-" + DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒") + ".xlsx";
            MiniExcel.SaveAsByTemplateAsync(fileName, "muban2.xlsx", value);
        }
    }
}
