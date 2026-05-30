using mediatek86.bddmanager;
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
            // On ne hache plus, on utilise 'pwd' tel quel
            // Votre requête compare maintenant la saisie avec le '1234' en clair
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
        public List<object[]> GetPersonnel()
        {
            // On retourne la liste d'object[] comme attendu par la signature de BddManager
    return Manager.ReqSelect("SELECT * FROM personnel;");
}

    }
}