namespace AppliBoursoBank
{
    public enum Categorie
    {
        Alimentation,
        Loisirs,
        Transports,
        Logement,
        Santé,
        Revenus,
        Autre
    }

    public class Transaction
    {
        public DateTime Date { get; private set; }
        public decimal Montant { get; private set; }
        public string Destinataire { get; private set; }
        public string Etat { get; private set; }

        public string Description  { get; private set; } 
        
        public string ModeTransaction { get; private set; }

        public Categorie Categorie { get; private set; }

        public Transaction(DateTime date, decimal montant, string dest, string etat, Categorie categorie, string modeTransaction, string description)
        {
            Date = date;
            Montant = montant;
            Destinataire = dest;
            Etat = etat;
            Categorie = categorie;
            ModeTransaction = modeTransaction;
            Description = description;
        }

    }
}

