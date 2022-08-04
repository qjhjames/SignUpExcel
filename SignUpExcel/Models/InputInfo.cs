using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SignUpExcel.Models
{
    public class InputInfo
    {
        [Required]
        [Display(Name = "男生人数")]
        public int StudentMale { get; set; }
        [Required]
        [Display(Name = "女生人数")]
        public int StudentFemale { get; set; }
        [Required]
        [Display(Name = "男教师人数")]
        public int TeacherMale { get; set; }
        [Required]
        [Display(Name = "女教师人数")]
        public int TeacherFemale { get; set; }
    }
}
