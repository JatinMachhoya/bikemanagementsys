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
    public partial class UserBike : Form
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
        public UserBike()
        {
            InitializeComponent();
            display_bike();
        }

        private void Delete_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            if (bikeKey == "")
            {
                MessageBox.Show("Select Bike");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("delete from bike_detail_tbl where BNum = '" + bikeKey + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike Details Deleted");
                    display_bike();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Edit_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("update bike_detail_tbl set BBrand = '" + Bike_brand_txt.Text + "',BModel = '" + Bike_Model_txt.Text + "',BDate='" + Bike_date.Value.Date + "',OwnerName = '" + Bike_OwnerName_txt.Text + "' where BNum = '" + bikeKey + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bike Updated");
            display_bike();
        }
        private void display_bike()
        {
            conn();
            string qry = "select * from bike_detail_tbl";
            da = new SqlDataAdapter(qry, con);
            // SqlCommandBuilder bil = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            Bike_DGV.DataSource = ds.Tables[0];
        }

        private void Add_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("insert into bike_detail_tbl (BNum,BBrand,BModel,BDate,OwnerName) values('" + bike_num_txt.Text + "','" + Bike_brand_txt.Text + "','" + Bike_Model_txt.Text + "','" + Bike_date.Value.Date + "','" + Bike_OwnerName_txt.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bike Register");
            display_bike();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UserStock userStock = new UserStock();
            userStock.Show();
            this.Hide();
        }

        int key = 0;
        string bikeKey = "";

        private void Bike_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bike_num_txt.Text = Bike_DGV.SelectedRows[0].Cells[0].Value.ToString();
            bikeKey = bike_num_txt.Text = Bike_DGV.SelectedRows[0].Cells[0].Value.ToString();
            Bike_brand_txt.Text = Bike_DGV.SelectedRows[0].Cells[1].Value.ToString();
            Bike_Model_txt.Text = Bike_DGV.SelectedRows[0].Cells[2].Value.ToString();
            Bike_date.Text = Bike_DGV.SelectedRows[0].Cells[3].Value.ToString();
            Bike_OwnerName_txt.Text = Bike_DGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            UserBill bill = new UserBill();
            bill.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            UserProfile profile = new UserProfile();
            profile.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            User_Login user_Login = new User_Login();   
            user_Login.Show();
            this.Hide();
        }
    }
}
