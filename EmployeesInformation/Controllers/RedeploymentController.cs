using Microsoft.AspNetCore.Mvc;
using EmployeesInformation.Models;

namespace EmployeesInformation.Controllers
{
    public class RedeploymentController : Controller
    {
        private readonly IAbstractInterface<Redeployment> Repository;

        public RedeploymentController(IAbstractInterface<Redeployment> Repository)
        {
            this.Repository = Repository;
        }

        public ActionResult Index()
        {
            return View(Repository.GetAllItems());
        }

        [HttpPost]
        public ActionResult Add(Redeployment Redeployment)
        {
            if (ModelState.IsValid)
            {
                Repository.Add(Redeployment);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpGet]
        public ActionResult Edit([FromHeader]int id)
        {
            if (Repository.FindById(id) != null)
            {
                Redeployment Redeployment = Repository.FindById(id);
                return View(Redeployment);
            }
            return BadRequest();
        }

        [HttpPost]
        public ActionResult Edit(Redeployment Redeployment)
        {
            if (ModelState.IsValid)
            {
                Repository.Edit(Redeployment);
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}