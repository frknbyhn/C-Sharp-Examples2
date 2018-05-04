namespace yazilim_sinama_proje
{
    partial class demirbas_listele
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
            this.YenileBtn = new System.Windows.Forms.Button();
            this.DemirbasGrid = new System.Windows.Forms.DataGridView();
            this.AraBtn = new System.Windows.Forms.Button();
            this.txtDAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // YenileBtn
            // 
            this.YenileBtn.Location = new System.Drawing.Point(320, 7);
            this.YenileBtn.Name = "YenileBtn";
            this.YenileBtn.Size = new System.Drawing.Size(100, 23);
            this.YenileBtn.TabIndex = 14;
            this.YenileBtn.Text = "Yenile";
            this.YenileBtn.UseVisualStyleBackColor = true;
            // 
            // DemirbasGrid
            // 
            this.DemirbasGrid.AllowUserToAddRows = false;
            this.DemirbasGrid.AllowUserToDeleteRows = false;
            this.DemirbasGrid.AllowUserToResizeColumns = false;
            this.DemirbasGrid.AllowUserToResizeRows = false;
            this.DemirbasGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemirbasGrid.Location = new System.Drawing.Point(12, 33);
            this.DemirbasGrid.Name = "DemirbasGrid";
            this.DemirbasGrid.ReadOnly = true;
            this.DemirbasGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DemirbasGrid.Size = new System.Drawing.Size(793, 455);
            this.DemirbasGrid.TabIndex = 13;
            // 
            // AraBtn
            // 
            this.AraBtn.Location = new System.Drawing.Point(198, 7);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(100, 23);
            this.AraBtn.TabIndex = 12;
            this.AraBtn.Text = "Ara";
            this.AraBtn.UseVisualStyleBackColor = true;
            // 
            // txtDAdi
            // 
            this.txtDAdi.Location = new System.Drawing.Point(84, 9);
            this.txtDAdi.Name = "txtDAdi";
            this.txtDAdi.Size = new System.Drawing.Size(108, 20);
            this.txtDAdi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Demirbaş Adı";
            // 
            // demirbas_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 500);
            this.Controls.Add(this.YenileBtn);
            this.Controls.Add(this.DemirbasGrid);
            this.Controls.Add(this.AraBtn);
            this.Controls.Add(this.txtDAdi);
            this.Controls.Add(this.label1);
            this.Name = "demirbas_listele";
            this.Text = "Demirbaş Listeleme";
            this.Load += new System.EventHandler(this.DemirbasListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DemirbasGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YenileBtn;
        private System.Windows.Forms.DataGridView DemirbasGrid;
        private System.Windows.Forms.Button AraBtn;
        private System.Windows.Forms.TextBox txtDAdi;
        private System.Windows.Forms.Label label1;
    }
}