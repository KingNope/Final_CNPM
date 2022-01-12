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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private string _namecustom, _address, _phonecustom;
        SqlConnection sqlConnection = new Connect().sqlconnection;

        private void load()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select DISTINCT ID_custom, name_custom, address_custom, phone_number from customers";
                SqlCommand com = new SqlCommand(myquery, sqlConnection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.Close();
                list_customer.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }

        private string RandomString(bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < 6; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (idcustom.Text == "" | namecustom.Text == "" | address.Text == "" | phone_custom.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng");
                }
                else if (!IsNumeric(phone_custom.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin khách hàng");
                }
                else
                {
                    bool check = true;
                    if (list_customer.Rows[0].Cells[0].Value != null)
                    {
                        sqlConnection.Open();
                        SqlCommand checkID = new SqlCommand("SELECT * FROM customers WHERE ID_custom = '" + idcustom.Text + "'", sqlConnection);
                        SqlDataReader reader = checkID.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Khách hàng đã tồn tại, vui lòng chọn ID khác");
                            check = false;
                            idcustom.Text = "";
                            namecustom.Text = "";
                            address.Text = "";
                            phone_custom.Text = "";
                            count.Text = "0";
                            Sum.Text = "0.0000000";
                            idcustom.ReadOnly = false;
                        }
                        sqlConnection.Close();
                    }
                    if (check)
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("insert into customers values('" + idcustom.Text + "',N'" + namecustom.Text + "',N'" + address.Text + "','" + phone_custom.Text + "','" + null + "','" + null + "','" + null + "','" + null + "','" + null + "','" + RandomString(true) + "','" + null + "','" + null + "')", sqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm khách hàng thành công");
                        sqlConnection.Close();
                        load();
                        idcustom.Text = "";
                        namecustom.Text = "";
                        address.Text = "";
                        phone_custom.Text = "";
                        count.Text = "0";
                        Sum.Text = "0.0000000";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng thất bại");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (namecustom.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn thông tin cần xóa");
                }
                else
                {
                    if (_namecustom != namecustom.Text | _address != address.Text | _phonecustom != phone_custom.Text)
                    {
                        MessageBox.Show("Vui lòng không chỉnh sửa thông tin khi xóa");
                    }
                    else
                    {
                        bool check1 = true;
                        sqlConnection.Open();
                        SqlCommand check = new SqlCommand("SELECT * FROM customers WHERE product_name != '" + null + "' and ID_custom = '" + idcustom.Text + "'", sqlConnection);
                        SqlDataReader reader = check.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Khách hàng hiện tại đang có đơn hàng, không thể xóa");
                            check1 = false;
                            idcustom.Text = "";
                            namecustom.Text = "";
                            address.Text = "";
                            phone_custom.Text = "";
                            count.Text = "0";
                            Sum.Text = "0.0000000";
                            idcustom.ReadOnly = false;
                            Delete.Enabled = false;
                            Change.Enabled = false;
                            Add.Enabled = true;
                        }
                        sqlConnection.Close();
                        if (check1)
                        {
                            sqlConnection.Open();
                            SqlCommand cmd = new SqlCommand("delete from customers where ID_custom = '" + idcustom.Text + "'", sqlConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa khách hàng thành công");
                            sqlConnection.Close();
                            load();
                            idcustom.Text = "";
                            namecustom.Text = "";
                            address.Text = "";
                            phone_custom.Text = "";
                            count.Text = "0";
                            Sum.Text = "0.0000000";
                            idcustom.ReadOnly = false;
                            Delete.Enabled = false;
                            Change.Enabled = false;
                            Add.Enabled = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa người dùng thất bại");
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
        private void Change_Click(object sender, EventArgs e)
        {
            try
            {

                if (idcustom.Text == "" | namecustom.Text == "" | address.Text == "" | phone_custom.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng");
                }
                else if (!IsNumeric(phone_custom.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin khách hàng");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("update customers set name_custom = N'" + namecustom.Text + "',address_custom = N'" + address.Text + "',phone_number = '" + phone_custom.Text + "' where ID_custom = '" + idcustom.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin người dùng thành công");
                    sqlConnection.Close();
                    load();
                    idcustom.Text = "";
                    namecustom.Text = "";
                    address.Text = "";
                    phone_custom.Text = "";
                    count.Text = "0";
                    Sum.Text = "0.0000000";
                    idcustom.ReadOnly = false;
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
            idcustom.Text = "";
            namecustom.Text = "";
            address.Text = "";
            phone_custom.Text = "";
            idcustom.ReadOnly = false;
            Delete.Enabled = false;
            Add.Enabled = true;
            Change.Enabled = false;
            count.Text = "0";
            Sum.Text = "0.0000000";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            load();
            Delete.Enabled = false;
            Change.Enabled = false;
        }

        private void list_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.list_customer.Rows[e.RowIndex];
            idcustom.Text = row.Cells[0].Value.ToString();
            namecustom.Text = row.Cells[1].Value.ToString();
            _namecustom = row.Cells[1].Value.ToString();
            address.Text = row.Cells[2].Value.ToString();
            _address = row.Cells[2].Value.ToString();
            phone_custom.Text = row.Cells[3].Value.ToString();
            _phonecustom = row.Cells[3].Value.ToString();
            sqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select Count(*) from customers where product_name != '" + null + "' and ID_custom = '" + idcustom.Text + "'", sqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            count.Text = data.Rows[0][0].ToString();
            SqlDataAdapter sql = new SqlDataAdapter("select Sum(sum_price) from customers where product_name != '" + null + "' and ID_custom = '" + idcustom.Text + "'", sqlConnection);
            DataTable data1 = new DataTable();
            sql.Fill(data1);
            Sum.Text = data1.Rows[0][0].ToString();
            sqlConnection.Close();
            idcustom.ReadOnly = true;
            Delete.Enabled = true;
            Change.Enabled = true;
            Add.Enabled = false;
        }
    }
}
