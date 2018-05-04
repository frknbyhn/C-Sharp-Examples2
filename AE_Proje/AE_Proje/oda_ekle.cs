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
    public partial class oda_ekle : Form
    {
        public oda_ekle()
        {
            InitializeComponent();
        }

        private void OdaEkle_Load(object sender, EventArgs e)
        {
            Controller.LoadComboFakulte(ComboFakulte);
            Controller.LoadComboCalisan(ComboSorumlu);    
        }
        public bool IsFormValid()
        {
            string oda_adi = Oda_adiTxt.Text.Trim(' ');
            if (oda_adi != "" && ComboFakulte.SelectedIndex != -1 && ComboDep.SelectedIndex != -1)
                return true;
            return false;
        }
        
        public void ClearForm()
        {
            oda_ekle new_form = new oda_ekle();
            new_form.MdiParent = this.MdiParent;
            this.Close();
            new_form.Show();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int sorumlu_id = -1;
                if (ComboSorumlu.SelectedIndex != -1)
                    sorumlu_id = ((Node)ComboSorumlu.SelectedItem).id;

                if (IsFormValid())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Odalar(department_id, employee_id, name) VALUES(@dep_id, @emp_id, @name)";
                    cmd.Connection = Database.Connect();

                    cmd.Parameters.AddWithValue("@dep_id", ((Node)ComboDep.SelectedItem).id);
                    cmd.Parameters.AddWithValue("@emp_id", sorumlu_id);
                    cmd.Parameters.AddWithValue("@name", Oda_adiTxt.Text.Trim(' '));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Oda Eklendi.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Lütfen *'lı alanları doldurup tekrar deneyiniz");
                }
            }
            catch
            {
                MessageBox.Show("Oda Eklenirken bir hata oluştu.");
            }
        }

        private void comboFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Node selected = (Node)ComboFakulte.SelectedItem;
            Controller.LoadComboDepartman(ComboDep, selected.id);
        }
    }

    class txtOdaAdi
    {
    }
}
