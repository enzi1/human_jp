using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(Web_languageMetadata))]
    public partial class Web_language
    {
        internal sealed class Web_languageMetadata
        {
            public int id { get; set; }

            [Display(Name = "Tên ngôn ngữ web")]
            public string name { get; set; }

            [Display(Name = "Ảnh đại diện")]
            public string img { get; set; }

            [Display(Name = "Ký tự")]
            public string chars { get; set; }
        }
    }
}