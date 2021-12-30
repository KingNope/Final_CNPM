
namespace Final_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Xacnhan = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Edt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Xacnhan);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Edt_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(145, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 540);
            this.panel1.TabIndex = 0;
            // 
            // Xacnhan
            // 
            this.Xacnhan.BackColor = System.Drawing.Color.SlateGray;
            this.Xacnhan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xacnhan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Xacnhan.Location = new System.Drawing.Point(107, 374);
            this.Xacnhan.Name = "Xacnhan";
            this.Xacnhan.Size = new System.Drawing.Size(209, 40);
            this.Xacnhan.TabIndex = 3;
            this.Xacnhan.Text = "XÁC NHẬN";
            this.Xacnhan.UseVisualStyleBackColor = false;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Password.Location = new System.Drawing.Point(49, 254);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(325, 34);
            this.Password.TabIndex = 2;
            this.Password.Text = "Enter your password";
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Edt_name
            // 
            this.Edt_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edt_name.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Edt_name.Location = new System.Drawing.Point(49, 183);
            this.Edt_name.Name = "Edt_name";
            this.Edt_name.Size = new System.Drawing.Size(325, 34);
            this.Edt_name.TabIndex = 1;
            this.Edt_name.Text = "Enter your name";
            this.Edt_name.Enter += new System.EventHandler(this.Edt_name_Enter);
            this.Edt_name.Leave += new System.EventHandler(this.Edt_name_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(132, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hệ thống quản lí kho hàng";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(703, 738);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Edt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Xacnhan;
        private System.Windows.Forms.TextBox Password;
    }
}

