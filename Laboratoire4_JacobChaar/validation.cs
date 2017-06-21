using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoire4_JacobChaar
{
    public class validation
    {
       
       
        //Fonction qui vérifie si le contenue des textbox contient des guillet simple ' 
        //Paramètre: pChamps
        //Valeur de retour  Vrai ou faux
       public bool ValidationTextBox(TextBox[] pChamps)
        {
            for (int i=0; i < pChamps.Length; i++)
            {
                  string stValidation = pChamps[i].ToString();

            if (stValidation.Contains((char)39) || stValidation.Contains((char)34))
            {
                MessageBox.Show("Veuillez ne pas entrer des guillmet simple ou de guillet double:, dans les champs ");
                pChamps[i].Focus();
                return false;
            }
            }
        
             return true;
        }

    }
}
