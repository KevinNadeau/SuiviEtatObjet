using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviEtatObjet.Utilisateurs
{
    public class HistoriqueUtilisateur
    {
        public int Id { get; set; }
        public int UtilisateurId { get; set; }
        public string AncienEtat { get; set; } = "Inatif";
        public string NouvelEtat { get; set; }
        public DateTime DateModification { get; set; }
        public Utilisateur User { get; set; }
    }
}
