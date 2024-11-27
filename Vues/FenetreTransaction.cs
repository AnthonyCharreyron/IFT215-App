using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppliBoursoBank.Controleurs;
using AppliBoursoBank.Modeles;

namespace AppliBoursoBank
{
    public partial class FenetreTransaction : Form, IObserver<Transaction>
    {
        private Transaction transaction;

        private ControleurFenetreTransaction controleur;
        public FenetreTransaction(Transaction transaction, IObserver<Transaction> observer)
        {

            InitializeComponent();
            this.transaction = transaction;

            this.controleur = new ControleurFenetreTransaction(transaction);
            controleur.Subscribe(this);
            controleur.Subscribe(observer);

            // Initialiser la taille de la fenêtre de dialogue
            Size = new Size(500, 400);
            Text = "Informations sur la transaction";
            StartPosition = FormStartPosition.CenterScreen; // Centrer la fenêtre

            // initialisation des valeurs de la transaction à afficher
            l_categorie.Text = transaction.Categorie.ToString();
            l_date_etat.Text = transaction.Date.ToString("d") + " - " + transaction.Etat;
            l_description.Text = transaction.Description;
            l_modepaiement.Text = transaction.ModeTransaction;
            l_montant.Text = transaction.Montant.ToString() + " $";
            l_montant.ForeColor = transaction.Montant < 0 ? Color.Red : Color.Green;
            l_destinataire.Text = transaction.Destinataire;

            if (transaction.Etat == "Contestée")
            {
                b_contester.Visible = false;
            }

            // événements boutons modifier la transaction
            b_modifsave.Click += ModifierTransaction_Click;
            b_annulermodif.Click += AnnulerModification_Click;

            // valeurs par défaut des inputs lors de la modification de la transaction
            cb_categorie.SelectedItem = transaction.Categorie.ToString();
            cb_modepaiement.SelectedItem = transaction.ModeTransaction; 
            tb_description.Text = transaction.Description;

            // événement bouton contester transaction
            b_contester.Click += ContesterTransaction_Click;
        }

        public void ModifierTransaction_Click(object sender, EventArgs e)
        {
            bool modif = (b_modifsave.Tag.ToString() == "modifier");

            if (!modif) { // enregistrement des nouvelles données
                controleur.ModifierTransaction(this.transaction, cb_categorie.SelectedItem.ToString(), cb_modepaiement.SelectedItem.ToString(), tb_description.Text);
            }

            l_categorie.Visible = !modif ;
            l_modepaiement.Visible = !modif;
            l_description.Visible = !modif;
            cb_categorie.Visible = modif;
            cb_modepaiement.Visible = modif;
            tb_description.Visible = modif;
            b_annulermodif.Visible = modif;

            
            b_modifsave.Tag = modif ? "enregistrer" : "modifier";
            b_modifsave.BackColor = modif ? Color.LightGreen : Color.LightGray;
            b_modifsave.Text = modif ? "Enregistrer" : "Modifier";
            

        }

        public void AnnulerModification_Click(object sender, EventArgs e)
        {
            l_categorie.Visible = true;
            l_modepaiement.Visible = true;
            l_description.Visible = true;
            cb_categorie.Visible = false;
            cb_modepaiement.Visible = false;
            tb_description.Visible = false;
            b_annulermodif.Visible = false;

            b_modifsave.Tag = "modifier";
            b_modifsave.BackColor = Color.LightGray;
            b_modifsave.Text ="Modifier";

            cb_categorie.SelectedItem = transaction.Categorie.ToString();
            cb_modepaiement.SelectedItem = transaction.ModeTransaction;
            tb_description.Text = transaction.Description;

        }

        public void ContesterTransaction_Click(object sender, EventArgs e)
        {
            controleur.contesterTransaction(this.transaction);
            b_contester.Visible = false;
            l_date_etat.ForeColor = Color.LightCoral;
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
            l_categorie.Text = transaction.Categorie.ToString();
            l_modepaiement.Text = transaction.ModeTransaction;
            l_description.Text = transaction.Description;
            l_date_etat.Text = transaction.Date.ToString("d") + " - " + transaction.Etat;

        }
    }
}
