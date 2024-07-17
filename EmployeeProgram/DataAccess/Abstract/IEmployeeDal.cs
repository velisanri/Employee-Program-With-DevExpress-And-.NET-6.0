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
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
        bool  CheckIdentityNumber(string identityNumber);

        List<EmployeeDto> GetEmployeelist();

        List<OffDayEmployeeDto> GetEmployeeListByOffDay();

        OffDay GetOffDayByEmployee(int employeeId, DateTime date);

        PayrollParameter GetParameter();
    }
}
