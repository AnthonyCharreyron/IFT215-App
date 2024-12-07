
using System;
//using System.Transactions;
using AppliBoursoBank.Modeles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static AppliBoursoBank.Accueil;

namespace AppliBoursoBank.Controleurs
{
    public class Controleur : IObservable<Transaction>
    {

        private List<IObserver<Transaction>> observers = new List<IObserver<Transaction>>();

        Transaction transaction;

        public Compte compte;
        private Form accueil;

        // Constructeur du controleur
        public Controleur()
        {
            compte = Program.compte;
            this.accueil = new Accueil(this);

        }

        // Fonction qui démarre l'application
        public void LancerApplication()
        {
            Application.Run(accueil);
        }


        // Fonction qui transmet les "count" dernières transactions à la vue
        public List<Transaction> getListTransactions(int count)
        {
            return compte.getLastsTransactions(count);
        }

        // Fonction qui transmet le solde du compte à la vue
        public decimal getSoldeCompte()
        {
            return compte.Solde;
        }

        // Fonction qui affiche la fenêtre FenetreTransaction pour une transaction donnée
        public void AfficherDetailsFenetreTransaction(Transaction transaction)
        {
            this.transaction = transaction;
            var fenetreTransaction = new FenetreTransaction(transaction, this);
            fenetreTransaction.ShowDialog();
        }

        // Fonction qui affiche la fenêtre GestionBudget, et cache la fenêtre de l'accueil
        public void AfficherFenetreGestionBudget()
        {
            var fenetreBudget = new GestionBudget(this);
            fenetreBudget.Show();
        }

        // Fonction qui affiche la fenêtre de l'accueil
        public void AfficherAccueil()
        {
            accueil.Show();
        }

        // Fonction qui met à jour les transactions et prévient les observers
        public void ModifierTransaction(Transaction transaction, string categorie, string modeTransaction, string description)
        {
            Enum.TryParse(categorie, out Categorie cat);
            transaction.updateTransaction(cat, modeTransaction, description);
            fireEvent();
        }

        // Fonction qui conteste une transaction et prévient les observers
        public void contesterTransaction(Transaction transaction)
        {
            transaction.contester();
            fireEvent();
        }

        // Fonction qui transmet la liste des transactions filtrées
        public List<Transaction> getListMonthlyTransactionByType(string type, string categorie, int mois, int year)
        {
            return compte.GetMonthTransactionByType(type, categorie, mois, year);
        }

        // Fonction qui transmet les données nécessaires au graphique
        public IEnumerable<(string Groupe, decimal Total)> GetTransactionsParCategorie(string type, int mois, int year)
        {
            return compte.GetDepensesParCategorie(type, mois, year); // Totaliser les montants
        }

        // Prévention d'un événement à tous les observers
        public void fireEvent()
        {

            foreach (IObserver<Transaction> observer in observers)
            {
                observer.OnNext(transaction);
            }
        }

        // Souscription d'un observer au controleur
        public IDisposable Subscribe(IObserver<Transaction> observer)
        {
            observers.Add(observer);

            return null;
        }

        // Désinscription d'un observer au controleur
        public IDisposable unSubscribe (IObserver<Transaction> observer)
        {
            observers.Remove(observer);

            return null;
        }

    }
}

