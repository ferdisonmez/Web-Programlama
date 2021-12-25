using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Admin
    {
        [Key][Required]
        public int id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Parola { get; set; }
        public bool isPersistent { get; set; }

        public String Rolename { get; set; }

    }
}
