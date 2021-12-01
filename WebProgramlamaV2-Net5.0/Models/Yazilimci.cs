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
        public int id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String Parola { get; set; }
    }
}
