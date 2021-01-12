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
    public partial class Storage : Form
    {
        Connection sqlConn = new Connection();
        public Storage()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddItem item = new AddItem("Storage");
            item.ShowDialog();
        }

        private void Storage_Load(object sender, EventArgs e)
        {            
            sqlConn.OpenConection();
            this.storageTableAdapter.Fill(this.pharmacyDataSet1.Storage);
            dataG_storage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sqlConn.delete_OneStorage(int.Parse(dataG_storage.CurrentRow.Cells[0].Value.ToString()));
            this.storageTableAdapter.Fill(this.pharmacyDataSet1.Storage);
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            this.storageTableAdapter.Fill(this.pharmacyDataSet1.Storage);
        }
    }
}
