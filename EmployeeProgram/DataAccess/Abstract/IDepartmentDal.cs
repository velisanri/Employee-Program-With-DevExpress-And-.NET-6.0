using Core.DataAccess;
using Entitiess.Concrete;
using Entitiess.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal : IEntityRepository<Department> 
    {

        void StatusChange(Department department);

        List<Department> GetList();

        List<DepartmentDto> GetListEmployeeCount();

        List<Department> GetListWithStatusTrue();

        bool CheckDeparmentUses(int departmentId);
    }
}
