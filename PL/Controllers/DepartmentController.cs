using BLL.Repos;
using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            DepartmentRepo departmentRepo = new DepartmentRepo();
            var dep = departmentRepo.GetAll();

            return View(dep);
        }
    }
}
