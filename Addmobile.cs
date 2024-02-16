using Happy_Mobile;
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
    public partial class Addmobile : Form
    {
        public Addmobile()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog= Mobile;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Addmobile_Load(object sender, EventArgs e)
        {
            Getaddmobile();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try { 
            int Mobile_id = int.Parse(mobidtxt.Text);
            string Mob_Name = monametxt.Text, Model = mobemodtxt.Text, Ram = mobcomram.Text, Rom = mobcomrom.Text, Battery = mobatcomb.Text, Processor = pretext.Text, Price = pricemobtxt.Text, Qunatity = quantxt.Text;
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_Addmobileupdate'" + Mobile_id + "', '" + Mob_Name + "','" + Model + "','" + Ram + "', '" + Rom + "','" + Battery + "','" + Processor + "','" + Price + "','" + Qunatity + "'", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update into successfully");
            Getaddmobile();
            conn.Close();

        }
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

    private void button1_Click(object sender, EventArgs e)
        {
            Addmobile mobile = new Addmobile();
            mobile.Show();
            this.Hide();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            salespage sales = new salespage();
            sales.Show();
            this.Hide();
        }

        private void Accebtn_Click(object sender, EventArgs e)
        {
            Accessories Acc = new Accessories();
            Acc.Show();
            this.Hide();
        }

        private void Empbtn_Click(object sender, EventArgs e)
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
       
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int Mobile_id = int.Parse(mobidtxt.Text);
                string Mob_Name = monametxt.Text, Model = mobemodtxt.Text, Ram = mobcomram.Text, Rom = mobcomrom.Text, Battery = mobatcomb.Text, Processor = pretext.Text, Price = pricemobtxt.Text, Qunatity = quantxt.Text;
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_Addinsert'" + Mobile_id + "', '" + Mob_Name + "','" + Model + "','" + Ram + "', '" + Rom + "','" + Battery + "','" + Processor + "','" + Price + "','" + Qunatity + "'",conn);
                cmd.ExecuteNonQuery();
                 MessageBox.Show("Insert into successfully");
                Getaddmobile();
                conn.Close();
            
                //SqlCommand cmd = new SqlCommand("sp_Addmobile_insert1", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter param1 = new SqlParameter("@Mobile_id", SqlDbType.Int);
                //cmd.Parameters.Add(param1).Value = mobidtxt.Text;
                //SqlParameter param2 = new SqlParameter("@Mob_Name", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param2).Value = monametxt.Text;
                //SqlParameter param3 = new SqlParameter("@Model", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param3).Value = mobemodtxt.Text;
                //SqlParameter param4 = new SqlParameter("@Ram", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param4).Value = mobcomram.Text;
                //SqlParameter param5 = new SqlParameter("@Rom", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param5).Value = mobcomrom.Text;
                //SqlParameter param6 = new SqlParameter("@Battery", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param6).Value = mobatcomb.Text;
                //SqlParameter param7 = new SqlParameter("@processor", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param7).Value = pretext.Text;
                //SqlParameter param8 = new SqlParameter("@Price", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param8).Value = pricemobtxt.Text;
                //SqlParameter param9 = new SqlParameter("@Qunatity", SqlDbType.NVarChar);
                //cmd.Parameters.Add(param9).Value = quantxt.Text;
                //int i = cmd.ExecuteNonQuery();
                //if (i > 0)
                //    MessageBox.Show("Data inserted successfully");
                //else
                //    MessageBox.Show("Data cannot be inserted");
                //conn.Close();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            //Getaddmobile();





        }
        void Getaddmobile()
        {
            SqlCommand cmd = new SqlCommand("sp_Addview", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Mobile_id = int.Parse(mobidtxt.Text);
                conn.Open();
                SqlCommand c = new SqlCommand("sp_Addmobiledelete'" + Mobile_id + "'", conn);
                c.ExecuteNonQuery();
                MessageBox.Show("successfully delete");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnclear_Click(object sender, EventArgs e)
        {
            mobidtxt.Clear();
            monametxt.Clear();
            mobemodtxt.Clear();
            mobcomram.Items.Clear();
            mobcomrom.Items.Clear();
            mobatcomb.Items.Clear();
            pretext.Clear();
            pricemobtxt.Clear();
            quantxt.Clear();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchsales fetch = new fetchsales();
            fetch.Show();
            this.Hide();
        }
    }
 }