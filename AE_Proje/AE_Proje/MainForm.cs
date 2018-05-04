using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_sinama_proje
{
    public partial class MainForm : Form
    {
        private oda_ekle oda_ekle;
        private oda_listele oda_listele;
        private demirbas_ekle demirbas_ekle;
        private demirbas_listele demirbas_listele;
        
        public bool role;
        public MainForm(bool role)
        {
            this.role = role;
            InitializeComponent();
            if (role == true)
            {
                ToolStripMenuItem oda_ekle = new ToolStripMenuItem();
                oda_ekle.Text = "Oda Ekle";
                oda_ekle.Click += new EventHandler(odaEkleToolStripMenuItem_Click);
                odaToolStripMenuItem.DropDownItems.Add(oda_ekle);

                ToolStripMenuItem demirbas_ekle = new ToolStripMenuItem();
                demirbas_ekle.Text = "Demirbaş Ekle";
                demirbas_ekle.Click += new EventHandler(demirbasEkleToolStripMenuItem_Click);
                demirbaşToolStripMenuItem.DropDownItems.Add(demirbas_ekle);
            }
        }

        private void odaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oda_ekle == null || oda_ekle != null && oda_ekle.IsDisposed)
            {
                oda_ekle = new oda_ekle();
                oda_ekle.MdiParent = this;
                oda_ekle.Show();
            }
            else
                oda_ekle.BringToFront();

        }

        private void demirbasEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (demirbas_ekle == null || demirbas_ekle != null && demirbas_ekle.IsDisposed)
                {
                    demirbas_ekle = new demirbas_ekle();
                    demirbas_ekle.MdiParent = this;
                    demirbas_ekle.Show();
                }
                else
                    demirbas_ekle.BringToFront();

        }

        private void odalarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oda_listele == null || oda_listele != null && oda_listele.IsDisposed)
            {
                oda_listele = new oda_listele(this.role);
                oda_listele.MdiParent = this;
                oda_listele.Show();
            }
            else
                oda_listele.BringToFront();
        }

        private void demirbaşListeleAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (demirbas_listele == null || demirbas_listele != null && demirbas_listele.IsDisposed)
            {
                demirbas_listele = new demirbas_listele();
                demirbas_listele.MdiParent = this;
                demirbas_listele.Show();
            }
            else
                demirbas_listele.BringToFront();

        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere");
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Furkan Beyhan" + Environment.NewLine + "Aydın Baran");
        }

        private void odaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}
