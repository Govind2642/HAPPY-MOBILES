namespace Happy_Mobile
{
    partial class fetchsales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnfetch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbill = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fetch Sales Details";
            // 
            // btnfetch
            // 
            this.btnfetch.BackColor = System.Drawing.Color.White;
            this.btnfetch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfetch.Location = new System.Drawing.Point(800, 149);
            this.btnfetch.Name = "btnfetch";
            this.btnfetch.Size = new System.Drawing.Size(175, 62);
            this.btnfetch.TabIndex = 4;
            this.btnfetch.Text = "Fetch";
            this.btnfetch.UseVisualStyleBackColor = false;
            this.btnfetch.Click += new System.EventHandler(this.btnfetch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Name";
            // 
            // txtbill
            // 
            this.txtbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbill.Location = new System.Drawing.Point(301, 166);
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(181, 30);
            this.txtbill.TabIndex = 6;
            this.txtbill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.White;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(1079, 150);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(175, 62);
            this.Backbtn.TabIndex = 7;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(539, 150);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(175, 62);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1568, 657);
            this.dataGridView1.TabIndex = 9;
            // 
            // fetchsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1780, 1050);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.txtbill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnfetch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fetchsales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "fetchsales";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnfetch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}