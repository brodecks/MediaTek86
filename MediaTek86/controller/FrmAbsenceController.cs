using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    /// <summary>
    /// controleur de FrmAbsence
    /// </summary>
    public class FrmAbsenceController
    {
        private readonly AbsenceAccess absenceAccess;
        /// <summary>
        /// récupère les accès aux données
        /// </summary>
        public FrmAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
        }
        /// <summary>
        /// récupère et retourne la liste des absences
        /// </summary>
        /// <returns></returns>
        public List<Absence> GetLesAbsences()
        {
            return absenceAccess.GetLesAbsences();
        }
        /// <summary>
        /// demande de supprimer une absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
        /// <summary>
        /// demande d'ajouter une absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }
        /// <summary>
        /// demande de mettre à jour une absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAccess.UpdateAbsence(absence);
        }
    }
}
