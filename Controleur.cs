
using System;
using static AppliBoursoBank.Form1;

namespace AppliBoursoBank
{
    public class Controleur : IObservable<Compte>
    {
        private List<IObserver<Compte>> observers = new List<IObserver<Compte>>();

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
            var fenetreTransaction = new FenetreTransaction(transaction);
            fenetreTransaction.ShowDialog();
        }

        public void fireEvent()
        {

            foreach (IObserver<Compte> observer in observers)
            {
                observer.OnNext(compte);
            }
        }

        public IDisposable Subscribe(IObserver<Compte> observer)
        {
            observers.Add(observer);

            return null;
        }

    }
}

