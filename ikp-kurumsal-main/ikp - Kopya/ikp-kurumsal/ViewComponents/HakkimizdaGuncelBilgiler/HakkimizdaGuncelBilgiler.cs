using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.HakkimizdaGuncelBilgiler
{
    public class HakkimizdaGuncelBilgiler:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var bilgi = c.hakkimizdaGuncelBilgilers.FirstOrDefault();
            ViewBag.isilaniSayisi = bilgi.IsIlaniSayisi;
            ViewBag.isarayanSayisi = bilgi.IsArayanSayisi;
            ViewBag.isverenSayisi = bilgi.IsVerenSayisi;
            ViewBag.kulaniciSayisi = bilgi.UyeSayisi;
            return View();
        }
        
    }
}
