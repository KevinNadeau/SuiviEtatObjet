using SuiviEtatObjet.Utilisateurs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviEtatObjet.Suivi
{
    public interface IsuiviChangementEtat
    {
       void MiseAJour(Utilisateur user, string ancienEtat, string nouvelEtat);
    }
}
