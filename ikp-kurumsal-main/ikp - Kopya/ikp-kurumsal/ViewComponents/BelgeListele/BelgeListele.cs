using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace ikp_kurumsal.ViewComponents.BelgeListele
{
    public class BelgeListele:ViewComponent
    {
        private readonly IBelgelerService _belgelerservice;

        public BelgeListele(IBelgelerService belgelerservice)
        {
            _belgelerservice = belgelerservice;
        }

        public IViewComponentResult Invoke()
        {
            var belgelerliste = _belgelerservice.GetList();
            return View(belgelerliste);
        }
    }
}
