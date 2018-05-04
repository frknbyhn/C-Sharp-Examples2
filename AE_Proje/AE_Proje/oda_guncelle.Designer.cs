namespace yazilim_sinama_proje
{
    partial class oda_guncelle
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
            this.GuncelBtn = new System.Windows.Forms.Button();
            this.ComboSorumlu = new System.Windows.Forms.ComboBox();
            this.ComboDep = new System.Windows.Forms.ComboBox();
            this.ComboFakulte = new System.Windows.Forms.ComboBox();
            this.Oda_adiTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuncelBtn
            // 
            this.GuncelBtn.Location = new System.Drawing.Point(94, 182);
            this.GuncelBtn.Name = "GuncelBtn";
            this.GuncelBtn.Size = new System.Drawing.Size(121, 28);
            this.GuncelBtn.TabIndex = 17;
            this.GuncelBtn.Text = "GÜNCELLE";
            this.GuncelBtn.UseVisualStyleBackColor = true;
            // 
            // ComboSorumlu
            // 
            this.ComboSorumlu.FormattingEnabled = true;
            this.ComboSorumlu.Location = new System.Drawing.Point(94, 141);
            this.ComboSorumlu.Name = "ComboSorumlu";
            this.ComboSorumlu.Size = new System.Drawing.Size(121, 21);
            this.ComboSorumlu.TabIndex = 16;
            // 
            // ComboDep
            // 
            this.ComboDep.FormattingEnabled = true;
            this.ComboDep.Location = new System.Drawing.Point(94, 99);
            this.ComboDep.Name = "ComboDep";
            this.ComboDep.Size = new System.Drawing.Size(121, 21);
            this.ComboDep.TabIndex = 15;
            // 
            // ComboFakulte
            // 
            this.ComboFakulte.FormattingEnabled = true;
            this.ComboFakulte.Location = new System.Drawing.Point(94, 56);
            this.ComboFakulte.Name = "ComboFakulte";
            this.ComboFakulte.Size = new System.Drawing.Size(121, 21);
            this.ComboFakulte.TabIndex = 14;
            // 
            // Oda_adiTxt
            // 
            this.Oda_adiTxt.Location = new System.Drawing.Point(94, 21);
            this.Oda_adiTxt.Name = "Oda_adiTxt";
            this.Oda_adiTxt.Size = new System.Drawing.Size(121, 20);
            this.Oda_adiTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Departman :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sorumlu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fakülte :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Oda Adı :";
            // 
            // oda_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 232);
            this.Controls.Add(this.GuncelBtn);
            this.Controls.Add(this.ComboSorumlu);
            this.Controls.Add(this.ComboDep);
            this.Controls.Add(this.ComboFakulte);
            this.Controls.Add(this.Oda_adiTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "oda_guncelle";
            this.Text = "Oda Düzenle";
            this.Load += new System.EventHandler(this.OdaGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuncelBtn;
        private System.Windows.Forms.ComboBox ComboSorumlu;
        private System.Windows.Forms.ComboBox ComboDep;
        private System.Windows.Forms.ComboBox ComboFakulte;
        private System.Windows.Forms.TextBox Oda_adiTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}