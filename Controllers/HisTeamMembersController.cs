using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using THE_REAL_ONE.Models;

namespace THE_REAL_ONE.Controllers
{
    public class HisTeamMembersController : Controller
    {
        HisDB _Context = new HisDB();
        public IActionResult Index()
        {
            List<HisTTeamMembers> teams = _Context.HisTTeamMembers.ToList();
            return View(teams);
        }
        public IActionResult Details(int id)
        {
            HisTTeamMembers project = _Context.HisTTeamMembers.Include(x => x.Task).FirstOrDefault(p => p.Id == id);
            return View(project);
        }
        [HttpGet]
        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(HisTTeamMembers team)
        {
            _Context.HisTTeamMembers.Add(team);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            HisTTeamMembers team = _Context.HisTTeamMembers.Find(id);
            return View(team);
        }
        [HttpPost]
        public IActionResult Edit(HisTTeamMembers team)
        {
            _Context.HisTTeamMembers.Update(team);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            HisTTeamMembers team = _Context.HisTTeamMembers.Find(id);
            return View(team);
        }
        [HttpPost]
        public IActionResult Delete(HisTTeamMembers team)
        {
            _Context.HisTTeamMembers.Remove(team);
            _Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
