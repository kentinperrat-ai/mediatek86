using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        // Ajoutez les autres propriétés selon les colonnes de votre table SQL (tel, mail, idService...)

        public Personnel(int id, string nom, string prenom)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
        }
    }
}
