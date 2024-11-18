
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppliBoursoBank
{
    public partial class Form1 : Form, IObserver<Compte>
    {

        Controleur controleur = new Controleur();

        Compte compte;


        public Form1()
        {
            InitializeComponent();
            Creer_Compte();
            getListTransactions();

            controleur.Subscribe(this);


        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Compte compte)
        {
            throw new NotImplementedException();
        }

        public void Creer_Compte()
        {
            compte = new Compte(1, "John Doe", 200);
            compte.Deposer(1000, "Amazon", "Validé", Categorie.Loisirs);
            compte.Deposer(40, "Uniprix", "En cours", Categorie.Santé);
            compte.Retirer(60, "Amazon", "Validé", Categorie.Loisirs);
            compte.Deposer(40, "Maxi", "Validé", Categorie.Alimentation);
            compte.Retirer(20, "STS", "En cours", Categorie.Transports);
        }

        private void getListTransactions()
        {
            var dernieresTransactions = controleur.getListTransactions(compte, 3);

            // Tableau de labels existants
            Label[] destinataireLabels = { l_dest1, l_dest2, l_dest3 };
            Label[] amountLabels = { l_montant1, l_montant2, l_montant3 };
            Label[] dateLabels = { l_date1, l_date2, l_date3 };

            // Parcourir les transactions et mettre à jour les labels
            for (int i = 0; i < dernieresTransactions.Count; i++)
            {
                var lastTransaction = dernieresTransactions[i];

                // Mettre à jour les labels
                destinataireLabels[i].Text = $"Destinataire : {lastTransaction.Destinataire}";
                amountLabels[i].Text = $"Montant : {lastTransaction.Montant:C}";
                amountLabels[i].ForeColor = lastTransaction.Montant < 0 ? Color.Red : Color.Green; // Couleur conditionnelle
                dateLabels[i].Text = $"Date : {lastTransaction.Date:dd/MM/yyyy}";
            }
        }


    }
}
