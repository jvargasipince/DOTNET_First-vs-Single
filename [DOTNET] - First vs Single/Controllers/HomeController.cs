using _DOTNET____First_vs_Single.Data;
using _DOTNET____First_vs_Single.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace _DOTNET____First_vs_Single.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string? name, string? category)
        {
            var products = ProductCatalog.Products.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(name))
            {
                products = products.Where(product => product.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(category))
            {
                products = products.Where(product => product.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            }

            ViewBag.NameFilter = name;
            ViewBag.CategoryFilter = category;
            ViewBag.Categories = ProductCatalog.Products.Select(product => product.Category).Distinct().Order();

            return View(products.ToList());
        }

        public IActionResult DetailsFirst(int id)
        {
            // First() returns the first matching item, or throws if there is no match.
            var product = ProductCatalog.Products.First(product => product.Id == id);
            ViewBag.LookupMethod = "First()";
            return View("Details", product);
        }

        public IActionResult DetailsSingle(int id)
        {
            // Single() expects exactly one matching item, so it also throws on duplicates.
            var product = ProductCatalog.Products.Single(product => product.Id == id);
            ViewBag.LookupMethod = "Single()";
            return View("Details", product);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
