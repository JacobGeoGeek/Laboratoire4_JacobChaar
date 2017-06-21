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
    public partial class Ajouter : Form
    {
        OleDbConnection cncxBD = new OleDbConnection("Data Source=Commandes.mdb;Provider=Microsoft.Jet.OLEDB.4.0"); //connection vers la DB chemin
              
        OleDbCommand cmd; //Envoyer des commandes SQL 
        OleDbDataReader lireDonne; //Permet de lire les données

        
        public Ajouter()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Déclaration des variables 
            TextBox[] TBChamp = { txtAdresse, txtCode, txtCodepostal, txtContact, txtFax, txtFonction, txtProvince, txtSociete, txtTelContact, txtTelephone, txtVille };
            validation ValiderChamps = new validation();
            bool boValidation = true;


            if (ValiderChamps.ValidationTextBox(TBChamp)) //Appeler la fonction ValiderChamps (qui se trouve dans le fichier    validation.cs
            {
               //appeler la fonction validation
                if (Validation())   //Si le Code est unique (pas de doublon), ajoutez la nouvelle donnée
            {
               
                cncxBD.Open();
                string query = "INSERT INTO Clients (CodeClient, SocieteClient, AdresseClient, VilleClient, ProvClient, CPClient, TelClient, Fax, ContactClient, FonctionClient, TelContactClient) VALUES ('" + txtCode.Text.ToUpper() + "', '" + txtSociete.Text + "', '" + txtAdresse.Text + "', '" + txtVille.Text + "', '" + txtProvince.Text + "', '" + txtCodepostal.Text + "', '" + txtTelephone.Text + "', '" + txtFax.Text + "', '" + txtContact.Text + "', '" + txtFonction.Text + "', '" + txtTelContact.Text + "')";
            
                cmd = new OleDbCommand(query, cncxBD);

                try   //Si on retrouve des erreur affichez un messagebox
                {
                    int temp = cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    if (ex.Message.Contains("ne peut pas être une chaîne vide."))
                    {
                        MessageBox.Show("Tous les champs doivent être remplie, à l'exception du champ Téléphone contact, qui n'est pas obligatoire");
                    }
                    else 
                    {
                       MessageBox.Show(ex.Message.ToString());
                    }
                    boValidation = false;
                    
                    cncxBD.Close();
                   
                }
            
                cncxBD.Close();

                if (boValidation == true)    // Si les données sont correct effacez videz les textbox
                {
                    for (int i = 0; i < TBChamp.Length; i++)
                {
                    TBChamp[i].Clear();
                }
                    txtCode.Focus();
                }

              

          

            }
         
            }

        }
     
      

        //Fonction qui Permettant de valider si le l'élément txtCode existe déjà dans la DB
        //Paramètre: aucun
        //Valeur de retour: Vrai ou faux
        bool Validation()
        {

            string Query = "SELECT Clients.[CodeClient] FROM Clients WHERE Clients.[CodeClient] = '" + txtCode.Text + "';";
            //MessageBox.Show(Query);
                cncxBD.Open();

            cmd = new OleDbCommand(Query, cncxBD);

           
            lireDonne = cmd.ExecuteReader();

            while (lireDonne.Read())
            {
                if (txtCode.Text.ToUpper() == lireDonne.GetValue(0).ToString())
                {
                    MessageBox.Show("Le Code " + txtCode.Text + " existe déjà dans la base de données. Veuillez entrer un autre code");
                    txtCode.Focus();
                    cncxBD.Close();

                    return false;

                }

            }


            cncxBD.Close();
            return true;



        }

      

        private void Ajouter_FormClosed(object sender, FormClosedEventArgs e)
        {
            cncxBD.Close();
        }
    }
}
