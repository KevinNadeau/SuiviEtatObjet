using SuiviEtatObjet.Suivi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviEtatObjet.Utilisateurs
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        //public string Etat { get; set; } = "Inactif";
        private string _etat;

        private readonly List<IsuiviChangementEtat> _suivi;

        public Utilisateur()
        {
            _suivi = new List<IsuiviChangementEtat>();
        }

        public string Etat
        {
            get => _etat;
            set
            {
                if (_etat != value)
                {
                    MajSuivi(_etat, value);
                    _etat = value;
                }
            }
        }

        public void AjoutSuivi(IsuiviChangementEtat suivi)
        {
            _suivi.Add(suivi);
        }

        private void MajSuivi(string ancienEtat, string nouvelEtat)
        {
            foreach (var suivi in _suivi)
            {
                suivi.MiseAJour(this, ancienEtat, nouvelEtat);
            }
        }
    }
}
