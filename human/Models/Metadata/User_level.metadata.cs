using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using 2 thu vien thiet ke class metadata
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(User_levelMetadata))]
    public partial class User_level
    {
        internal sealed class User_levelMetadata
        {
            [Display(Name = "Mã User_level")]
            public int id { get; set; }

            [Display(Name = "Phân quyền")]
            [Required(ErrorMessage ="Không thể để trống!")]
            public string name { get; set; }
        }
    }
}