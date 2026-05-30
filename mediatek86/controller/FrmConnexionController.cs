using mediatek86.dal;
using mediatek86.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.controller
{
    /// <summary>
    /// Contrôleur gérant la connexion.
    /// </summary>
    public class FrmConnexionController
    {
        public Form1 frmConnexion;

        /// <summary>
        /// Constructeur.
        /// </summary>
        public FrmConnexionController()
        {
            frmConnexion = new Form1(this);
            frmConnexion.ShowDialog();
        }

        /// <summary>
        /// Vérifie les identifiants et navigue vers l'application si succès.
        /// </summary>
        public void ControleConnexion(string login, string pwd)
        {
            // Appel à la base de données via le Singleton Access
            if (Access.GetInstance().Authentifier(login, pwd))
            {
                MessageBox.Show("Connexion réussie !");
                frmConnexion.Hide();

                // Ouverture de la fenêtre principale
                FrmPersonnel leFormPersonnel = new FrmPersonnel();
                leFormPersonnel.Show();
            }
            else
            {
                MessageBox.Show("Erreur d'identifiants");
            }
        }
    }
}