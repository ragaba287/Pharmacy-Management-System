using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Dashboard : Form
    {
        Connection sqlConn = new Connection();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.pharmacyDataSet.sales);
            sqlConn.OpenConection();
            lbl_sum_sales.Text = sqlConn.count_sales().ToString() ?? "0";
            lbl_orders_count.Text = sqlConn.count_orders().ToString() ?? "0";
            lbl_empl_count.Text = sqlConn.count_empl().ToString()??"0";
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            employe empl = new employe();
            empl.ShowDialog();
        }
    }
}
