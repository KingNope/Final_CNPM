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
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        private string _namecustom, _address, _phonecustom, _nameproduct, amount_pro, resum, date, remethod, restatus_p, restatus_order;


        SqlConnection sqlConnection = new Connect().sqlconnection;

        private void load()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select * from customers";
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

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

     

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            load();
            Delete.Enabled = false;
            Change.Enabled = false;
            status_p.SelectedItem = "Chọn trạng thái";
            method_product.SelectedItem = "Chọn phương thức";
            status_or.SelectedItem = "Chọn tình trạng";
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
                    if (_namecustom != namecustom.Text | _address != address.Text | _phonecustom != phone_custom.Text | _nameproduct != nameproduct.Text | amount_pro != amount_product.Text | resum != sum_p.Text | date != date_time.Value.ToString("MM/dd/yyyy") | restatus_p != status_p.SelectedItem.ToString() | restatus_order != status_or.SelectedItem.ToString() | remethod != method_product.SelectedItem.ToString())
                    {
                        MessageBox.Show("Vui lòng không chỉnh sửa thông tin khi xóa");
                    }
                    else
                    {
                        sqlConnection.Open();
                        SqlCommand cmd = new SqlCommand("delete from customers where ID_order = '" + idorder.Text + "'", sqlConnection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa đơn hàng thành công");
                        sqlConnection.Close();
                        load();
                        idcustom.Text = "";
                        namecustom.Text = "";
                        address.Text = "";
                        phone_custom.Text = "";
                        nameproduct.Text = "";
                        amount_product.Text = "";
                        sum_p.Text = "";
                        date_time.Value = DateTime.Now;
                        method_product.SelectedItem = "Chọn phương thức";
                        idorder.Text = "";
                        status_p.SelectedItem = "Chọn trạng thái";
                        status_or.SelectedItem = "Chọn tình trạng";

                        idcustom.ReadOnly = false;
                        idorder.ReadOnly = false;
                        Delete.Enabled = false;
                        Change.Enabled = false;

                    }
                }
            }
            catch
            {
                MessageBox.Show("Xóa đơn hàng thất bại");
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
                if (idcustom.Text == "" | namecustom.Text == "" | address.Text == "" | phone_custom.Text == "" | nameproduct.Text == "" | amount_product.Text == "" | sum_p.Text == "" | method_product.SelectedItem == "Chọn phương thức" | status_p.SelectedItem == "Chọn trạng thái" | status_or.SelectedItem == "Chọn tình trạng")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin đơn hàng");
                }
                else if(!IsNumeric(amount_product.Text.ToString()) | !IsNumeric(sum_p.Text.ToString()) | !IsNumeric(phone_custom.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng điền chính xác thông tin đơn hàng");
                }
                else
                {
                    sqlConnection.Open();
                    SqlCommand cmd = new SqlCommand("update customers set name_custom = N'" + namecustom.Text + "',address_custom = N'" + address.Text + "',phone_number = '" + phone_custom.Text + "',product_name = '" + nameproduct.Text + "',amount = '" + amount_product.Text + "',sum_price = '" + sum_p.Text + "',date_order = '" + date_time.Value.ToString("MM/dd/yyyy") + "',method = '" + method_product.SelectedItem.ToString() + "',status = N'" + status_p.SelectedItem.ToString() + "',status_order = N'" + status_or.SelectedItem.ToString() + "' where ID_order = '" + idorder.Text + "'", sqlConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin đơn hàng thành công");
                    sqlConnection.Close();
                    load();
                    idcustom.Text = "";
                    namecustom.Text = "";
                    address.Text = "";
                    phone_custom.Text = "";
                    nameproduct.Text = "";
                    amount_product.Text = "";
                    sum_p.Text = "";
                    date_time.Value = DateTime.Now;
                    method_product.SelectedItem = "Chọn phương thức";
                    idorder.Text = "";
                    status_p.SelectedItem = "Chọn trạng thái";
                    status_or.SelectedItem = "Chọn tình trạng";

                    idcustom.ReadOnly = false;
                    idorder.ReadOnly = false;
                    Delete.Enabled = false;
                    Change.Enabled = false;

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
            nameproduct.Text = "";
            amount_product.Text = "";
            sum_p.Text = "";
            date_time.Value = DateTime.Now;
            method_product.SelectedItem = "Chọn phương thức";
            idorder.Text = "";
            status_p.SelectedItem = "Chọn trạng thái";
            status_or.SelectedItem = "Chọn tình trạng";

            idcustom.ReadOnly = false;
            idorder.ReadOnly = false;
            Delete.Enabled = false;
            Change.Enabled = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hóa đơn thanh toán", new Font("Century", 25, FontStyle.Bold), Brushes.Black, new Point(230));
            e.Graphics.DrawString("ID khách hàng: " + idcustom.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Tên khách hàng: " + namecustom.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 140));
            e.Graphics.DrawString("Địa chỉ: " + address.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 180));
            e.Graphics.DrawString("Số điện thoại: " + phone_custom.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 220));
            e.Graphics.DrawString("ID đơn hàng: " + idorder.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 260));
            e.Graphics.DrawString("Tên sản phẩm: " + nameproduct.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 300));
            e.Graphics.DrawString("Số lượng: " + amount_product.Text, new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 340));
            e.Graphics.DrawString("Tổng tiền: " + sum_p.Text + " VND", new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 380));
            e.Graphics.DrawString("Ngày đặt hàng: " + date_time.Value.ToString("MM/dd/yyyy"), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 420));
            e.Graphics.DrawString("Hình thức thanh toán: " + method_product.SelectedItem.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 460));
            e.Graphics.DrawString("Trạng thái thanh toán: " + status_p.SelectedItem.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 500));
            e.Graphics.DrawString("Trạng thái giao hàng: " + status_or.SelectedItem.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 540));
        }

        private void list_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = this.list_customer.Rows[e.RowIndex];
            idcustom.Text = row.Cells[0].Value.ToString().Trim();
            namecustom.Text = row.Cells[1].Value.ToString().Trim();
            _namecustom = row.Cells[1].Value.ToString().Trim();
            address.Text = row.Cells[2].Value.ToString().Trim();
            _address = row.Cells[2].Value.ToString().Trim();
            phone_custom.Text = row.Cells[3].Value.ToString().Trim();
            _phonecustom = row.Cells[3].Value.ToString().Trim();
            nameproduct.Text = row.Cells[4].Value.ToString().Trim();
            _nameproduct = row.Cells[4].Value.ToString().Trim();
            amount_product.Text = row.Cells[5].Value.ToString().Trim();
            amount_pro = row.Cells[5].Value.ToString().Trim();
            sum_p.Text = row.Cells[6].Value.ToString().Trim();
            resum = row.Cells[6].Value.ToString().Trim();
            if (row.Cells[7].Value.ToString() != "")
            {
                date_time.Value = DateTime.Parse(row.Cells[7].Value.ToString().Trim());
                date = date_time.Value.ToString("MM/dd/yyyy");
            }
            method_product.SelectedItem = row.Cells[8].Value.ToString().Trim();
            remethod = row.Cells[8].Value.ToString().Trim();
            idorder.Text = row.Cells[9].Value.ToString().Trim();
            status_p.SelectedItem = row.Cells[10].Value.ToString().Trim();
            restatus_p = row.Cells[10].Value.ToString().Trim();
            status_or.SelectedItem = row.Cells[11].Value.ToString().Trim();
            restatus_order = row.Cells[11].Value.ToString().Trim();
            idcustom.ReadOnly = true;
            idorder.ReadOnly = true;
            Delete.Enabled = true;
            Change.Enabled = true;
        }

        private void print_Click(object sender, EventArgs e)
        {
          
            if (idcustom.Text == "" | namecustom.Text == "" | address.Text == "" | phone_custom.Text == "" | nameproduct.Text == "" | amount_product.Text == "" | sum_p.Text == "" | method_product.SelectedItem == "Chọn phương thức" | status_p.SelectedItem == "Chọn trạng thái" | status_or.SelectedItem == "Chọn tình trạng")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin đơn hàng");
            }
            else if (!IsNumeric(amount_product.Text.ToString()) | !IsNumeric(sum_p.Text.ToString()) | !IsNumeric(phone_custom.Text.ToString()))
            {
                MessageBox.Show("Vui lòng điền chính xác thông tin đơn hàng");
            }
            else 
            {
                string selected_method = method_product.SelectedItem.ToString();
                string selected_status_p = status_p.SelectedItem.ToString();
                string selected_status_or = status_or.SelectedItem.ToString();
                if (_namecustom != namecustom.Text | _address != address.Text | _phonecustom != phone_custom.Text | _nameproduct != nameproduct.Text | amount_pro != amount_product.Text | resum != sum_p.Text | date != date_time.Value.ToString("MM/dd/yyyy") | !restatus_p.Equals(selected_status_p) | !restatus_order.Equals(selected_status_or) | !remethod.Equals(selected_method))
                {
                    MessageBox.Show("Vui lòng không chỉnh sửa thông tin khi in phiếu xuất");
                }
                else if((printPreviewDialog1.ShowDialog() == DialogResult.OK)) {
                    printDocument1.Print();
                }
            }
        }
    }
}
