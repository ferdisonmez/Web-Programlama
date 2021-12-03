﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Patron
    {
        [Key]
        public int id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Parola { get; set; }
        [Required]
        public String Sirket { get; set; }
       

    }
}
