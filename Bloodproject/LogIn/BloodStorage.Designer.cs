namespace LogIn
{
    partial class BloodStorage
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_expire = new System.Windows.Forms.DateTimePicker();
            this.cmb_btype = new System.Windows.Forms.ComboBox();
            this.cmb_sid = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bid = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_bstorage = new System.Windows.Forms.DataGridView();
            this.blood_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bstorage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Expire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seller Id";
            // 
            // dtp_expire
            // 
            this.dtp_expire.Location = new System.Drawing.Point(134, 241);
            this.dtp_expire.Name = "dtp_expire";
            this.dtp_expire.Size = new System.Drawing.Size(205, 20);
            this.dtp_expire.TabIndex = 5;
            // 
            // cmb_btype
            // 
            this.cmb_btype.FormattingEnabled = true;
            this.cmb_btype.Location = new System.Drawing.Point(131, 129);
            this.cmb_btype.Name = "cmb_btype";
            this.cmb_btype.Size = new System.Drawing.Size(205, 21);
            this.cmb_btype.TabIndex = 6;
            this.cmb_btype.SelectedIndexChanged += new System.EventHandler(this.cmb_btype_SelectedIndexChanged);
            // 
            // cmb_sid
            // 
            this.cmb_sid.FormattingEnabled = true;
            this.cmb_sid.Location = new System.Drawing.Point(131, 280);
            this.cmb_sid.Name = "cmb_sid";
            this.cmb_sid.Size = new System.Drawing.Size(205, 21);
            this.cmb_sid.TabIndex = 7;
            this.cmb_sid.SelectedIndexChanged += new System.EventHandler(this.cmb_sid_SelectedIndexChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(408, 95);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 87);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blood Id";
            // 
            // txt_bid
            // 
            this.txt_bid.Location = new System.Drawing.Point(131, 92);
            this.txt_bid.Name = "txt_bid";
            this.txt_bid.Size = new System.Drawing.Size(205, 20);
            this.txt_bid.TabIndex = 10;
            this.txt_bid.TextChanged += new System.EventHandler(this.txt_bid_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantity";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Current Date";
            // 
            // dataGridView_bstorage
            // 
            this.dataGridView_bstorage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_bstorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bstorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blood_id,
            this.b_type,
            this.quantity,
            this.entry_date,
            this.expire_date,
            this.seller_id});
            this.dataGridView_bstorage.Location = new System.Drawing.Point(9, 307);
            this.dataGridView_bstorage.Name = "dataGridView_bstorage";
            this.dataGridView_bstorage.Size = new System.Drawing.Size(636, 162);
            this.dataGridView_bstorage.TabIndex = 15;
            this.dataGridView_bstorage.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // blood_id
            // 
            this.blood_id.DataPropertyName = "blood_id";
            this.blood_id.HeaderText = "BLOOD ID";
            this.blood_id.Name = "blood_id";
            // 
            // b_type
            // 
            this.b_type.DataPropertyName = "b_type";
            this.b_type.HeaderText = "BLOOD TYPE";
            this.b_type.Name = "b_type";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.Name = "quantity";
            // 
            // entry_date
            // 
            this.entry_date.DataPropertyName = "entry_date";
            this.entry_date.HeaderText = "CURRENT DATE";
            this.entry_date.Name = "entry_date";
            // 
            // expire_date
            // 
            this.expire_date.DataPropertyName = "expire_date";
            this.expire_date.HeaderText = "EXPIRE DATE";
            this.expire_date.Name = "expire_date";
            // 
            // seller_id
            // 
            this.seller_id.DataPropertyName = "seller_id";
            this.seller_id.HeaderText = "SELLER ID";
            this.seller_id.Name = "seller_id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(97, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(452, 55);
            this.label7.TabIndex = 16;
            this.label7.Text = "BLOOD STORAGE";
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Location = new System.Drawing.Point(408, 201);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(178, 81);
            this.del_btn.TabIndex = 17;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // BloodStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 481);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_bstorage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_bid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_sid);
            this.Controls.Add(this.cmb_btype);
            this.Controls.Add(this.dtp_expire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BloodStorage";
            this.Text = "Buying Information";
            this.Load += new System.EventHandler(this.BloodStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bstorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_expire;
        private System.Windows.Forms.ComboBox cmb_btype;
        private System.Windows.Forms.ComboBox cmb_sid;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_bstorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn blood_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn entry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn expire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button del_btn;
    }
}