using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    public class Personnel
    {
        public int Id { get; set; } //propriété pour l'ID
        public string Nom { get; set; } //propriété pour le Nom
        public string Prenom { get; set; }// propriété pour le prénom
        public string Tel { get; set; }  // propriété pour le tel
        public string Mail { get; set; } // propriétés pour le mail
        public string Service { get; set; } //propriété 
    

        public Personnel(int id, string nom, string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }
    }
}
