using lr9.Models;
using Microsoft.AspNetCore.Mvc;

namespace lr9.ViewComponents
{
    public class TableViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(List<TableItem> items)
        {
            return View(items);
        }
    }
}
