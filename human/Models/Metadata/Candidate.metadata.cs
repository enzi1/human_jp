using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(CandidateMetadata))]
    public partial class Candidate
    {
        internal sealed class CandidateMetadata
        {
            public int id { get; set; }

            [Required(ErrorMessage = "Hãy nhập họ và tên")]
            [Display(Name = "Họ và tên")]
            [MaxLength(64)]
            public string fullname { get; set; }

            [Required(ErrorMessage = "Hãy nhập Email")]
            [MaxLength(255)]
            [Display(Name = "Email")]
            [EmailAddress(ErrorMessage = "Email không đúng định dạng")]
            public string email { get; set; }

            [Required(ErrorMessage = "Hãy nhập mật khẩu")]
            [MaxLength(255)]
            [Display(Name = "Mật khẩu")]
            [DataType(DataType.Password)]
            public string password { get; set; }

            [Display(Name = "Ngày sinh")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public Nullable<System.DateTime> birthday { get; set; }

            [Display(Name = "Địa chỉ")]
            public string address { get; set; }

            [Display(Name = "Số điện thoại")]
            [MaxLength(15)]
            [DataType(DataType.PhoneNumber)]
            public string phone { get; set; }

            [Display(Name = "Ảnh đại diện")]
            public string img { get; set; }

            [Display(Name = "Tiêu đề CV")]
            public string cv_title { get; set; }

            [Display(Name = "Tên công ty")]
            public string company_name { get; set; }

            [Display(Name = "Làm từ")]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> work_time_from { get; set; }

            [Display(Name = "Làm đến")]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> work_time_to { get; set; }

            [Display(Name = "Năm kinh nghiệm")]
            public int experience_year { get; set; }

            [Display(Name = "Vị trí hiện tại")]
            public string current_position { get; set; }

            [Display(Name = "Vị trí mong muốn")]
            public string desire_position { get; set; }

            [Display(Name = "Công việc mong muốn")]
            public string desire_job { get; set; }

            [Display(Name = "Mức lương mong muốn")]
            public string desire_salary { get; set; }

            [Display(Name = "Ký hiệu lương")]
            public int salary_char_id { get; set; }

            [Display(Name = "Nơi làm việc mong muốn")]
            public string desire_work_location { get; set; }

            [Display(Name = "Mục đích nghề nghiệp")]
            public string career_goal { get; set; }

            [Display(Name = "Tên trường học")]
            public string education_school_name { get; set; }

            [Display(Name = "Thời gian học từ")]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> education_time_from { get; set; }

            [Display(Name = "Học đến")]
            [DataType(DataType.Date)]
            public Nullable<System.DateTime> education_time_to { get; set; }

            [Display(Name = "Ngành học")]
            public string speciality { get; set; }

            [Display(Name = "Loại tốt nghiệp")]
            public string graduate_level { get; set; }

            [Display(Name = "Id Ngôn ngữ")]
            public int self_language_id { get; set; }

            [Display(Name = "Ngôn ngữ khác")]
            public string language_other { get; set; }

            [Display(Name = "Id kỹ năng")]
            public int skill_id { get; set; }

            [Display(Name = "Kỹ năng khác")]
            public string skill_other { get; set; }

            [Display(Name = "Sở thích")]
            public string hobby { get; set; }

            [Display(Name = "Facebook")]
            public string facebook { get; set; }

            [Display(Name = "idloginsocial")]
            public int idloginsocial { get; set; }

            [Display(Name = "Trạng thái kích hoạt")]
            public int status_active { get; set; }

            [Display(Name = "user_id")]
            public int user_id { get; set; }

            [Display(Name = "created_at")]
            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> created_at { get; set; }

            [Display(Name = "updated_at")]
            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> updated_at { get; set; }
        }
    }
}