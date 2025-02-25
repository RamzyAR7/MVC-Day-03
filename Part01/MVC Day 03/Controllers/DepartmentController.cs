using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using MVC_Day_03.Models;
using MVC_Day_03.Services;
using MVC_Day_03.ViewModels;

namespace MVC_Day_03.Controllers
{
    public class DepartmentController:Controller
    {
        DepartmentServices services = new DepartmentServices();

        // Department/ShowAll
        public IActionResult ShowAll()
        {
            var departments = services.GetAll();
            return View(departments);
        }
        // Department/ShowDetails/{id}
        public IActionResult ShowDetails(int id)
        {
            
            var department = services.GetDepartmentViewModels(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }
        // Department/Add/{id}?Name=SE&MgrName=ramzy
        public IActionResult Add(AddDepartmentViewModels Viewdepartment)
        {
            if (ModelState.IsValid)
            {
                var department = new Department
                {
                    Name = Viewdepartment.Name,
                    MgrName = Viewdepartment.MgrName
                };
                services.Add(department);
                return RedirectToAction("ShowAll");
            }
            return View(Viewdepartment);
        }
    }
}
