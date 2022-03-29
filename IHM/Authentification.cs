using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using THOLDI.IHM;

namespace THOLDI
{
    public partial class Authentification : Form
    {
        private static MySqlConnection _connexion = new MySqlConnection("Database=tholdi_pp3;Data Source=localhost;User Id=root;Password=''");
        public Authentification()
        {
            InitializeComponent();
        }

       
        private void image_Mdp_Afficher_Mdp(object sender, MouseEventArgs e)
        {
            champMdp.UseSystemPasswordChar = false;
        }

        private void champDeSaisitLogin(object sender, EventArgs e)
        {
            champLogin.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            champMdp.BackColor = SystemColors.Control;
        }

        private void champDeSaisitMdp(object sender, EventArgs e)
        {
            champMdp.BackColor = Color.White;
            panel4.BackColor = Color.White;
            champLogin.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }
        private void button_Afficher_Mdp(object sender, EventArgs e)
        {
            if (champMdp.UseSystemPasswordChar)
            {
                champMdp.UseSystemPasswordChar = false;
            }
            else
            {
                champMdp.UseSystemPasswordChar = true;
            }
        }

        private void button_Authentification(object sender, EventArgs e)
        {
            string cs_pp2 = "server=localhost;userid=root;password=;database=tholdi_pp2";
            var connection_ppe2 = new MySqlConnection(cs_pp2);
            connection_ppe2.Open();


            var sql = "SELECT login, mdp FROM utilisateur";
            var cmd = new MySqlCommand(sql, connection_ppe2);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                reader.Read();

                string login = reader.GetString("login");
                string mdp =  reader.GetString("mdp");

                var pass = BCrypt.Net.BCrypt.HashPassword(champMdp.Text);
                var checkPass = BCrypt.Net.BCrypt.Verify(mdp, pass);

                // 


                if (checkPass  && login == champLogin.Text)
                {
                    this.Hide();
                    Inspection form = new Inspection();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                    MessageBox.Show("php : " + mdp + "      c# : " + pass);
                }

            }
        }

        private void button_Fermeture_Appli(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
