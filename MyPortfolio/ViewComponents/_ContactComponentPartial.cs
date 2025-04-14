using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Contacts.ToList();
            ViewBag.v1 = values[0].Title;
            ViewBag.v2 = values[0].Description;
            return View(values);
        }
    }
}
