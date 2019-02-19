using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(NewsMetadata))]
    public partial class News
    {
        internal sealed class NewsMetadata
        {
            public int id { get; set; }

            [Display(Name = "listnews_id")]
            public int listnews_id { get; set; }

            [Display(Name = "Tin tức")]
            public string name { get; set; }

            [Display(Name = "Intro")]
            public string intro { get; set; }

            [Display(Name = "Nội dung")]
            public string content { get; set; }

            [Display(Name = "Hình ảnh")]
            public string img { get; set; }

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