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
        public FenetreTransaction()
        {
            InitializeComponent();

            // Initialiser la taille de la fenêtre de dialogue
            Size = new Size(500, 400);
            Text = "Informations sur la transaction";
            StartPosition = FormStartPosition.CenterScreen; // Centrer la fenêtre
        }
    }
}
