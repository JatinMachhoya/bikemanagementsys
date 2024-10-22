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
    public partial class UserStock : Form
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
        public UserStock()
        {
            InitializeComponent();
            display_stock();
        }
        void display_stock()
        {
            conn();
            string qry = "select * from stock_tbl";
            da = new SqlDataAdapter(qry, con);
            // SqlCommandBuilder bil = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            Stock_DGV.DataSource = ds.Tables[0];
        }

        private void Stock_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserBike userBike = new UserBike(); 
            userBike.Show();
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
            User_Login login = new User_Login();
            login.Show();
            this.Hide();
        }
    }
}
