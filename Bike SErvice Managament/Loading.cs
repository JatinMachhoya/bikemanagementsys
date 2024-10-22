using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bike_SErvice_Managament
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }

        int startP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            Loading_bar.Value = startP;

            per.Text = startP + " %";

            if(Loading_bar.Value == 100)
            {
                Loading_bar.Value = 0;
                timer1.Stop();

                User_Login login = new User_Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
