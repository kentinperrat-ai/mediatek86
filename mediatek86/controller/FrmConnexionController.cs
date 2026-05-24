using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.controller
{
    public class FrmConnexionController
    {
        public Form1 frmConnexion;

        public FrmConnexionController()
        {
            frmConnexion = new Form1(this);
            frmConnexion.ShowDialog();
        }

        public void ControleConnexion(string login, string pwd)
        {
            if (login == "admin" && pwd == "1234")
            {
                MessageBox.Show("Connexion réussie !");
                frmConnexion.Hide();
            }
            else
            {
                MessageBox.Show("Erreur d'identifiants");
            }
        }
    }
}