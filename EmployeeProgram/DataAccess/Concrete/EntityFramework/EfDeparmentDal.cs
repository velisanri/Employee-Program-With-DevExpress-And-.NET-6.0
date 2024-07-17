using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entitiess.Concrete;
using Entitiess.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDeparmentDal : EfEntityRepositoryBase<Department,EmployeeDbContext>,IDepartmentDal
    {
        public bool CheckDeparmentUses(int departmentId)
        {
            using (var context = new EmployeeDbContext()) 
            {
                var result = context.Employees.Where(e => e.DepartmentId == departmentId);
                return (result.Count() > 0? false:true);

            }
        }


        public List<Department> GetList()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = from department in context.Departments
                             select new Department
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 Status = department.Status,
                             };
                return result.ToList();
            }

        }

        public List<DepartmentDto> GetListEmployeeCount()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = from department in context.Departments
                             select new DepartmentDto
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 EmployeeCount = context.Employees.Where(e => e.DepartmentId == department.Id && e.Status != "isten ayrildi").Count()
                             };
                return result.ToList();
            }

        }

        public List<Department> GetListWithStatusTrue()
        {
            using (var context = new EmployeeDbContext())
            {
                var result = from department in context.Departments
                             where department.Status == true
                             select new Department
                             {
                                 Id = department.Id,
                                 Name = department.Name.ToUpper(),
                                 Status = department.Status,
                             };
                return result.ToList();
            }
        }

        public void StatusChange(Department department)
        {
            using (var context = new EmployeeDbContext())
            {
                if(department.Status)
                {
                    department.Status = false;
                }
                else
                {
                    department.Status= true;
                }
                context.Departments.Update(department);
                context.SaveChanges();
            }
        }

        
    }
}
