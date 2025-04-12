using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.AboutTitle = portfolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.AboutSubDescription = portfolioContext.Abouts.Select(x=>x.Subdescription).FirstOrDefault();
            ViewBag.AboutDetail = portfolioContext.Abouts.Select(x=>x.Detail).FirstOrDefault();
            return View();
        }
    }
}
