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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        public bool IsFormValid()
        {
            string username = txtUsername.Text.Trim(' ');
            string password = txtPassword.Text.Trim(' ');
            if (username != "" && password != "")
            {
                return true;
            }
            return false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            if(!IsFormValid())
            {
                MessageBox.Show("Lütfen eksik alan bırakmayınız.");
                return;
            }
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Kullanicilar WHERE username=@username and password=@password";
            cmd.Connection = Database.Connect();
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);

            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                bool role = (bool)reader[3];
                reader.Close();
                this.Hide();

                MainForm dash = new MainForm(role);
                dash.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış!");
            }
            reader.Close();
        }
    }
}
