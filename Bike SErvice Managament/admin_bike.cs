using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Bike_SErvice_Managament
{
    public partial class admin_bike : Form
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
        public admin_bike()
        {
            InitializeComponent();
            display_bike();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Bike_show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            if(bikeKey == "")
            {
                MessageBox.Show("Select Bike");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("delete from bike_detail_tbl where BNum = '"+bikeKey+"'",con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bike Details Deleted");
                    display_bike();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Edit_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("update bike_detail_tbl set BBrand = '" + Bike_brand_txt.Text + "',BModel = '" + Bike_Model_txt.Text + "',BDate='" + Bike_date.Value.Date + "',OwnerName = '" + Bike_OwnerName_txt.Text + "' where BNum = '"+bikeKey+"'", con);
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
            cmd = new SqlCommand("insert into bike_detail_tbl (BNum,BBrand,BModel,BDate,OwnerName) values('"+bike_num_txt.Text+"','"+Bike_brand_txt.Text+"','"+Bike_Model_txt.Text+"','"+Bike_date.Value.Date+"','"+Bike_OwnerName_txt.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bike Register");
            display_bike();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            admin_stock stock = new admin_stock();
            stock.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();    
            emp.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(); 
            bill.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();   
            dash.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            User_Login user = new User_Login();
            user.Show();
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

            /*if(bike_num_txt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Bike_DGV.SelectedRows[0].Cells[1].Value.ToString());
            }*/

        }
    }
}
