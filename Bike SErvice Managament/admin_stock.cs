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
    public partial class admin_stock : Form
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

        public admin_stock()
        {
            InitializeComponent();
            display_stock();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            admin_bike bike = new admin_bike();
            bike.Show();
            this.Hide();
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

        private void Add_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("insert into stock_tbl (PartName,PartQty,PartPrice) values('" + Part_name_txt.Text + "','" + Part_qty_txt.Text + "','" + Part_price_txt.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Stock Added");
            display_stock();
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

        int key = 0;
        private void Stock_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Part_name_txt.Text = Stock_DGV.SelectedRows[0].Cells[1].Value.ToString();
            Part_qty_txt.Text = Stock_DGV.SelectedRows[0].Cells[2].Value.ToString();
            Part_price_txt.Text = Stock_DGV.SelectedRows[0].Cells[3].Value.ToString();
           

            if (Part_name_txt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Stock_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Edit_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("update stock_tbl set PartName = '" + Part_name_txt.Text + "',PartQty = '" + Part_qty_txt.Text + "',PartPrice = '" + Part_price_txt.Text + "' where PartId = '" + key + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Stock Details Updated");
            display_stock();
        }

        private void Delete_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            if (key == 0)
            {
                MessageBox.Show("Select Part");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("delete from stock_tbl where PartId = '" + key + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stock Details Deleted");
                    display_stock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }

        private void admin_stock_Load(object sender, EventArgs e)
        {

        }
    }
}
