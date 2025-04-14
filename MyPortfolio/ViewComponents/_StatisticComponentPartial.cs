using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Portfolios.Count();
            ViewBag.v2 = 10000;
            ViewBag.v3 = context.SocialMedias.Count();
            ViewBag.v4 = context.Skills.Count();
            return View();
        }
    }
}