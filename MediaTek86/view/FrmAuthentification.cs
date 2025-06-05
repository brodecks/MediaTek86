using System;
using System.Collections.Generic;
using MediaTek86.controller;
using MediaTek86.model;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;
        /// <summary>
        /// construction des composants graphique et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }
        /// <summary>
        /// initialisations :
        /// création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }
        /// <summary>
        /// demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleAuthentification(responsable))
                {
                    FrmMediatek frm = new FrmMediatek();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte.", "Alerte");
                }
            }
        }
    }
}
