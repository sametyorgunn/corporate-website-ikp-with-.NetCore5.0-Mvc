using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ikp_kurumsal.ViewComponents.AnaSayfaCozumlerimizListele
{
    public class AnaSayfaCozumlerimizListele : ViewComponent
    {
        private readonly IAnaSayfaKisim2Service _anasayfakisim2service;

        public AnaSayfaCozumlerimizListele(IAnaSayfaKisim2Service anasayfakisim2service)
        {
            _anasayfakisim2service = anasayfakisim2service;
        }

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var liste = c.anaSayfaKisim2s.ToList();
            var list = c.anaSayfaKisim2s.FirstOrDefault();
            ViewBag.baslik = list.AnaSayfaBaslik2.ToString();
            ViewBag.description = list.AnaSayfaDescription2_1.ToString();
            ViewBag.description2 = list.AnaSayfaDescription2_2.ToString();
            return View(liste);
        }
    }
}