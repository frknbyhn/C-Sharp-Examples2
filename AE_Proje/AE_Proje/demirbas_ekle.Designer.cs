namespace yazilim_sinama_proje
{
    partial class demirbas_ekle
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
            this.date_alim = new System.Windows.Forms.DateTimePicker();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Turcombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FiyatTXt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MiktarTxt = new System.Windows.Forms.TextBox();
            this.AdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_alim
            // 
            this.date_alim.Location = new System.Drawing.Point(81, 135);
            this.date_alim.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.date_alim.Name = "date_alim";
            this.date_alim.Size = new System.Drawing.Size(192, 20);
            this.date_alim.TabIndex = 33;
            this.date_alim.Value = new System.DateTime(2017, 12, 12, 0, 0, 0, 0);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(81, 161);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(192, 43);
            this.EkleBtn.TabIndex = 35;
            this.EkleBtn.Text = "EKLE";
            this.EkleBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Alım Tarihi :";
            // 
            // Turcombo
            // 
            this.Turcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Turcombo.FormattingEnabled = true;
            this.Turcombo.Location = new System.Drawing.Point(81, 108);
            this.Turcombo.Name = "Turcombo";
            this.Turcombo.Size = new System.Drawing.Size(192, 21);
            this.Turcombo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Parça Türü :";
            // 
            // FiyatTXt
            // 
            this.FiyatTXt.Location = new System.Drawing.Point(81, 82);
            this.FiyatTXt.Name = "FiyatTXt";
            this.FiyatTXt.Size = new System.Drawing.Size(192, 20);
            this.FiyatTXt.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Birim Fiyat :";
            // 
            // MiktarTxt
            // 
            this.MiktarTxt.Location = new System.Drawing.Point(81, 56);
            this.MiktarTxt.Name = "MiktarTxt";
            this.MiktarTxt.Size = new System.Drawing.Size(192, 20);
            this.MiktarTxt.TabIndex = 28;
            // 
            // AdTxt
            // 
            this.AdTxt.Location = new System.Drawing.Point(81, 30);
            this.AdTxt.Name = "AdTxt";
            this.AdTxt.Size = new System.Drawing.Size(192, 20);
            this.AdTxt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Miktar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Adı :";
            // 
            // demirbas_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.date_alim);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Turcombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FiyatTXt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MiktarTxt);
            this.Controls.Add(this.AdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "demirbas_ekle";
            this.Text = "Demirbaş Ekle";
            this.Load += new System.EventHandler(this.DemirbasEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_alim;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Turcombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FiyatTXt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MiktarTxt;
        private System.Windows.Forms.TextBox AdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}