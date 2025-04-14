using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class SkillController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
        public IActionResult DeleteSkill(int id)
        {
            var skill = context.Skills.Find(id);
            context.Skills.Remove(skill);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var skill = context.Skills.Find(id);
            return View(skill);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill p)
        {
            context.Skills.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill p)
        {
            context.Skills.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
