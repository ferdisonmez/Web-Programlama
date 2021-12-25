using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Yazilimci
    {
        [Key]
        [Required]
        public int id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Surname { get; set; }
        [Required]
        public String education { get; set; }
        [Required]
        public String progLang { get; set; }
        [Required]
        public String experience { get; set; }

        [Required]
        public String Email { get; set; }
        [Required]
        public String Parola { get; set; }

        public bool isPersistent { get; set; }
        public String Rolename { get; set; }
    }
}
