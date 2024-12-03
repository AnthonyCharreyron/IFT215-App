
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

        public Controleur()
        {
            compte = Program.compte;
            this.accueil = new Accueil(this);

        }

        public void LancerApplication()
        {
            Application.Run(accueil);
        }


        public List<Transaction> getListTransactions(int count)
        {
            return compte.getLastsTransactions(count);
        }

        public decimal getSoldeCompte()
        {
            return compte.Solde;
        }

        public void AfficherDetailsFenetreTransaction(Transaction transaction)
        {
            this.transaction = transaction;
            var fenetreTransaction = new FenetreTransaction(transaction, this);
            fenetreTransaction.ShowDialog();
        }

        
        public void AfficherFenetreGestionBudget()
        {
            var fenetreBudget = new GestionBudget(this);
            fenetreBudget.Show();
        }

        public void AfficherAccueil()
        {
            accueil.Show();
        }

        public void ModifierTransaction(Transaction transaction, string categorie, string modeTransaction, string description)
        {
            Enum.TryParse(categorie, out Categorie cat);
            transaction.updateTransaction(cat, modeTransaction, description);
            fireEvent();
        }

        public void contesterTransaction(Transaction transaction)
        {
            transaction.contester();
            fireEvent();
        }

        public List<Transaction> getListMonthlyTransactionByType(string type, string categorie, int mois, int year)
        {
            return compte.GetCurrentMonthTransactionByType(type, categorie, mois, year);
        }


        public IEnumerable<(string Groupe, decimal Total)> GetTransactionsParCategorie(string type, int mois, int year)
        {
            return compte.GetDepensesParCategorie(type, mois, year); // Totaliser les montants
        }

        public void fireEvent()
        {

            foreach (IObserver<Transaction> observer in observers)
            {
                observer.OnNext(transaction);
            }
        }

        public IDisposable Subscribe(IObserver<Transaction> observer)
        {
            observers.Add(observer);

            return null;
        }

        
        public IDisposable unSubscribe (IObserver<Transaction> observer)
        {
            observers.Remove(observer);

            return null;
        }

    }
}

