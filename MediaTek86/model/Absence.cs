using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe représentant une absence d'un personnel
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Identifiant de l'absence
        /// </summary>
        public int IdAbsence { get;}
        /// <summary>
        /// Identifiant du personnel concerné par l'absence
        /// </summary>
        public int IdPersonnel { get; set; }
        /// <summary>
        /// Date de début de l'absence
        /// </summary>
        public string DateDebut { get; set; }
        /// <summary>
        /// Date de fin de l'absence
        /// </summary>
        public string DateFin { get; set; }
        /// <summary>
        /// Motif de l'absence
        /// </summary>
        public int Motif { get; set; }
        /// <summary>
        /// Constructeur de la classe Absence
        /// </summary>
        /// <param name="idabsence"></param>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public Absence(int idabsence,int idpersonnel, string datedebut, string datefin, int idmotif)
        {
            this.IdAbsence = idabsence;
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = idmotif;
        }
    }
}
