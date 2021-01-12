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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e) {Application.Exit();}

        void loginCheck()
        {
            if (txt_username.Text == "Ahmed" && txt_password.Text == "0000")
            {
                main frm2 = new main();
                this.Hide();
                frm2.ShowDialog();
                //this.Show();  
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password.");
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            loginCheck();
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCheck();
            }
        }

        private void lbl_forgot_Click(object sender, EventArgs e)
        {
            ForgMessageBox item = new ForgMessageBox();
            item.ShowDialog();
        }

    }
}
