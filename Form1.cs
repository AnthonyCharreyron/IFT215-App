
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

        Controleur controleur = new Controleur();

        Compte compte;

        // Stocker la couleur actuelle de la bordure pour chaque image
        private Dictionary<PictureBox, Color> imageBorderColors = new Dictionary<PictureBox, Color>();

        public Form1()
        {
            InitializeComponent();
            Initialize();
            Creer_Compte();
            getListTransactions();
            afficherSoldeCompte();

            controleur.Subscribe(this);


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

        private void Img_Contour(object sender, PaintEventArgs e)
        {
            // Dessiner une bordure bleue autour de l'image
            using (Pen bluePen = new Pen(Color.LightBlue, 3)) // 3 = épaisseur de la bordure
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(bluePen, 2.5f, 2.5f, 100, 100);
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
            Label[] categorieLabels = { l_categorie1, l_categorie2, l_categorie3 };
            Label[] destinataireLabels = { l_dest1, l_dest2, l_dest3 };
            Label[] amountLabels = { l_montant1, l_montant2, l_montant3 };
            Label[] dateLabels = { l_date1, l_date2, l_date3 };
            Label[] etatLabels = { l_etat1, l_etat2, l_etat3 };

            // Parcourir les transactions et mettre à jour les labels
            for (int i = 0; i < dernieresTransactions.Count; i++)
            {
                var lastTransaction = dernieresTransactions[i];

                // Mettre à jour les labels
                categorieLabels[i].Text = $"{lastTransaction.Categorie}";
                destinataireLabels[i].Text = $"{lastTransaction.Destinataire}";
                amountLabels[i].Text = $"{lastTransaction.Montant:C}";
                amountLabels[i].ForeColor = lastTransaction.Montant < 0 ? Color.Red : Color.Green; // Couleur conditionnelle
                dateLabels[i].Text = $"{lastTransaction.Date:dd/MM/yyyy}";
                etatLabels[i].Text = $"{lastTransaction.Etat}";
            }
        }

        private void afficherSoldeCompte() 
        {

            var solde = controleur.getSoldeCompte(compte);
            l_solde.Text = $"{solde} $";
        }

    }
}
