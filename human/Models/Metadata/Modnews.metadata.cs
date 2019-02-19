using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(ModnewsMetadata))]
    public partial class Modnews
    {
        internal sealed class ModnewsMetadata
        {
            public int id { get; set; }

            [Display(Name = "Thể loại tin")]
            public string mod_name { get; set; }

            [Display(Name = "Hình ảnh")]
            public string mod_img { get; set; }

            [Display(Name = "Miêu tả")]
            public string description { get; set; }

            [Display(Name = "slug")]
            public string slug { get; set; }

            [Display(Name = "user_id")]
            public int user_id { get; set; }
        }
    }
}