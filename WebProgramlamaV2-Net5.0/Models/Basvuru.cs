using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Basvuru
    {
        [Key]
        [Required]
        public int kayitId { get; set; }
        [Required]
        public int IsilaniId { get; set; }
        [Required]
        public int PatronId { get; set; }
        [Required]
        public int yazilimciId { get; set; }

    }
}
