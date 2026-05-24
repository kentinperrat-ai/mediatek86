namespace mediatek86.model
{
    /// <summary>
    /// Classe métier représentant un profil utilisateur au sein de l'application.
    /// </summary>
    public class Profil
    {
        /// <summary>
        /// Obtient ou définit l'identifiant unique du profil.
        /// </summary>
        public int Idprofil { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du profil.
        /// </summary>
        public string Nom { get; set; } 
    }
}