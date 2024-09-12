using SuiviEtatObjet.Suivi;
using SuiviEtatObjet.Utilisateurs;

namespace SuiviEtatObjet
{ 

    // See https://aka.ms/new-console-template for more information
    //Console.WriteLine("Hello, World!");

    class Principale {

        //Imaginons une gestion d'un registre de états d'utilisateurs "Actif", "Inactif", "Banni"
        static void Main(string[] args)
        {
            // Création de l'objet user            
            var client = new Utilisateur { Id = 1, Nom = "Ventos", Prenom = "Eric", Pseudo = "LaChouete" };

            // Création de l'observateur d'historique
            var suivi = new HistoriqueSuivi();

            // Ajouter l'observateur à l'objet
            client.AjoutSuivi(suivi);

            // Changement d'état de l'objet 
            Console.WriteLine($"État initial: {client.Etat}");
            client.Etat = "Inactif";
            Console.WriteLine($"État modifié: {client.Etat}");

            // Autre changement d'état
            client.Etat = "Actif";
            Console.WriteLine($"État final: {client.Etat}");

            // Affichage de l'historique des modifications
            var historique = suivi.GetHistorique();
            Console.WriteLine("\nHistorique des modifications:");
            foreach (var modification in historique)
            {
                Console.WriteLine($"Utilisateur user {modification.User.Nom}, Prénom = {modification.User.Prenom}, Pseudo = {modification.User.Pseudo} : Ancien état = {modification.AncienEtat}, Nouvel état = {modification.NouvelEtat}, Date = {modification.DateModification}");
            }
            // Attente de la fin de l'exécution
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

    }
}