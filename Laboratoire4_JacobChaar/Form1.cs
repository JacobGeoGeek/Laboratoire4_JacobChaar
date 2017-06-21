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

    public partial class Form1 : Form
    {
        OleDbConnection cncxBD = new OleDbConnection("Data Source=Commandes.mdb;Provider=Microsoft.Jet.OLEDB.4.0"); //connection vers la DB chemin
         OleDbDataAdapter adpBD; //remplir la DB (va chercher les données)
         DataSet dsUsagers; //Celui qui fais une copie de la DB
         DataView dvUsagers; //Permert de présenter les données 
     

        int inRange; // variable Indique l'emplacement actuel dans le datagridview
        public Form1()
        {
            InitializeComponent();

          
        }

        //Procédure pour afficher les données de la DB dans le dataGridView
        //Aucun paramètre
        //aucune valeur de retour
        void Afficher()
        {
            //connexion à la BD
          
            adpBD = new OleDbDataAdapter("SELECT * FROM Clients", cncxBD); //SELECT NoÉlève, NomÉlève...   WHERE PrénomÉlève LIKE 'k%'
            dsUsagers = new DataSet();
            dvUsagers = new DataView();

            try
            {
                //récupérer la table Client
                 adpBD.Fill(dsUsagers, "Clients");
                    dvUsagers = dsUsagers.Tables["Clients"].DefaultView;
                 dvUsagers.Sort = "Codeclient";

                //Afficher les données
                 dataGridView1.DataSource = null;
                 dataGridView1.DataSource = dvUsagers.Table;
                 cncxBD.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
       

        }
        //Procédure qui affiche les résultats des dans les textbox 
        //paramètre: aucun
        //valeur de retour: aucun
        void DonnedansleTextbox()
        {
            txtCodeClient.Text = dataGridView1.Rows[inRange].Cells[0].Value.ToString();
            txtSocieteClient.Text = dataGridView1.Rows[inRange].Cells[1].Value.ToString();
            txtContactClient.Text = dataGridView1.Rows[inRange].Cells[8].Value.ToString();
            txtTelContactClient.Text = dataGridView1.Rows[inRange].Cells[10].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Afficher(); // Appeler la procédure afficher

            DonnedansleTextbox(); //appeler la procédure Donnedans le textbox
            inRange = dataGridView1.CurrentCell.RowIndex;  
        }

  

 

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            //Compteur permettant de retourner en arrière dans le DataGridView
            if (inRange < dataGridView1.RowCount)
            {
                if (inRange > 0)
                {
                    dataGridView1.Rows[inRange].Selected = false;
                    dataGridView1.Rows[--inRange].Selected = true;
                    btnPrecedent.Enabled = true;
                    btnSuivant.Enabled = true;

                    DonnedansleTextbox();
                   
                }
                else
                {
                    btnPrecedent.Enabled = false;   //Si l'usager se situe dans la première ligne de la DB, désactiver le button 
                }
            

            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            //le même compteur permettant d'aller au donnée sivantes
            if (inRange < dataGridView1.RowCount-2)
            {
                dataGridView1.Rows[inRange].Selected = false;
                dataGridView1.Rows[++inRange].Selected = true;
                btnPrecedent.Enabled = true;
                btnSuivant.Enabled = true;

                DonnedansleTextbox();

            }
            else
            {
                btnSuivant.Enabled = false;  //si l'usager est rendue à la dernième ligne désactiver le button
            }
          
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            cncxBD.Close();  //dès qu'on change de formulaire ferme le DB
            Modifier fModifer = new Modifier(); //ouvre le formulaire modifer
            fModifer.ShowDialog();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            cncxBD.Close();
            Ajouter fAjouter = new Ajouter();   //ouver le formulaire Ajouter
            fAjouter.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            cncxBD.Close();
            Supprimer fSupprimer = new Supprimer();    //Ouvre le Formulaire Supprmier
            fSupprimer.ShowDialog();
        }

    

        

        private void Form1_Activated(object sender, EventArgs e)
        {
            Afficher();
            dataGridView1.Refresh();   //Mettre à jours le datagridview
        }
    }
}
