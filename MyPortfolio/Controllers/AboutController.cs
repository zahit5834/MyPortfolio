using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Abouts.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            context.Abouts.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
