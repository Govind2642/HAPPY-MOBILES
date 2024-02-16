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
    public partial class Accessories : Form
    {
        public Accessories()
        {
            InitializeComponent();
        }

        private void Accessories_Load(object sender, EventArgs e)
        {
            Getview();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addmobile mobile = new Addmobile();
            mobile.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salespage sales = new salespage();
            sales.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Accessories Acc = new Accessories();
            Acc.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee();
            Emp.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog= Mobile;Integrated Security=True");
        private void Accsavebtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int id = int.Parse(Aidtxt.Text);
                int Price = int.Parse(Apricetxt.Text);
                int Qunatity = int.Parse(Aquntxt.Text);
                string Brand = Abrandtxt.Text, Model = Amodeltxt.Text, Product = Aprttxt.Text;
                SqlCommand cmd = new SqlCommand("sp_accinsert'" + id + "','" + Brand + "','" + Model + "','" + Product + "','" + Price + "','" + Qunatity + "'", conn);
                cmd.ExecuteNonQuery();
                Getview();
                MessageBox.Show("Insert Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            void Getview()
        {
            SqlCommand cmd = new SqlCommand("sp_accview", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int id = int.Parse(Aidtxt.Text);
                int Price = int.Parse(Apricetxt.Text);
                int Qunatity = int.Parse(Aquntxt.Text);
                string Brand = Abrandtxt.Text, Model = Amodeltxt.Text, Product = Aprttxt.Text;
                SqlCommand cmd = new SqlCommand("sp_accupdate'" + id + "','" + Brand + "','" + Model + "','" + Product + "','" + Price + "','" + Qunatity + "'", conn);
                cmd.ExecuteNonQuery();
                Getview();
                MessageBox.Show("Update Successfully");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(Aidtxt.Text);
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_accdelete'" + id + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete successfully");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnclear_Click(object sender, EventArgs e)
        {
            Aidtxt.Clear();
            Apricetxt.Clear();
            Aquntxt.Clear();
            Abrandtxt.Clear();
            Amodeltxt.Clear();
            Aprttxt.Clear();



        }

        private void btnfetch_Click(object sender, EventArgs e)
        {

            fetchsales fetch = new fetchsales();
            fetch.Show();
            this.Hide();
        }
    }
    }
    

