using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Mobile
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addmobile mobile = new Addmobile();
            mobile.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salespage sales = new salespage();
             sales.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fetchsales fetch = new fetchsales();
            fetch.Show();
            this.Hide();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void Accessoriesbtn_Click(object sender, EventArgs e)
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
    }
}
