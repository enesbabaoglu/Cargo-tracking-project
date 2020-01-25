namespace KargoTakip
{
    partial class FrmAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kargoGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kargoTakipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiyatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kargoGönderToolStripMenuItem,
            this.kargoTakipToolStripMenuItem,
            this.fiyatToolStripMenuItem,
            this.adminGirişiToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kargoGönderToolStripMenuItem
            // 
            this.kargoGönderToolStripMenuItem.Name = "kargoGönderToolStripMenuItem";
            this.kargoGönderToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.kargoGönderToolStripMenuItem.Text = "Kargo Gönder";
            this.kargoGönderToolStripMenuItem.Click += new System.EventHandler(this.kargoGönderToolStripMenuItem_Click);
            // 
            // kargoTakipToolStripMenuItem
            // 
            this.kargoTakipToolStripMenuItem.Name = "kargoTakipToolStripMenuItem";
            this.kargoTakipToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.kargoTakipToolStripMenuItem.Text = "Kargo Takip";
            this.kargoTakipToolStripMenuItem.Click += new System.EventHandler(this.kargoTakipToolStripMenuItem_Click);
            // 
            // fiyatToolStripMenuItem
            // 
            this.fiyatToolStripMenuItem.Name = "fiyatToolStripMenuItem";
            this.fiyatToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.fiyatToolStripMenuItem.Text = "Fiyat Hesapla";
            this.fiyatToolStripMenuItem.Click += new System.EventHandler(this.fiyatToolStripMenuItem_Click);
            // 
            // adminGirişiToolStripMenuItem
            // 
            this.adminGirişiToolStripMenuItem.Name = "adminGirişiToolStripMenuItem";
            this.adminGirişiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.adminGirişiToolStripMenuItem.Text = "Admin Girişi";
            this.adminGirişiToolStripMenuItem.Click += new System.EventHandler(this.adminGirişiToolStripMenuItem_Click);
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 544);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaMenu";
            this.Text = "KARGO İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kargoGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kargoTakipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiyatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminGirişiToolStripMenuItem;
    }
}

