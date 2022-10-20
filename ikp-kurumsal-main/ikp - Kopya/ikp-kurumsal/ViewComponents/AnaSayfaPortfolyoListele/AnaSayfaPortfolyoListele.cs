using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnaSayfaPortfolyoListele
{
    public class AnaSayfaPortfolyoListele : ViewComponent
    {
        private readonly IAnaSayfaKisim4Service _anasayfakisim4service;

        public AnaSayfaPortfolyoListele(IAnaSayfaKisim4Service anasayfakisim4service)
        {
            _anasayfakisim4service = anasayfakisim4service;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var list = c.anaSayfaKisim4s.FirstOrDefault();
            ViewBag.baslik = list.AnaSayfaBaslik4.ToString();
            var anasayfalistesi4 = _anasayfakisim4service.GetList().Where(x=>x.AnaSayfaResim4Yol!=null).ToList();
            return View(anasayfalistesi4);
        }
    }
}