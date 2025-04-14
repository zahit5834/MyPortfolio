using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavBarComponentPartial: ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ListCount = context.TodoLists.Where(x => x.Status == false).Count();
            var values = context.TodoLists.Where(x=> x.Status == false).ToList();
            return View(values);
        }
    }
}
