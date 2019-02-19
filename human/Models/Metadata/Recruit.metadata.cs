using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(RecruitMetadata))]
    public partial class Recruit
    {
        internal sealed class RecruitMetadata
        {
            public int id { get; set; }

            [Display(Name = "company_id")]
            public int company_id { get; set; }

            [Display(Name = "Tiêu đề")]
            public string title { get; set; }

            [Display(Name = "Số lượng")]
            public int quantity { get; set; }

            [Display(Name = "Giới tính")]
            public int sex { get; set; }

            [Display(Name = "Miêu tả công việc")]
            public string job_description { get; set; }

            [Display(Name = "Địa điểm")]
            public string work_location { get; set; }

            [Display(Name = "Thời gian làm việc")]
            public string work_time { get; set; }

            [Display(Name = "Ngày nghỉ")]
            public string holiday { get; set; }

            [Display(Name = "Điều kiện")]
            public string condition { get; set; }

            [Display(Name = "Công việc")]
            public int employment_id { get; set; }

            [Display(Name = "Trình độ giáo dục")]
            public string education_level { get; set; }

            [Display(Name = "Lương")]
            public string salary { get; set; }

            [Display(Name = "salary_char_id")]
            public int salary_char_id { get; set; }

            [Display(Name = "Thời gian thử việc")]
            public string training_time { get; set; }

            [Display(Name = "Phúc lợi")]
            public string welfare { get; set; }

            [Display(Name = "Quốc tịch")]
            public string applicable_nationality { get; set; }

            [Display(Name = "Quy trình tuyển chọn")]
            public string selection_process { get; set; }

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