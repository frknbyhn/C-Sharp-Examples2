namespace yazilim_sinama_proje
{
    partial class demirbas_guncelle
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
            this.dateAlimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnGunc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboParcaTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateAlimTarihi
            // 
            this.dateAlimTarihi.Location = new System.Drawing.Point(81, 149);
            this.dateAlimTarihi.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateAlimTarihi.Name = "dateAlimTarihi";
            this.dateAlimTarihi.Size = new System.Drawing.Size(192, 20);
            this.dateAlimTarihi.TabIndex = 44;
            this.dateAlimTarihi.Value = new System.DateTime(2017, 12, 12, 0, 0, 0, 0);
            // 
            // btnGunc
            // 
            this.btnGunc.Location = new System.Drawing.Point(81, 175);
            this.btnGunc.Name = "btnGunc";
            this.btnGunc.Size = new System.Drawing.Size(192, 43);
            this.btnGunc.TabIndex = 46;
            this.btnGunc.Text = "GUNCELLE";
            this.btnGunc.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Alım Tarihi :";
            // 
            // comboParcaTuru
            // 
            this.comboParcaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParcaTuru.FormattingEnabled = true;
            this.comboParcaTuru.Location = new System.Drawing.Point(81, 122);
            this.comboParcaTuru.Name = "comboParcaTuru";
            this.comboParcaTuru.Size = new System.Drawing.Size(192, 21);
            this.comboParcaTuru.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Parça Türü :";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(81, 96);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(192, 20);
            this.txtFiyat.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Birim Fiyat :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(81, 70);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(192, 20);
            this.txtMiktar.TabIndex = 39;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(81, 44);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 20);
            this.txtAd.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Miktar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Adı :";
            // 
            // demirbas_guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dateAlimTarihi);
            this.Controls.Add(this.btnGunc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboParcaTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "demirbas_guncelle";
            this.Text = "DemirbasGuncelle";
            this.Load += new System.EventHandler(this.DemirbasGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateAlimTarihi;
        private System.Windows.Forms.Button btnGunc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboParcaTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}