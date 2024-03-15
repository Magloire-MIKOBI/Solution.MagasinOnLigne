using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.MagasinOnLigne.Core.EntitiesData
{
    public class AchatModel
    {
        public int Id { get; set; }
        public UtilisateurModel Utilisateur { get; set; }
        public int UtilisateurId { get; set; }
        public int ProduitId { get; set; }
        public int Quantite { get; set; }
        public ProduitModel Produit { get; set; }
    }
}
