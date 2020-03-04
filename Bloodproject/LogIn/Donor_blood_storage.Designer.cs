namespace LogIn
{
    partial class Donor_blood_storage
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_dstrg = new System.Windows.Forms.DataGridView();
            this.Dblood_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donor_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dstrg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DONATING BLOOD STORAGE INFORMATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "BLOOD TYPE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "EXPIRE DATE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DONOR ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(394, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(394, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 291);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(743, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "QUANTITY";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(394, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DONATING BLOOD ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(743, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(743, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 39);
            this.button5.TabIndex = 20;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "CURRENT DATE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView_dstrg
            // 
            this.dataGridView_dstrg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dstrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dstrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dblood_id,
            this.donor_id,
            this.b_type,
            this.qty,
            this.entry_date,
            this.expire_date});
            this.dataGridView_dstrg.Location = new System.Drawing.Point(28, 342);
            this.dataGridView_dstrg.Name = "dataGridView_dstrg";
            this.dataGridView_dstrg.Size = new System.Drawing.Size(807, 207);
            this.dataGridView_dstrg.TabIndex = 23;
            // 
            // Dblood_id
            // 
            this.Dblood_id.DataPropertyName = "Dblood_id";
            this.Dblood_id.HeaderText = "Donating Blood ID";
            this.Dblood_id.Name = "Dblood_id";
            // 
            // donor_id
            // 
            this.donor_id.DataPropertyName = "donor_id";
            this.donor_id.HeaderText = "Donor ID";
            this.donor_id.Name = "donor_id";
            // 
            // b_type
            // 
            this.b_type.DataPropertyName = "b_type";
            this.b_type.HeaderText = "Blood type";
            this.b_type.Name = "b_type";
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // entry_date
            // 
            this.entry_date.DataPropertyName = "entry_date";
            this.entry_date.HeaderText = "Current Date";
            this.entry_date.Name = "entry_date";
            // 
            // expire_date
            // 
            this.expire_date.DataPropertyName = "expire_date";
            this.expire_date.HeaderText = "Expire Date";
            this.expire_date.Name = "expire_date";
            // 
            // Donor_blood_storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(854, 539);
            this.Controls.Add(this.dataGridView_dstrg);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Donor_blood_storage";
            this.Text = "Donor_blood_storage";
            this.Load += new System.EventHandler(this.Donor_blood_storage_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dstrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_dstrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dblood_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn donor_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_date;
    }
}