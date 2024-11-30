using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AppliBoursoBank.Controleurs;
using AppliBoursoBank.Modeles;

namespace AppliBoursoBank
{
    public partial class GestionBudget : Form, IObserver<Transaction>
    {
        Controleur controleur;

        public GestionBudget(Controleur controleur)
        {
            this.controleur = controleur;
            controleur.Subscribe(this);

            InitializeComponent();
            getListTransactionsByType(controleur.compte, true);
            getListTransactionsByType(controleur.compte, false);

            DisplayPieChart(controleur.compte, true);
            DisplayPieChart(controleur.compte, false);

            string mois = DateTime.Now.ToString("MMMM");
            l_month.Text = char.ToUpper(mois[0]) + mois.Substring(1);

            l_menuaccueil.Click += Return_Accueil;
            p_logo.Click += Return_Accueil;
            link_accueil.Click += Return_Accueil;
            l_menuaccueil.MouseEnter += (sender, e) => Hover_Control(sender, e, true, Color.SkyBlue);
            l_menuaccueil.MouseLeave += (sender, e) => Hover_Control(sender, e, false, Color.SkyBlue);
            p_logo.MouseEnter += (sender, e) => { Cursor = Cursors.Hand; };
            p_logo.MouseLeave += (sender, e) => { Cursor = Cursors.Default; };


        }

        public void Return_Accueil(object sender, EventArgs e)
        {
            controleur.AfficherAccueil();
            this.Close();
        }

        public void TransactionClick(object sender, EventArgs e)
        {
            Panel elt = sender as Panel ?? (sender as Control)?.Parent as Panel;
            if (elt != null && elt.Tag is Transaction transaction)
            {
                controleur.AfficherDetailsFenetreTransaction(transaction);
            }
        }

        private void Hover_Control(object sender, EventArgs e, bool isHovering, Color color)
        {
            var elt = sender as Control;

            elt.BackColor = isHovering ? Color.LightGray : color;
            elt.Cursor = isHovering ? Cursors.Hand : Cursors.Default;
        }

        private void getListTransactionsByType(Compte compte, bool isDepense)
        {
            var depenses = controleur.getListMonthlyTransactionByType(compte, isDepense);

            String[] nomslabel = { "l_montant", "l_destinataire", "l_date", "l_categorie" };
            int[,] coordonnees = { { 4, 3 }, { 80, 3 }, { 236, 3 }, { 300, 3 } };

            var flp = isDepense ? flp_depenses : flp_recettes;
            flp.Controls.Clear();

            for (int i = 0; i < depenses.Count; i++)
            {

                var t = depenses[i];

                String[] values = { t.Montant.ToString() + " $", t.Destinataire, t.Date.ToString("dd/MM"), t.Categorie.ToString() };
                var color = Color.Transparent;
                // création du panel pour la transaction i
                Panel panel = new Panel();
                panel.Size = new Size(409, 26);
                panel.TabIndex = i;
                panel.Tag = t;
                if (i % 2 == 0)
                {
                    color = Color.LightBlue;
                }
                panel.BackColor = color;
                panel.MouseClick += TransactionClick;
                panel.MouseEnter += (sender, e) => Hover_Control(sender, e, true, color);
                panel.MouseLeave += (sender, e) => Hover_Control(sender, e, false, color);

                // ajout de l transaction i au flowLayoutPanel correspondant
                flp.Controls.Add(panel);

                //création des Labels pour chaque élément de la transaction
                for (int j = 0; j < nomslabel.Length; j++)
                {
                    Label label = new Label();
                    label.AutoSize = true;
                    label.Location = new Point(coordonnees[j, 0], coordonnees[j, 1]);
                    label.Name = nomslabel[j];
                    label.TabIndex = j;
                    label.Text = values[j];
                    label.MouseClick += TransactionClick;
                    label.MouseEnter += (sender, e) =>
                    {
                        panel.BackColor = Color.LightGray;
                        label.Cursor = Cursors.Hand;
                    };
                    label.MouseLeave += (sender, e) =>
                    {
                        panel.BackColor = color;
                        label.Cursor = Cursors.Default;

                    };
                    panel.Controls.Add(label); // ajout du label au panel de la transaction
                }
            }
        }

        private void DisplayPieChart(Compte compte, bool isDepense)
        {
            // Regrouper les dépenses par catégorie
            var data = controleur.GetTransactionsParCategorie(compte, isDepense);

            var chart = isDepense ? chartDepenses : chartRecettes;

            // Configurer le graphique
            chart.Series.Clear();
            chart.Titles.Clear();

            // Ajouter un titre
            chart.Titles.Add(isDepense ? "Répartition des dépenses par catégorie" : "Répartition des recettes par catégorie");

            // Ajouter une série
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = isDepense ? "Dépenses" : "Recettes",
                IsVisibleInLegend = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            chart.Series.Add(series);

            decimal totalDepenses = data.Sum(item => item.Total);

            var label = isDepense ? l_totdepenses : l_totrecettes;
            label.Text = totalDepenses.ToString()+" $";

            // Ajouter les données au graphique
            foreach (var item in data)
            {
                System.Diagnostics.Debug.WriteLine(item);
                // Ajouter le point à la série

                double pourcentage = (double)(item.Total / totalDepenses * 100);

                var point = new System.Windows.Forms.DataVisualization.Charting.DataPoint
                {
                    YValues = new[] { (double)item.Total },
                    LegendText = item.Categorie.ToString(),
                    Label = pourcentage.ToString("0.0") + "%",

                };
                point.LabelForeColor = Color.White;
                series.Points.Add(point);

            }
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
            //throw new NotImplementedException();
            getListTransactionsByType(controleur.compte, true);
            getListTransactionsByType(controleur.compte, false);
            DisplayPieChart(controleur.compte, true);
            DisplayPieChart(controleur.compte, false);
        }

    }
}
