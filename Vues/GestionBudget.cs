using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppliBoursoBank.Controleurs;
using AppliBoursoBank.Modeles;

namespace AppliBoursoBank
{
    public partial class GestionBudget : Form, IObserver<Transaction>
    {
        Controleur controleur = new Controleur();

        public GestionBudget(Controleur controleur)
        {
            this.controleur = controleur;

            InitializeComponent();
            getListDepenses(controleur.compte);
            getListDepots(controleur.compte);

            DisplayPieChart(controleur.compte);

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

        public void OnNext(Transaction transaction)
        {
            throw new NotImplementedException();
        }


        private void getListDepenses(Compte compte)
        {
            var dernieresDepenses = controleur.getListMonthlyTransactionByType(compte, 2, true);

            // Tableau de labels existants
            Label[] categorieLabels = { l_dep_categorie1, l_dep_categorie2 };
            Label[] amountLabels = { l_dep_montant1, l_dep_montant2 };
            Label[] destinataireLabels = { l_dep_dest1, l_dep_dest2 };

            // Parcourir les transactions et mettre à jour les labels
            for (int i = 0; i < dernieresDepenses.Count; i++)
            {
                var lastTransaction = dernieresDepenses[i];

                // Mettre à jour les labels
                categorieLabels[i].Text = $"{lastTransaction.Categorie}";
                amountLabels[i].Text = $"{lastTransaction.Montant:C}";
                amountLabels[i].ForeColor = lastTransaction.Montant < 0 ? Color.Red : Color.Green; // Couleur conditionnelle
                destinataireLabels[i].Text = $"{lastTransaction.Destinataire}";
            }
        }

        private void getListDepots(Compte compte)
        {
            var derniersDepots = controleur.getListMonthlyTransactionByType(compte, 2,false);

            // Tableau de labels existants
            Label[] categorieLabels = { l_depot_categorie1, l_depot_categorie2 };
            Label[] amountLabels = { l_depot_montant1, l_depot_montant2 };
            Label[] destinataireLabels = { l_depot_dest1, l_depot_dest2 };

            // Parcourir les transactions et mettre à jour les labels
            for (int i = 0; i < derniersDepots.Count; i++)
            {
                var lastTransaction = derniersDepots[i];

                // Mettre à jour les labels
                categorieLabels[i].Text = $"{lastTransaction.Categorie}";
                amountLabels[i].Text = $"{lastTransaction.Montant:C}";
                amountLabels[i].ForeColor = lastTransaction.Montant < 0 ? Color.Red : Color.Green; // Couleur conditionnelle
                destinataireLabels[i].Text = $"{lastTransaction.Destinataire}";
            }
        }

        private void DisplayPieChart(Compte compte)
        {
            // Regrouper les dépenses par catégorie
            var data = controleur.GetDepensesParCategorie(compte);

            // Configurer le graphique
            chartDepenses.Series.Clear();
            chartDepenses.Titles.Clear();

            // Ajouter une série
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Dépenses",
                IsVisibleInLegend = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            chartDepenses.Series.Add(series);

            // Ajouter les données au graphique
            foreach (var item in data)
            {
                series.Points.AddXY(item.Categorie.ToString(), item.Total);
            }

            // Ajouter un titre
            chartDepenses.Titles.Add("Répartition des dépenses par catégorie");
        }

     
    }
}
