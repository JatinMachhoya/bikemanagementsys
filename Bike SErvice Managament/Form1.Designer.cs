namespace Bike_SErvice_Managament
{
    partial class User_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin = new System.Windows.Forms.LinkLabel();
            this.Emp_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.Emp_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_emp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.Exit_Btn);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(553, 91);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Login";
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Animated = true;
            this.Exit_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit_Btn.FillColor = System.Drawing.Color.Transparent;
            this.Exit_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.Color.White;
            this.Exit_Btn.HoverState.FillColor = System.Drawing.Color.Red;
            this.Exit_Btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.Exit_Btn.Location = new System.Drawing.Point(487, 0);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(66, 31);
            this.Exit_Btn.TabIndex = 0;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // admin
            // 
            this.admin.ActiveLinkColor = System.Drawing.Color.White;
            this.admin.AutoSize = true;
            this.admin.BackColor = System.Drawing.Color.Transparent;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.LinkColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(235, 376);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(56, 20);
            this.admin.TabIndex = 8;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.admin.VisitedLinkColor = System.Drawing.Color.White;
            this.admin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.admin_LinkClicked);
            // 
            // Emp_pass
            // 
            this.Emp_pass.BackColor = System.Drawing.Color.Transparent;
            this.Emp_pass.BorderRadius = 7;
            this.Emp_pass.BorderThickness = 0;
            this.Emp_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emp_pass.DefaultText = "";
            this.Emp_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Emp_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Emp_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emp_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emp_pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Emp_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emp_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Emp_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emp_pass.Location = new System.Drawing.Point(239, 220);
            this.Emp_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_pass.Name = "Emp_pass";
            this.Emp_pass.PasswordChar = '*';
            this.Emp_pass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Emp_pass.PlaceholderText = "Enter Password";
            this.Emp_pass.SelectedText = "";
            this.Emp_pass.Size = new System.Drawing.Size(245, 30);
            this.Emp_pass.TabIndex = 10;
            // 
            // Emp_txt
            // 
            this.Emp_txt.BackColor = System.Drawing.Color.Transparent;
            this.Emp_txt.BorderRadius = 7;
            this.Emp_txt.BorderThickness = 0;
            this.Emp_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Emp_txt.DefaultText = "";
            this.Emp_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Emp_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Emp_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emp_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Emp_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.Emp_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emp_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Emp_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Emp_txt.Location = new System.Drawing.Point(239, 152);
            this.Emp_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emp_txt.Name = "Emp_txt";
            this.Emp_txt.PasswordChar = '\0';
            this.Emp_txt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Emp_txt.PlaceholderText = "Enter User Name";
            this.Emp_txt.SelectedText = "";
            this.Emp_txt.Size = new System.Drawing.Size(245, 30);
            this.Emp_txt.TabIndex = 9;
            this.Emp_txt.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Employee Name :";
            // 
            // Login_emp
            // 
            this.Login_emp.BackColor = System.Drawing.Color.Transparent;
            this.Login_emp.BorderColor = System.Drawing.Color.Transparent;
            this.Login_emp.BorderRadius = 10;
            this.Login_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login_emp.FillColor = System.Drawing.Color.Gray;
            this.Login_emp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Login_emp.ForeColor = System.Drawing.Color.White;
            this.Login_emp.HoverState.FillColor = System.Drawing.Color.Silver;
            this.Login_emp.Location = new System.Drawing.Point(190, 316);
            this.Login_emp.Name = "Login_emp";
            this.Login_emp.Size = new System.Drawing.Size(149, 45);
            this.Login_emp.TabIndex = 12;
            this.Login_emp.Text = "Login";
            this.Login_emp.Click += new System.EventHandler(this.Login_emp_Click);
            // 
            // User_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(551, 468);
            this.Controls.Add(this.Login_emp);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.Emp_pass);
            this.Controls.Add(this.Emp_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Login";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button Exit_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel admin;
        private Guna.UI2.WinForms.Guna2TextBox Emp_pass;
        private Guna.UI2.WinForms.Guna2TextBox Emp_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Login_emp;
    }
}

