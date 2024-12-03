using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AppliBoursoBank.Controleurs;
using AppliBoursoBank.Modeles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace AppliBoursoBank
{
    public partial class GestionBudget : Form, IObserver<Transaction>
    {
        Controleur controleur;

        int mois = DateTime.Now.Month;
        int year = DateTime.Now.Year;  

        public GestionBudget(Controleur controleur)
        {
            this.controleur = controleur;
            controleur.Subscribe(this);

            InitializeComponent();
            getListTransactionsByType("depense", "Toutes");
            getListTransactionsByType("recette", "Toutes");
            getListTransactionsByType("all", "Toutes");
            DisplayPieChart("depense");
            DisplayPieChart("recette");
            DisplayPieChart("all");

            string moisString = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.mois);
            l_month.Text = char.ToUpper(moisString[0]) + moisString.Substring(1) + " " + year.ToString();

            l_menuaccueil.Click += Return_Accueil;
            p_logo.Click += Return_Accueil;
            link_accueil.Click += Return_Accueil;
            l_menuaccueil.MouseEnter += (sender, e) => Hover_Control(sender, e, true, Color.SkyBlue);
            l_menuaccueil.MouseLeave += (sender, e) => Hover_Control(sender, e, false, Color.SkyBlue);
            p_logo.MouseEnter += (sender, e) => { Cursor = Cursors.Hand; };
            p_logo.MouseLeave += (sender, e) => { Cursor = Cursors.Default; };

            InitialiseComboBoxes();

            p_previousMonth.Click += ShowPreviousMonth; 
            p_nextMonth.Click += ShowNextMonth;

        }

        private void InitialiseComboBoxes()
        {
            ComboBox[] combos = { cb_all, cb_depenses, cb_recettes };
            String[] types = { "all", "depense", "recette" };

            for (int i = 0; i < combos.Length; i++)
            {
                int index = i; // Créer une variable locale pour capturer la valeur de `i` dans ce contexte

                combos[index].SelectedIndex = 0;

                combos[index].SelectedIndexChanged += (sender, e) => ComboBox_SelectionChanged(types[index], combos[index].SelectedItem.ToString());

            }

        }

        private void ComboBox_SelectionChanged(string type, string selectedCategory)
        {
            //string selectedCategory = comboBox.SelectedItem.ToString();
            getListTransactionsByType(type, selectedCategory);
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

        private void getListTransactionsByType(string type, string categorie)
        {
            var depenses = controleur.getListMonthlyTransactionByType(type, categorie, this.mois, this.year);

            String[] nomslabel = { "l_montant", "l_destinataire", "l_date", "l_categorie" };
            int[,] coordonnees = { { 4, 3 }, { 80, 3 }, { 236, 3 }, { 300, 3 } };

            var flp = (type == "depense") ? flp_depenses : (type == "recette") ? flp_recettes : flp_general;
            flp.Controls.Clear();

            for (int i = 0; i < depenses.Count; i++)
            {

                var t = depenses[i];

                String[] values = { t.Montant.ToString() + " $", t.Destinataire, t.Date.ToString("dd/MM"), t.Categorie.ToString() };
                var color = Color.Transparent;
                // création du panel pour la transaction i
                Panel panel = new Panel();
                panel.Size = new Size(409, 26);
                panel.MinimumSize = new Size(409, 26);
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
                    if (type == "all" && j == 0)
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

        private void DisplayPieChart(string type)
        {
            // Regrouper les dépenses par catégorie
            var data = controleur.GetTransactionsParCategorie(type, this.mois, this.year);

            var chart = (type == "depense") ? chartDepenses : (type == "recette") ? chartRecettes : chartAll;

            // Configurer le graphique
            chart.Series.Clear();
            chart.Titles.Clear();

            // Ajouter un titre
            chart.Titles.Add((type == "depense") ? "Répartition des dépenses par catégorie" : (type == "recette") ? "Répartition des recettes par catégorie" : "Equilibre entrées / sorties");

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
            label.Text = (type == "all") ? totAll.ToString() + " $" : total.ToString() + " $";

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

        public void ShowPreviousMonth(object sender, EventArgs e)
        {

           this.mois = (this.mois - 2 + 12) % 12 + 1;

            if (this.mois == 12) { this.year -= 1; };

            controleur.fireEvent();

            string moisString = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.mois);
            l_month.Text = char.ToUpper(moisString[0]) + moisString.Substring(1) + " " + year.ToString();
        }

        public void ShowNextMonth(object sender, EventArgs e)
        {
            this.mois = (this.mois % 12) + 1 ;

            if(this.mois == 1) { this.year += 1; };

            controleur.fireEvent();

            string moisString = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.mois);
            l_month.Text = char.ToUpper(moisString[0]) + moisString.Substring(1) + " " + year.ToString();
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

            getListTransactionsByType("depense", "Toutes");
            getListTransactionsByType("recette", "Toutes");
            getListTransactionsByType("all", "Toutes");
            DisplayPieChart("depense");
            DisplayPieChart("recette");
            DisplayPieChart("all");
        }

    }
}
