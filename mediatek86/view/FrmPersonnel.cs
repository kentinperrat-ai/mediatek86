using mediatek86.dal;
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

            // C'est ici qu'on branche la base de données au tableau
            // On appelle la méthode 'GetPersonnel()' que vous avez créée dans Access.cs
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
           
        }
       
    }
}
