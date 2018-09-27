using Microsoft.AspNetCore.Mvc;
using EmployeesInformation.Models;

namespace EmployeesInformation.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IAbstractInterface<Department> Repository;

        public DepartmentController(IAbstractInterface<Department> Repository)
        {
            this.Repository = Repository;
        }

        public ActionResult Index()
        {
            return View(Repository.GetAllItems());
        }

        [HttpPost]
        public ActionResult Add(Department Department)
        {
            if(ModelState.IsValid)
            {
                Repository.Add(Department);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult Edit([FromHeader]int id)
        {
            if (Repository.FindById(id) != null)
            {
                Department Department = Repository.FindById(id);
                return View(Department);
            }
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Edit(Department Department)
        {
            if(ModelState.IsValid)
            {
                Repository.Edit(Department);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}