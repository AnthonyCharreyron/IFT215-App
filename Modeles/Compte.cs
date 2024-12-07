using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppliBoursoBank.Modeles
{
    // Création du modèle compte
    public class Compte
    {
        // Déclaration des attributs d'un compte
        private int NumeroCompte { get; }
        private string Titulaire { get; }
        public decimal Solde { get; private set; }
        public List<Transaction> Transactions { get; private set; }

        // Constructeur d'un compte
        public Compte(int numeroCompte, string titulaire, decimal soldeInitial = 0)
        {
            NumeroCompte = numeroCompte;
            Titulaire = titulaire;
            Solde = soldeInitial;
            Transactions = new List<Transaction>();
        }

        // Fonction qui ajoute une transaction qui ajoute de l'argent au solde du compte
        public void Deposer(DateTime date, decimal montant, string destinataire = "Anonyme", string etat = "En cours", Categorie categorie = Categorie.Autre, string modeTransaction = "Autre", string description = "")
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant doit être positif.", nameof(montant)); // Le montant doit être positif pour être ajouté au solde

            Solde += montant;
            Transactions.Add(new Transaction(date, montant, destinataire, etat, categorie, modeTransaction, description));
        }

        // Fonction qui ajoute une transaction qui retire de l'argent au solde du compte
        public void Retirer(DateTime date, decimal montant, string destinataire = "Anonyme", string etat = "En cours", Categorie categorie = Categorie.Autre, string modeTransaction = "Autre", string description = "")
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant doit être positif.", nameof(montant)); // Le montant doit être positif pour être retiré au solde

            if (montant > Solde)
                throw new InvalidOperationException("Fonds insuffisants pour effectuer cette opération."); // Le montant doit être inférieur au solde pour être retiré

            Solde -= montant;
            Transactions.Add(new Transaction(date, -montant, destinataire, etat, categorie, modeTransaction, description));
        }

        // Fonction qui renvoit les "count" dernières transactions du compte
        public List<Transaction> getLastsTransactions(int count)
        {
            return Transactions.OrderByDescending(t => t.Date).Take(count).ToList();
        }

        // Fonction qui renvoit les transactions filtrées par le type, la catégories, le mois et l'année
        public List<Transaction> GetMonthTransactionByType(string type, string categorie, int mois, int year)
        {
            return Transactions
                .Where(t => (type == "depense") ? t.Montant < 0 : (type == "recette") ? t.Montant >= 0 : true) // Si "all", inclure toutes les transactions
                .OrderByDescending(t => t.Date)
                .Where(t =>
                    categorie == "Toutes" || t.Categorie.ToString() == categorie)
                .Where(t => t.Date.Month == mois)
                .Where(t => t.Date.Year == year)
                .ToList();
        }

        // Fonction qui renvoit les données (catégorie et total) pour construire les graphiques, selon le type, le mois et l'année
        public IEnumerable<(string Groupe, decimal Total)> GetDepensesParCategorie(string type, int mois, int year)
        {
            // Appliquer le filtre en fonction du type
            IEnumerable<IGrouping<string, Transaction>> liste = Transactions
                .Where(t =>
                   (type == "depense") ? t.Montant < 0 :
                   (type == "recette") ? t.Montant >= 0 :
                    true // Si "all", inclure toutes les transactions
                )
                .Where(t => t.Date.Month == mois) // Filtrer par le mois
                .Where(t => t.Date.Year == year)
                .GroupBy(t =>
                    (type == "all")
                        ? (t.Montant < 0 ? "Dépenses" : "Recettes") // Regrouper par nature si "all"
                        : t.Categorie.ToString() // Sinon, regrouper par catégorie
                );

            // Calculer et retourner les résultats
            return liste.Select(group => (group.Key, group.Sum(t => Math.Abs(t.Montant))));

        }

    }
}

