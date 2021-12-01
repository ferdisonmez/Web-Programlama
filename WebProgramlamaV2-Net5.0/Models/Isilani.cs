using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Isilani
    {
        [Display(Name="Şirket İsmi")]
        public String sirketismi { get; set; }
        [Display(Name = "Lokasyon")]
        public String lokasyon { get; set; }
        [Display(Name = "Pozisyon")]
        public String pozisyon { get; set; }
        [Display(Name = "Deneyim")]
        public String deneyim { get; set; }
        [Display(Name = "Açıklama")]
        public String aciklama { get; set; }
    }
}
