using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace yazilim_sinama_proje
{
    public partial class oda_listele : Form
    {
        public string condition = "";
        public bool role;
        public oda_listele(bool role)
        {
            this.role = role;
            InitializeComponent();
            GridOdalar.Columns.Add("room_id", "Oda ID");
            GridOdalar.Columns[0].Visible = false;
            GridOdalar.Columns.Add("fac_id", "Fakulte ID");
            GridOdalar.Columns[1].Visible = false;
            GridOdalar.Columns.Add("room_name", "Oda Adı");
            GridOdalar.Columns.Add("faculty_id", "Fakülte");
            GridOdalar.Columns.Add("department_id", "Departman");
            GridOdalar.Columns.Add("employee_id", "Sorumlu");

            if (role)
            {
                DataGridViewButtonColumn deleteCol = new DataGridViewButtonColumn();
                deleteCol.Name = "delete_col";
                deleteCol.HeaderText = "Sil";
                deleteCol.Text = "Sil";
                deleteCol.UseColumnTextForButtonValue = true;
                GridOdalar.Columns.Add(deleteCol);

                DataGridViewButtonColumn updateCol = new DataGridViewButtonColumn();
                updateCol.Name = "update_col";
                updateCol.HeaderText = "Düzenle";
                updateCol.Text = "Düzenle";
                updateCol.UseColumnTextForButtonValue = true;
                GridOdalar.Columns.Add(updateCol);
            }
            
        }

        public void ListRooms(bool reset=false)
        {
            GridOdalar.Rows.Clear();
            SqlCommand comm = new SqlCommand();
            comm.Connection = Database.Connect();
            string query = "SELECT * FROM(Odalar LEFT JOIN Calisan ON Odalar.employee_id = Calisan.id) INNER JOIN (Fakulte INNER JOIN Departman ON Fakulte.id = Departman.faculty_id) ON Odalar.department_id = Departman.id";
            if (condition != "" && reset == false)
            {
                query += " WHERE Odalar.name LIKE '%" + condition + "%'";
            }
            SqlCommand cmd = new SqlCommand(query, Database.Connect());
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GridOdalar.Rows.Add(reader[0], reader[7], reader[3], reader[8], reader[10], reader[5] + " " + reader[6]);
                }
            }
            reader.Close();
        }
        private void OdaListele_Load(object sender, EventArgs e)
        {
            ListRooms();
        }
        

        private void GridOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == GridOdalar.Columns["delete_col"].Index && e.RowIndex >= 0)
                {
                    DialogResult sil = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Seçilen Odayı Sil", MessageBoxButtons.YesNo);
                    if(sil == DialogResult.Yes)
                    {
                        // Silme işlemi
                        int room_id = (int)GridOdalar.Rows[e.RowIndex].Cells[0].Value;

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Database.Connect();
                        cmd.CommandText = "DELETE FROM Odalar WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", room_id);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Silme işlemi tamamlandı");
                        }
                        else
                        {
                            MessageBox.Show("Silme işlemi esnasında bir hata ile karşılaşıldı");
                        }
                        ListRooms();
                    }
                    else
                    {
                        // Silme işlemi iptali
                        MessageBox.Show("Silme işlemi iptal edildi");
                    }
                    
                }
                else if (e.ColumnIndex == GridOdalar.Columns["update_col"].Index && e.RowIndex >= 0)
                {
                    // Update için, open room
                    oda_guncelle oda_guncelle = new oda_guncelle((int)GridOdalar.Rows[e.RowIndex].Cells[0].Value, (int)GridOdalar.Rows[e.RowIndex].Cells[1].Value);
                    oda_guncelle.MdiParent = this.MdiParent;
                    oda_guncelle.Show();
                }
            }
            catch
            {
                return;
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string oda_adi = Oda_adiTxt.Text.Trim(' ');
            this.condition = oda_adi;
            ListRooms();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListRooms(true);
            Oda_adiTxt.Text = "";
        }
    }
}
