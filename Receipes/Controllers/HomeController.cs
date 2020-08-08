using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Receipes.Models;

namespace Receipes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult RecipeList()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpGet]
        public IActionResult AddRecipe()
        { //privacy
            return View();
        }

        //TODO When the form is no valid add cs that will highlight it in red.
        [HttpPost]
        public IActionResult AddRecipe(Recipe recipe)
        {
            if(ModelState.IsValid)
            {
                RecipeStorage.AddRecipe(recipe);
                return Redirect("Index"); //View();
            } else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
