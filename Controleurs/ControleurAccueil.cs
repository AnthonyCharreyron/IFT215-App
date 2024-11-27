
using System;
using AppliBoursoBank.Modeles;
using static AppliBoursoBank.Accueil;

namespace AppliBoursoBank.Controleurs
{
    public class ControleurAccueil
    {

        public Compte compte;

        public ControleurAccueil()
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

        public void AfficherDetailsFenetreTransaction(Transaction transaction, IObserver<Transaction> observer)
        {
            var fenetreTransaction = new FenetreTransaction(transaction, observer);
            fenetreTransaction.ShowDialog();

        }

    }
}

