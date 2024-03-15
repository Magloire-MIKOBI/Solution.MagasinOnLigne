using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MagasinOnLigne.POCO.Entities
{
    public class Produit
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public float Prix { get; set; }
        public int Quantite { get; set; }
        public Categorie Categorie { get; set; }
        public int CategorieId { get; set; }
        
        //public ICollection<Achat>? Achats { get; set; }
    }
}
