using AppliBoursoBank.Modeles;
using AppliBoursoBank.Controleurs;

namespace AppliBoursoBank
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        public static Compte compte;



        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            initData();
            var controleur = new Controleur();
            controleur.LancerApplication();
        }

        // Fonction qui permet de créer des données tests
        static void initData()
        {
            compte = new Compte(1, "John Doe", 200);
            compte.Deposer(new DateTime(2024, 10, 30), 200, "Client freelance", "Validé", Categorie.Revenus, "Virement", "Paiement prestation");
            compte.Retirer(new DateTime(2024, 11, 1), 90, "Super C", "Validé", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 2), 60, "Hydro-Québec", "Validé", Categorie.Logement, "Virement", "Facture électricité");
            compte.Deposer(new DateTime(2024, 11, 3), 1000, "Employeur", "Validé", Categorie.Revenus, "Virement", "Salaire du mois de novembre");
            compte.Retirer(new DateTime(2024, 11, 4), 300, "Immobilier", "Validé", Categorie.Logement, "Virement", "Travaux appartement");
            compte.Deposer(new DateTime(2024, 11, 5), 60, "SAQ", "Validé", Categorie.Loisirs, "Carte bancaire", "Achat de vin pour une soirée");
            compte.Retirer(new DateTime(2024, 11, 7), 25, "Uber", "Validé", Categorie.Transports, "Carte bancaire", "Course pour rentrer chez soi");
            compte.Deposer(new DateTime(2024, 11, 8), 85, "Provigo", "Validé", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 9), 200, "Apple Store", "Validé", Categorie.Loisirs, "Carte bancaire", "Achat d'accessoires pour iPhone");
            compte.Deposer(new DateTime(2024, 11, 10), 50, "Pharmaprix", "Validé", Categorie.Santé, "Carte bancaire", "Achat de médicaments");
            compte.Retirer(new DateTime(2024, 11, 12), 400, "Fournisseur internet", "Validé", Categorie.Logement, "Carte bancaire", "Facture annuelle internet");
            compte.Deposer(new DateTime(2024, 11, 15), 150, "Client freelance", "Validé", Categorie.Revenus, "Virement", "Paiement prestation");
            compte.Retirer(new DateTime(2024, 11, 16), 50, "Centre sportif", "Validé", Categorie.Loisirs, "Carte bancaire", "Inscription à la piscine");
            compte.Deposer(new DateTime(2024, 11, 17), 40, "Bureau en Gros", "Validé", Categorie.Autre, "Carte bancaire", "Achat de fournitures de bureau");
            compte.Retirer(new DateTime(2024, 11, 19), 60, "Essence", "Validé", Categorie.Transports, "Carte bancaire", "Plein d'essence");
            compte.Deposer(new DateTime(2024, 11, 20), 100, "IGA", "Validé", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 21), 15, "Théâtre", "Validé", Categorie.Loisirs, "Espèce", "Billet de spectacle");
            compte.Deposer(new DateTime(2024, 11, 22), 75, "Rona", "Validé", Categorie.Autre, "Carte bancaire", "Achat de matériel pour bricolage");
            compte.Retirer(new DateTime(2024, 11, 23), 50, "Transport collectif", "Validé", Categorie.Transports, "Carte bancaire", "Recharge de carte Opus");
            compte.Retirer(new DateTime(2024, 11, 24), 30, "Restaurant", "Validé", Categorie.Loisirs, "Espèce", "Sortie restaurant entre amis");
            compte.Deposer(new DateTime(2024, 11, 25), 200, "Revenu locatif", "Validé", Categorie.Revenus, "Virement", "Paiement locataire");
            compte.Retirer(new DateTime(2024, 11, 26), 90, "Etsy", "Validé", Categorie.Loisirs, "Carte bancaire", "Achat d'articles artisanaux");
            compte.Deposer(new DateTime(2024, 11, 27), 30, "Maxi", "Validé", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 28), 25, "Métro", "En cours", Categorie.Transports, "Espèce", "Recharge de carte de transport");
            compte.Deposer(new DateTime(2024, 11, 30), 50, "Dépanneur", "Validé", Categorie.Alimentation, "Espèce", "Achat de produits de dépannage");

            compte.Deposer(new DateTime(2024, 12, 5), 1000, "Employeur", "Validé", Categorie.Revenus, "Virement", "Salaire du mois d'octobre");
            compte.Deposer(new DateTime(2024, 12, 7), 80, "Super C", "Validé", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 12, 9), 45, "Netflix", "Validé", Categorie.Loisirs, "Virement", "Abonnement mensuel");
            compte.Retirer(new DateTime(2024, 12, 10), 800, "Propriétaire", "Validé", Categorie.Logement, "Virement", "Loyer d'octobre");
            compte.Deposer(new DateTime(2024, 12, 12), 35, "Pharmacie Jean Coutu", "Validé", Categorie.Santé, "Carte bancaire", "Achat de vitamines");
            compte.Retirer(new DateTime(2024, 12, 14), 205, "STM", "Validé", Categorie.Transports, "Carte bancaire", "Achat d'une carte de métro");
            compte.Deposer(new DateTime(2024, 12, 15), 120, "Revenu locatif", "Validé", Categorie.Revenus, "Virement", "Paiement locataire");
            compte.Retirer(new DateTime(2024, 12, 18), 100, "Amazon", "Validé", Categorie.Loisirs, "Carte bancaire", "Achat de livres");
            compte.Deposer(new DateTime(2024, 12, 19), 70, "IGA", "Validé", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 12, 20), 25, "Spotify", "Validé", Categorie.Loisirs, "Virement", "Abonnement Spotify Premium");
            compte.Deposer(new DateTime(2024, 12, 22), 50, "SAAQ", "Validé", Categorie.Autre, "Carte bancaire", "Renouvellement permis de conduire");
            compte.Retirer(new DateTime(2024, 12, 25), 200, "Centre dentaire", "Validé", Categorie.Santé, "Carte bancaire", "Détartrage dentaire");
            compte.Retirer(new DateTime(2024, 12, 27), 15, "Cinéplex", "Validé", Categorie.Loisirs, "Espèce", "Sortie cinéma");
        }
    }
}