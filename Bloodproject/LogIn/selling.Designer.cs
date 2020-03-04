namespace LogIn
{
    partial class selling
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
            this.dataGridView_sell = new System.Windows.Forms.DataGridView();
            this.blood_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_sell
            // 
            this.dataGridView_sell.AllowUserToAddRows = false;
            this.dataGridView_sell.AllowUserToDeleteRows = false;
            this.dataGridView_sell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blood_id,
            this.b_type,
            this.quantity,
            this.expire_date});
            this.dataGridView_sell.Location = new System.Drawing.Point(25, 92);
            this.dataGridView_sell.Name = "dataGridView_sell";
            this.dataGridView_sell.ReadOnly = true;
            this.dataGridView_sell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_sell.Size = new System.Drawing.Size(489, 250);
            this.dataGridView_sell.TabIndex = 2;
            this.dataGridView_sell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // blood_id
            // 
            this.blood_id.DataPropertyName = "blood_id";
            this.blood_id.HeaderText = "Blood ID";
            this.blood_id.Name = "blood_id";
            this.blood_id.ReadOnly = true;
            this.blood_id.Visible = false;
            // 
            // b_type
            // 
            this.b_type.DataPropertyName = "b_type";
            this.b_type.HeaderText = "Blood Type";
            this.b_type.Name = "b_type";
            this.b_type.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // expire_date
            // 
            this.expire_date.DataPropertyName = "expire_date";
            this.expire_date.HeaderText = "Expire Date";
            this.expire_date.Name = "expire_date";
            this.expire_date.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(474, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 250);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Blood Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Name :";
            // 
            // selling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(674, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView_sell);
            this.Name = "selling";
            this.Text = "selling";
            this.Load += new System.EventHandler(this.selling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_sell;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn blood_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}