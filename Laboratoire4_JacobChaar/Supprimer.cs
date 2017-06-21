using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Laboratoire4_JacobChaar
{
    public partial class Supprimer : Form
    {
        OleDbConnection cncxBD = new OleDbConnection("Data Source=Commandes.mdb;Provider=Microsoft.Jet.OLEDB.4.0"); //connection vers la DB chemin
        OleDbCommand cmd; //Envoyer des commandes SQL 
        OleDbDataReader lireDonne; //Permet de lire les données



        public Supprimer()
        {
            InitializeComponent();
        }

        private void Supprimer_Load(object sender, EventArgs e)
        {

            RemplirComboBox();  //Appler la procédure remplir combobox
        }




        //Procédure qui permet de remplir le combo
        //Paramètre: aucun
        //Valeur de retour: aucun
        void RemplirComboBox()
        {
            string Query = "SELECT * FROM Clients ORDER BY CodeClient ASC;";
            cmd = new OleDbCommand(Query, cncxBD);

            cncxBD.Open();
            lireDonne = cmd.ExecuteReader();

            //lire les données un par un et enregistrer dans la DB au Champs Code  et insérer les valeurs dans le combobox
            while (lireDonne.Read())
            {
                string sCodeClient = lireDonne.GetValue(0).ToString();
                cboCode.Items.Add(sCodeClient);
            }
            cboCode.SelectedIndex = 0;
            cncxBD.Close();
        }

        private void btnSupprminer_Click(object sender, EventArgs e)
        {
            cncxBD.Open();
            string Query = "DELETE FROM CLients WHERE [CodeClient] = '" + cboCode.Text + "';";

            cmd = new OleDbCommand(Query, cncxBD);

            //demander une confirmation
            if (MessageBox.Show("Êtes-vous certains de vouloir supprimer l'enregistrement?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int temp = cmd.ExecuteNonQuery();
                if (temp == 0)
                {
                    MessageBox.Show("Aucune ligne supprimée.");
                }
                //une fois supprimée, actualise le combobox
                cncxBD.Close();
                cboCode.Items.Clear();
                cboCode.SelectedIndex = -1;
                RemplirComboBox();


            }
            cncxBD.Close();


        }

        private void Supprimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            cncxBD.Close();
        }
    }
}
