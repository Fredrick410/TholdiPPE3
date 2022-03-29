using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace THOLDI.IHM
{
    public partial class Inspection : Form
    {
    
        public Inspection()
        {
            InitializeComponent();
        }

        private void text_Nom_Utilisateur(object sender, EventArgs e)
        {
            // nom d'utilisateur à afficher
        }

        private void afficher_Num_Container(object sender, EventArgs e)
        {
            string cs_pp2 = "server=localhost;userid=root;password=;database=tholdi_pp3";
            var connection_ppe2 = new MySqlConnection(cs_pp2);
            connection_ppe2.Open();

            listView1.Items.Clear();
            var sql = "SELECT * FROM container";
            var cmd = new MySqlCommand(sql, connection_ppe2);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Object[] values = new object[reader.FieldCount];
                    int nombreColonne = reader.GetValues(values);
                    for (int i = 0; i < nombreColonne; i++)
                    {
                        listView1.Items.Add(reader.GetString(0));
                    }
                    
                }
            }
        }

        private void dateTimeInspection_ValueChanged(object sender, EventArgs e)
        {
            dateTimeInspection.Format = DateTimePickerFormat.Custom;
            dateTimeInspection.CustomFormat = "yyyy-MM-dd";
        }

        private void button_Ajouter_Une_Inspection(object sender, EventArgs e)
        {
            string cs_pp2 = "server=localhost;userid=root;password=;database=tholdi_pp3";
            var connection_ppe2 = new MySqlConnection(cs_pp2);
            connection_ppe2.Open();

            var sql = "INSERT INTO inspection (dateInspection, commentairePostInspection, Avis, numContainer, libelleMotif, libelleEtat) VALUES (@dateInspection, @commentairePostInspection, @Avis, @numContainer, @libelleMotif, @libelleEtat)";
            var cmd = new MySqlCommand(sql, connection_ppe2);
            try { 
                cmd.Parameters.AddWithValue("@dateInspection", dateTimeInspection.Text);
                cmd.Parameters.AddWithValue("@commentairePostInspection", textBoxCommentaire.Text);
                cmd.Parameters.AddWithValue("@Avis", textBoxAvis.Text);
                cmd.Parameters.AddWithValue("@numContainer", textBoxNumContainer.Text);
                cmd.Parameters.AddWithValue("@libelleMotif", textBoxMotif.Text);
                cmd.Parameters.AddWithValue("@libelleEtat", textBoxEtat.Text);
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                MessageBox.Show("Inspection ajouté");
          }catch (Exception ex)
          {
              MessageBox.Show("Impossible d'ajouter une nouvelle inspection");
           }
            
        }

        private void button_Actualiser(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            string cs_pp2 = "server=localhost;userid=root;password=;database=tholdi_pp3";
            var connection_ppe2 = new MySqlConnection(cs_pp2);
            connection_ppe2.Open();

            var sql = "SELECT numInspection, dateInspection,commentairePostInspection, Avis, numContainer, libelleMotif, libelleEtat FROM inspection";
            var cmd = new MySqlCommand(sql, connection_ppe2);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string numInspection = reader["numInspection"].ToString();
                    string dateInspection = reader["dateInspection"].ToString();
                    string commentairePostInspection = reader["commentairePostInspection"].ToString();
                    string Avis = reader["Avis"].ToString();
                    string numContainer = reader["numContainer"].ToString();
                    string libelleMotif = reader["libelleMotif"].ToString();
                    string libelleEtat = reader["libelleEtat"].ToString();

                    listView1.Items.Add(new ListViewItem(new[] { numInspection, dateInspection, commentairePostInspection, numContainer, Avis, libelleMotif, libelleEtat }));
                }
            }
        }

        private void button_Redirection_Declaration(object sender, EventArgs e)
        {
            this.Hide();
            Declaration form = new Declaration();
            form.ShowDialog();
        }

        private void button_Fermeture_Appli(object sender, EventArgs e)
        {
            Inspection log = new Inspection();
            this.Close();
        }

       
    }
}
