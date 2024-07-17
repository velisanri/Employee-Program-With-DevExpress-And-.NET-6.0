using Entitiess.Concrete;
using Entitiess.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPayrollService
    {
        bool Add(int mounth,int year);

        void Delete (Payroll payroll);

        List<PayrollDto> GetPayrollListWithEmployee();

        List<PayrollListDto> GetPayrolList();

    }
}
