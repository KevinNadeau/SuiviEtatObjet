using SuiviEtatObjet.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviEtatObjet.Suivi
{
    public class HistoriqueSuivi : IsuiviChangementEtat
    {
        private readonly List<HistoriqueUtilisateur> _historique;

        public HistoriqueSuivi()
        {
            _historique = new List<HistoriqueUtilisateur>();
        }

        public void MiseAJour(Utilisateur user, string ancienEtat, string nouvelEtat)
        {
            var modification = new HistoriqueUtilisateur
            {
                UtilisateurId = user.Id,
                AncienEtat = "Inatif",
                NouvelEtat = nouvelEtat,
                DateModification = DateTime.Now,
                User = user
            };
            _historique.Add(modification);
        }
        public List<HistoriqueUtilisateur> GetHistorique() => _historique;
    }
}
