using Microsoft.AspNetCore.Mvc;
using EmployeesInformation.Models;

namespace EmployeesInformation.Controllers
{
    public class PositionController : Controller
    {
        private readonly IAbstractInterface<Position> Repository;

        public PositionController(IAbstractInterface<Position> Repository)
        {
            this.Repository = Repository;
        }

        public ActionResult Index()
        {
            return View(Repository.GetAllItems());
        }

        [HttpPost]
        public ActionResult Add(Position Position)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(Position);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult Edit([FromHeader]int id)
        {
            if (Repository.FindById(id) != null)
            {
                Position Position = Repository.FindById(id);
                return View(Position);
            }
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Edit(Position Position)
        {
            if (ModelState.IsValid)
            {
                Repository.Edit(Position);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}