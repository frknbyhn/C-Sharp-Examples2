namespace yazilim_sinama_proje
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odalarıListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbaşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demirbaşListeleAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaToolStripMenuItem,
            this.demirbaşToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odaToolStripMenuItem
            // 
            this.odaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odalarıListeleToolStripMenuItem});
            this.odaToolStripMenuItem.Name = "odaToolStripMenuItem";
            this.odaToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.odaToolStripMenuItem.Text = "Oda";
            this.odaToolStripMenuItem.Click += new System.EventHandler(this.odaToolStripMenuItem_Click);
            // 
            // odalarıListeleToolStripMenuItem
            // 
            this.odalarıListeleToolStripMenuItem.Name = "odalarıListeleToolStripMenuItem";
            this.odalarıListeleToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.odalarıListeleToolStripMenuItem.Text = "Oda Listele - Ara";
            this.odalarıListeleToolStripMenuItem.Click += new System.EventHandler(this.odalarıListeleToolStripMenuItem_Click);
            // 
            // demirbaşToolStripMenuItem
            // 
            this.demirbaşToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.demirbaşListeleAraToolStripMenuItem});
            this.demirbaşToolStripMenuItem.Name = "demirbaşToolStripMenuItem";
            this.demirbaşToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.demirbaşToolStripMenuItem.Text = "Demirbaş";
            // 
            // demirbaşListeleAraToolStripMenuItem
            // 
            this.demirbaşListeleAraToolStripMenuItem.Name = "demirbaşListeleAraToolStripMenuItem";
            this.demirbaşListeleAraToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.demirbaşListeleAraToolStripMenuItem.Text = "Demirbaş Listele - Ara";
            this.demirbaşListeleAraToolStripMenuItem.Click += new System.EventHandler(this.demirbaşListeleAraToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.helpToolStripMenuItem.Text = "Yardım";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 562);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbaşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odalarıListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demirbaşListeleAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}