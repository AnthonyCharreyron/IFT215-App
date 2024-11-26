
using System;
using AppliBoursoBank.Modeles;
using static AppliBoursoBank.Accueil;

namespace AppliBoursoBank.Controleurs
{
    public class ControleurFenetreTransaction : IObservable<Transaction>
    {
        private List<IObserver<Transaction>> observers = new List<IObserver<Transaction>>();

        Transaction transaction;

        public ControleurFenetreTransaction(Transaction transaction)
        {
            this.transaction = transaction;
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

    }
}

