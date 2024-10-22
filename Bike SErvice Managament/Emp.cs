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
    public partial class Emp : Form
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
        public Emp()
        {
            InitializeComponent();
            display_Emp();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void display_Emp()
        {
            conn();
            string qry = "select * from emp_tbl";
            da = new SqlDataAdapter(qry, con);
            // SqlCommandBuilder bil = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            Emp_DGV.DataSource = ds.Tables[0];
        }

        private void Add_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("insert into emp_tbl (EmpName,EmpGen,EmpAdd,EmpPass) values('" + Emp_Name_txt.Text + "','" + Emp_gen.SelectedItem.ToString() + "','" + Emp_Add_txt.Text + "','" + Emp_pass_txt.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Register");
            display_Emp();
        }

        int key = 0;
        private void Emp_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Emp_Name_txt.Text = Emp_DGV.SelectedRows[0].Cells[1].Value.ToString();
            Emp_gen.SelectedItem = Emp_DGV.SelectedRows[0].Cells[2].Value.ToString();
            Emp_Add_txt.Text = Emp_DGV.SelectedRows[0].Cells[3].Value.ToString();
            Emp_pass_txt.Text = Emp_DGV.SelectedRows[0].Cells[4].Value.ToString();

            if (Emp_Name_txt.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Emp_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Delete_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            if (key == 0)
            {
                MessageBox.Show("Select Employee");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("delete from emp_tbl where EmpId = '" + key + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Details Deleted");
                    display_Emp();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Edit_btn_admin_Click(object sender, EventArgs e)
        {
            conn();
            cmd = new SqlCommand("update emp_tbl set EmpName = '" + Emp_Name_txt.Text + "',EmpGen = '" + Emp_gen.SelectedItem.ToString() + "',EmpAdd='" + Emp_Add_txt.Text + "',EmpPass = '" + Emp_pass_txt.Text + "' where EmpId = '" + key + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Details Updated");
            display_Emp();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            admin_bike bike = new admin_bike();
            bike.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            admin_stock stock = new admin_stock();
            stock.Show();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }
    }
}
