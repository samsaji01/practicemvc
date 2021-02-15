using Microsoft.AspNetCore.Mvc;
using practicemvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practicemvc.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            // use faek category class/model to create and display 10 categories
            //1. cretate an object to hold  a list of categories
            var categories = new List<Category>();
            for(var i=1; i<=10; i++)
            {
                categories.Add(new Category { Id = i, Name = "Category " + i.ToString() });
            }
            // modify  the return view so that it now accepts a list of categories to pass to the view of the display

            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            ViewBag.category = category;
            return View();
        }
    }
}
