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
using Microsoft.VisualBasic;

namespace yazilim_sinama_proje
{
    public partial class demirbas_listele : Form
    {
        public string condition = "";
        public demirbas_listele()
        {
            InitializeComponent();

            DemirbasGrid.Columns.Add("part_id", "Part ID");
            DemirbasGrid.Columns[0].Visible = false;
            DemirbasGrid.Columns.Add("part_name", "Adı");
            DemirbasGrid.Columns.Add("stock", "Miktar");
            DemirbasGrid.Columns.Add("price", "Birim Fiyatı");
            DemirbasGrid.Columns.Add("date", "Alım Tarihi");
            DemirbasGrid.Columns.Add("part_type", "Türü");

            DataGridViewButtonColumn sil = new DataGridViewButtonColumn();
            sil.HeaderText = sil.Text = "Sil";
            sil.Name = "col_sil";
            sil.UseColumnTextForButtonValue = true;
            DemirbasGrid.Columns.Add(sil);

            DataGridViewButtonColumn duzenle = new DataGridViewButtonColumn();
            duzenle.HeaderText = duzenle.Text = "Düzenle";
            duzenle.Name = "col_duzenle";
            duzenle.UseColumnTextForButtonValue = true;
            DemirbasGrid.Columns.Add(duzenle);
        }

        private void ListParts()
        {
            DemirbasGrid.Rows.Clear();
            string query = "SELECT * FROM Parcalar, ParcaTurleri WHERE Parcalar.part_type_id = ParcaTurleri.id" + this.condition;
            SqlDataReader reader = Controller.GetDataReader(query);
            while (reader.Read())
            {
                DemirbasGrid.Rows.Add((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[7].ToString());
            }
            reader.Close();
        }

        private void DemirbasListeleme_Load(object sender, EventArgs e)
        {
            ListParts();
        }

        private void GridDemirbaslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DemirbasGrid.Columns["col_sil"].Index && e.RowIndex >= 0)
                {
                    // silme işlemi
                    string input_box = Microsoft.VisualBasic.Interaction.InputBox("Silinecek demirbaş miktarını giriniz.", "Demirbaş Sil", "0", 0, 0);
                    if (input_box == "")
                        return;
                    int miktar = Convert.ToInt32(input_box);
                    if (miktar <= 0)
                        return;
                    DialogResult sonuc = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Database.Connect();
                        int stok_miktari = Convert.ToInt32(DemirbasGrid.Rows[e.RowIndex].Cells[2].Value);
                        if (miktar == stok_miktari)
                            cmd.CommandText = "DELETE FROM Parcalar WHERE id=@id";
                        else if (miktar > stok_miktari)
                        {
                            MessageBox.Show("Girilen miktar, stoktaki miktarı aşıyor. İşlem durduruldu");
                            return;
                        }
                        else
                        {
                            cmd.CommandText = "UPDATE Parcalar SET stock=@miktar WHERE id=@id";
                            cmd.Parameters.AddWithValue("@miktar", stok_miktari - miktar);
                        }
                        cmd.Parameters.AddWithValue("@id", (int)DemirbasGrid.Rows[e.RowIndex].Cells[0].Value);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Demirbaş silme işlemi başarılı");
                            ListParts();
                        }
                        else
                        {
                            MessageBox.Show("Demirbaş silerken hata ile karşılaşıldı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi iptal edildi");
                    }
                }
                else if (e.ColumnIndex == DemirbasGrid.Columns["col_duzenle"].Index && e.RowIndex >= 0)
                {
                    // güncelle işlemi
                    demirbas_guncelle demirbas_guncelle = new demirbas_guncelle((int)DemirbasGrid.Rows[e.RowIndex].Cells[0].Value);
                    demirbas_guncelle.MdiParent = this.MdiParent;
                    demirbas_guncelle.Show();
                }
            }
            catch
            {
                MessageBox.Show("Doğru formatta data giriniz. (Sayısal)");
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string room_name = txtDAdi.Text.Trim(' ');
            this.condition = " and Parcalar.name LIKE '%" + room_name + "%'";
            ListParts();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListParts();
            txtDAdi.Text = "";
        }
    }
}
