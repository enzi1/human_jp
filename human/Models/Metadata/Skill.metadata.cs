using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(SkillMetadata))]
    public partial class Skill
    {
        internal sealed class SkillMetadata
        {
            public int id { get; set; }

            [Display(Name = "Kỹ năng")]
            public string name { get; set; }
        }
    }
}