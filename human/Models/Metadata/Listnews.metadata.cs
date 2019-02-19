using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(ListnewsMetadata))]
    public partial class Listnews
    {
        internal sealed class ListnewsMetadata
        {
            public int id { get; set; }

            [Display(Name = "Thể loại tin")]
            public int modnews_id { get; set; }

            [Display(Name = "Loại tin")]
            public string name { get; set; }

            [Display(Name = "Hình ảnh")]
            public string img { get; set; }

            [Display(Name = "Miêu tả")]
            public string description { get; set; }

            [Display(Name = "slug")]
            public string slug { get; set; }

            [Display(Name = "user_id")]
            public int user_id { get; set; }
        }
    }
}