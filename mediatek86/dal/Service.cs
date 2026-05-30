namespace mediatek86.dal
{
    public class Service
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        // Ajoutez ce constructeur :
        public Service(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}