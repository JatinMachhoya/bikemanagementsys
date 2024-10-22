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

namespace Bike_SErvice_Managament
{
    public partial class User_Login : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds;
        DataGridViewCellEventArgs es;

        string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ROG STRIX\source\repos\Bike SErvice Managament\Bike SErvice Managament\Bike_db.mdf"";Integrated Security=True";

        public static string Username = "";
        void conn()
        {
            con = new SqlConnection(Constr);
            con.Open();
        }

        public User_Login()
        {
            InitializeComponent();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_emp_Click(object sender, EventArgs e)
        {
            if (Emp_txt.Text == "" && Emp_pass.Text == "")
            {
                MessageBox.Show("Enter Valid Username and Password", "Error");
            }
            else
            {
                conn();
                da = new SqlDataAdapter("select count(*) from emp_tbl where EmpName = '" + Emp_txt.Text + "' and EmpPass ='" + Emp_pass.Text + "' ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Username = Emp_txt.Text; 
                    UserDashboard dashboard = new UserDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password");
                }
            }
        }

        private void admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            admin_login admin_login_page = new admin_login();
            admin_login_page.Show();
            this.Hide();
        }
    }
}
