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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        
        private void Addempbtn_Click(object sender, EventArgs e)
        {
            Addmobile mobile = new Addmobile();
            mobile.Show();
            this.Hide();
        }

        private void salesempbtn_Click(object sender, EventArgs e)
        {
            salespage sales = new salespage();
            sales.Show();
            this.Hide();
        }

        private void customerempbtn_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Hide();
        }

        private void Accessoriesempbtn_Click(object sender, EventArgs e)
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

        private void backempbtn_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage();
            home.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            empidtxt.Clear();
            embsalarytxt.Clear();
            empnametxt.Clear();
            embmobtxt.Clear();
            comboBox1.Items.Clear();
            embcitytxt.Clear();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=Mobile;Integrated Security=True");
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                int Emp_Id = int.Parse(empidtxt.Text);
                int Emp_salary = int.Parse(embsalarytxt.Text);
                string Emp_Name = empnametxt.Text, Emp_Mob = embmobtxt.Text, Emp_Role = comboBox1.Text, Emp_City = embcitytxt.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("exec sp_employeeinsert'" + Emp_Id + "','" + Emp_Name + "','" + Emp_Mob + "','" + Emp_Role + "','" + Emp_City + "','" + Emp_salary + "'", con);
                cmd.ExecuteNonQuery();
                GetEmpList();
                MessageBox.Show("successfully inserted");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            void GetEmpList()

        {
            SqlCommand cmd = new SqlCommand("exec sp_viewemp", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            EmpGridview.DataSource = dt;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            GetEmpList();

        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Emp_Id = int.Parse(empidtxt.Text);
                int Emp_salary = int.Parse(embsalarytxt.Text);
                string Emp_Name = empnametxt.Text, Emp_Mob = embmobtxt.Text, Emp_Role = comboBox1.Text, Emp_City = embcitytxt.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_empupdate'" + Emp_Id + "','" + Emp_Name + "','" + Emp_Mob + "','" + Emp_Role + "','" + Emp_City + "','" + Emp_salary + "'", con);
                cmd.ExecuteNonQuery();
                GetEmpList();
                MessageBox.Show("successfully inserted");
                con.Close();

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
                int Emp_Id = int.Parse(empidtxt.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand(" sp_delete '" + Emp_Id + "'", con);
                cmd.ExecuteNonQuery();
                GetEmpList();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fetchsales fetch = new fetchsales();
            fetch.Show();
            this.Hide();
        }

        private void EmpGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
