using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFormApp
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
           /* newForm newForm =new newForm();
            newForm.Show();*/
        }

        private void bttnView_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            EmployeeInfo emplooyeeInfo = new EmployeeInfo()
            {
                surName = txtSurname.Text,
                otherNames = txtFirstName.Text,
                dateOfEmployment = DOE.Text,
                department = cmbDept.Text,
                role= cmbRole.Text,

            };

            int res=  emplooyeeInfo.employeeCreate(emplooyeeInfo);
            if (res>0)
            {
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }

        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeInfo emplooyeeInfo = new EmployeeInfo()
            {
                Id = int.Parse(txtID.Text),
                surName = txtSurname.Text,
                otherNames = txtFirstName.Text,
                dateOfEmployment = DOE.Text,
                department = cmbDept.Text,
                role = cmbRole.Text,

            };

            int res = emplooyeeInfo.employeeUpdate(emplooyeeInfo);
            if (res > 0)
            {
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }

        }
    }
}
