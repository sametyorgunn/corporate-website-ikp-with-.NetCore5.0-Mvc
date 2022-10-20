using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnaSayfaKisim2
    {
        [Key]
        public int AnaSayfaKisim2Id { get; set; }
        public string AnaSayfaBaslik2 { get; set; }
        public string AnaSayfaDescription2_1 { get; set; }
        public string AnaSayfaDescription2_2 { get; set; }
        public string AnaSayfaAltBaslik2 { get; set; }
        public string AnaSayfaAltDescription2 { get; set; }
        public string AnaSayfaAltUrl2 { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
