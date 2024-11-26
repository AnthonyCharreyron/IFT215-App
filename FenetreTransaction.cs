using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliBoursoBank
{
    public partial class FenetreTransaction : Form
    {
        private Transaction transaction;
        public FenetreTransaction(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;

            // Initialiser la taille de la fenêtre de dialogue
            Size = new Size(500, 400);
            Text = "Informations sur la transaction";
            StartPosition = FormStartPosition.CenterScreen; // Centrer la fenêtre

            l_categorie.Text = transaction.Categorie.ToString();
            l_date_etat.Text = transaction.Date.ToString("d") + " - " + transaction.Etat;
            l_description.Text = transaction.Description;
            l_modepaiement.Text = transaction.ModeTransaction;
            l_montant.Text = transaction.Montant.ToString() + " $";
            l_montant.ForeColor = transaction.Montant < 0 ? Color.Red : Color.Green;
            l_destinataire.Text = transaction.Destinataire;

        }
    }
}
