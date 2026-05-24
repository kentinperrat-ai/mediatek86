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
    public partial class Form1 : Form
    {
        private FrmConnexionController controller;

        public Form1(FrmConnexionController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string login = txtIdentifiant.Text;
            string pwd = txtMdp.Text;

            this.controller.ControleConnexion(login, pwd);
        }

        private void btnSeConnecter_Click_1(object sender, EventArgs e)
        {
            string login = txtIdentifiant.Text;
            string pwd = txtMdp.Text; 
            this.controller.ControleConnexion(login, pwd);
        }
    }
}
