﻿using Business.Abstract;
using DevExpress.XtraEditors;
using Entitiess.Concrete.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeUI
{
    public partial class XtraEmployeeList : DevExpress.XtraEditors.XtraForm
    {
        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _deparmentService;
        private readonly IOffDayService _offDayService;

        public XtraEmployeeList(IEmployeeService employeeService, IDepartmentService deparmentService, IOffDayService offDayService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _deparmentService = deparmentService;
            _offDayService = offDayService;
        }

        private void XtraEmployeeList_Load(object sender, EventArgs e)
        {
            GetList();
        }

        public void GetList()
        {
            
            var employees = _employeeService.GetAll().Where(e => e.Status != "isten ayrildi").ToList();

            foreach(var item in employees)
            {
                string date = DateTime.Now.ToShortDateString();
                var result = _offDayService.GetEmployeeOfDayByDate(item.Id,Convert.ToDateTime(date));

                if(result != null)
                {
                    item.Status = "İzinli";
                    _employeeService.UpdateList(item);
                }
                else
                {
                    item.Status = "Çalışıyor";
                    _employeeService.UpdateList(item);
                }

            }
            var employeeList = _employeeService.GetEmployeelist();
            gCEmployeeList.DataSource = employeeList.Where(e => e.Status == "Çalışıyor").ToList();

            var departmentList = _deparmentService.GetListEmployeeCount();
            gCDepartmentList.DataSource = departmentList;

            int employee = employeeList.Where(e => e.Status == "Çalışıyor").Count();
            int off = employeeList.Where(e => e.Status == "İzinli").Count();
            int dismiss = employeeList.Where(e => e.Status == "isten ayrildi").Count();

            btnEmployee.Text = "Çalışan :" + employee;
            btnOff.Text = "İzinli :" + off;
            btnDismiss.Text = "Ayrilan :" + dismiss;

            lbActiveList.Text = "Çalışan Listesi";

            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = true;
            gridView1.Columns[11].Visible = true;
            gridView1.Columns[12].Visible = true;
            gridView1.Columns[13].Visible = false;



        }

        void GetOffEmployeeList()
        {
            var employeeList = _employeeService.GetEmployeelist().Where(e => e.Status == "İzinli").ToList();
            gCEmployeeList.DataSource = employeeList;

            lbActiveList.Text = "İzinli Listesi";

            gridView1.Columns[7].Visible = true;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = true;
            gridView1.Columns[11].Visible = true;
            gridView1.Columns[12].Visible = true;
            gridView1.Columns[13].Visible = false;
        }

        void GetDismissEmployeeList()
        {
            var employeeList = _employeeService.GetEmployeelist().Where(e => e.Status == "isten ayrildi").ToList();
            gCEmployeeList.DataSource = employeeList;

            lbActiveList.Text = "Ayrilanlar Listesi";

            gridView1.Columns[7].Visible = false;
            gridView1.Columns[9].Visible = true;
            gridView1.Columns[8].Visible = true;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;
            gridView1.Columns[12].Visible = false;
            gridView1.Columns[13].Visible = true;
        }

        private void repositoryBtnEdit_Click(object sender, EventArgs e)
        {
            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;

            XtraEmployeeUpdate employeeUpdate;
            employeeUpdate = new XtraEmployeeUpdate(_employeeService, _deparmentService);
            employeeUpdate.employeeList = this;
            employeeUpdate.Show();

            employeeUpdate.Get(id);
        }

        private void repositoryBtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{(gridView1.GetFocusedRow() as EmployeeDto).Name} personelini silmek istiyor musunuz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var result = _employeeService.Get((gridView1.GetFocusedRow() as EmployeeDto).Id);

                _employeeService.Delete(result);
                MessageBox.Show("Personel Başarıyla silindi", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetList();
            }
        }

        private void repositoryBtnEmployeeQuit_Click(object sender, EventArgs e)
        {
            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;


            XtraEmployeeQuit employeeQuit;
            employeeQuit = new XtraEmployeeQuit(_employeeService);
            employeeQuit.employeeList = this;
            employeeQuit.Show();

            employeeQuit.Get(id);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            GetOffEmployeeList();
        }

        private void btnDismiss_Click(object sender, EventArgs e)
        {
            GetDismissEmployeeList();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void repositoryBtnReHired_Click(object sender, EventArgs e)
        {
            XtraReHired reHired;
            reHired = new XtraReHired(_employeeService);
            reHired.employeeList = this;
            reHired.Show();

            int id = (gridView1.GetFocusedRow() as EmployeeDto).Id;
            reHired.employeeId = id;
        }
    }

}