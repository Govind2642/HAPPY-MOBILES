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
    public partial class fetchsales : Form
    {
        public fetchsales()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog= Mobile;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnfetch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(" sp_saleview", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_search", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param1 = new SqlParameter("@Customer_name ", SqlDbType.VarChar);
            cmd.Parameters.Add(param1).Value = txtbill.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
