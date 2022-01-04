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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }


        private string _nameproduct, thumbnail, des, quatly, cent, cato, dtiem;
        SqlConnection sqlConnection = new Connect().sqlconnection;

        private void fillcate()
        {
            string query = "select * from categories";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader;
            try
            {
                sqlConnection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("name_cate", typeof(string));
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                categories.ValueMember = "name_cate";
                categories.DataSource = dt;
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }

        private void fillcate_search()
        {
            string query = "select * from categories";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader;
            try
            {
                sqlConnection.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("name_cate", typeof(string));
                reader = cmd.ExecuteReader();
                dt.Load(reader);
                list_search.ValueMember = "name_cate";
                list_search.DataSource = dt;
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }

        private void load_search()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select ID_product,name_product,image,descrip,quality,price,category,date from products where category = '" + list_search.SelectedValue.ToString() + "'";
                SqlCommand com = new SqlCommand(myquery, sqlConnection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.Close();
                list_product.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }

        private void load()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select ID_product,name_product,image,descrip,quality,price,category,date from products";
                SqlCommand com = new SqlCommand(myquery, sqlConnection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.Close();
                list_product.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            fillcate();
            fillcate_search();
            load();
            Delete.Enabled = false;
            Change.Enabled = false;
            categories.SelectedValue = "";
            list_search.SelectedValue = "";
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
                if (idproduct.Text == "" | nameproduct.Text == "" | quaty.Text == "" | _price.Text == "" | _image.Text == "" | categories.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm");
                }
                else if (!IsNumeric(quaty.Text.ToString()) | !IsNumeric(_price.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin sản phẩm");
                }
                else
                {
                    bool check = true;
                    if (list_product.Rows[0].Cells[0].Value != null)
                    {
                        sqlConnection.Open();
                        SqlCommand checkID = new SqlCommand("SELECT * FROM products WHERE ID_product = '" + idproduct.Text + "'", sqlConnection);
                        SqlDataReader reader = checkID.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Sản phẩm đã tồn tại, vui lòng chọn ID khác");
                            check = false;
                            idproduct.Text = "";
                            nameproduct.Text = "";
                            _descrip.Text = "";
                            _image.Text = "";
                            quaty.Text = "";
                            _price.Text = "";
                            date_time.Value = DateTime.Now;
                            categories.SelectedValue = "";
                            idproduct.ReadOnly = false;
                        }
                        sqlConnection.Close();
                    }
                    if (check)
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("insert into products values('" + idproduct.Text + "','" + nameproduct.Text + "','" + _image.Text + "',N'" + _descrip.Text + "','" + quaty.Text + "','" + _price.Text + "','" + categories.SelectedValue.ToString() + "','" + date_time.Value.ToString("MM/dd/yyyy") + "')", sqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sản phẩm thành công");
                        sqlConnection.Close();
                        load();
                        idproduct.Text = "";
                        nameproduct.Text = "";
                        _descrip.Text = "";
                        _image.Text = "";
                        quaty.Text = "";
                        _price.Text = "";
                        categories.SelectedValue = "";
                        date_time.Value = DateTime.Now;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm người dùng thất bại");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameproduct.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
                }
                else
                {

                    if (_nameproduct != nameproduct.Text | _image.Text != thumbnail | quaty.Text != quatly | _price.Text != cent | categories.SelectedValue.ToString() != cato | date_time.Value.ToString("MM/dd/yyyy") != dtiem)
                    {
                        MessageBox.Show("Không được phép thay đổi giá trị trước khi xóa");
                    }
                    else
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("delete from products where ID_product = '" + idproduct.Text + "'", sqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sản phẩm thành công");
                        sqlConnection.Close();
                        load();
                    }

                    idproduct.Text = "";
                    nameproduct.Text = "";
                    _descrip.Text = "";
                    _image.Text = "";
                    quaty.Text = "";
                    _price.Text = "";
                    categories.SelectedValue = "";
                    date_time.Value = DateTime.Now;
                    idproduct.ReadOnly = false;
                    Delete.Enabled = false;
                    Change.Enabled = false;
                    Add.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Xóa sản phẩm thất bại");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            try
            {

                if (idproduct.Text == "" | nameproduct.Text == "" | quaty.Text == "" | _price.Text == "" | _image.Text == "" | categories.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin người dùng");
                }
                else if (!IsNumeric(quaty.Text.ToString()) | !IsNumeric(_price.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin sản phẩm");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("update products set name_product = '" + nameproduct.Text + "',image = '" + _image.Text + "',descrip = N'" + _descrip.Text + "',quality = '" + quaty.Text + "',price = '" + _price.Text + "',category = '" + categories.SelectedValue.ToString() + "',date = '" + date_time.Value.ToString("MM/dd/yyyy") + "' where ID_product = '" + idproduct.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
                    sqlConnection.Close();
                    load();
                    idproduct.Text = "";
                    nameproduct.Text = "";
                    _descrip.Text = "";
                    _image.Text = "";
                    quaty.Text = "";
                    _price.Text = "";
                    categories.SelectedValue = "";
                    date_time.Value = DateTime.Now;
                    idproduct.ReadOnly = false;
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
            idproduct.Text = "";
            nameproduct.Text = "";
            _descrip.Text = "";
            _image.Text = "";
            quaty.Text = "";
            _price.Text = "";
            categories.SelectedValue = "";
            date_time.Value = DateTime.Now;
            idproduct.ReadOnly = false;
            Delete.Enabled = false;
            Add.Enabled = true;
            Change.Enabled = false;
        }

        private void list_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.list_product.Rows[e.RowIndex];
            idproduct.Text = row.Cells[0].Value.ToString();
            nameproduct.Text = row.Cells[1].Value.ToString();
            _nameproduct = row.Cells[1].Value.ToString();
            _image.Text = row.Cells[2].Value.ToString();
            thumbnail = row.Cells[2].Value.ToString();
            _descrip.Text = row.Cells[3].Value.ToString();
            des = row.Cells[3].Value.ToString();
            quaty.Text = row.Cells[4].Value.ToString();
            quatly = row.Cells[4].Value.ToString();
            _price.Text = row.Cells[5].Value.ToString();
            cent = row.Cells[5].Value.ToString();
            categories.SelectedValue = row.Cells[6].Value.ToString();
            cato = row.Cells[6].Value.ToString();
            if (row.Cells[7].Value.ToString() != "")
            {
                date_time.Value = DateTime.Parse(row.Cells[7].Value.ToString());
                dtiem = date_time.Value.ToString("MM/dd/yyyy");
            }

            idproduct.ReadOnly = true;
            Delete.Enabled = true;
            Change.Enabled = true;
            Add.Enabled = false;
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (list_search.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần tìm");
            }
            else
            {
                load_search();
            }
            idproduct.Text = "";
            nameproduct.Text = "";
            _descrip.Text = "";
            _image.Text = "";
            quaty.Text = "";
            _price.Text = "";
            categories.SelectedValue = "";
            date_time.Value = DateTime.Now;
            idproduct.ReadOnly = false;
            Delete.Enabled = false;
            Add.Enabled = true;
            Change.Enabled = false;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            load();
            list_search.SelectedValue = "";
            idproduct.Text = "";
            nameproduct.Text = "";
            _descrip.Text = "";
            _image.Text = "";
            quaty.Text = "";
            _price.Text = "";
            categories.SelectedValue = "";
            date_time.Value = DateTime.Now;
            idproduct.ReadOnly = false;
            Delete.Enabled = false;
            Add.Enabled = true;
            Change.Enabled = false;
        }
    }
}
