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

        public Categorie Categorie { get; private set; }

        public Transaction(decimal montant, string dest, string etat, Categorie categorie)
        {
            Date = DateTime.Now;
            Montant = montant;
            Destinataire = dest;
            Etat = etat;
            Categorie = categorie;
        }

    }
}

