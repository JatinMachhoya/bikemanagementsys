using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_SErvice_Managament
{
    public partial class admin_login : Form
    {
        public static string Name = "Jatin";
        public admin_login()
        {
            InitializeComponent();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Show();  
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {
            if (admin_name_txt.Text == "Jatin" && Admin_pass_txt.Text == "3424")
            {
                admin_bike bike = new admin_bike();
                bike.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username and Password", "Error");
            }
        }
    }
}
