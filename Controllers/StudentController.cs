using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPattern.Models;
using RepositoryDesignPattern.Services;

namespace RepositoryDesignPattern.Controllers
{
    public class StudentController : Controller
    {
        IRepository<Student> Studrepo;
        public StudentController(IRepository<Student> Studrepo)
        {
            this.Studrepo = Studrepo;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Student st)
        {
            Studrepo.Add(st);
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
