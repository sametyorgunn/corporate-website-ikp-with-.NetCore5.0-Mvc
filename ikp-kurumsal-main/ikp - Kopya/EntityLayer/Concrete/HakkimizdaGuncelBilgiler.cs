using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class HakkimizdaGuncelBilgiler
    {
        [Key]
        public int Id { get; set; }
        public string UyeSayisi { get; set; }
        public string IsArayanSayisi { get; set; }
        public string IsVerenSayisi { get; set; }
        public string IsIlaniSayisi { get; set; }
    }
}
