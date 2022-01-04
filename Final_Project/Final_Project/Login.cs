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

namespace Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-HA348VVB\SQLEXPRESS;Initial Catalog=users;Integrated Security=True");
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Edt_name_Leave(object sender, EventArgs e)
        {
            if (Edt_name.Text == "")
            {
                Edt_name.Text = "Enter your name";
                Edt_name.ForeColor = Color.DarkGray;
            }
        }

        private void Edt_name_Enter(object sender, EventArgs e)
        {
            if(Edt_name.Text == "Enter your name")
            {
                Edt_name.Text = "";
                Edt_name.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if(Password.Text == "")
            {
                Password.Text = "Enter your password";
                Password.ForeColor = Color.DarkGray;
                Password.UseSystemPasswordChar = false;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Enter your password")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
                Password.UseSystemPasswordChar = true;
            }
        }

        private void Xacnhan_Click(object sender, EventArgs e)
        {
            if (Edt_name.Text == "" | Password.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập");
            }
            else
            {
                sqlConnection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("select Count(*) from tb_user where name_login = '" + Edt_name.Text + "' and _password = '" + Password.Text + "'", sqlConnection);
                DataTable data = new DataTable();
                sqlData.Fill(data);
                if (data.Rows[0][0].ToString() == "1")
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác");
                }
                sqlConnection.Close();
            }
        }
    }
}
