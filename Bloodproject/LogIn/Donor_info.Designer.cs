namespace LogIn
{
    partial class Donor_info
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_donor = new System.Windows.Forms.DataGridView();
            this.donor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_donate_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_donor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(585, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "CLEAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "DONOR ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAME :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ADRESS :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CONTACT :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "LAST DONATING DATE";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(186, 163);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 21);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(295, 20);
            this.textBox6.TabIndex = 19;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(443, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "SEARCH";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(237, 20);
            this.textBox4.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(186, 282);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(237, 20);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "CURRENT DATE";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView_donor
            // 
            this.dataGridView_donor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_donor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_donor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.donor_id,
            this.name,
            this.adress,
            this.contact,
            this.entry_date,
            this.last_donate_date});
            this.dataGridView_donor.Location = new System.Drawing.Point(12, 347);
            this.dataGridView_donor.Name = "dataGridView_donor";
            this.dataGridView_donor.Size = new System.Drawing.Size(757, 184);
            this.dataGridView_donor.TabIndex = 25;
            this.dataGridView_donor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_donor_CellContentClick);
            // 
            // donor_id
            // 
            this.donor_id.DataPropertyName = "donor_id";
            this.donor_id.HeaderText = "DONOR ID";
            this.donor_id.Name = "donor_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adress";
            this.adress.HeaderText = "ADDRESS";
            this.adress.Name = "adress";
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "CONTACT";
            this.contact.Name = "contact";
            // 
            // entry_date
            // 
            this.entry_date.DataPropertyName = "entry_date";
            this.entry_date.HeaderText = "CURRENT DATE";
            this.entry_date.Name = "entry_date";
            // 
            // last_donate_date
            // 
            this.last_donate_date.DataPropertyName = "last_donate_date";
            this.last_donate_date.HeaderText = "LAST DONATING DATE";
            this.last_donate_date.Name = "last_donate_date";
            // 
            // Donor_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 534);
            this.Controls.Add(this.dataGridView_donor);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Donor_info";
            this.Text = "Donor_info";
            this.Load += new System.EventHandler(this.Donor_info_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_donor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_donor;
        private System.Windows.Forms.DataGridViewTextBoxColumn donor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_donate_date;
    }
}