using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MagasinOnLigne.POCO.Entities
{
    public class Achat
    {
        public int Id { get; set; }
        public Utilisateur Utilisateur { get; set; }
        public int UtilisateurId { get; set; }
        public int ProduitId { get; set; }
        public int Quantite { get; set; }
        public Produit Produit { get; set; }
    }
}
