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
    public partial class UserProfile : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds;
        DataGridViewCellEventArgs es;

        string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ROG STRIX\source\repos\Bike SErvice Managament\Bike SErvice Managament\Bike_db.mdf"";Integrated Security=True";
        String Username = User_Login.Username;
        void conn()
        {
            con = new SqlConnection(Constr);
            con.Open();
        }
        public UserProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            UserDashboard dashboard = new UserDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserBike userBike = new UserBike();
            userBike.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserStock userStock = new UserStock();  
            userStock.Show();
                this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            UserBill userBill = new UserBill();
            userBill.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            User_Login userLogin = new User_Login();
            userLogin.Show();
            this.Hide();

        }

        private void Add_btn_admin_Click(object sender, EventArgs e)
        {

        }

        private void Update_btn_admin_Click(object sender, EventArgs e)
        {
            conn();

            if (Emp_Name_txt.Text == null || Emp_pass_txt.Text == null || Emp_gen.Text == null || Emp_Add_txt.Text == null)
            {
                MessageBox.Show("Fill Data");
            }
            else
            {
                cmd = new SqlCommand("update emp_tbl set EmpName = '" + Emp_Name_txt.Text + "',EmpGen = '" + Emp_gen.Text + "',EmpAdd='" + Emp_Add_txt.Text + "',EmpPass = '" + Emp_pass_txt.Text + "' where EmpName = '" + Username + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Details Updated");
            }
        }
    }
}
