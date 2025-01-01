using Microsoft.AspNetCore.Mvc;
using THE_REAL_ONE.Models;

namespace THE_REAL_ONE.Controllers
{
    public class TasksController : Controller
    {
        HisDB _Context = new HisDB();
        [HttpGet]
        public IActionResult Index()
        {
            List<HisTTasks> Tasks = _Context.HisTTasks.ToList();
            return View(Tasks);
        }
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(HisTTasks task)
        {
            _Context.HisTTasks.Add(task);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            HisTTasks task = _Context.HisTTasks.Find(id);
            return View(task);
        }
        [HttpPost]
        public IActionResult Edit(HisTTasks task)
        {
            _Context.HisTTasks.Update(task);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
