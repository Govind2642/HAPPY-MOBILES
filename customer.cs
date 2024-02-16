using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Mobile
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void Addmobilebtn_Click(object sender, EventArgs e)
        {
            Addmobile mobile = new Addmobile();
            mobile.Show();
            this.Hide();
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            salespage sales = new salespage();
            sales.Show();
            this.Hide();
        }

        private void customerbtn_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Hide();
        }

        private void Accessoriesbtn_Click(object sender, EventArgs e)
        {
            Accessories Acc = new Accessories();
            Acc.Show();
            this.Hide();
        }

        private void Employeebtn_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            Emp.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog= Mobile;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int Customer_id = int.Parse(cusidtxt.Text);
                string Customer_name = cusnametxt.Text, Customer_mob = cusmobtxt.Text, Product = custprdtxt.Text, Product_name = cusprdnametxt.Text;
                DateTime Date = DateTime.Parse(cusdatetxt.Text);
                SqlCommand cmd = new SqlCommand("sp_cusinsert'" + Customer_id + "','" + Customer_name + "','" + Customer_mob + "','" + Product + "','" + Product_name + "','" + Date + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert into Successfully");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            void Getview()
        {
            SqlCommand cmd = new SqlCommand("sp_cusview", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
            

        private void customer_Load(object sender, EventArgs e)
        {
            Getview();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int Customer_id = int.Parse(cusidtxt.Text);
                string Customer_name = cusnametxt.Text, Customer_mob = cusmobtxt.Text, Product = custprdtxt.Text, Product_name = cusprdnametxt.Text;
                DateTime Date = DateTime.Parse(cusdatetxt.Text);
                SqlCommand cmd = new SqlCommand("sp_cusupdate'" + Customer_id + "','" + Customer_name + "','" + Customer_mob + "','" + Product + "','" + Product_name + "','" + Date + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update into Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Customer_id = int.Parse(cusidtxt.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_cusdelete'" + Customer_id + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnback_Click(object sender, EventArgs e)
        {
            cusidtxt.Clear();
            cusnametxt.Clear();
            cusmobtxt.Clear();
            custprdtxt.Clear();
            cusprdnametxt.Clear();
        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            fetchsales fetch = new fetchsales();
            fetch.Show();
            this.Hide();
        }
    }
}
