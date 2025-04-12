using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadViewComponents: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
