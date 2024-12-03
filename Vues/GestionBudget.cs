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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            getListTransactionsByType(controleur.compte, "depense", "Toutes");
            getListTransactionsByType(controleur.compte, "recette", "Toutes");
            getListTransactionsByType(controleur.compte, "all", "Toutes");
            DisplayPieChart(controleur.compte, "depense");
            DisplayPieChart(controleur.compte, "recette");
            DisplayPieChart(controleur.compte, "all");

            string mois = DateTime.Now.ToString("MMMM");
            l_month.Text = char.ToUpper(mois[0]) + mois.Substring(1);

            l_menuaccueil.Click += Return_Accueil;
            p_logo.Click += Return_Accueil;
            link_accueil.Click += Return_Accueil;
            l_menuaccueil.MouseEnter += (sender, e) => Hover_Control(sender, e, true, Color.SkyBlue);
            l_menuaccueil.MouseLeave += (sender, e) => Hover_Control(sender, e, false, Color.SkyBlue);
            p_logo.MouseEnter += (sender, e) => { Cursor = Cursors.Hand; };
            p_logo.MouseLeave += (sender, e) => { Cursor = Cursors.Default; };


            InitialiseComboBox("depense");
            InitialiseComboBox("recette");
            InitialiseComboBox("all");
        }

        private void InitialiseComboBox(string type)
        {
            var cb = (type == "depense") ? cb_depenses : (type == "recette") ? cb_recettes : cb_all;
            cb.Items.Clear();
            cb.Items.Add("Toutes");
            cb.Items.Add("Loisirs");
            cb.Items.Add("Alimentation");
            cb.Items.Add("Transports");
            cb.Items.Add("Logement");
            cb.Items.Add("Santé");
            cb.Items.Add("Revenus");
            cb.Items.Add("Autre");

            cb.SelectedIndex = 0;

            cb.SelectedIndexChanged += (sender, e) => ComboBox_SelectionChanged(type, cb);
        }

        private void ComboBox_SelectionChanged(string type, System.Windows.Forms.ComboBox comboBox)
        {
            string selectedCategory = comboBox.SelectedItem.ToString();
            getListTransactionsByType(controleur.compte, type, selectedCategory);
        }

        public void Return_Accueil(object sender, EventArgs e)
        {
            controleur.AfficherAccueil();
            controleur.unSubscribe(this);
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

        private void getListTransactionsByType(Compte compte, string type, string categorie)
        {
            var depenses = controleur.getListMonthlyTransactionByType(compte, type, categorie);

            String[] nomslabel = { "l_montant", "l_destinataire", "l_date", "l_categorie" };
            int[,] coordonnees = { { 4, 3 }, { 80, 3 }, { 236, 3 }, { 300, 3 } };

            var flp = (type=="depense") ? flp_depenses : (type=="recette") ? flp_recettes : flp_general;
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
                    if(type == "all" && j == 0) 
                    {
                        label.ForeColor = t.Montant < 0 ? Color.Red : Color.Green;
                    }
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

        private void DisplayPieChart(Compte compte,string type)
        {
            // Regrouper les dépenses par catégorie
            var data = controleur.GetTransactionsParCategorie(compte, type); // TO DO 

            var chart = (type == "depense") ? chartDepenses : (type == "recette") ? chartRecettes : chartAll;

            // Configurer le graphique
            chart.Series.Clear();
            chart.Titles.Clear();

            // Ajouter un titre
            chart.Titles.Add((type == "depense") ? "Répartition des dépenses par catégorie" : (type == "recette") ? "Répartition des recettes par catégorie" : "Equilibre entrées / sorties") ;

            // Ajouter une série
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = (type == "depense") ? "Dépenses" : (type == "recette") ? "Recettes" : "Général",
                IsVisibleInLegend = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
            };

            chart.Series.Add(series);

            decimal totAll = 0;

            if (type == "all")
            {
                totAll = data.Where(item => item.Groupe == "Recettes").Sum(item => item.Total) - data.Where(item => item.Groupe == "Dépenses").Sum(item => item.Total);
            }

            decimal total = data.Sum(item => item.Total);

            var label = (type == "depense") ? l_totdepenses : (type == "recette") ? l_totrecettes : l_totmensuel;
            label.Text =(type=="all") ? totAll.ToString() + " $" : total.ToString()+" $" ;

            // Ajouter les données au graphique
            foreach (var item in data)
            {
                System.Diagnostics.Debug.WriteLine(item);
                // Ajouter le point à la série

                double pourcentage = (double)(item.Total / total * 100);

                var point = new System.Windows.Forms.DataVisualization.Charting.DataPoint
                {
                    YValues = new[] { (double)item.Total },
                    LegendText = item.Groupe.ToString(),
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
            getListTransactionsByType(controleur.compte, "depense", "Toutes");
            getListTransactionsByType(controleur.compte, "recette", "Toutes");
            getListTransactionsByType(controleur.compte, "all", "Toutes");
            DisplayPieChart(controleur.compte, "depense");
            DisplayPieChart(controleur.compte, "recette");
            DisplayPieChart(controleur.compte, "all");
        }

    }
}
