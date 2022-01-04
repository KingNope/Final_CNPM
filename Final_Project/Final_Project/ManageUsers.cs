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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private string _namelogin, _fullname, repassword, phone_number;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-HA348VVB\SQLEXPRESS;Initial Catalog=users;Integrated Security=True");

        private void load()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select * from tb_user";
                SqlCommand com = new SqlCommand(myquery, sqlConnection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.Close();
                list_user.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }
        private bool IsNumeric(string value)
        {
            try
            {
                char[] chars = value.ToCharArray();
                foreach (char c in chars)
                {
                    if (!char.IsNumber(c))
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (iduser.Text == "" | namelogin.Text == "" | fullname.Text == "" | _password_.Text == "" | _telephone_.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng");
                }
                else if (!IsNumeric(_telephone_.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin người dùng");
                }
                else
                {
                    bool check = true;
                    if (list_user.Rows[0].Cells[0].Value != null)
                    {
                        sqlConnection.Open();
                        SqlCommand checkID = new SqlCommand("SELECT * FROM tb_user WHERE id_user = '" + iduser.Text + "'", sqlConnection);
                        SqlDataReader reader = checkID.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Người dùng đã tồn tại, vui lòng chọn ID khác");
                            check = false;
                            iduser.Text = "";
                            namelogin.Text = "";
                            fullname.Text = "";
                            _password_.Text = "";
                            _telephone_.Text = "";
                            iduser.ReadOnly = false;
                        }
                        sqlConnection.Close();
                    }
                    if(check)
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("insert into tb_user values('" + iduser.Text + "','" + namelogin.Text + "',N'" + fullname.Text + "','" + _password_.Text + "','" + _telephone_.Text + "')", sqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm người dùng thành công");
                        sqlConnection.Close();
                        load();
                        iduser.Text = "";
                        namelogin.Text = "";
                        fullname.Text = "";
                        _password_.Text = "";
                        _telephone_.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm người dùng thất bại");
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            load();
            Delete.Enabled = false;
            Change.Enabled = false;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (namelogin.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa");
                }
                else if (namelogin.Text != _namelogin | fullname.Text != _fullname | _password_.Text != repassword | _telephone_.Text != phone_number)
                {
                    MessageBox.Show("Vui lòng không chỉnh sửa thông tin khi xóa");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("delete from tb_user where id_user = '" + iduser.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa người dùng thành công");
                    sqlConnection.Close();
                    load();
                }
                iduser.Text = "";
                namelogin.Text = "";
                fullname.Text = "";
                _password_.Text = "";
                _telephone_.Text = "";
                iduser.ReadOnly = false;
                Delete.Enabled = false;
                Change.Enabled = false;
                Add.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Xóa người dùng thất bại");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void list_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.list_user.Rows[e.RowIndex];
            iduser.Text = row.Cells[0].Value.ToString();
            namelogin.Text = row.Cells[1].Value.ToString();
            _namelogin = row.Cells[1].Value.ToString();
            fullname.Text = row.Cells[2].Value.ToString();
            _fullname = row.Cells[2].Value.ToString();
            _password_.Text = row.Cells[3].Value.ToString();
            repassword = row.Cells[3].Value.ToString();
            _telephone_.Text = row.Cells[4].Value.ToString();
            phone_number = row.Cells[4].Value.ToString();
            iduser.ReadOnly = true;
            Delete.Enabled = true;
            Change.Enabled = true;
            Add.Enabled = false;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            try
            {

                if (iduser.Text == "" | namelogin.Text == "" | fullname.Text == "" | _password_.Text == "" | _telephone_.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng");
                }
                else if (!IsNumeric(_telephone_.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin người dùng");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("update tb_user set name_login = '" + namelogin.Text + "',full_name = N'" + fullname.Text + "',_password = '" + _password_.Text + "',telephone = '" + _telephone_.Text + "' where id_user = '" + iduser.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin người dùng thành công");
                    sqlConnection.Close();
                    load();
                    iduser.Text = "";
                    namelogin.Text = "";
                    fullname.Text = "";
                    _password_.Text = "";
                    _telephone_.Text = "";
                    iduser.ReadOnly = false;
                    Delete.Enabled = false;
                    Change.Enabled = false;
                    Add.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            iduser.Text = "";
            namelogin.Text = "";
            fullname.Text = "";
            _password_.Text = "";
            _telephone_.Text = "";
            iduser.ReadOnly = false;
            Delete.Enabled = false;
            Add.Enabled = true;
            Change.Enabled = false;
        }
    }
}
