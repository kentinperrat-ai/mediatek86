
using mediatek86.bddmanager;
using mediatek86.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.dal
{
    /// <summary>
    /// Singleton : classe d'accès à BddManager
    /// </summary>
    public class Access
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static readonly string connectionString = "server=localhost;user id=root;password=;database=mediatek86;";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionString);
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }
        public bool Authentifier(string login, string pwd)
        {
            
          //recupere  mot de passe et login de la table responsable
            string req = "SELECT * FROM responsable WHERE login = '" + login + "' AND pwd = '" + pwd + "';";

            // On récupère le résultat
            var result = Manager.ReqSelect(req);

            // On vérifie si la liste n'est pas nulle et contient au moins un élément
            return (result != null && result.Count > 0);
        }
        /// <summary>
        /// Récupère tout le personnel.
        /// </summary>
        /// <returns>Liste des membres du personnel.</returns>
        /// <summary>
        /// Récupère tout le personnel.
        /// </summary>
        /// <returns>Liste des membres du personnel.</returns>
        public List<Personnel> GetPersonnel()
        {
            string requete = "SELECT * FROM personnel";
            // On suppose que 'Manager' est l'objet qui exécute vos requêtes
            var result = Manager.ReqSelect(requete);

            List<Personnel> lesPersonnels = new List<Personnel>();

            if (result != null)
            {
                foreach (var row in result)
                {
                    // Remplacez les indices [0], [1]... par les indices correspondant à votre table SQL
                    lesPersonnels.Add(new Personnel(
                        Convert.ToInt32(row[0]),
                        row[1].ToString(),
                        row[2].ToString()
                    // ... ajoutez les autres champs ici
                    ));
                }
            }
            return lesPersonnels;
        }


        public bool AjouterPersonnel(string nom, string prenom, string tel, string mail, int idService)
        {
            // Attention : utilisez des guillemets simples pour les chaînes SQL
            string req = "INSERT INTO personnel (nom, prenom, tel, mail, id_service) VALUES ('" + nom + "', '" + prenom + "', '" + tel + "', '" + mail + "', " + idService + ");";
            return Manager.ReqUpdate(req) > 0;
        }
        /// <summary>
        /// Récupère la liste des services.
        /// </summary>
        /// <returns>Liste des services.</returns>
        public List<Service> GetServices()
        {
            string requete = "SELECT * FROM service";
            var result = Manager.ReqSelect(requete);
            List<Service> lesServices = new List<Service>();

            if (result != null)
            {
                foreach (var row in result)
                {
                    // Adaptez les indices [0] et [1] selon l'ordre de vos colonnes dans la table service
                    lesServices.Add(new Service(
                        Convert.ToInt32(row[0]),
                        row[1].ToString()
                    ));
                }
            }
            return lesServices;
        }

    }

}