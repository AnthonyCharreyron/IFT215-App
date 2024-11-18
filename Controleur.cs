
using System;
using static AppliBoursoBank.Form1;

namespace AppliBoursoBank
{
    public class Controleur : IObservable<Compte>
    {
        private List<IObserver<Compte>> observers = new List<IObserver<Compte>>();

        private Compte compte;

        public List<Transaction> getListTransactions(Compte compte, int count)
        {
            return compte.getLastsTransactions(count);
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

