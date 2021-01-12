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
    public partial class AddItem : Form
    {
        String platform;
        Connection sqlConn = new Connection();

        public AddItem(string dest="Add")
        {
            platform = dest;
            InitializeComponent();
            lbl_title.Text = "Add "+dest;
            if (dest == "Suppliers")
            {
                txt_6.Visible = true;
                txt_7.Visible = true;
            }
            else if (dest == "Storage") 
            {
                txt_7.Height=350;
                txt_7.Visible = true;
                txt_7.Location = new Point(368, 85);
                txt_4.Text = "Storage Space";
                txt_5.Text = "Medicine Type";
            }
            else if (dest == "employe") 
            {
                txt_6.Visible = true;
                txt_4.Text = "Job Title ";
                txt_5.Text = "Hire Date ";
                txt_6.Text = "Salary";
            }
        }

        private void btn_exit_Click(object sender, EventArgs e){this.Close();}

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (platform == "Suppliers") 
            {
                sqlConn.add_supplier(txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, txt_5.Text, int.Parse(txt_6.Text), txt_7.Text);
            }
            else if (platform == "Storage")
            {
                sqlConn.add_storage(txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, txt_5.Text, txt_6.Text);
            }
            else if (platform == "employe")
            {
                sqlConn.add_employees(txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, txt_5.Text, int.Parse(txt_6.Text));
            }

            confMessageBox confItem = new confMessageBox();
            confItem.ShowDialog();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            sqlConn.OpenConection();
        }
    }
}
