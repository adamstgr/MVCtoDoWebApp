using firstMVCwebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVCwebApp.Controllers
{
    public class ToDoItemController : Controller
    {
        private readonly string _apiKey;
        private static List<ToDoItem> toDoItems = new List<ToDoItem>();
        public ToDoItemController(IConfiguration configuration)
        {
            _apiKey = configuration["APIKey"];
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            ViewBag.GoogleMapsApiKey = _apiKey;
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
