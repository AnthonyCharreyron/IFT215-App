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

        // Constructeur de la fenêtre GestionBudget
        public GestionBudget(Controleur controleur)
        {
            // Abonnement à l'observateur
            this.controleur = controleur;
            controleur.Subscribe(this);

            // Initialisation de la fenêtre
            InitializeComponent();

            // Création des listes de transactions par défaut
            getListTransactionsByType("depense", "Toutes");
            getListTransactionsByType("recette", "Toutes");
            getListTransactionsByType("all", "Toutes");

            // Création des graphiques
            DisplayPieChart("depense");
            DisplayPieChart("recette");
            DisplayPieChart("all");

            // Affichage du mois + année en cours
            string moisString = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.mois);
            l_month.Text = char.ToUpper(moisString[0]) + moisString.Substring(1) + " " + year.ToString();

            // Ajout d'événements pour retourner à l'accueil
            l_menuaccueil.Click += Return_Accueil;
            p_logo.Click += Return_Accueil;
            link_accueil.Click += Return_Accueil;

            // Ajout d'événements pour le curseur et la surbrillance de l'accueil dans le menu
            l_menuaccueil.MouseEnter += (sender, e) => Hover_Control(sender, e, true, Color.SkyBlue);
            l_menuaccueil.MouseLeave += (sender, e) => Hover_Control(sender, e, false, Color.SkyBlue);
            p_logo.MouseEnter += (sender, e) => { Cursor = Cursors.Hand; };
            p_logo.MouseLeave += (sender, e) => { Cursor = Cursors.Default; };

            // Initialisation des filtres de catégories
            InitialiseComboBoxes();

            // Ajout d'événements sur les flèches pour naviguer sur les mois
            p_previousMonth.Click += ShowPreviousMonth;
            p_nextMonth.Click += ShowNextMonth;

        }

        // Fonction qui initialise les combosbox des filtres pour les catégories
        private void InitialiseComboBoxes()
        {
            // Tableau des combobox
            ComboBox[] combos = { cb_all, cb_depenses, cb_recettes };
            String[] types = { "all", "depense", "recette" };

            for (int i = 0; i < combos.Length; i++)
            {
                int index = i; // Créer une variable locale pour capturer la valeur de `i` dans ce contexte

                combos[index].SelectedIndex = 0; // Valeur par défaut

                // Ajout d'événement lors du choix d'un item
                combos[index].SelectedIndexChanged += (sender, e) => ComboBox_SelectionChanged(types[index], combos[index].SelectedItem.ToString());

            }

        }

        // Evénement qui met à jour la liste des transactions selloln le filtre
        private void ComboBox_SelectionChanged(string type, string selectedCategory)
        {
            //string selectedCategory = comboBox.SelectedItem.ToString();
            getListTransactionsByType(type, selectedCategory);
        }

        // Evénement qui retourne sur l'accueil
        public void Return_Accueil(object sender, EventArgs e)
        {
            // On affiche l'accueil
            controleur.AfficherAccueil();
            
            // On se désabonne de l'observateur et on ferme la fenêtre
            controleur.unSubscribe(this);
            this.Close();
        }

        // Evénement associé au click qui ouvre la fenêtre FenetreTransaction 
        public void TransactionClick(object sender, EventArgs e)
        {
            // On récupére le tag du panel (ou du panel dans lequel est le Label 
            Panel elt = sender as Panel ?? (sender as Control)?.Parent as Panel;
            if (elt != null && elt.Tag is Transaction transaction)
            {
                controleur.AfficherDetailsFenetreTransaction(transaction);
            }
        }

        // Evénement qui modifie le curseur et le fond d'un Control (panel ou label)
        private void Hover_Control(object sender, EventArgs e, bool isHovering, Color color)
        {
            var elt = sender as Control;

            elt.BackColor = isHovering ? Color.LightGray : color;
            elt.Cursor = isHovering ? Cursors.Hand : Cursors.Default;
        }

        // Fonction qui affiche la liste de transaction selon les filtres désirés
        private void getListTransactionsByType(string type, string categorie)
        {
            // On récupére les transactions souhaitées
            var transactions = controleur.getListMonthlyTransactionByType(type, categorie, this.mois, this.year);

            // Tableaux des labels à ajouter pour chaque transactions
            String[] nomslabel = { "l_montant", "l_destinataire", "l_date", "l_categorie" };
            // Tableaux des positions de chacun des labels
            int[,] coordonnees = { { 4, 3 }, { 80, 3 }, { 236, 3 }, { 300, 3 } };

            // Choix du FlowLayoutPanel où on met à jour les transactions
            var flp = (type == "depense") ? flp_depenses : (type == "recette") ? flp_recettes : flp_general;
            flp.Controls.Clear();

            // Pour toutes les transactions, on crée un panel dans le flp, puis les labels qu'on met à jour
            for (int i = 0; i < transactions.Count; i++)
            {
                // t = transaction i en cours
                var t = transactions[i];

                var color = Color.Transparent;
                // création du panel pour la transaction i
                Panel panel = new Panel();
                panel.Size = new Size(409, 26);
                panel.MinimumSize = new Size(409, 26);
                panel.TabIndex = i;
                panel.Tag = t;
                if (i % 2 == 0) // on colore différemment une ligne sur 2
                {
                    color = Color.LightBlue;
                }
                panel.BackColor = color;
                panel.MouseClick += TransactionClick;
                panel.MouseEnter += (sender, e) => Hover_Control(sender, e, true, color);
                panel.MouseLeave += (sender, e) => Hover_Control(sender, e, false, color);

                // ajout de la transaction i au flowLayoutPanel correspondant
                flp.Controls.Add(panel);

                // Tableau des valeurs pour les labels
                String[] values = { t.Montant.ToString() + " $", t.Destinataire, t.Date.ToString("dd/MM"), t.Categorie.ToString() };
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
                        label.ForeColor = t.Montant < 0 ? Color.Red : Color.Green; // Pour la liste "générale", on ajoute une couleur au solde selon la valeur
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

        // Fonction qui affiche les graphiques selon le type
        private void DisplayPieChart(string type)
        {
            // Récupérer les données selon le type
            var data = controleur.GetTransactionsParCategorie(type, this.mois, this.year);

            // On récupère le chart à modifier selon le type
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

            // Initialiser le total
            decimal totAll = 0;

            if (type == "all") // Total = Recettes - Dépenses si type = all
            {
                totAll = data.Where(item => item.Groupe == "Recettes").Sum(item => item.Total) - data.Where(item => item.Groupe == "Dépenses").Sum(item => item.Total);
            }
            // Compter le total
            decimal total = data.Sum(item => item.Total);

            // Affichage du total
            var label = (type == "depense") ? l_totdepenses : (type == "recette") ? l_totrecettes : l_totmensuel;
            label.Text = (type == "all") ? totAll.ToString() + " $" : total.ToString() + " $";

            if (type == "all" && totAll < 0) {
                label.ForeColor = Color.Red;
                l_balancemensuelle.ForeColor = Color.Red;
            } else if (type == "all" && totAll > 0){
                label.ForeColor = Color.Green;
                l_balancemensuelle.ForeColor = Color.Green;
            }


            // Ajouter les données au graphique
            foreach (var item in data)
            {
                // Calcul du pourcentage pour le groupe
                double pourcentage = (double)(item.Total / total * 100);

                // Ajouter le point à la série
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

        // Fonction qui recule d'un mois
        public void ShowPreviousMonth(object sender, EventArgs e)
        {
            // On stocke le nouveau mois
            this.mois = (this.mois - 2 + 12) % 12 + 1;

            
            if (this.mois == 12) { 
                this.year -= 1; // Décrémentation de l'année
            };

            // On notifie l'observateur du changement
            controleur.fireEvent();

            // Affichage du mois + année en cours
            string moisString = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.mois);
            l_month.Text = char.ToUpper(moisString[0]) + moisString.Substring(1) + " " + year.ToString();
        }

        // Fonction qui avance d'un mois
        public void ShowNextMonth(object sender, EventArgs e)
        {
            // On stocke le nouveau mois
            this.mois = (this.mois % 12) + 1;

            if (this.mois == 1) { 
                this.year += 1; // Décrémentation de l'année
            };

            // On notifie l'observateur du changement
            controleur.fireEvent();

            // Affichage du mois + année en cours
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

        // Lorsque l'on est notifié d'un changement, on met à jour les informations (graphique et liste)
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
