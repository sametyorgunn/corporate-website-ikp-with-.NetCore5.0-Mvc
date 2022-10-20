using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnaSayfaKisim3
    {
        [Key]
        public int AnaSayfaKisim3Id { get; set; }
        public string AnaSayfaBaslik3 { get; set; }
        public string AnaSayfaDescription3_1 { get; set; }
        public string AnaSayfaKucukBaslik3_1 { get; set; }
        public string AnaSayfaKucukBaslik3_1_1 { get; set; }
        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }
    }
}
