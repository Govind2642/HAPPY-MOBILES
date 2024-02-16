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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=Mobile;Integrated Security=True ");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand(("select*from tbl_user where Name='" + login_txt.Text + "' " + "and Password ='" + pwd_txt.Text + "'"), conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                int a = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                if (a > 0)
                {
                    MessageBox.Show("Welcome To Happy Mobiles");
                    Homepage home = new Homepage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("InVald User");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Reg = new Register();
            Reg.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            login_txt.Clear();
            pwd_txt.Clear();
        }
    }

    //private void clearbtn_Click(object sender, EventArgs e)        
    //{
    //    DataTableClearEventArgs 
    //    login_txt.clear();


    //     }
    }

