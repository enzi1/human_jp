using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(Salary_charMetadata))]
    public partial class Salary_char
    {
        internal sealed class Salary_charMetadata
        {
            [Display(Name = "Mã Salary_char")]
            public int id { get; set; }

            [Display(Name = "Tên tiền tệ")]
            public string name { get; set; }

            [Display(Name = "Ký hiệu")]
            public string chars { get; set; }
        }
    }
}