using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Models
{
    public class PlaceTablModel
    {
        [Key]
        public int Place_id { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string Photo { get; set; }
       
    }
}
