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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=Mobile;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Register",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@User_id", SqlDbType.VarChar);
                cmd.Parameters.Add(param1).Value =RegUstxt.Text;
                SqlParameter param2 = new SqlParameter("@Name", SqlDbType.VarChar);
                cmd.Parameters.Add(param2).Value =RegNametxt.Text;
                SqlParameter param3 = new SqlParameter("@Gmail", SqlDbType.VarChar);
                cmd.Parameters.Add(param3).Value =Reggmailtxt.Text;
                SqlParameter param4 = new SqlParameter("@Password", SqlDbType.VarChar);
                cmd.Parameters.Add(param4).Value =RegPwdtxt.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registered successfully");
                else
                    MessageBox.Show("Registration Failed");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
