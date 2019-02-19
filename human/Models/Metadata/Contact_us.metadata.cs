using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(Contact_usMetadata))]
    public partial class Contact_us
    {
        internal sealed class Contact_usMetadata
        {
            public int id { get; set; }

            [Display(Name = "Tên liên lạc")]
            public string name { get; set; }

            [Display(Name = "Email")]
            public string email { get; set; }

            [Display(Name = "Địa chỉ")]
            public string address { get; set; }

            [Display(Name = "Phone")]
            public string phone { get; set; }

            [Display(Name = "Chủ đề")]
            public string subject { get; set; }

            [Display(Name = "Nội dung")]
            public string content { get; set; }

            [Display(Name = "created_at")]
            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> created_at { get; set; }

            [Display(Name = "updated_at")]
            [DataType(DataType.DateTime)]
            public Nullable<System.DateTime> updated_at { get; set; }
        }
    }
}