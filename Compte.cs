namespace AppliBoursoBank
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


        public void Deposer(decimal montant, string destinataire = "Anonyme", string etat = "En cours", Categorie categorie = Categorie.Autre)
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant doit être positif.", nameof(montant));

            Solde += montant;
            Transactions.Add(new Transaction(montant, destinataire, etat, categorie));
        }

        public void Retirer(decimal montant, string destinataire = "Anonyme", string etat = "En cours", Categorie categorie = Categorie.Autre)
        {
            if (montant <= 0)
                throw new ArgumentException("Le montant doit être positif.", nameof(montant));

            if (montant > Solde)
                throw new InvalidOperationException("Fonds insuffisants pour effectuer cette opération.");

            Solde -= montant;
            Transactions.Add(new Transaction(-montant, destinataire, etat, categorie));
        }


        public List<Transaction> getLastsTransactions(int count)
        {
            return Transactions.OrderByDescending(t => t.Date).Take(count).ToList();
        }
    }
}

