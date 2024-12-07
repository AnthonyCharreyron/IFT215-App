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

        // Fonction qui permet de cr�er des donn�es tests
        static void initData()
        {
            compte = new Compte(1, "John Doe", 200);
            compte.Deposer(new DateTime(2024, 10, 30), 200, "Client freelance", "Valid�", Categorie.Revenus, "Virement", "Paiement prestation");
            compte.Retirer(new DateTime(2024, 11, 1), 90, "Super C", "Valid�", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 2), 60, "Hydro-Qu�bec", "Valid�", Categorie.Logement, "Virement", "Facture �lectricit�");
            compte.Deposer(new DateTime(2024, 11, 3), 1000, "Employeur", "Valid�", Categorie.Revenus, "Virement", "Salaire du mois de novembre");
            compte.Retirer(new DateTime(2024, 11, 4), 300, "Immobilier", "Valid�", Categorie.Logement, "Virement", "Travaux appartement");
            compte.Deposer(new DateTime(2024, 11, 5), 60, "SAQ", "Valid�", Categorie.Loisirs, "Carte bancaire", "Achat de vin pour une soir�e");
            compte.Retirer(new DateTime(2024, 11, 7), 25, "Uber", "Valid�", Categorie.Transports, "Carte bancaire", "Course pour rentrer chez soi");
            compte.Deposer(new DateTime(2024, 11, 8), 85, "Provigo", "Valid�", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 9), 200, "Apple Store", "Valid�", Categorie.Loisirs, "Carte bancaire", "Achat d'accessoires pour iPhone");
            compte.Deposer(new DateTime(2024, 11, 10), 50, "Pharmaprix", "Valid�", Categorie.Sant�, "Carte bancaire", "Achat de m�dicaments");
            compte.Retirer(new DateTime(2024, 11, 12), 400, "Fournisseur internet", "Valid�", Categorie.Logement, "Carte bancaire", "Facture annuelle internet");
            compte.Deposer(new DateTime(2024, 11, 15), 150, "Client freelance", "Valid�", Categorie.Revenus, "Virement", "Paiement prestation");
            compte.Retirer(new DateTime(2024, 11, 16), 50, "Centre sportif", "Valid�", Categorie.Loisirs, "Carte bancaire", "Inscription � la piscine");
            compte.Deposer(new DateTime(2024, 11, 17), 40, "Bureau en Gros", "Valid�", Categorie.Autre, "Carte bancaire", "Achat de fournitures de bureau");
            compte.Retirer(new DateTime(2024, 11, 19), 60, "Essence", "Valid�", Categorie.Transports, "Carte bancaire", "Plein d'essence");
            compte.Deposer(new DateTime(2024, 11, 20), 100, "IGA", "Valid�", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 21), 15, "Th��tre", "Valid�", Categorie.Loisirs, "Esp�ce", "Billet de spectacle");
            compte.Deposer(new DateTime(2024, 11, 22), 75, "Rona", "Valid�", Categorie.Autre, "Carte bancaire", "Achat de mat�riel pour bricolage");
            compte.Retirer(new DateTime(2024, 11, 23), 50, "Transport collectif", "Valid�", Categorie.Transports, "Carte bancaire", "Recharge de carte Opus");
            compte.Retirer(new DateTime(2024, 11, 24), 30, "Restaurant", "Valid�", Categorie.Loisirs, "Esp�ce", "Sortie restaurant entre amis");
            compte.Deposer(new DateTime(2024, 11, 25), 200, "Revenu locatif", "Valid�", Categorie.Revenus, "Virement", "Paiement locataire");
            compte.Retirer(new DateTime(2024, 11, 26), 90, "Etsy", "Valid�", Categorie.Loisirs, "Carte bancaire", "Achat d'articles artisanaux");
            compte.Deposer(new DateTime(2024, 11, 27), 30, "Maxi", "Valid�", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 11, 28), 25, "M�tro", "En cours", Categorie.Transports, "Esp�ce", "Recharge de carte de transport");
            compte.Deposer(new DateTime(2024, 11, 30), 50, "D�panneur", "Valid�", Categorie.Alimentation, "Esp�ce", "Achat de produits de d�pannage");

            compte.Deposer(new DateTime(2024, 12, 5), 1000, "Employeur", "Valid�", Categorie.Revenus, "Virement", "Salaire du mois d'octobre");
            compte.Deposer(new DateTime(2024, 12, 7), 80, "Super C", "Valid�", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 12, 9), 45, "Netflix", "Valid�", Categorie.Loisirs, "Virement", "Abonnement mensuel");
            compte.Retirer(new DateTime(2024, 12, 10), 800, "Propri�taire", "Valid�", Categorie.Logement, "Virement", "Loyer d'octobre");
            compte.Deposer(new DateTime(2024, 12, 12), 35, "Pharmacie Jean Coutu", "Valid�", Categorie.Sant�, "Carte bancaire", "Achat de vitamines");
            compte.Retirer(new DateTime(2024, 12, 14), 205, "STM", "Valid�", Categorie.Transports, "Carte bancaire", "Achat d'une carte de m�tro");
            compte.Deposer(new DateTime(2024, 12, 15), 120, "Revenu locatif", "Valid�", Categorie.Revenus, "Virement", "Paiement locataire");
            compte.Retirer(new DateTime(2024, 12, 18), 100, "Amazon", "Valid�", Categorie.Loisirs, "Carte bancaire", "Achat de livres");
            compte.Deposer(new DateTime(2024, 12, 19), 70, "IGA", "Valid�", Categorie.Alimentation, "Carte bancaire", "Courses alimentaires");
            compte.Retirer(new DateTime(2024, 12, 20), 25, "Spotify", "Valid�", Categorie.Loisirs, "Virement", "Abonnement Spotify Premium");
            compte.Deposer(new DateTime(2024, 12, 22), 50, "SAAQ", "Valid�", Categorie.Autre, "Carte bancaire", "Renouvellement permis de conduire");
            compte.Retirer(new DateTime(2024, 12, 25), 200, "Centre dentaire", "Valid�", Categorie.Sant�, "Carte bancaire", "D�tartrage dentaire");
            compte.Retirer(new DateTime(2024, 12, 27), 15, "Cin�plex", "Valid�", Categorie.Loisirs, "Esp�ce", "Sortie cin�ma");
        }
    }
}