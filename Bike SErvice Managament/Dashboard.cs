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
using System.IO;

namespace Bike_SErvice_Managament
{
    public partial class Dashboard : Form
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

        public Dashboard()
        {
            InitializeComponent();
            CountBike();
            countStock();
            countEMP();
            Sum();
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

        void countEMP()
        {
            conn();
            da = new SqlDataAdapter("select count(*) from emp_tbl", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            emp_lbl.Text = dt.Rows[0][0].ToString();
        }

        void Sum()
        {
            conn();
            da = new SqlDataAdapter("select Sum (TotalFee) from bill_tbl", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Finance_lbl.Text = dt.Rows[0][0].ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            admin_bike bike = new admin_bike();
            bike.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            admin_stock stock = new admin_stock();
            stock.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            User_Login user = new User_Login();
            user.Show();
            this.Hide();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
