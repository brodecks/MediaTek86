using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// classe permettant de gérer les demandes concernant les personnels
    /// </summary>
    public class PersonnelAccess
    {
        /// <summary>
        /// instance unique d l'accès au données
        /// </summary>
        private readonly Access access = null;
        /// <summary>
        /// constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }
        /// <summary>
        /// controle si un responsable se connecte
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns></returns>
        public Boolean controleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable where login = @login and pwd = SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@login", responsable.Login);
                parameters.Add("@pwd", responsable.Pwd);
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }
        /// <summary>
        /// Récupère et retourne les personnels
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            string req = @"SELECT p.idpersonnel, p.nom, p.prenom, 
                  COALESCE(p.tel, '') as tel, 
                  COALESCE(p.mail, '') as mail, 
                  s.idservice, s.nom as service
                  FROM personnel p 
                  JOIN service s ON p.idservice = s.idservice
                  ORDER BY p.idpersonnel";

            try
            {
                List<object[]> records = access.Manager.ReqSelect(req);
                foreach (object[] record in records)
                {
                    Personnel personnel = new Personnel(
                        idpersonnel: Convert.ToInt32(record[0]),
                        nom: record[1].ToString(),
                        prenom: record[2].ToString(),
                        tel: record[3].ToString(), // Gère déjà les NULL via COALESCE
                        mail: record[4].ToString(),
                        service: new Service(
                            idservice: Convert.ToInt32(record[5]),
                            nom: record[6].ToString()
                        )
                    );
                    lesPersonnels.Add(personnel);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur accès BD : " + e.Message);
                // Retourner une liste vide plutôt qu'arrêter l'application
                return new List<Personnel>();
            }
            return lesPersonnels;
        }
        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.Idpersonnel);
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
        /// Demande d'ajout un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
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
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("idpersonnel", personnel.Idpersonnel);
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.Idservice);
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
