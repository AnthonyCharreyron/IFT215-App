using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppliBoursoBank.Modeles
{

    public class Compte
    {
        private int NumeroCompte { get; }
        private string Titulaire { get; }
        public decimal Solde { get; private set; }
        public List<Transaction> Transactions { get; private set; }

        public Compte(int numeroCompte, string titulaire, decimal soldeInitial = 0)
        {
            NumeroCompte = numeroCompte;
            Titulaire = titulaire;
            Solde = soldeInitial;
            Transactions = new List<Transaction>();
        }


        public void Deposer(DateTime date, decimal montant, string destinataire = "Anonyme", string etat = "En cours", Categorie categorie = Categorie.Autre, string modeTransaction = "Autre", string description = "")
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant doit être positif.", nameof(montant));

            Solde += montant;
            Transactions.Add(new Transaction(date, montant, destinataire, etat, categorie, modeTransaction, description));
        }

        public void Retirer(DateTime date, decimal montant, string destinataire = "Anonyme", string etat = "En cours", Categorie categorie = Categorie.Autre, string modeTransaction = "Autre", string description = "")
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant doit être positif.", nameof(montant));

            if (montant > Solde)
                throw new InvalidOperationException("Fonds insuffisants pour effectuer cette opération.");

            Solde -= montant;
            Transactions.Add(new Transaction(date, -montant, destinataire, etat, categorie, modeTransaction, description));
        }


        public List<Transaction> getLastsTransactions(int count)
        {
            return Transactions.OrderByDescending(t => t.Date).Take(count).ToList();
        }

        public List<Transaction> GetCurrentMonthTransactionByType(bool isDepense)
        {
            return Transactions
                .Where(t => isDepense ? t.Montant < 0 : t.Montant >= 0)
                .OrderByDescending(t => t.Date)
                .Where(t => t.Date.Month == DateTime.Now.Month)
                .ToList();
        }

        public IEnumerable<(Categorie Categorie, decimal Total)> GetDepensesParCategorie(bool isDepense)
        {
            IEnumerable<IGrouping<Categorie, Transaction>> liste = Transactions
                .Where(t => isDepense ? t.Montant < 0 : t.Montant >=0) // Filtrer uniquement les dépenses
                .GroupBy(t => t.Categorie); // Grouper par catégorie

            return liste.Select(group => (group.Key, group.Sum(t => Math.Abs(t.Montant))));
        }
    }
}

