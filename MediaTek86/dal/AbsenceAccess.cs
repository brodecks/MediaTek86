using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// instance unique d l'accès au données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns></returns>
        public List<Absence> GetLesAbsences()
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                // Requête améliorée avec COALESCE pour gérer les NULL
                string req = @"SELECT 
                      idabsence, 
                      idpersonnel, 
                      COALESCE(datedebut, '00-01-01') as datedebut,
                      COALESCE(datefin, '00-01-01') as datefin,
                      idmotif
                      FROM absence
                      ORDER BY datedebut, datefin;";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            // Conversion sécurisée avec vérification NULL
                            Absence absence = new Absence(
                                idabsence: record[0] != DBNull.Value ? Convert.ToInt32(record[0]) : 0,
                                idpersonnel: record[1] != DBNull.Value ? Convert.ToInt32(record[1]) : 0,
                                datedebut: record[2]?.ToString() ?? "00-01-01",
                                datefin: record[3]?.ToString() ?? "00-01-01",
                                idmotif: record[4] != DBNull.Value ? Convert.ToInt32(record[4]) : 0
                            );
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    // Meilleure gestion d'erreur
                    Console.WriteLine($"Erreur lors du chargement des absences : {e.Message}");
                    // Retourne une liste vide au lieu de quitter l'application
                    return new List<Absence>();
                }
            }
            return lesAbsences;
        }
        /// <summary>
        /// demande de supprimer une absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idabsence = @idabsence;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idabsence", absence.IdAbsence);
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// demande un ajout d'absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
        /// <summary>
        /// demande de mettre à jour une absence dans la base de données
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "update absence set idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", absence.IdPersonnel },
                    { "@datedebut", absence.DateDebut },
                    { "@datefin", absence.DateFin },
                    { "@idmotif", absence.Motif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
