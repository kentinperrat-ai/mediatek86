using mediatek86.dal;
using mediatek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86.view
{
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();

            // connexion de la base de données au tableau
            
            dgvPersonnel.DataSource = Access.GetInstance().GetPersonnel();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {
            // Récupérer la liste des services depuis la BDD
            List<Service> lesServices = Access.GetInstance().GetServices();

            // Configuration de la ComboBox
            cboService.DataSource = lesServices;
            cboService.DisplayMember = "nom"; // Ce que l'utilisateur voit
            cboService.ValueMember = "id";    // Ce que le programme utilise (l'ID)
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //  ajout d'un personnel dans la BDD
            Access.GetInstance().AjouterPersonnel(txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, 1);

            //  rappelle méthode qui à le DataSource
            ChargerTableau();
        }
        private void ChargerTableau()
        {
            // vide le tableau
            dgvPersonnel.Rows.Clear();

            // On remplit directement avec les données récupérées
            // On vide le tableau avant de le remplir
            dgvPersonnel.Rows.Clear();

            // récupèration de la liste
            var lesPersonnels = Access.GetInstance().GetPersonnel();

            //  remplissage ligne par ligne
            foreach (Personnel ligne in lesPersonnels)
            {
                
                dgvPersonnel.Rows.Add(ligne.Id, ligne.Nom, ligne.Prenom);
            }
        }
    }
}
