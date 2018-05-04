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
    public partial class demirbas_ekle : Form
    {
        public string demirbas_adi = "";
        public int miktar = 0;
        public double fiyat = 0;
        public DateTime alim_tarihi;

        public string sharedError = "";
        
        public demirbas_ekle()
        {
            InitializeComponent();
        }
        public bool IsFormValid()
        {
            try
            {

                this.demirbas_adi = AdTxt.Text.Trim(' ');
                this.miktar = Convert.ToInt32(MiktarTxt.Text);
                this.fiyat = Convert.ToDouble(FiyatTXt.Text);
                this.alim_tarihi = Convert.ToDateTime(date_alim.Text);

                if (FiyatTXt.Text.Contains("."))
                {
                    sharedError = "Fiyat girdisinde (.) Nokta yerine (,) Virgül kullanın";
                    return false;
                }

                if (demirbas_adi != "" && miktar > 0 && fiyat > 0)
                    return true;
                return false;
            }
            catch
            {
                sharedError = "Lütfen girdi alanlarına veri girişini doğru bir şekilde yapın.";
                return false;
            }
        }
        public void Reopen()
        {
            demirbas_ekle demirbas_ekle = new demirbas_ekle();
            demirbas_ekle.MdiParent = this.MdiParent;
            this.Close();
            demirbas_ekle.Show();
        }
        private void DemirbasEkle_Load(object sender, EventArgs e)
        {
            Controller.LoadComboParcaTurleri(Turcombo);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Parcalar VALUES(@ad, @miktar, @fiyat, @tarih, @type_id)";
                cmd.Connection = Database.Connect();

                cmd.Parameters.AddWithValue("@ad", demirbas_adi);
                cmd.Parameters.AddWithValue("@miktar", miktar);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.Parameters.AddWithValue("@type_id", ((Node)Turcombo.SelectedItem).id);
                cmd.Parameters.AddWithValue("@tarih", alim_tarihi);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Demirbaş başarılı bir şekilde eklendi");
                    Reopen();
                }
                else
                {
                    MessageBox.Show("Demirbaş eklerken bir hata ile karşılaşıldı");
                }
            }
            else
            {
                MessageBox.Show(sharedError + Environment.NewLine + "Lütfen boş alanları doldurunuz");
            }
        }
    }
}
