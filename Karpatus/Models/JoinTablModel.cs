using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Karpatus.Models
{
    public class JoinTablModel
    {
        [Key]
        public int Join_id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
    }
}
