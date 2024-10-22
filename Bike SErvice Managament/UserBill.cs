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
    public partial class UserBill : Form
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
        public UserBill()
        {
            InitializeComponent();
            display_stock();
            getBikes();

            Emp_lbl.Text = User_Login.Username;
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

        private void getBikes()
        {
            conn();
            cmd = new SqlCommand("select BNum from bike_detail_tbl ", con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BNum", typeof(string));
            dt.Load(dr);
            BikeNumber.ValueMember = "BNum";
            BikeNumber.DataSource = dt;

        }

        int Qty = 0, price = 0, key = 0;
        string PartName = "";

        private void Stock_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PartName = Stock_DGV.SelectedRows[0].Cells[1].Value.ToString();
            Qty = Convert.ToInt32(Stock_DGV.SelectedRows[0].Cells[2].Value.ToString());
            price = Convert.ToInt32(Stock_DGV.SelectedRows[0].Cells[3].Value.ToString());


            if (PartName == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Stock_DGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        int n = 0, num = 0;
        int tf = 0;

        private void Save_bill_btn_Click(object sender, EventArgs e)
        {
            if (BikeNumber.SelectedIndex == -1 || TotalFee.Text == "Total Fee")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                cmd = new SqlCommand("insert into bill_tbl (BikeNum,BillDate,MechFee,PartFee,TotalFee,EmpName) values('" + BikeNumber.SelectedValue.ToString() + "','" + Bike_date.Value.Date + "','" + Mech_fee_txt.Text + "','" + grdtot + "','" + tf + "','" + Emp_lbl.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bill Saved");
            }
        }

        private void AddPart_btn_Click(object sender, EventArgs e)
        {
            if (key == 0 || Qty_txt.Text == "")
            {
                MessageBox.Show("Select Parts To Add");
            }
            else if (Convert.ToInt32(Qty_txt.Text) > Qty)
            {
                MessageBox.Show("NOT Enough Stock");
            }
            else
            {
                num = Convert.ToInt32(Qty_txt.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(Bill_DGV);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = PartName;
                tot = price * num;
                newRow.Cells[2].Value = num;
                newRow.Cells[3].Value = price;
                newRow.Cells[4].Value = tot;
                Bill_DGV.Rows.Add(newRow);
                n++;
                grdtot = grdtot + tot;
                PartFee.Text = " Part fee = RS" + grdtot;
                UpdateQty();
                Qty_txt.Text = "";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UserBike bike = new UserBike(); 
            bike.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            UserStock userStock = new UserStock();
            userStock.Show();
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
            User_Login  login = new User_Login();
            login.Show();
            this.Hide();
        }

        private void UpdateQty()
        {
            conn();
            int newQty = Qty - Convert.ToInt32(Qty_txt.Text);
            cmd = new SqlCommand("update stock_tbl set PartQty = '" + newQty + "' where PartId = '" + key + "'", con);
            cmd.ExecuteNonQuery();

            display_stock();
        }



        private void Cal_Fee_btn_Click(object sender, EventArgs e)
        {
            if (Mech_fee_txt.Text == "")
            {
                MessageBox.Show("Enter Velid Amount!!");
            }
            else if (PartFee.Text == "Part Fee")
            {
                tf = Convert.ToInt32(Mech_fee_txt.Text);
                TotalFee.Text = "Total Fee Rs" + (Mech_fee_txt.Text).ToString();
            }
            else
            {
                tf = (grdtot + Convert.ToInt32(Mech_fee_txt.Text));
                TotalFee.Text = "Total Fee Rs" + (grdtot + Convert.ToInt32(Mech_fee_txt.Text)).ToString();
            }
        }

        int tot = 0, grdtot = 0;





    }
}
