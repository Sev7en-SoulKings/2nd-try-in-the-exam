using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using THE_REAL_ONE.Models;

namespace THE_REAL_ONE.Controllers
{
    public class HisProjectController : Controller
    {
        HisDB _Context = new HisDB();
        HisTTasks hisTTasks;
        [HttpGet]
        public IActionResult Index()
        {
            List<HisPProjects> projects = _Context.HisPProjects.ToList();
            return View(projects);
        }
        public IActionResult Details(int id)
        {
            HisPProjects project = _Context.HisPProjects.Include(x => x.Task).FirstOrDefault(p => p.Id == id);
            return View(project);
        }
        //[HttpPost]
        //public IActionResult Details()
        //{
        //    List<HisTTasks> projects = _Context.HisTTasks.ToList();
        //    return View(projects);
        //}
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(HisPProjects project)
        {
            _Context.HisPProjects.Add(project);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            HisPProjects project = _Context.HisPProjects.Find(id);
            return View(project);
        }
        [HttpPost]
        public IActionResult Edit(HisPProjects project)
        {
            _Context.HisPProjects.Update(project);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            HisPProjects project = _Context.HisPProjects.Find(id);
            return View(project);
        }
        [HttpPost]
        public IActionResult Delete(HisPProjects project)
        {
            _Context.HisPProjects.Remove(project);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
