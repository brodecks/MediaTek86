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
    /// controleur de FrmAuthentification
    /// </summary>
    public class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// récupère l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            personnelAccess = new PersonnelAccess();
        }
        /// <summary>
        /// vérifie l'authentification
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return personnelAccess.controleAuthentification(responsable);
        }
    }
}
