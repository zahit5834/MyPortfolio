using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.TodoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateToDo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateToDo(ToDoList p)
        {
            p.Status = false;
            context.TodoLists.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDo(int id)
        {
            var value = context.TodoLists.Find(id);
            context.TodoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateToDo(int id)
        {
            var value = context.TodoLists.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateToDo(ToDoList p)
        {
            context.TodoLists.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeIsRead(int id)
        {
            var value = context.TodoLists.Find(id);
            if (value.Status == false)
            {
                value.Status = true;
            }
            else
            {
                value.Status = false;
            }
            context.TodoLists.Update(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
