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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        private string name_category;

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-HA348VVB\SQLEXPRESS;Initial Catalog=users;Integrated Security=True");

        private void load()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select * from categories";
                SqlCommand com = new SqlCommand(myquery, sqlConnection);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sqlConnection.Close();
                list_categories.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Đổ dữ liệu thất bại");
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (idcate.Text == "" | namecate.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin danh mục");
                }
                else
                {
                    bool check = true;
                    if (list_categories.Rows[0].Cells[0].Value != null)
                    {
                        sqlConnection.Open();
                        SqlCommand checkID = new SqlCommand("SELECT * FROM categories WHERE ID_cate = '" + idcate.Text + "'", sqlConnection);
                        SqlDataReader reader = checkID.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Danh mục đã tồn tại, vui lòng chọn ID khác");
                            check = false;
                            idcate.Text = "";
                            namecate.Text = "";
                            idcate.ReadOnly = false;
                        }
                        sqlConnection.Close();
                    }
                    if (check)
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("insert into categories values('" + idcate.Text + "','" + namecate.Text + "')", sqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm danh mục thành công");
                        sqlConnection.Close();
                        load();
                        idcate.Text = "";
                        namecate.Text = "";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (namecate.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn danh mục cần xóa");
                }
                else
                {

                    if (namecate.Text != name_category)
                    {
                        MessageBox.Show("Vui lòng không thay đổi giá trị ban đầu khi muốn xóa");
                        idcate.Text = "";
                        namecate.Text = "";
                        idcate.ReadOnly = false;
                    }
                    else
                    {
                        bool check1 = true;
                        sqlConnection.Open();
                        SqlCommand checkcate = new SqlCommand("SELECT * FROM products WHERE category = '" + namecate.Text + "'", sqlConnection);
                        SqlDataReader reader = checkcate.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Đang tồn tại sản phẩm, không thể xóa");
                            check1 = false;
                            idcate.Text = "";
                            namecate.Text = "";
                            idcate.ReadOnly = false;
                        }
                        sqlConnection.Close();
                        if (check1)
                        {
                            sqlConnection.Open();
                            SqlCommand cmd = new SqlCommand("delete from categories where ID_cate = '" + idcate.Text + "'", sqlConnection);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa danh mục thành công");
                            sqlConnection.Close();
                            load();
                            idcate.Text = "";
                            namecate.Text = "";
                            idcate.ReadOnly = false;
                            Delete.Enabled = false;
                            Change.Enabled = false;
                            Add.Enabled = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa danh mục thất bại");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            try
            {

                if (idcate.Text == "" | namecate.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin danh mục");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("update categories set name_cate = '" + namecate.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin danh mục thành công");
                    sqlConnection.Close();
                    load();
                    idcate.Text = "";
                    namecate.Text = "";
                    idcate.ReadOnly = false;
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
            idcate.Text = "";
            namecate.Text = "";
            idcate.ReadOnly = false;
            Delete.Enabled = false;
            Add.Enabled = true;
            Change.Enabled = false;
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            load();
            Delete.Enabled = false;
            Change.Enabled = false;
        }

        private void list_categories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.list_categories.Rows[e.RowIndex];
            idcate.Text = row.Cells[0].Value.ToString();
            namecate.Text = row.Cells[1].Value.ToString();
            name_category = row.Cells[1].Value.ToString();
            idcate.ReadOnly = true;
            Delete.Enabled = true;
            Change.Enabled = true;
            Add.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
