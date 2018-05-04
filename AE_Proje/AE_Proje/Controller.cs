using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilim_sinama_proje
{
    public class Controller
    {
        public static SqlDataReader GetDataReader(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = Database.Connect();

            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int txtPassword(int input)
        {
            if (input == 123)
                return 123;
            throw new InvalidOperationException();
        }

        public int MiktarTxt(int input)
        {
            if (input.Equals((Convert.ToString(" "))))
                return input;
            throw new InvalidOperationException();
        }

        public int FiyatTXt(int input)
        {
            if (input.Equals((Convert.ToString(" "))))
                return input;
            throw new InvalidOperationException();
        }

        public static void LoadComboParcaTurleri(ComboBox Turcombo)
        {
            Turcombo.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM ParcaTurleri");
            while (reader.Read())
            {
                Node.AddItemToCombo(Turcombo, (int)reader[0], (string)reader[1]);
            }
            Turcombo.SelectedIndex = 0;
            reader.Close();
        }
        public static void LoadComboParcaTurleri(ComboBox Turcombo, int part_type_id)
        {
            Turcombo.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM ParcaTurleri");
            int i = 0;
            while (reader.Read())
            {
                Node.AddItemToCombo(Turcombo, (int)reader[0], (string)reader[1]);
                if ((int)reader[0] == part_type_id)
                {
                    Turcombo.SelectedIndex = i;
                }
                i++;
            }
            reader.Close();
        }
        public static void LoadComboFakulte(ComboBox ComboFakulte)
        {
            ComboFakulte.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Fakulte");
            while(reader.Read())
            {
                Node.AddItemToCombo(ComboFakulte, (int)reader[0], (string)reader[1]);
            }
            reader.Close();
        }
        public static void LoadComboFakulte(ComboBox ComboFakulte, int faculty_id)
        {
            ComboFakulte.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Fakulte");
            int i = 0;
            while (reader.Read())
            {
                Node.AddItemToCombo(ComboFakulte, (int)reader[0], (string)reader[1]);
                if (faculty_id == (int)reader[0])
                {
                    ComboFakulte.SelectedIndex = i;
                }
                i++;
            }
            reader.Close();
        }
        public static void LoadComboDepartman(ComboBox ComboDep, int faculty_id)
        {
            ComboDep.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Departman WHERE faculty_id='" + faculty_id+"'");
            while (reader.Read())
            {
                Node.AddItemToCombo(ComboDep, (int)reader[0], (string)reader[1]);
            }
            ComboDep.SelectedIndex = 0;
            reader.Close();
        }
        public static void LoadComboDepartman(ComboBox ComboDep, int faculty_id, int departman_id)
        {
            ComboDep.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Departman WHERE faculty_id='" + faculty_id + "'");
            int i = 0;
            while (reader.Read())
            {
                Node.AddItemToCombo(ComboDep, (int)reader[0], (string)reader[1]);
                if(departman_id == (int)reader[0])
                {
                    ComboDep.SelectedIndex = i;
                }
                i++;
            }
            ComboDep.SelectedIndex = 0;
            reader.Close();
        }
        public static void LoadComboCalisan(ComboBox ComboSorumlu)
        {
            ComboSorumlu.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Calisan");
            while (reader.Read())
            {
                Node.AddItemToCombo(ComboSorumlu, (int)reader[0], reader[1] + " " + reader[2]);
            }
            reader.Close();
        }
        public static void LoadComboCalisan(ComboBox ComboSorumlu, int sorumlu_id)
        {
            int i = 0;
            ComboSorumlu.Items.Clear();
            SqlDataReader reader = Controller.GetDataReader("SELECT * FROM Calisan");
            while (reader.Read())
            {
                Node.AddItemToCombo(ComboSorumlu, (int)reader[0], reader[1] + " " + reader[2]);
                if(sorumlu_id == (int)reader[0])
                {
                    ComboSorumlu.SelectedIndex = i;
                }
                i++;
            }
            reader.Close();
        }
    }
}
