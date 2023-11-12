using lr9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace lr9.Controllers
{
    public class HomeController : Controller
    {
        private List<TableItem> GetTableItems()
        {
            List<TableItem> list = new List<TableItem>();
            for (var i = 0; i < 10; i++) list.Add(new TableItem { Id = i, Name = $"Product {i}", Price = i * 10 });
            return list;
        }

        public IActionResult Index()
        {
            dynamic model = new ExpandoObject();
            model.TableItems = GetTableItems();
            return View(model);
        }
    }
}