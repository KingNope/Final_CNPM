
namespace Final_Project
{
    partial class ManageUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.namelogin = new System.Windows.Forms.TextBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this._password_ = new System.Windows.Forms.TextBox();
            this._telephone_ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.list_user = new System.Windows.Forms.DataGridView();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.iduser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(445, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí người dùng";
            // 
            // namelogin
            // 
            this.namelogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelogin.Location = new System.Drawing.Point(183, 203);
            this.namelogin.Name = "namelogin";
            this.namelogin.Size = new System.Drawing.Size(338, 34);
            this.namelogin.TabIndex = 1;
            // 
            // fullname
            // 
            this.fullname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.Location = new System.Drawing.Point(183, 276);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(338, 34);
            this.fullname.TabIndex = 2;
            // 
            // _password_
            // 
            this._password_.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._password_.Location = new System.Drawing.Point(183, 346);
            this._password_.Name = "_password_";
            this._password_.Size = new System.Drawing.Size(338, 34);
            this._password_.TabIndex = 3;
            // 
            // _telephone_
            // 
            this._telephone_.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._telephone_.Location = new System.Drawing.Point(183, 411);
            this._telephone_.Name = "_telephone_";
            this._telephone_.Size = new System.Drawing.Size(338, 34);
            this._telephone_.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đăng nhập: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ và tên: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật khẩu: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại: ";
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Lavender;
            this.Add.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(22, 487);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 40);
            this.Add.TabIndex = 10;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Lavender;
            this.Delete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(155, 487);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 40);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Xóa";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.BackColor = System.Drawing.Color.Lavender;
            this.Change.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change.Location = new System.Drawing.Point(290, 487);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(110, 40);
            this.Change.TabIndex = 12;
            this.Change.Text = "Sửa";
            this.Change.UseVisualStyleBackColor = false;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.LightSlateGray;
            this.Back.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Back.Location = new System.Drawing.Point(1111, 536);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 40);
            this.Back.TabIndex = 13;
            this.Back.Text = "Trở về";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // list_user
            // 
            this.list_user.BackgroundColor = System.Drawing.Color.LightBlue;
            this.list_user.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.list_user.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.list_user.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.list_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.name_login,
            this.full_name,
            this._password,
            this.telephone});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list_user.DefaultCellStyle = dataGridViewCellStyle15;
            this.list_user.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.list_user.Location = new System.Drawing.Point(583, 151);
            this.list_user.Name = "list_user";
            this.list_user.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list_user.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.list_user.RowHeadersWidth = 51;
            this.list_user.RowTemplate.Height = 24;
            this.list_user.Size = new System.Drawing.Size(676, 345);
            this.list_user.TabIndex = 14;
            this.list_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_user_CellClick);
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_user.DefaultCellStyle = dataGridViewCellStyle10;
            this.id_user.HeaderText = "ID";
            this.id_user.MinimumWidth = 6;
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            this.id_user.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_user.Width = 125;
            // 
            // name_login
            // 
            this.name_login.DataPropertyName = "name_login";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.name_login.DefaultCellStyle = dataGridViewCellStyle11;
            this.name_login.HeaderText = "Tên đăng nhập";
            this.name_login.MinimumWidth = 6;
            this.name_login.Name = "name_login";
            this.name_login.ReadOnly = true;
            this.name_login.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.name_login.Width = 125;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.full_name.DefaultCellStyle = dataGridViewCellStyle12;
            this.full_name.HeaderText = "Họ và tên";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.full_name.Width = 125;
            // 
            // _password
            // 
            this._password.DataPropertyName = "_password";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._password.DefaultCellStyle = dataGridViewCellStyle13;
            this._password.HeaderText = "Mật khẩu";
            this._password.MinimumWidth = 6;
            this._password.Name = "_password";
            this._password.ReadOnly = true;
            this._password.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._password.Width = 125;
            // 
            // telephone
            // 
            this.telephone.DataPropertyName = "telephone";
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telephone.DefaultCellStyle = dataGridViewCellStyle14;
            this.telephone.HeaderText = "Số điện thoại";
            this.telephone.MinimumWidth = 6;
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.telephone.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 10);
            this.panel2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID user:";
            // 
            // iduser
            // 
            this.iduser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iduser.Location = new System.Drawing.Point(183, 139);
            this.iduser.Name = "iduser";
            this.iduser.Size = new System.Drawing.Size(338, 34);
            this.iduser.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(787, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 32);
            this.label8.TabIndex = 18;
            this.label8.Text = "Danh sách người dùng";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Lavender;
            this.Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(426, 487);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 40);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Dọn";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1271, 592);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iduser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.list_user);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._telephone_);
            this.Controls.Add(this._password_);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.namelogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ManageUsers";
            this.Text = "Quản lí người dùng";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namelogin;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.TextBox _password_;
        private System.Windows.Forms.TextBox _telephone_;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView list_user;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox iduser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn _password;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
    }
}