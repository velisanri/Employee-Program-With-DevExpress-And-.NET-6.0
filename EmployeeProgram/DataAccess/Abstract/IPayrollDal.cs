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
    public interface IPayrollDal : IEntityRepository<Payroll>
    {
        List<PayrollDto> GetPayrollListWithEmployee();

        List<Employee> GetEmployeeList(int mounth, int year);

        List<PayrollListDto> GetPayrolList();

        PayrollParameter GetPayrollParameter();

        int GetEmployeeOffDayCount(int employeeId,int mounth,int year);
    }
}
