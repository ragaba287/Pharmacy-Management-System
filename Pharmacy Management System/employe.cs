using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class employe : Form
    {
        Connection sqlConn = new Connection();
        public employe()
        {
            InitializeComponent();
        }

        private void employe_Load(object sender, EventArgs e)
        {
            dataG_empl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.employeesTableAdapter.Fill(this.pharmacyDataSet1.employees);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem item = new AddItem("employe");
            item.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sqlConn.delete_OneStorage(int.Parse(dataG_empl.CurrentRow.Cells[0].Value.ToString()));
            this.employeesTableAdapter.Fill(this.pharmacyDataSet1.employees);

        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.pharmacyDataSet1.employees);
        }
    }
}
