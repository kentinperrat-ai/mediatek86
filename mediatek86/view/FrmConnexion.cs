using mediatek86.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86
{
    /// <summary>
    /// Formulaire de connexion à l'application.
    /// </summary>
    public partial class Form1 : Form
    {
        // --- Propriétés ---
        private FrmConnexionController controller;

        // --- Constructeur ---
        /// <summary>Constructeur du formulaire de connexion.</summary>
        public Form1(FrmConnexionController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        // --- Événements ---
        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            // On récupère les valeurs saisies par l'utilisateur
            string login = txtIdentifiant.Text;
            string pwd = txtMdp.Text;

            // On délègue la vérification au contrôleur
            this.controller.ControleConnexion(login, pwd);
        }
    }
    }

