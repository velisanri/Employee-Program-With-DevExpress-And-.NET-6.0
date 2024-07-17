using Business.Abstract;
using Business.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entitiess.Concrete;
using Entitiess.Concrete.Dtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public bool Add(Department department)
        {
            bool validation = ValidationTool.Validate(new DepartmentValidator(), department);

            if(validation)
            {
                _departmentDal.Add(department);
                MessageBox.Show("Bölüm Başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;

           


        }

        public void Delete(Department department)
        {
            var result = _departmentDal.CheckDeparmentUses(department.Id);
            if (!result) 
            {
                MessageBox.Show("Bu bölüme atanmış personeller olduğundan bölüm silinemiyor","Hata!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _departmentDal.Delete(department);
        }

        public int GetDepartmentId(string departmentName)
        {
            return _departmentDal.GetList().Where(d=>d.Name== departmentName).Select(s=>s.Id).FirstOrDefault();
        }

        public Department Get(int id)
        {
            return _departmentDal.Get(g=> g.Id == id);
        }

        public List<Department> GetList()
        {
            return _departmentDal.GetList();
        }

        public bool Update(Department department)
        {

            bool validation = ValidationTool.Validate(new DepartmentValidator(), department);

            if (validation)
            {
                _departmentDal.Update(department);
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;


        }

        public bool StatusChange(Department department)
        {
            _departmentDal.StatusChange(department);
            //MessageBox.Show("Durum güncelleme işlemi başarıyla gerçekleşti", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        public List<Department> GetListWithStatusTrue()
        {
            return _departmentDal.GetListWithStatusTrue();
        }

        public List<DepartmentDto> GetListEmployeeCount()
        {
            return _departmentDal.GetListEmployeeCount();
        }
    }
}
