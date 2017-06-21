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
    public partial class Modifier : Form
    {
        OleDbConnection cncxBD = new OleDbConnection("Data Source=Commandes.mdb;Provider=Microsoft.Jet.OLEDB.4.0"); //connection vers la DB chemin
        OleDbDataAdapter adpBD; //remplir la DB (va chercher les données)
        DataSet dsUsagers; //Celui qui fais une copie de la DB
        DataView dvUsagers; //Permert de présenter les données 
        OleDbCommand cmd; //Envoyer des commandes SQL 
        OleDbDataReader lireDonne; //Permet de lire les données


        public Modifier()
        {

            InitializeComponent();

        }

        private void Modifier_Load(object sender, EventArgs e)
        {
            Afficher();
            RemplirComboBox();

        }

        void Afficher()
        {

            adpBD = new OleDbDataAdapter("SELECT * FROM Clients", cncxBD);
            dsUsagers = new DataSet();
            dvUsagers = new DataView();


        }

        private void cboCodeclient_SelectedValueChanged(object sender, EventArgs e)
        {
            string Query = "SELECT  Clients.[SocieteClient], Clients.[AdresseClient], Clients.[VilleClient], Clients.[ProvClient], Clients.[CPClient], Clients.[TelClient], Clients.[Fax], Clients.[ContactClient], Clients.[FonctionClient], Clients.[TelContactClient] FROM Clients WHERE Clients.[CodeClient]= '" + cboCodeclient.Text + "';";

            cmd = new OleDbCommand(Query, cncxBD);

            txtCode.Text = cboCodeclient.Text;
            cncxBD.Open();
            lireDonne = cmd.ExecuteReader();

            while (lireDonne.Read())
            {
                txtSociete.Text = lireDonne.GetValue(0).ToString();
                txtAdresse.Text = lireDonne.GetValue(1).ToString();
                txtVille.Text = lireDonne.GetValue(2).ToString();
                txtProvince.Text = lireDonne.GetValue(3).ToString();
                txtCodePostal.Text = lireDonne.GetValue(4).ToString();
                txtTelephone.Text = lireDonne.GetValue(5).ToString();
                txtFax.Text = lireDonne.GetValue(6).ToString();
                txtContact.Text = lireDonne.GetValue(7).ToString();
                txtFonction.Text = lireDonne.GetValue(8).ToString();
                txtTelContact.Text = lireDonne.GetValue(9).ToString();

            }
            cncxBD.Close();


        }
        //Procédure qui permet de remplir le combo
        //Paramètre: aucun
        //Valeur de retour: aucun
        void RemplirComboBox()
        {
            string Query = "SELECT [CodeClient] FROM Clients;";
            cmd = new OleDbCommand(Query, cncxBD);

            cncxBD.Open();
            lireDonne = cmd.ExecuteReader();

            //lire les données un par un et enregistrer dans la DB au Champs Code
            while (lireDonne.Read())
            {
                string sCodeClient = lireDonne.GetValue(0).ToString();
                cboCodeclient.Items.Add(sCodeClient);
            }


            cncxBD.Close();



        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            //déclaration des variables
            TextBox[] TBChamp = { txtCode, txtAdresse, txtCodePostal, txtContact, txtFax, txtFonction, txtProvince, txtSociete, txtTelContact, txtTelephone, txtVille };
            validation ValiderChamps = new validation();
            bool boValidation = true;

            if (ValiderChamps.ValidationTextBox(TBChamp)) // Appler la fonction ValiderChamps qui se trouve dans le fichier Validation.cs
            {
                cncxBD.Open();
                string query = "UPDATE Clients SET SocieteClient = '" + txtSociete.Text + "', AdresseClient = '" + txtAdresse.Text + "', VilleClient = '" + txtVille.Text + "', ProvClient = '" + txtProvince.Text + "', CPClient = '" + txtCodePostal.Text + "', TelClient = '" + txtTelephone.Text + "', Fax = '" + txtFax.Text + "', ContactClient = '" + txtContact.Text + "', FonctionClient = '" + txtFonction.Text + "', TelContactClient = '" + txtTelContact.Text + "' WHERE CodeClient = '" + txtCode.Text + "';";
                //MessageBox.Show(query);
                cmd = new OleDbCommand(query, cncxBD);



                try    //Selon la configuration de la DB , lorsque l'usager modifie une donnée, tous les champs  doivent être entrée, sauf le Téléphone contact.
                {
                    int temp = cmd.ExecuteNonQuery();
                    cncxBD.Close();

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

                if (boValidation == true)  //si tous est correct videz les textbox et le combobox et actualise le combobox
                {
                    for (int i = 0; i < TBChamp.Length; i++)
                    {
                        TBChamp[i].Clear();
                    }

                    cboCodeclient.Items.Clear();

                    RemplirComboBox();   // APPLER la procédure RemplirCombobox
                }



            }




        }

        private void Modifier_FormClosed(object sender, FormClosedEventArgs e)
        {
            cncxBD.Close();
        }

    }
}

