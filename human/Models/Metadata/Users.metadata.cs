using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(UsersMetadata))]
    public partial class Users
    {
        internal sealed class UsersMetadata
        {
            [Display(Name = "Mã Users")]
            public int id { get; set; }

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

            [Required(ErrorMessage = "Hãy nhập họ và tên")]
            [Display(Name = "Họ và tên")]
            [MaxLength(64)]
            public string fullname { get; set; }

            [Display(Name = "Địa chỉ")]
            public string address { get; set; }

            [Display(Name = "Số điện thoại")]
            [MaxLength(15)]
            [DataType(DataType.PhoneNumber)]
            public string phone { get; set; }

            [Display(Name = "Quê hương")]
            public string hometown { get; set; }

            [Display(Name = "Ảnh đại diện")]
            public string avatar { get; set; }

            [Display(Name = "Ghi chú")]
            public string note { get; set; }

            [Display(Name = "Ngày sinh")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public Nullable<System.DateTime> birthday { get; set; }

            [Display(Name = "Phân quyền")]
            public int level_id { get; set; }

            public string remember_token { get; set; }

            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> created_at { get; set; }

            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> updated_at { get; set; }
        }
    }
}