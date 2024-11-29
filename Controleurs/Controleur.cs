
using System;
//using System.Transactions;
using AppliBoursoBank.Modeles;
using static AppliBoursoBank.Accueil;

namespace AppliBoursoBank.Controleurs
{
    public class Controleur : IObservable<Transaction>
    {

        private List<IObserver<Transaction>> observers = new List<IObserver<Transaction>>();

        Transaction transaction;

        public Compte compte;

        public Controleur()
        {
            compte = Program.compte;
        }

        public List<Transaction> getListTransactions(Compte compte, int count)
        {
            return compte.getLastsTransactions(count);
        }

        public decimal getSoldeCompte(Compte compte)
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

        public List<Transaction> getListMonthlyTransactionByType(Compte compte, int count, bool isDepense)
        {
            return compte.GetCurrentMonthTransactionByType(count, isDepense);
        }


        public IEnumerable<(Categorie Categorie, decimal Total)> GetDepensesParCategorie(Compte compte)
        {
            return compte.GetDepensesParCategorie(); // Totaliser les montants
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

