namespace yazilim_sinama_proje
{
    partial class oda_listele
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
            this.GridOdalar = new System.Windows.Forms.DataGridView();
            this.ListBtn = new System.Windows.Forms.Button();
            this.AraBtn = new System.Windows.Forms.Button();
            this.Oda_adiTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridOdalar)).BeginInit();
            this.SuspendLayout();
            // 
            // GridOdalar
            // 
            this.GridOdalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOdalar.Location = new System.Drawing.Point(12, 46);
            this.GridOdalar.Name = "GridOdalar";
            this.GridOdalar.Size = new System.Drawing.Size(499, 334);
            this.GridOdalar.TabIndex = 10;
            // 
            // ListBtn
            // 
            this.ListBtn.Location = new System.Drawing.Point(305, 9);
            this.ListBtn.Name = "ListBtn";
            this.ListBtn.Size = new System.Drawing.Size(206, 23);
            this.ListBtn.TabIndex = 9;
            this.ListBtn.Text = "Yeniden Listele";
            this.ListBtn.UseVisualStyleBackColor = true;
            // 
            // AraBtn
            // 
            this.AraBtn.Location = new System.Drawing.Point(175, 9);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(75, 23);
            this.AraBtn.TabIndex = 8;
            this.AraBtn.Text = "ARA";
            this.AraBtn.UseVisualStyleBackColor = true;
            // 
            // Oda_adiTxt
            // 
            this.Oda_adiTxt.Location = new System.Drawing.Point(69, 11);
            this.Oda_adiTxt.Name = "Oda_adiTxt";
            this.Oda_adiTxt.Size = new System.Drawing.Size(100, 20);
            this.Oda_adiTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oda Adı:";
            // 
            // oda_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 387);
            this.Controls.Add(this.GridOdalar);
            this.Controls.Add(this.ListBtn);
            this.Controls.Add(this.AraBtn);
            this.Controls.Add(this.Oda_adiTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oda_listele";
            this.Text = "OdaListele";
            this.Load += new System.EventHandler(this.OdaListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridOdalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridOdalar;
        private System.Windows.Forms.Button ListBtn;
        private System.Windows.Forms.Button AraBtn;
        private System.Windows.Forms.TextBox Oda_adiTxt;
        private System.Windows.Forms.Label label1;
    }
}