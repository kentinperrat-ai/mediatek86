
using mediatek86.dal;
using mediatek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les developpeurs
    /// </summary>
    public class DeveloppeurAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public DeveloppeurAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les développeurs
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Developpeur> GetLesDeveloppeurs()
        {
            List<Developpeur> lesDeveloppeurs = new List<Developpeur>();
            if (access.Manager != null)
            {
                string req = "select d.iddeveloppeur as iddeveloppeur, d.nom as nom, d.prenom as prenom, d.tel as tel, d.mail as mail, p.idprofil as idprofil, p.nom as profil ";
                req += "from developpeur d join profil p on (d.idprofil = p.idprofil) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        for (int i = 0; i < records.Count; i++)
                        {
                            object[] record = records[i];
                            lesDeveloppeurs.Add(new Developpeur
                            {
                                Iddeveloppeur = int.Parse(record[0].ToString()),
                                Nom = record[1].ToString(),
                                Prenom = record[2].ToString(),
                                Tel = record[3].ToString(),
                                Mail = record[4].ToString(),
                                Idprofil = int.Parse(record[5].ToString()),
                                Profil = record[6].ToString()
                            });
                        }
                    } 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            } /
            return lesDeveloppeurs;
        }

        /// <summary>
        /// Demande de suppression d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à supprimer</param>
        public void DelDepveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "delete from developpeur where iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@iddeveloppeur", developpeur.Iddeveloppeur);
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
        /// Demande d'ajout un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à ajouter</param>
        public void AddDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "insert into developpeur(nom, prenom, tel, mail, pwd, idprofil) ";
                req += "values (@nom, @prenom, @tel, @mail, SHA2(@pwd, 256), @idprofil);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", developpeur.Nom);
                parameters.Add("@prenom", developpeur.Prenom);
                parameters.Add("@tel", developpeur.Tel);
                parameters.Add("@mail", developpeur.Mail);
                parameters.Add("@pwd", developpeur.Nom);
                parameters.Add("@idprofil", developpeur.Idprofil);
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
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="developpeur">objet developpeur à modifier</param>
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "update developpeur set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idprofil = @idprofil ";
                req += "where iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idDeveloppeur", developpeur.Iddeveloppeur);
                parameters.Add("@nom", developpeur.Nom);
                parameters.Add("@prenom", developpeur.Prenom);
                parameters.Add("@tel", developpeur.Tel);
                parameters.Add("@mail", developpeur.Mail);
                parameters.Add("@idprofil", developpeur.Idprofil);
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
        /// Demande de modification du pwd
        /// </summary>
        /// <param name="developpeur">objet developpeur avec nouveau pwd</param>
        public void UpdatePwd(Developpeur developpeur)
        {
            if (access.Manager != null)
            {
                string req = "update developpeur set pwd = SHA2(@pwd, 256) ";
                req += "where iddeveloppeur = @iddeveloppeur;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idDeveloppeur", developpeur.Iddeveloppeur);
                parameters.Add("@pwd", developpeur.Pwd);
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