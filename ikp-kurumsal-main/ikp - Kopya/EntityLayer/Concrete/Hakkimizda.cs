using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int Hkkimizda_id { get; set; }
        public string Hakkimizda_Baslik { get; set; }
        public string Hakkimizda_icerik { get; set; }
        public string Hakkimizda_alt_baslik_bir { get; set; }
        public string Hakkimizda_Misyonumuz_icerik { get; set; }
        public string Hakkimizda_altbaslik_orta { get; set; }
        public string Hakkimizda_Vizyon_icerik { get; set; }
        public string Hakkimizda_altbaslik_sag { get; set; }
        public string Hakkimizda_Neden_Biz_icerik { get; set; }
        public string Hakkimizda_Bizkimiz_baslik { get; set; }
        public string Hakkimizda_Biz_Kimiz_icerik { get; set; }
        public string Hakkimizda_Ekibimiz_Baslik { get; set; }
        public string Hakkimizda_Ekibimiz_icerik { get; set; }
        public string Biz_kimiz_resim_yol { get; set; }
        [NotMapped]
        public IFormFile Biz_kimiz_resim { get; set; }
        public string Hakkimizda_Ekibimiz_Resim_Yol { get; set; }
        [NotMapped]
        public IFormFile Hakkimizda_Ekibimiz_Resim { get; set; }

        public DilTablosu DilTablosu { get; set; }
        public int DilTablosuId { get; set; }



    }
}
