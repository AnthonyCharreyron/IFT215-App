
using AppliBoursoBank.Controleurs;
using AppliBoursoBank.Modeles;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AppliBoursoBank
{
    public partial class Accueil : Form, IObserver<Transaction>
    {

        private Controleur controleur;

        // Stocker la couleur actuelle de la bordure pour chaque image
        private Dictionary<PictureBox, Color> imageBorderColors = new Dictionary<PictureBox, Color>();

        // Constructeur de l'accueil
        public Accueil(Controleur controleur)
        {
            // Abonnement à l'observateur
            this.controleur = controleur;
            controleur.Subscribe(this);

            // Iniatisation de la page
            InitializeComponent();
            Initialize();
            AfficherTransactions();
            AfficherSoldeCompte();
            Transactions_Events(groupBox1);

            // Ajout d'événements
            img_budget.MouseEnter += (sender, e) => Hover_Image(sender, e, true);
            img_budget.MouseLeave += (sender, e) => Hover_Image(sender, e, false);
            img_budget.MouseClick += GestionBudgetClick;
        }

        // Fonction qui dessine le sous-menu
        private void Initialize()
        {
            System.Drawing.Drawing2D.GraphicsPath obj = new System.Drawing.Drawing2D.GraphicsPath();
            obj.AddEllipse(0, 0, 105, 105);
            Region rg = new Region(obj);
            img_virement.Region = rg;
            img_infocompte.Region = rg;
            img_infocarte.Region = rg;
            img_budget.Region = rg;

            img_virement.Paint += Img_Contour;
            img_infocompte.Paint += Img_Contour;
            img_infocarte.Paint += Img_Contour;
            img_budget.Paint += Img_Contour;

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

        // Evénement associé au click qui ouvre la fenêtre GestionBudget
        public void GestionBudgetClick(object sender, EventArgs e)
        {
             controleur.AfficherFenetreGestionBudget();
            this.Hide(); // on cache la fenêtre principale
        }

        private void Transactions_Events(Control control)
        {
            // Pour tous les panels des transactions
            Panel[] panels = { p_transaction1, p_transaction2, p_transaction3 };
            foreach (Panel panel in panels)
            {
                // On ajoute au panel les événements liés au changement de curseur, à la surbrillance et au Click
                panel.MouseEnter += (sender, e) => Hover_Control(sender, e, true);
                panel.MouseLeave += (sender, e) => Hover_Control(sender, e, false);

                panel.MouseClick += TransactionClick;

                // Pour tous les enfants (tous des Label) présents dans le panel, on ajoute aussi les événements
                foreach (Label child in panel.Controls)
                {
                    child.MouseClick += TransactionClick;

                    child.MouseEnter += (sender, e) =>
                    {
                        panel.BackColor = Color.LightGray;
                        child.Cursor = Cursors.Hand;
                    };
                    child.MouseLeave += (sender, e) =>
                    {
                        if (!panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
                        {
                            panel.BackColor = SystemColors.Control;
                            child.Cursor = Cursors.Default;
                        }
                    };

                }
            }
        }

        // Fonction qui dessine les contours des images du sous-menu
        private void Img_Contour(object sender, PaintEventArgs e)
        {
            // Dessiner une bordure bleue autour de l'image
            using (Pen bluePen = new Pen(Color.LightBlue, 3)) // 3 = épaisseur de la bordure
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(bluePen, 2.5f, 2.5f, 100, 100);
            }
        }

        // Evénement qui modifie le curseur et le fond d'un Control (panel ou label)
        private void Hover_Control(object sender, EventArgs e, bool isHovering)
        {
            var elt = sender as Control;

            elt.BackColor = isHovering ? Color.LightGray : SystemColors.Control;
            elt.Cursor = isHovering ? Cursors.Hand : Cursors.Default;
        }

        // Evénement qui modifie le curseur et le fond d'une Image
        private void Hover_Image(object sender, EventArgs e, bool isHovering)
        {
            var image = sender as PictureBox;

            image.BackColor = isHovering ? Color.LightGray : SystemColors.Control;
            image.Cursor = isHovering ? Cursors.Hand : Cursors.Default;
        }

        // Fonction qui affiche les 3 dernières transactions
        private void AfficherTransactions()
        {
            // on récupère les 3 dernières transactions
            var dernieresTransactions = controleur.getListTransactions(3);
            
            // Tableau de panel
            Panel[] panels = { p_transaction1, p_transaction2, p_transaction3 };
            // Tableau de labels existants
            Label[] categorieLabels = { l_categorie1, l_categorie2, l_categorie3 };
            Label[] destinataireLabels = { l_dest1, l_dest2, l_dest3 };
            Label[] amountLabels = { l_montant1, l_montant2, l_montant3 };
            Label[] dateLabels = { l_date1, l_date2, l_date3 };
            Label[] etatLabels = { l_etat1, l_etat2, l_etat3 };


            // Parcourir les transactions et mettre à jour les labels
            for (int i = 0; i < dernieresTransactions.Count; i++)
            {
                var lastTransaction = dernieresTransactions[i];
                panels[i].Tag = lastTransaction;    // On associe une transaction à un panel avec tag

                // Mettre à jour les labels
                categorieLabels[i].Text = $"{lastTransaction.Categorie}";
                destinataireLabels[i].Text = $"{lastTransaction.Destinataire}";
                amountLabels[i].Text = $"{lastTransaction.Montant} $";
                amountLabels[i].ForeColor = lastTransaction.Montant < 0 ? Color.Red : Color.Green; // Couleur conditionnelle selon la valeur du montant
                dateLabels[i].Text = $"{lastTransaction.Date:dd/MM/yyyy}";
                etatLabels[i].Text = $"{lastTransaction.Etat}";
            }
        }

        // Fonction qui affiche le solde du compte
        private void AfficherSoldeCompte()
        {
            // On récupère la valeur du solde du compte
            var solde = controleur.getSoldeCompte();
            // On met à jour le label
            l_solde.Text = $"{solde} $";
        }


        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        // Lorsque l'on est notifié d'un changement, on met à jour les dernières transactions
        public void OnNext(Transaction transaction)
        {
            //throw new NotImplementedException();
            AfficherTransactions();
        }

    }
}
