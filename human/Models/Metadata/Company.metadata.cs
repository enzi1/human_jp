using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(CompanyMetadata))]
    public partial class Company
    {
        internal sealed class CompanyMetadata
        {
            public int id { get; set; }

            [Display(Name = "Email")]
            public string email { get; set; }

            [Display(Name = "Mật khẩu")]
            public string password { get; set; }

            [Display(Name = "Tên")]
            public string name { get; set; }

            [Display(Name = "Địa chỉ")]
            public string address { get; set; }

            [Display(Name = "Điện thoại")]
            public string phone { get; set; }

            [Display(Name = "Fax")]
            public string fax { get; set; }

            [Display(Name = "Ảnh đại diện")]
            public string img { get; set; }

            [Display(Name = "Thành lập năm")]
            public string establish { get; set; }

            [Display(Name = "Nhà sáng lập")]
            public string founder { get; set; }

            [Display(Name = "Số nhân viên")]
            public int member_quantity { get; set; }

            [Display(Name = "Giới thiệu")]
            public string introduce { get; set; }

            [Display(Name = "Website")]
            public string website { get; set; }

            [Display(Name = "Trạng thái kích hoạt")]
            public int status_active { get; set; }

            [Display(Name = "User id")]
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