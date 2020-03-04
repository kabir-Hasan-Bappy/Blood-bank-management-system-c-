namespace LogIn
{
    partial class free_give
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dblood_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(491, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 234);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Blood type";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dblood_id,
            this.b_type,
            this.qty,
            this.expire_date});
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(473, 234);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Dblood_id
            // 
            this.Dblood_id.DataPropertyName = "Dblood_id";
            this.Dblood_id.HeaderText = "DBLOOD ID";
            this.Dblood_id.Name = "Dblood_id";
            // 
            // b_type
            // 
            this.b_type.DataPropertyName = "b_type";
            this.b_type.HeaderText = "BLOOD TYPE";
            this.b_type.Name = "b_type";
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "QUANTITY";
            this.qty.Name = "qty";
            // 
            // expire_date
            // 
            this.expire_date.DataPropertyName = "expire_date";
            this.expire_date.HeaderText = "EXPIRE DATE";
            this.expire_date.Name = "expire_date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FG ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CONTACT :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "NAME :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(405, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 37);
            this.label5.TabIndex = 13;
            this.label5.Text = "FREE GIVE";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // free_give
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 396);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "free_give";
            this.Load += new System.EventHandler(this.free_give_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dblood_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
    }
}