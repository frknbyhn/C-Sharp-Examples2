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
    public partial class oda_guncelle : Form
    {
        public int room_id;
        public int fakulte_id;
        public bool Loaded = false;
        public oda_guncelle(int p_room_id, int fakulte_id)
        {
            InitializeComponent();
            this.room_id = p_room_id;
            this.fakulte_id = fakulte_id;
        }

        private void OdaGuncelle_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Rooms WHERE id='" + room_id + "'");
            int departman_id = 0;
            string oda_adi="";
            int employee_id = 0;
            while (reader.Read())
            {
                departman_id = (int)reader[1];
                oda_adi = reader[3].ToString();
                employee_id = (int)reader[2];
            }
            reader.Close();
            Oda_adiTxt.Text = oda_adi;
            Controller.LoadComboFakulte(ComboFakulte, fakulte_id);
            Controller.LoadComboDepartman(ComboDep, fakulte_id, departman_id);
            Controller.LoadComboCalisan(ComboSorumlu, employee_id);
            this.Loaded = true;
        }

        private void comboFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.Loaded == true)
            {
                Node selected = (Node)ComboFakulte.SelectedItem;
                Controller.LoadComboDepartman(ComboDep, selected.id);
            }
        }
        public bool IsFormValid()
        {
            if (Oda_adiTxt.Text == "" || ComboDep.SelectedIndex == -1 || ComboFakulte.SelectedIndex == -1)
                return false;
            return true;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int sorumlu_id = -1;
            if(ComboSorumlu.SelectedIndex != -1)
            {
                sorumlu_id = ((Node)ComboSorumlu.SelectedItem).id;
            }
            if(IsFormValid())
            {
                string room_name = Oda_adiTxt.Text;
                int departman_id = ((Node)ComboDep.SelectedItem).id;
                int fakulte_id = ((Node)ComboFakulte.SelectedItem).id;

                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE Odalar SET department_id=@departman, employee_id=@sorumlu, name=@room_name WHERE id=@room_id";
                    cmd.Connection = Database.Connect();

                    cmd.Parameters.AddWithValue("@departman", departman_id);
                    cmd.Parameters.AddWithValue("@sorumlu", sorumlu_id);
                    cmd.Parameters.AddWithValue("@room_name", room_name);
                    cmd.Parameters.AddWithValue("@room_id", room_id);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Oda başarılı bir şekilde güncellendi");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme esnasında bir hata ile karşılaşıldı, QueryError.");
                    }
                }
                catch
                {
                    MessageBox.Show("İşlem esnasında bir hata oluştu.");
                }
            }
        }
    }
}
