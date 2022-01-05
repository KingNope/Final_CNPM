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
    public partial class Statistical : Form
    {
        public Statistical()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new Connect().sqlconnection;

        private void load_product()
        {
            try
            {
                sqlConnection.Open();
                string myquery = "select ID,name_product,image,descrip,quality,price,category,date from products";
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

        private void load_customers()
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

        private void loadsearch()
        {
            string s = list_month.SelectedItem.ToString();
            int month = int.Parse(s.Substring(6, 2));
            int year = int.Parse(list_year.SelectedItem.ToString());
            sqlConnection.Open();
            string myquery = "select * from customers where month(date_order) = '" + month + "' and year(date_order) = '" + year + "'";
            SqlCommand com = new SqlCommand(myquery, sqlConnection);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            list_customer.DataSource = dt;

            SqlDataAdapter sqlData = new SqlDataAdapter("select Count(*) from customers where month(date_order) = '" + month + "' and year(date_order) = '" + year + "'", sqlConnection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            count.Text = data.Rows[0][0].ToString();

            SqlDataAdapter sql = new SqlDataAdapter("select Sum(sum_price) from customers where month(date_order) = '" + month + "' and year(date_order) = '" + year + "'", sqlConnection);
            DataTable data1 = new DataTable();
            sql.Fill(data1);
            if (data.Rows[0][0].ToString() != "0")
            {
                Sum_order.Text = data1.Rows[0][0].ToString();
            }
            else
            {
                Sum_order.Text = "0.0000000";
            }


            string myquery1 = "select * from products where month(date) = '" + month + "' and year(date) = '" + year + "'";
            SqlCommand com1 = new SqlCommand(myquery1, sqlConnection);
            com1.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            list_product.DataSource = dt1;

            SqlDataAdapter sql1 = new SqlDataAdapter("select Count(*) from products where month(date) = '" + month + "' and year(date) = '" + year + "'", sqlConnection);
            DataTable data2 = new DataTable();
            sql1.Fill(data2);
            sum_product.Text = data2.Rows[0][0].ToString();


            sqlConnection.Close();
        }

        private void Statistical_Load(object sender, EventArgs e)
        {
            list_month.SelectedItem = "Chọn tháng";
            list_year.SelectedItem = "Chọn năm";
            load_product(); 
            load_customers();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(list_month.SelectedItem == "Chọn tháng" | list_year.SelectedItem == "Chọn năm")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin cần tìm");
            }
            else
            {
                loadsearch();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            load_customers();
            load_product();
            list_month.SelectedItem = "Chọn tháng";
            list_year.SelectedItem = "Chọn năm";
            sum_product.Text = "0";
            count.Text = "0";
            Sum_order.Text = "0.0000000";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
