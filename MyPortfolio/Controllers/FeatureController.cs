﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Features.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            context.Features.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
