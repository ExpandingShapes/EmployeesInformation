using Microsoft.AspNetCore.Mvc;
using EmployeesInformation.Models;

namespace EmployeesInformation.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IAbstractInterface<Employee> Repository;

        public EmployeeController(IAbstractInterface<Employee> Repository)
        {
            this.Repository = Repository;
        }

        public ActionResult Index()
        {
            return View(Repository.GetAllItems());
        }

        [HttpPost]
        public ActionResult Add(Employee Employee)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(Employee);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult Edit([FromHeader]int id)
        {
            if (Repository.FindById(id) != null)
            {
                Employee Employee = Repository.FindById(id);
                return View(Employee);
            }
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Edit(Employee Employee)
        {
            if (ModelState.IsValid)
            {
                Repository.Edit(Employee);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}