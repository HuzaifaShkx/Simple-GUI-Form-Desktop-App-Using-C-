using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5_GUI
{
    public partial class Form1 : Form
    {
        float bsal, deduction, tax, nsal, asal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text == string.Empty)
            {
                MessageBox.Show("Employee no. is Missing");
            }
            else if (txtEmpName.Text == string.Empty)
            {
                MessageBox.Show("Employee name is Missing");
            }
            else if (txtBsal.Text == string.Empty)
            {
                MessageBox.Show("Employee Salary is Missing");
            }
            else if (txtDeduction.Text == string.Empty)
            {
                MessageBox.Show("Employee Deduction is Missing");
            }
            else
            {
                try { 
                    bsal=float.Parse(txtBsal.Text);
                    deduction=float.Parse(txtDeduction.Text);
                    tax = float.Parse((bsal * 0.06).ToString());
                    txtTax.Text = tax.ToString();
                    nsal = bsal - tax - deduction;
                    txtNSal.Text=nsal.ToString();
                    txtAsal.Text = (nsal * 12).ToString();
                }
                catch (Exception ec) {
                    MessageBox.Show(ec.ToString());
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNSal.Text = string.Empty;
            txtEmpno.Text = string.Empty;
            txtEmpName.Text = string.Empty;
            txtDeduction.Text = string.Empty;
            txtAsal.Text = string.Empty;
            txtBsal.Text = string.Empty;
            txtTax.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
