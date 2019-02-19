using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace human.Models
{
    [MetadataTypeAttribute(typeof(EmploymentMetadata))]
    public partial class Employment
    {
        internal sealed class EmploymentMetadata
        {
            public int id { get; set; }

            [Display(Name = "Tên công việc")]
            public string name { get; set; }
        }
    }
}