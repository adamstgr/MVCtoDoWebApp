﻿using firstMVCwebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVCwebApp.Controllers
{
    public class ToDoController : Controller
    {
        private static List<ToDo> toDoList = new List<ToDo>();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(ToDo model)
        {
            if (ModelState.IsValid)
            {
                toDoList.Add(model);
                return View("Details", model);
            }

            return View("Create", model);
        }

        public IActionResult Details(Guid id)
        {
            ToDo toDo = toDoList.FirstOrDefault(x => x.Id == id);
            return View(toDo);
        }

        public IActionResult Edit(Guid id)
        {
            ToDo toDo = toDoList.FirstOrDefault(x => x.Id == id);
            return View(toDo);
        }

        public IActionResult List()
        {
            return View(toDoList);
        }

        public IActionResult Delete(Guid id)
        {
            ToDo toDo = toDoList.FirstOrDefault(x => x.Id == id);
            return View(toDo);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(Guid id)
        {
            ToDo toDo = toDoList.FirstOrDefault(x => x.Id == id);
            toDoList.Remove(toDo);
            return RedirectToAction("List");
        }
    }
}
