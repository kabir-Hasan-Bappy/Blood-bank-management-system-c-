namespace LogIn
{
    partial class invoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoice));
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_invoice = new System.Windows.Forms.DataGridView();
            this.blood_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 592);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sell";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(495, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(102, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name :";
            // 
            // dataGridView_invoice
            // 
            this.dataGridView_invoice.AllowUserToAddRows = false;
            this.dataGridView_invoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_invoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blood_id,
            this.b_type,
            this.quantity,
            this.subtotal});
            this.dataGridView_invoice.Location = new System.Drawing.Point(35, 258);
            this.dataGridView_invoice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView_invoice.Name = "dataGridView_invoice";
            this.dataGridView_invoice.ReadOnly = true;
            this.dataGridView_invoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_invoice.Size = new System.Drawing.Size(565, 191);
            this.dataGridView_invoice.TabIndex = 4;
            this.dataGridView_invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(35, 592);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Amount :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(142, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(486, 54);
            this.label5.TabIndex = 11;
            this.label5.Text = "ULTRA BLOOD BANK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sector-10, Uttrar, Dhaka 1230";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(105, 42);
            this.panel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(595, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "................................................................................." +
    "..................................................................";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 555);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 15;
            this.label8.Text = "Recieved By";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 541);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "................................";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 555);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 14);
            this.label11.TabIndex = 18;
            this.label11.Text = "Authorized By";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(471, 537);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 14);
            this.label12.TabIndex = 19;
            this.label12.Text = "................................";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 573);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(595, 14);
            this.label10.TabIndex = 20;
            this.label10.Text = "................................................................................." +
    "..................................................................";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(420, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "DATE :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 23;
            this.label3.Text = "Invoice No :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(166, 170);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 14);
            this.label14.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(159, 215);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 14);
            this.label16.TabIndex = 26;
            this.label16.Text = "........................";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(159, 169);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 14);
            this.label15.TabIndex = 27;
            this.label15.Text = "........................";
            // 
            // invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 618);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_invoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBox = false;
            this.Name = "invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVOICE";
            this.Load += new System.EventHandler(this.invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_invoice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn blood_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}