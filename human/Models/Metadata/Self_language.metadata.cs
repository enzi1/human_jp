using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(Self_languageMetadata))]
    public partial class Self_language
    {
        internal sealed class Self_languageMetadata
        {
            public int id { get; set; }

            [Display(Name = "Ngôn ngữ")]
            public string name { get; set; }

            [Display(Name = "Trình độ")]
            public string level { get; set; }
        }
    }
}