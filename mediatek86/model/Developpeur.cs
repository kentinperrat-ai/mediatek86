using mediatek86.model;
using System.Collections.Generic;


namespace mediatek86.model
{
    /// <summary>
    /// Classe métier représentant un développeur de l'application.
    /// </summary>
    public class Developpeur
    {
        /// <summary>
        /// Identifiant unique du développeur.
        /// </summary>
        public int Iddeveloppeur { get; set; }

        /// <summary>
        /// Nom de famille du développeur.
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du développeur.
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Numéro de téléphone du développeur.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Adresse mail du développeur.
        /// </summary>
        public string Mail { get; set; }

        /// <summary>
        /// Identifiant du profil associé au développeur.
        /// </summary>
        public int Idprofil { get; set; }

        /// <summary>
        /// Nom du profil du développeur.
        /// </summary>
        public string Profil { get; set; }

        /// <summary>
        /// Mot de passe du développeur.
        /// </summary>
        public string Pwd { get; set; }
    }
}