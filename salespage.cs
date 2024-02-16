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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Happy_Mobile
{
    public partial class salespage : Form
    {
        public salespage()
        {
            InitializeComponent();
        }

        private void Addmobbtn_Click(object sender, EventArgs e)
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

        private void customersalesbtn_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Hide();
        }

        private void Accessoriessalesbtn_Click(object sender, EventArgs e)
        {
            Accessories Acc = new Accessories();
            Acc.Show();
            this.Hide();
        }

        private void Empsalesbtn_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            Emp.Show();
            Getview();

            this.Hide();
        }

        private void backsalesbtn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void salespage_Load(object sender, EventArgs e)
        {
            Getview();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=Mobile;Integrated Security=True");
        private void qunttxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (qunttxt.Text.Length > 0)
                {
                    totaltxt.Text = (Convert.ToInt16(Pricetxt.Text) * Convert.ToInt16(qunttxt.Text)).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void combotxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Distxt_TextChanged(object sender, EventArgs e)
        {
            Nettext.Text = (Convert.ToInt32(totaltxt.Text) - Convert.ToInt32(Distxt.Text)).ToString();
        }

        private void Gridaddbtn_Click(object sender, EventArgs e)
        {

            
                conn.Open();
                int Bill_no = int.Parse(Billtxt.Text);
                int Price = int.Parse(Pricetxt.Text);
                int Qunatity = int.Parse(qunttxt.Text);
                int Discount = int.Parse(Distxt.Text);
                int Net_total = int.Parse(Nettext.Text);
                string Customer_name = custnatxt.Text, Customer_mob= cusmobtxt.Text,Product_name = combotxt.Text, Model = Modeltxt.Text, Emp_id =comempid.Text;
                SqlCommand cmd = new SqlCommand("sp_salesadd '" + Bill_no + "','" + Customer_name + "','" + Customer_mob + "','" + Product_name + "','" + Model + "','" + Price + "','" + Qunatity+ "','" + Discount + "','" + Net_total + "','" + Emp_id + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insert into Successfully");
                Getview();
                conn.Close();
            
          
        }
       
        
        void Getview()
        {
            SqlCommand cmd = new SqlCommand(" sp_views", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Modeltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap (dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                e.Graphics.DrawImage(imagebmp ,0, 50);
        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
            int Bill_no = int.Parse(Billtxt.Text);
            int Price = int.Parse(Pricetxt.Text);
                int Qunatity = int.Parse(qunttxt.Text);
                int Discount = int.Parse(Distxt.Text);
            int Net_total = int.Parse(Nettext.Text);
          
            string Customer_name = custnatxt.Text, Customer_mob = cusmobtxt.Text, Product_name = combotxt.Text, Model = Modeltxt.Text, Emp_id = comempid.Text;
            SqlCommand cmd = new SqlCommand("exec sp_salesadd '" + Bill_no + "','" + Customer_name + "','" + Customer_mob + "','" + Product_name + "','" + Model + "','" + Price + "','" + Qunatity + "','" + Discount + "','" + Net_total + "','" + Emp_id + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Successfully");
            Getview();

       

            }
            catch (Exception )
            {
                MessageBox.Show("not insert values");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            Billtxt.Clear();
            custnatxt.Clear();
            cusmobtxt.Clear();
            combotxt .Items.Clear();
            Modeltxt.Clear();
            Pricetxt.Clear();
            qunttxt.Clear();
            totaltxt.Clear();
            Distxt.Clear();
            Nettext.Clear();
            comempid.Items.Clear();


        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            fetchsales fetch = new fetchsales();
            fetch.Show();
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void comempid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

 