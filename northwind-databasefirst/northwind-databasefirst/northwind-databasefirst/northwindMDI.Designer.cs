namespace northwind_databasefirst
{
    partial class northwindMDI
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.musteriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.urunMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriMenu,
            this.calisanMenu,
            this.urunMenu,
            this.siparisMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1278, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // musteriMenu
            // 
            this.musteriMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriToolStripMenuItem});
            this.musteriMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.musteriMenu.Name = "musteriMenu";
            this.musteriMenu.Size = new System.Drawing.Size(72, 20);
            this.musteriMenu.Text = "Müşteriler";
            // 
            // calisanMenu
            // 
            this.calisanMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calisanToolStripMenuItem});
            this.calisanMenu.Name = "calisanMenu";
            this.calisanMenu.Size = new System.Drawing.Size(70, 20);
            this.calisanMenu.Text = "Çalışanlar";
            // 
            // urunMenu
            // 
            this.urunMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunToolStripMenuItem});
            this.urunMenu.Name = "urunMenu";
            this.urunMenu.Size = new System.Drawing.Size(58, 20);
            this.urunMenu.Text = "Ürünler";
            // 
            // siparisMenu
            // 
            this.siparisMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparisToolStripMenuItem});
            this.siparisMenu.Name = "siparisMenu";
            this.siparisMenu.Size = new System.Drawing.Size(66, 20);
            this.siparisMenu.Text = "Siparişler";
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.musteriToolStripMenuItem.Text = "Müşteri";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // calisanToolStripMenuItem
            // 
            this.calisanToolStripMenuItem.Name = "calisanToolStripMenuItem";
            this.calisanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calisanToolStripMenuItem.Text = "Çalışan";
            this.calisanToolStripMenuItem.Click += new System.EventHandler(this.calisanToolStripMenuItem_Click);
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunToolStripMenuItem.Text = "Ürün";
            this.urunToolStripMenuItem.Click += new System.EventHandler(this.urunToolStripMenuItem_Click);
            // 
            // siparisToolStripMenuItem
            // 
            this.siparisToolStripMenuItem.Name = "siparisToolStripMenuItem";
            this.siparisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siparisToolStripMenuItem.Text = "Sipariş";
            this.siparisToolStripMenuItem.Click += new System.EventHandler(this.siparisToolStripMenuItem_Click);
            // 
            // northwindMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "northwindMDI";
            this.Text = "NORTHWIND";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem musteriMenu;
        private System.Windows.Forms.ToolStripMenuItem calisanMenu;
        private System.Windows.Forms.ToolStripMenuItem urunMenu;
        private System.Windows.Forms.ToolStripMenuItem siparisMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisToolStripMenuItem;
    }
}



