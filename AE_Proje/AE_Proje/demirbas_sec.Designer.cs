namespace yazilim_sinama_proje
{
    partial class demirbas_sec
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
            this.DemirbasGrid = new System.Windows.Forms.DataGridView();
            this.BtnAra = new System.Windows.Forms.Button();
            this.TxtDadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DemirbasGrid
            // 
            this.DemirbasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemirbasGrid.Location = new System.Drawing.Point(12, 41);
            this.DemirbasGrid.Name = "DemirbasGrid";
            this.DemirbasGrid.Size = new System.Drawing.Size(499, 334);
            this.DemirbasGrid.TabIndex = 19;
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(212, 7);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(75, 23);
            this.BtnAra.TabIndex = 18;
            this.BtnAra.Text = "ARA";
            this.BtnAra.UseVisualStyleBackColor = true;
            // 
            // TxtDadi
            // 
            this.TxtDadi.Location = new System.Drawing.Point(96, 7);
            this.TxtDadi.Name = "TxtDadi";
            this.TxtDadi.Size = new System.Drawing.Size(100, 20);
            this.TxtDadi.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Demirbaş Adı : ";
            // 
            // demirbas_sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 388);
            this.Controls.Add(this.DemirbasGrid);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.TxtDadi);
            this.Controls.Add(this.label1);
            this.Name = "demirbas_sec";
            this.Text = "DemirbasSec";
            this.Load += new System.EventHandler(this.DemirbasSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DemirbasGrid;
        private System.Windows.Forms.Button BtnAra;
        private System.Windows.Forms.TextBox TxtDadi;
        private System.Windows.Forms.Label label1;
    }
}