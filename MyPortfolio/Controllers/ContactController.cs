using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Contacts.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Contact p)
        {
            context.Contacts.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
