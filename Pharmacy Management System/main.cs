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
    public partial class main : Form
    {
        Connection sqlConn = new Connection();

        public main()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("hh:mm:tt\ndddd, dd MMMM");
        }

        void showDashborad()
        {
            pan_mid.Controls.Clear();
            Dashboard dash = new Dashboard();
            dash.TopLevel = false;
            dash.AutoScroll = true;
            pan_mid.Controls.Add(dash);
            dash.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            sqlConn.OpenConection();
            timer.Start();
            btn_dash.Active = true;
            showDashborad();
        }

        private void btn_exit_Click(object sender, EventArgs e) {Application.Exit();}


        private void btn_dash_Click(object sender, EventArgs e){showDashborad();}

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            pan_mid.Controls.Clear();
            Suppliers dash = new Suppliers();
            dash.TopLevel = false;
            dash.AutoScroll = true;
            pan_mid.Controls.Add(dash);
            dash.Show();
        }

        private void btn_storage_Click(object sender, EventArgs e)
        {
            pan_mid.Controls.Clear();
            Storage dash = new Storage();
            dash.TopLevel = false;
            dash.AutoScroll = true;
            pan_mid.Controls.Add(dash);
            dash.Show();
        }


        private void btn_sales_Click(object sender, EventArgs e)
        {
            pan_mid.Controls.Clear();
            Sales dash = new Sales();
            dash.TopLevel = false;
            dash.AutoScroll = true;
            pan_mid.Controls.Add(dash);
            dash.Show();
        }

        private void btn_empl_Click(object sender, EventArgs e)
        {
            pan_mid.Controls.Clear();
            employe empl = new employe();
            empl.TopLevel = false;
            empl.AutoScroll = true;
            pan_mid.Controls.Add(empl);
            empl.Show();
        }

        



    }
}
