namespace AppliBoursoBank.Modeles
{
    // Création d'un type Catégorie avec enum
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

    // Création du modèle Transaction
    public class Transaction
    {
        // Déclaration des attributs d'une transaction
        public DateTime Date { get; private set; }
        public decimal Montant { get; private set; }
        public string Destinataire { get; private set; }
        public string Etat { get; private set; }

        public string Description { get; private set; }

        public string ModeTransaction { get; private set; }

        public Categorie Categorie { get; private set; }

        // Constructeur d'une transaction
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

        // Fonction qui met à jour des informations (catégorie, mode de transaction et description) d'une transaction
        public void updateTransaction(Categorie categorie, string modeTransaction, string description)
        {
            Categorie = categorie;
            ModeTransaction = modeTransaction;
            Description = description;
        }

        // Fonction qui permet de constester une transaction
        public void contester()
        {
            Etat = "Contestée";
        }

    }
}

