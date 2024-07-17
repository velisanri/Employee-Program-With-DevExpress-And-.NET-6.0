using Business.Abstract;
using DevExpress.XtraEditors;
using Entitiess.Concrete;
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
    public partial class XtraPayrollParameter : DevExpress.XtraEditors.XtraForm
    {
        private readonly IPayrollParameterService _PayrollParameterService;

        

        public XtraPayrollParameter(IPayrollParameterService payrollParameterService)
        {
            InitializeComponent();
            _PayrollParameterService = payrollParameterService;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void XtraPayrollParameter_Load(object sender, EventArgs e)
        {
            var result = _PayrollParameterService.Get();

            if (result != null)
            {
                txtNetMinimumWage.Text = result.NetMinimumWage.ToString();
                txtGrossMinimumWage.Text = result.GrossMinimumWage.ToString();
                txtParameter1.Text = result.Parameter1.ToString();
                txtParameter2.Text = result.Parameter2.ToString();
            }

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = _PayrollParameterService.Get();

            if (result != null) 
            {
                result.NetMinimumWage = Convert.ToDecimal(txtNetMinimumWage.Text);
                result.GrossMinimumWage = Convert.ToDecimal(txtGrossMinimumWage.Text);
                result.Parameter1 = Convert.ToDecimal(txtParameter1.Text);
                result.Parameter2 = Convert.ToDecimal(txtParameter2.Text);
                _PayrollParameterService.Update(result);
            }
            else
            {
                PayrollParameter payrollParameter = new PayrollParameter()
                {
                    NetMinimumWage = Convert.ToDecimal(txtNetMinimumWage.Text),
                    GrossMinimumWage = Convert.ToDecimal(txtGrossMinimumWage.Text),
                    Parameter1 = Convert.ToDecimal(txtParameter1.Text),
                    Parameter2 = Convert.ToDecimal(txtParameter2.Text)
                };
                _PayrollParameterService.Update(payrollParameter);
            }


        }
    }
}