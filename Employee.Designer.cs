namespace Happy_Mobile
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfetch = new System.Windows.Forms.Button();
            this.Empbtn = new System.Windows.Forms.Button();
            this.backempbtn = new System.Windows.Forms.Button();
            this.customerempbtn = new System.Windows.Forms.Button();
            this.Accessoriesempbtn = new System.Windows.Forms.Button();
            this.salesempbtn = new System.Windows.Forms.Button();
            this.Addempbtn = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.Btnupdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.embsalarytxt = new System.Windows.Forms.TextBox();
            this.embcitytxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.embmobtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpGridview = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.employeeDataSet = new Happy_Mobile.employeeDataSet();
            this.employeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnfetch);
            this.panel1.Controls.Add(this.Empbtn);
            this.panel1.Controls.Add(this.backempbtn);
            this.panel1.Controls.Add(this.customerempbtn);
            this.panel1.Controls.Add(this.Accessoriesempbtn);
            this.panel1.Controls.Add(this.salesempbtn);
            this.panel1.Controls.Add(this.Addempbtn);
            this.panel1.Location = new System.Drawing.Point(25, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 863);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.White;
            this.btnfetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.Location = new System.Drawing.Point(42, 621);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(175, 62);
            this.btnfetch.TabIndex = 18;
            this.btnfetch.Text = "Fetch Sales";
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.button1_Click);
            // 
            // Empbtn
            // 
            this.Empbtn.BackColor = System.Drawing.Color.White;
            this.Empbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empbtn.Location = new System.Drawing.Point(42, 503);
            this.Empbtn.Name = "Empbtn";
            this.Empbtn.Size = new System.Drawing.Size(175, 62);
            this.Empbtn.TabIndex = 17;
            this.Empbtn.Text = "Employee";
            this.Empbtn.UseVisualStyleBackColor = false;
            this.Empbtn.Click += new System.EventHandler(this.Empbtn_Click);
            // 
            // backempbtn
            // 
            this.backempbtn.BackColor = System.Drawing.Color.White;
            this.backempbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backempbtn.Location = new System.Drawing.Point(42, 750);
            this.backempbtn.Name = "backempbtn";
            this.backempbtn.Size = new System.Drawing.Size(175, 62);
            this.backempbtn.TabIndex = 16;
            this.backempbtn.Text = "Back";
            this.backempbtn.UseVisualStyleBackColor = false;
            this.backempbtn.Click += new System.EventHandler(this.backempbtn_Click);
            // 
            // customerempbtn
            // 
            this.customerempbtn.BackColor = System.Drawing.Color.White;
            this.customerempbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerempbtn.Location = new System.Drawing.Point(42, 253);
            this.customerempbtn.Name = "customerempbtn";
            this.customerempbtn.Size = new System.Drawing.Size(175, 70);
            this.customerempbtn.TabIndex = 15;
            this.customerempbtn.Text = "Customer";
            this.customerempbtn.UseVisualStyleBackColor = false;
            this.customerempbtn.Click += new System.EventHandler(this.customerempbtn_Click);
            // 
            // Accessoriesempbtn
            // 
            this.Accessoriesempbtn.BackColor = System.Drawing.Color.White;
            this.Accessoriesempbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accessoriesempbtn.Location = new System.Drawing.Point(42, 383);
            this.Accessoriesempbtn.Name = "Accessoriesempbtn";
            this.Accessoriesempbtn.Size = new System.Drawing.Size(175, 63);
            this.Accessoriesempbtn.TabIndex = 14;
            this.Accessoriesempbtn.Text = "Accessories";
            this.Accessoriesempbtn.UseVisualStyleBackColor = false;
            this.Accessoriesempbtn.Click += new System.EventHandler(this.Accessoriesempbtn_Click);
            // 
            // salesempbtn
            // 
            this.salesempbtn.BackColor = System.Drawing.Color.White;
            this.salesempbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesempbtn.Location = new System.Drawing.Point(42, 138);
            this.salesempbtn.Name = "salesempbtn";
            this.salesempbtn.Size = new System.Drawing.Size(175, 65);
            this.salesempbtn.TabIndex = 13;
            this.salesempbtn.Text = "Sales";
            this.salesempbtn.UseVisualStyleBackColor = false;
            this.salesempbtn.Click += new System.EventHandler(this.salesempbtn_Click);
            // 
            // Addempbtn
            // 
            this.Addempbtn.BackColor = System.Drawing.Color.White;
            this.Addempbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addempbtn.Location = new System.Drawing.Point(42, 30);
            this.Addempbtn.Name = "Addempbtn";
            this.Addempbtn.Size = new System.Drawing.Size(175, 63);
            this.Addempbtn.TabIndex = 12;
            this.Addempbtn.Text = "Add Mobile";
            this.Addempbtn.UseVisualStyleBackColor = false;
            this.Addempbtn.Click += new System.EventHandler(this.Addempbtn_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.White;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(1329, 376);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(147, 48);
            this.btnback.TabIndex = 50;
            this.btnback.Text = "Clear";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(1008, 376);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(147, 48);
            this.btndelete.TabIndex = 49;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Btnupdate
            // 
            this.Btnupdate.BackColor = System.Drawing.Color.White;
            this.Btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnupdate.Location = new System.Drawing.Point(657, 376);
            this.Btnupdate.Name = "Btnupdate";
            this.Btnupdate.Size = new System.Drawing.Size(147, 48);
            this.Btnupdate.TabIndex = 48;
            this.Btnupdate.Text = "Update";
            this.Btnupdate.UseVisualStyleBackColor = false;
            this.Btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(349, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 48);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(742, 462);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(293, 42);
            this.label8.TabIndex = 46;
            this.label8.Text = "Employee Details";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // embsalarytxt
            // 
            this.embsalarytxt.Location = new System.Drawing.Point(1231, 310);
            this.embsalarytxt.Name = "embsalarytxt";
            this.embsalarytxt.Size = new System.Drawing.Size(335, 26);
            this.embsalarytxt.TabIndex = 45;
            // 
            // embcitytxt
            // 
            this.embcitytxt.Location = new System.Drawing.Point(552, 310);
            this.embcitytxt.Name = "embcitytxt";
            this.embcitytxt.Size = new System.Drawing.Size(335, 26);
            this.embcitytxt.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(962, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 31);
            this.label6.TabIndex = 41;
            this.label6.Text = "Employee City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(962, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 31);
            this.label5.TabIndex = 40;
            this.label5.Text = "Employee Role";
            // 
            // embmobtxt
            // 
            this.embmobtxt.Location = new System.Drawing.Point(552, 252);
            this.embmobtxt.Name = "embmobtxt";
            this.embmobtxt.Size = new System.Drawing.Size(335, 26);
            this.embmobtxt.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 31);
            this.label4.TabIndex = 38;
            this.label4.Text = "Employee MOB";
            // 
            // empnametxt
            // 
            this.empnametxt.Location = new System.Drawing.Point(1231, 189);
            this.empnametxt.Name = "empnametxt";
            this.empnametxt.Size = new System.Drawing.Size(335, 26);
            this.empnametxt.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(962, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 31);
            this.label3.TabIndex = 36;
            this.label3.Text = "Employee Name";
            // 
            // empidtxt
            // 
            this.empidtxt.Location = new System.Drawing.Point(552, 190);
            this.empidtxt.Name = "empidtxt";
            this.empidtxt.Size = new System.Drawing.Size(335, 26);
            this.empidtxt.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Employee Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(320, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1221, 102);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(707, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 42);
            this.label1.TabIndex = 32;
            this.label1.Text = "Add Employee Details";
            // 
            // EmpGridview
            // 
            this.EmpGridview.BackgroundColor = System.Drawing.Color.White;
            this.EmpGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridview.Location = new System.Drawing.Point(406, 526);
            this.EmpGridview.Name = "EmpGridview";
            this.EmpGridview.RowHeadersWidth = 62;
            this.EmpGridview.RowTemplate.Height = 28;
            this.EmpGridview.Size = new System.Drawing.Size(1003, 272);
            this.EmpGridview.TabIndex = 51;
            this.EmpGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGridview_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Sales Man",
            "Service Man"});
            this.comboBox1.Location = new System.Drawing.Point(1231, 252);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 28);
            this.comboBox1.TabIndex = 52;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "employeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDataSetBindingSource
            // 
            this.employeeDataSetBindingSource.DataSource = this.employeeDataSet;
            this.employeeDataSetBindingSource.Position = 0;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1874, 1059);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EmpGridview);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.Btnupdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.embsalarytxt);
            this.Controls.Add(this.embcitytxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.embmobtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empnametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empidtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Empbtn;
        private System.Windows.Forms.Button backempbtn;
        private System.Windows.Forms.Button customerempbtn;
        private System.Windows.Forms.Button Accessoriesempbtn;
        private System.Windows.Forms.Button salesempbtn;
        private System.Windows.Forms.Button Addempbtn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button Btnupdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox embsalarytxt;
        private System.Windows.Forms.TextBox embcitytxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox embmobtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empidtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EmpGridview;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource employeeDataSetBindingSource;
        private employeeDataSet employeeDataSet;
        private System.Windows.Forms.Button btnfetch;
    }


}