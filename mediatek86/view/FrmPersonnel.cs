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
            // Récupére la liste des services depuis la BDD
            List<Service> lesServices = Access.GetInstance().GetServices();

            // Configuration de la ComboBox
            cboService.DataSource = lesServices;
            cboService.DisplayMember = "nom"; // Ce que l'utilisateur voit
            cboService.ValueMember = "id";    // Ce que le programme utilise 
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // On récupère l'ID du service sélectionné dans la ComboBox
            int idService = (int)cboService.SelectedValue;

            // On ajoute le personnel avec le bon ID
            Access.GetInstance().AjouterPersonnel(txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, idService);

            // On rafraîchit le tableau
            ChargerTableau();
        }

        private void ChargerTableau()
        {
            // On remet le DataSource à null pour rafraîchir complètement l'affichage
            dgvPersonnel.DataSource = null;
            dgvPersonnel.DataSource = Access.GetInstance().GetPersonnel();
        }
    }
}
