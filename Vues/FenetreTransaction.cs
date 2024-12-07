using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        private Controleur controleur;

        // Constructeur de la FenetreTransaction
        public FenetreTransaction(Transaction transaction, Controleur controleur)
        {
            this.transaction = transaction;

            // Abonnement à l'observateur
            this.controleur = controleur;
            controleur.Subscribe(this);

            // Ajout d'événement lors de la fermeture, pour se désabonner de l'observateur
            this.FormClosed += new FormClosedEventHandler(Form_FormClosed);

            // Initialisation de la page
            InitializeComponent();

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

            // initialisation si la fenêtre est constestée
            if (transaction.Etat == "Contestée")
            {
                b_contester.Visible = false;
                l_date_etat.ForeColor = Color.Red;
                l_date_etat.Font =  new Font(l_date_etat.Font, l_date_etat.Font.Style | FontStyle.Bold);
                this.BackColor = Color.LightCoral;
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

        // Evénement pour modifier ou enregistrer la transaction
        public void ModifierTransaction_Click(object sender, EventArgs e)
        {
            // On regarde l'état du bouton
            bool modif = (b_modifsave.Tag.ToString() == "modifier");

            // Si on enregistre les données
            if (!modif) { // envoi des données
                this.controleur.ModifierTransaction(this.transaction, cb_categorie.SelectedItem.ToString(), cb_modepaiement.SelectedItem.ToString(), tb_description.Text);
            }

            // Affichage ou non des labels
            l_categorie.Visible = !modif ;
            l_modepaiement.Visible = !modif;
            l_description.Visible = !modif;

            // Affichachage ou non des combobox, textbox et bouton "Annuler"
            cb_categorie.Visible = modif;
            cb_modepaiement.Visible = modif;
            tb_description.Visible = modif;
            b_annulermodif.Visible = modif;

            // Modification du bouton Modifier/Enregistrer selon son état précédent
            b_modifsave.Tag = modif ? "enregistrer" : "modifier";
            b_modifsave.BackColor = modif ? Color.LightGreen : Color.LightGray;
            b_modifsave.Text = modif ? "Enregistrer" : "Modifier";
        }

        // Evénement qui permet d'annuler les modifications
        public void AnnulerModification_Click(object sender, EventArgs e)
        {
            // On rend visible les labels
            l_categorie.Visible = true;
            l_modepaiement.Visible = true;
            l_description.Visible = true;

            // On cache les combobox,la textbox et le bouton "Annuler"
            cb_categorie.Visible = false;
            cb_modepaiement.Visible = false;
            tb_description.Visible = false;
            b_annulermodif.Visible = false;

            // On remet le bouton Modifier/Enregistrer dans l'état Modifier
            b_modifsave.Tag = "modifier";
            b_modifsave.BackColor = Color.LightGray;
            b_modifsave.Text ="Modifier";

            // On remet à 0 les valeurs des cb et tb
            cb_categorie.SelectedItem = transaction.Categorie.ToString();
            cb_modepaiement.SelectedItem = transaction.ModeTransaction;
            tb_description.Text = transaction.Description;
        }

        // Evénement qui permet de constester une transaction
        public void ContesterTransaction_Click(object sender, EventArgs e)
        {
            // On change l'état pour la transaction
            this.controleur.contesterTransaction(this.transaction);

            // On cache le bouton constester
            b_contester.Visible = false;

            // On met à jour le label contenant l'état
            l_date_etat.ForeColor = Color.Red;
            l_date_etat.Font =  new Font(l_date_etat.Font, l_date_etat.Font.Style | FontStyle.Bold);

            // On met la transaction en rouge
            this.BackColor = Color.LightCoral;
        }

        // Evénement qui permet de se désabonner de l'observateur lors de la fermeture de la fenêtre
        public void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.controleur.unSubscribe(this);
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        // Lorsque l'on est notifié d'un changement, on met à jour les informations de la transaction
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
