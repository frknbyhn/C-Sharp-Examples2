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
    public partial class demirbas_guncelle : Form
    {
        public int demirbas_id;
        public string demirbas_adi = "";
        public int miktar = 0;
        public double fiyat = 0;
        public DateTime alim_tarihi;
        public string sharedError = "";
        public demirbas_guncelle(int demirbas_id)
        {
            InitializeComponent();
            this.demirbas_id = demirbas_id;
        }

        private void DemirbasGuncelle_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Parcalar WHERE Parts.id = '" + this.demirbas_id + "'";
            SqlDataReader reader = Controller.GetDataReader(query);
            int part_type_id = 0;
            while (reader.Read())
            {
                txtAd.Text = reader[1].ToString();
                txtMiktar.Text = reader[2].ToString();
                txtFiyat.Text = reader[3].ToString();
                dateAlimTarihi.Text = reader[4].ToString();
                part_type_id = (int)reader[5];
            }
            reader.Close();
            Controller.LoadComboParcaTurleri(comboParcaTuru, part_type_id);
        }

        public bool IsFormValid()
        {
            try
            {

                this.demirbas_adi = txtAd.Text.Trim(' ');
                this.miktar = Convert.ToInt32(txtMiktar.Text);
                this.fiyat = Convert.ToDouble(txtFiyat.Text);
                this.alim_tarihi = Convert.ToDateTime(dateAlimTarihi.Text);

                if (txtFiyat.Text.Contains("."))
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "UPDATE Parcalar SET name=@ad, stock=@miktar, price=@fiyat, purchase_date=@tarih, part_type_id=@type_id WHERE id=@id";
                cmd.Connection = Database.Connect();

                cmd.Parameters.AddWithValue("@id", demirbas_id);
                cmd.Parameters.AddWithValue("@ad", demirbas_adi);
                cmd.Parameters.AddWithValue("@miktar", miktar);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.Parameters.AddWithValue("@type_id", ((Node)comboParcaTuru.SelectedItem).id);
                cmd.Parameters.AddWithValue("@tarih", alim_tarihi);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Demirbaş başarılı bir şekilde güncellendi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Demirbaş güncellenirken bir hata ile karşılaşıldı");
                }
            }
            else
            {
                MessageBox.Show(sharedError + Environment.NewLine + "Lütfen * lı alanları doldurunuz");
            }
        }
    }
}
