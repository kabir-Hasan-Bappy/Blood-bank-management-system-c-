namespace LogIn
{
    partial class Main_Page
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBuyerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dONORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorBloodStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeGiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.bUYToolStripMenuItem,
            this.sELLToolStripMenuItem,
            this.dONORToolStripMenuItem,
            this.rEPORTToolStripMenuItem,
            this.lOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.aboutToolStripMenuItem.Text = "ABOUT";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
            this.adminToolStripMenuItem.Text = "ADMIN";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // bUYToolStripMenuItem
            // 
            this.bUYToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBuyerToolStripMenuItem,
            this.buyingInformationToolStripMenuItem});
            this.bUYToolStripMenuItem.Name = "bUYToolStripMenuItem";
            this.bUYToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.bUYToolStripMenuItem.Text = "BUY";
            this.bUYToolStripMenuItem.Click += new System.EventHandler(this.bUYToolStripMenuItem_Click);
            // 
            // addBuyerToolStripMenuItem
            // 
            this.addBuyerToolStripMenuItem.Name = "addBuyerToolStripMenuItem";
            this.addBuyerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addBuyerToolStripMenuItem.Text = "Add Seller";
            this.addBuyerToolStripMenuItem.Click += new System.EventHandler(this.addBuyerToolStripMenuItem_Click);
            // 
            // buyingInformationToolStripMenuItem
            // 
            this.buyingInformationToolStripMenuItem.Name = "buyingInformationToolStripMenuItem";
            this.buyingInformationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buyingInformationToolStripMenuItem.Text = "Buying Information";
            this.buyingInformationToolStripMenuItem.Click += new System.EventHandler(this.buyingInformationToolStripMenuItem_Click);
            // 
            // sELLToolStripMenuItem
            // 
            this.sELLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.sellingInformationToolStripMenuItem});
            this.sELLToolStripMenuItem.Name = "sELLToolStripMenuItem";
            this.sELLToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.sELLToolStripMenuItem.Text = "SELL";
            this.sELLToolStripMenuItem.Click += new System.EventHandler(this.sELLToolStripMenuItem_Click);
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // sellingInformationToolStripMenuItem
            // 
            this.sellingInformationToolStripMenuItem.Name = "sellingInformationToolStripMenuItem";
            this.sellingInformationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.sellingInformationToolStripMenuItem.Text = "Selling Information";
            this.sellingInformationToolStripMenuItem.Click += new System.EventHandler(this.sellingInformationToolStripMenuItem_Click);
            // 
            // dONORToolStripMenuItem
            // 
            this.dONORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonorToolStripMenuItem,
            this.donorBloodStorageToolStripMenuItem,
            this.freeGiveToolStripMenuItem});
            this.dONORToolStripMenuItem.Name = "dONORToolStripMenuItem";
            this.dONORToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.dONORToolStripMenuItem.Text = "DONOR";
            this.dONORToolStripMenuItem.Click += new System.EventHandler(this.dONORToolStripMenuItem_Click);
            // 
            // addDonorToolStripMenuItem
            // 
            this.addDonorToolStripMenuItem.Name = "addDonorToolStripMenuItem";
            this.addDonorToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.addDonorToolStripMenuItem.Text = "Add Donor";
            this.addDonorToolStripMenuItem.Click += new System.EventHandler(this.addDonorToolStripMenuItem_Click);
            // 
            // donorBloodStorageToolStripMenuItem
            // 
            this.donorBloodStorageToolStripMenuItem.Name = "donorBloodStorageToolStripMenuItem";
            this.donorBloodStorageToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.donorBloodStorageToolStripMenuItem.Text = "Donor_Blood_Storage";
            this.donorBloodStorageToolStripMenuItem.Click += new System.EventHandler(this.donorBloodStorageToolStripMenuItem_Click);
            // 
            // freeGiveToolStripMenuItem
            // 
            this.freeGiveToolStripMenuItem.Name = "freeGiveToolStripMenuItem";
            this.freeGiveToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.freeGiveToolStripMenuItem.Text = "Free Give";
            this.freeGiveToolStripMenuItem.Click += new System.EventHandler(this.freeGiveToolStripMenuItem_Click);
            // 
            // rEPORTToolStripMenuItem
            // 
            this.rEPORTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellingReportToolStripMenuItem});
            this.rEPORTToolStripMenuItem.Name = "rEPORTToolStripMenuItem";
            this.rEPORTToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.rEPORTToolStripMenuItem.Text = "REPORT";
            // 
            // sellingReportToolStripMenuItem
            // 
            this.sellingReportToolStripMenuItem.Name = "sellingReportToolStripMenuItem";
            this.sellingReportToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.sellingReportToolStripMenuItem.Text = "Selling Report";
            this.sellingReportToolStripMenuItem.Click += new System.EventHandler(this.sellingReportToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.lOGOUTToolStripMenuItem.Text = "LOG  OUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(831, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(285, 573);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(870, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "ULTRA BLOOD BANK";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(335, 668);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(774, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tears of Mother cannot save her child.  But your BLOOD  can......!!";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1062, 405);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Page";
            this.Text = "MAIN  PAGE";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dONORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBuyerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorBloodStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeGiveToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem rEPORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingReportToolStripMenuItem;
    }
}