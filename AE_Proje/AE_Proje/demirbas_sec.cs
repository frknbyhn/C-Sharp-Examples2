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
    public partial class demirbas_sec : Form
    {
        public string condition = "";
        public int room_id = 0;
        public demirbas_sec(int room_id)
        {
            InitializeComponent();
            this.room_id = room_id;
        }

        private void DemirbasSec_Load(object sender, EventArgs e)
        {
            DemirbasGrid.Columns.Add("part_id", "Part ID");
            DemirbasGrid.Columns[0].Visible = false;
            DemirbasGrid.Columns.Add("part_name", "Adı");
            DemirbasGrid.Columns.Add("stock", "Miktar");
            DemirbasGrid.Columns.Add("price", "Birim Fiyatı");
            DemirbasGrid.Columns.Add("date", "Alım Tarihi");
            DemirbasGrid.Columns.Add("part_type", "Türü");

            DataGridViewButtonColumn ekle = new DataGridViewButtonColumn();
            ekle.HeaderText = ekle.Text = "Seç";
            ekle.Name = "col_sec";
            ekle.UseColumnTextForButtonValue = true;
            DemirbasGrid.Columns.Add(ekle);

            ListParts();
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
        private void btnAra_Click(object sender, EventArgs e)
        {
            string room_name = TxtDadi.Text.Trim(' ');
            this.condition = " and Parcalar.name LIKE '%" + room_name + "%'";
            ListParts();
        }

        private void GridDemirbaslar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == DemirbasGrid.Columns["col_sec"].Index && e.RowIndex >= 0)
                {
                    // atama işlemi
                    string input_box = Microsoft.VisualBasic.Interaction.InputBox("Atanacak demirbaş miktarını giriniz", "Demirbaş Miktarı", "0", 0, 0);
                    if (input_box == "")
                        return;
                    int miktar = Convert.ToInt32(input_box);
                    if (miktar <= 0)
                        return;
                    DialogResult sonuc = MessageBox.Show("Atamak istediğinize emin misiniz?", "Onayla", MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Database.Connect();
                        int stok_miktari = Convert.ToInt32(DemirbasGrid.Rows[e.RowIndex].Cells[2].Value);
                        if (miktar <= stok_miktari)
                        {
                            int part_id = (int)DemirbasGrid.Rows[e.RowIndex].Cells[0].Value;
                            int stok = 0;
                            int row_id = 0;
                            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM OdaParca WHERE room_id='" + this.room_id + "' and part_id='" + part_id + "'");
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    stok = (int)reader[1];
                                    row_id = (int)reader[0];
                                }
                                reader.Close();
                                SqlCommand guncelle = new SqlCommand();
                                guncelle.Connection = Database.Connect();
                                guncelle.CommandText = "UPDATE OdaParca SET stok=@yeni_stok WHERE id=@row_id";
                                guncelle.Parameters.AddWithValue("@yeni_stok", stok + miktar);
                                guncelle.Parameters.AddWithValue("@row_id", row_id);
                                guncelle.ExecuteNonQuery();
                                MessageBox.Show("Demirbaş atandı");
                            }
                            else
                            {
                                reader.Close();
                                SqlCommand ekle = new SqlCommand();
                                ekle.Connection = Database.Connect();
                                ekle.CommandText = "INSERT INTO OdaParca(stock, room_id, part_id) VALUES(@stok, @r_id, @p_id)";
                                ekle.Parameters.AddWithValue("@stok", miktar);
                                ekle.Parameters.AddWithValue("@r_id", room_id);
                                ekle.Parameters.AddWithValue("@p_id", part_id);
                                ekle.ExecuteNonQuery();
                                MessageBox.Show("Demirbaş Atandı");
                            }
                            

                        }
                        else
                        {
                            MessageBox.Show("Girilen miktar, stoktaki miktarı aşıyor. İşlem durduruldu");
                            return;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Doğru formatta data giriniz. (Sayısal)");
            }
        }
    }
}
