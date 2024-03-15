using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MagasinOnLigne.POCO.Entities
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        //public ICollection<Achat>? Achats { get; set; }
    }
}
