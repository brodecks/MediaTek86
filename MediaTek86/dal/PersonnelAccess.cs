using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    public class PersonnelAccess
    {
        //instance unique d l'accès au données
        private readonly Access access = null;
        //constructeur pour créer l'accès aux données
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
                string req = "select * from responsable where login = @login and pwd = SH2(@pwd, 256);";
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
        /// Récupère et retourne les développeurs
        /// </summary>
        /// <returns></returns>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.service as idservice, s.nom as service";
                req += "from personnel p join service s on (p.idservice = s.idservice)";
                req += "order by idpersonnel;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                            (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }
    }
}
