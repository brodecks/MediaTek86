using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    public partial class FrmAbsence : Form
    {
        private Boolean EnCoursDeModifAbsence = false;
        private BindingSource bdgAbsences = new BindingSource();
        private FrmAbsenceController controller;
        private readonly String titreFenetreInformation = "Information";
        /// <summary>
        /// Constructeur de la fenêtre FrmAbsence
        /// </summary>
        public FrmAbsence()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            controller = new FrmAbsenceController();
            RemplirListeAbsences();
            EnCourseModifAbsence(false);
        }
        private void RemplirListeAbsences()
        {
            List<Absence> lesAbsences = controller.GetLesAbsences();
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsence.DataSource = bdgAbsences;
            dgvAbsence.Columns["idabsence"].Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                EnCourseModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                txtIdpersonnel.Text = absence.IdPersonnel.ToString();
                txtDatedebut.Text = absence.DateDebut;
                txtDatefin.Text = absence.DateFin;
                txtMotif.Text = absence.Motif.ToString();
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + absence.IdAbsence +" ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Vérification des champs vides
            if (string.IsNullOrEmpty(txtIdpersonnel.Text) ||
                string.IsNullOrEmpty(txtDatedebut.Text) ||
                string.IsNullOrEmpty(txtDatefin.Text) ||
                string.IsNullOrEmpty(txtMotif.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
                return;
            }

            try
            {
                // Conversion sécurisée des valeurs
                if (!int.TryParse(txtIdpersonnel.Text, out int idPersonnel))
                {
                    MessageBox.Show("L'ID personnel doit être un nombre valide.", titreFenetreInformation);
                    return;
                }

                if (!int.TryParse(txtMotif.Text, out int idMotif))
                {
                    MessageBox.Show("Le motif doit être un ID numérique valide.", titreFenetreInformation);
                    return;
                }

                // Validation des dates (ajustez le format selon vos besoins)
                DateTime dateDebut, dateFin;
                if (!DateTime.TryParse(txtDatedebut.Text, out dateDebut))
                {
                    MessageBox.Show("Format de date début invalide.", titreFenetreInformation);
                    return;
                }

                if (!DateTime.TryParse(txtDatefin.Text, out dateFin))
                {
                    MessageBox.Show("Format de date fin invalide.", titreFenetreInformation);
                    return;
                }

                if (EnCoursDeModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.IdPersonnel = idPersonnel;
                    absence.DateDebut = dateDebut.ToString("yyyy-MM-dd"); // Format standard
                    absence.DateFin = dateFin.ToString("yyyy-MM-dd");
                    absence.Motif = idMotif;
                    controller.UpdateAbsence(absence);
                }
                else
                {
                    Absence absence = new Absence(
                        0, // ID absence (nouvelle absence)
                        idPersonnel,
                        dateDebut.ToString("yyyy-MM-dd"),
                        dateFin.ToString("yyyy-MM-dd"),
                        idMotif
                    );
                    controller.AddAbsence(absence);
                }

                RemplirListeAbsences();
                EnCourseModifAbsence(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'opération : {ex.Message}", titreFenetreInformation);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifAbsence(false);
            }
        }
        private void EnCourseModifAbsence(Boolean modif)
        {
            EnCoursDeModifAbsence = modif;
            gbAbsence.Enabled = !modif;
            if (modif)
            {
                gbAbsence.Text = "modifier un développeur";
            }
            else
            {
                gbAbsence.Text = "ajouter un développeur";
                txtIdpersonnel.Text = "";
                txtDatedebut.Text = "";
                txtDatefin.Text = "";
                txtMotif.Text = "";
            }
        }
    }
}
