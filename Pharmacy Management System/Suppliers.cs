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
    public partial class Suppliers : Form
    {
        Connection sqlConn = new Connection();
        public Suppliers()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem item = new AddItem("Suppliers");
            item.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            dataG_sup.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.suppliers);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sqlConn.delete_OneStorage(int.Parse(dataG_sup.CurrentRow.Cells[0].Value.ToString()));
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.suppliers);

        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            this.suppliersTableAdapter.Fill(this.pharmacyDataSet.suppliers);
        }
    }
}
