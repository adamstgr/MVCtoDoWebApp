using firstMVCwebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVCwebApp.Controllers
{
    public class ToDoItemController : Controller
    {
        private static List<ToDoItem> toDoItems = new List<ToDoItem>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
