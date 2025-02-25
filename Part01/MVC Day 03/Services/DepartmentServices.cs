using Microsoft.EntityFrameworkCore;
using MVC_Day_03.DbContexts;
using MVC_Day_03.Models;
using MVC_Day_03.ViewModels;
namespace MVC_Day_03.Services
{
    public class DepartmentServices
    {
        AcademyDbContext dbContext = new AcademyDbContext();


        public ICollection<Department> GetAll()
        {
            var DepartmentList = dbContext.Departments
                .Include(d => d.Students)
                .ToList();

            return DepartmentList;
        }
        public Department ShowDetail(int id)
        {
            var Department = dbContext.Departments
                .Include(d => d.Students)
                .FirstOrDefault(d => d.Id == id);

            return Department;
        }

        public void Add(Department department)
        {
            dbContext.Add(department);
            dbContext.SaveChanges();
        }

        public DepartmentViewModels GetDepartmentViewModels(int id)
        {
            var department = ShowDetail(id);
            if (department == null)
            {
                return null;
            }

            var studentOver25 = department.Students
                .Where(s => s.Age > 25)
                .Select(s => s.Name)
                .ToList();

            var state = department.Students
                .Count > 50 ? "Main" : "Branch";

            return new DepartmentViewModels
            {
                DepartmentName = department.Name,
                StudentNamesOver25 = studentOver25,
                DepartmentState = state
            };

        }
    }
}
