namespace Project_Angkringan.Angkringan
{
    partial class Menu_Utama
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pemesanan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_stok = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.loginToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_pemesanan,
            this.submenu_stok});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(60, 20);
            this.menu.Text = "&Aplikasi";
            // 
            // submenu_pemesanan
            // 
            this.submenu_pemesanan.Name = "submenu_pemesanan";
            this.submenu_pemesanan.Size = new System.Drawing.Size(180, 22);
            this.submenu_pemesanan.Text = "&Pemesanan";
            this.submenu_pemesanan.Click += new System.EventHandler(this.submenu_pemesanan_Click);
            // 
            // submenu_stok
            // 
            this.submenu_stok.Name = "submenu_stok";
            this.submenu_stok.Size = new System.Drawing.Size(180, 22);
            this.submenu_stok.Text = "Stok";
            this.submenu_stok.Click += new System.EventHandler(this.submenu_stok_Click);
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 523);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu_Utama";
            this.Text = "Menu Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private MenuStrip menuStrip;
        public ToolStripMenuItem menu;
        public ToolStripMenuItem submenu_pemesanan;
        public ToolStripMenuItem submenu_stok;
        private ToolStripMenuItem loginToolStripMenuItem;
    }
}



