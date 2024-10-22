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
    public partial class UserDashboard : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        DataSet ds;
        DataGridViewCellEventArgs es;

        string Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ROG STRIX\source\repos\Bike SErvice Managament\Bike SErvice Managament\Bike_db.mdf"";Integrated Security=True";

        void conn()
        {
            con = new SqlConnection(Constr);
            con.Open();
        }
        public UserDashboard()
        {
            InitializeComponent();
            CountBike();
            countStock();
        }

        void CountBike()
        {
            conn();
            da = new SqlDataAdapter("select count(*) from bike_detail_tbl", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Bike_lbl.Text = dt.Rows[0][0].ToString();
        }

        void countStock()
        {
            conn();
            da = new SqlDataAdapter("select count(*) from stock_tbl", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stock_lbl.Text = dt.Rows[0][0].ToString();
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

        private void label7_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            userProfile.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();
            user_Login.Show();
            this.Hide();

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_MouseClick(object sender, MouseEventArgs e)
        {
            UserBike bike = new UserBike();
            bike.Show();
            this.Hide();
        }

        private void guna2Panel5_MouseClick(object sender, MouseEventArgs e)
        {
            UserStock stock = new UserStock();
            stock.Show();
            this.Hide();
        }

        private void guna2Panel7_MouseClick(object sender, MouseEventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Hide();
        }
    }
}
