
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AppliBoursoBank
{
    public partial class Form1 : Form, IObserver<Compte>
    {

        private Controleur controleur;

        // Stocker la couleur actuelle de la bordure pour chaque image
        private Dictionary<PictureBox, Color> imageBorderColors = new Dictionary<PictureBox, Color>();

        public Form1(Controleur controleur)
        {
            this.controleur = controleur;
            controleur.Subscribe(this);

            InitializeComponent();
            Initialize();
            getListTransactions(controleur.compte);
            afficherSoldeCompte(controleur.compte);
            Transactions_Events(groupBox1);

        }

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
        

        public void TransactionClick(object sender, EventArgs e)
        {
            Panel elt = sender as Panel ?? (sender as Control)?.Parent as Panel;
            if (elt != null && elt.Tag is Transaction transaction)
            {
                controleur.AfficherDetailsFenetreTransaction(transaction);
            }
        }
        private void Transactions_Events(Control control)
        {
            Panel[] panels = { p_transaction1, p_transaction2, p_transaction3 };
            foreach (Panel panel in panels)
            {
                panel.MouseEnter += (sender, e) => Hover_Panel(sender, e, true);
                panel.MouseLeave += (sender, e) => Hover_Panel(sender, e, false);

                panel.MouseClick +=TransactionClick; 

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

        private void Img_Contour(object sender, PaintEventArgs e)
        {
            // Dessiner une bordure bleue autour de l'image
            using (Pen bluePen = new Pen(Color.LightBlue, 3)) // 3 = épaisseur de la bordure
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(bluePen, 2.5f, 2.5f, 100, 100);
            }
        }

        private void Hover_Panel(object sender, EventArgs e, bool isHovering)
        {
            var panel = sender as Panel;
            
            panel.BackColor = isHovering ? Color.LightGray : SystemColors.Control;
            panel.Cursor = isHovering ? Cursors.Hand : Cursors.Default;
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

        private void getListTransactions(Compte compte)
        {
            var dernieresTransactions = controleur.getListTransactions(compte, 3);

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
                panels[i].Tag = lastTransaction;    // On associe une transaction à un panel

                // Mettre à jour les labels
                categorieLabels[i].Text = $"{lastTransaction.Categorie}";
                destinataireLabels[i].Text = $"{lastTransaction.Destinataire}";
                amountLabels[i].Text = $"{lastTransaction.Montant} $";
                amountLabels[i].ForeColor = lastTransaction.Montant < 0 ? Color.Red : Color.Green; // Couleur conditionnelle
                dateLabels[i].Text = $"{lastTransaction.Date:dd/MM/yyyy}";
                etatLabels[i].Text = $"{lastTransaction.Etat}";
            }
        }

        private void afficherSoldeCompte(Compte compte)
        {

            var solde = controleur.getSoldeCompte(compte);
            l_solde.Text = $"{solde} $";
        }

    }
}
