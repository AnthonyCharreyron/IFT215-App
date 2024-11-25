﻿namespace AppliBoursoBank
{
    partial class FenetreTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            l_destinataire = new Label();
            l_date_etat = new Label();
            l_montant = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            l_categorie = new Label();
            l_modepaiement = new Label();
            l_description = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // l_destinataire
            // 
            l_destinataire.AutoSize = true;
            l_destinataire.Location = new Point(21, 18);
            l_destinataire.Name = "l_destinataire";
            l_destinataire.Size = new Size(89, 20);
            l_destinataire.TabIndex = 0;
            l_destinataire.Text = "Destinataire";
            // 
            // l_date_etat
            // 
            l_date_etat.AutoSize = true;
            l_date_etat.Location = new Point(34, 46);
            l_date_etat.Name = "l_date_etat";
            l_date_etat.Size = new Size(81, 20);
            l_date_etat.TabIndex = 1;
            l_date_etat.Text = "Date - état";
            // 
            // l_montant
            // 
            l_montant.AutoSize = true;
            l_montant.Location = new Point(345, 31);
            l_montant.Name = "l_montant";
            l_montant.Size = new Size(65, 20);
            l_montant.TabIndex = 2;
            l_montant.Text = "Montant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 40);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Catégorie :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(l_description);
            groupBox1.Controls.Add(l_modepaiement);
            groupBox1.Controls.Add(l_categorie);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(34, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 213);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 77);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 4;
            label5.Text = "Mode de transaction :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 114);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 5;
            label6.Text = "Description :";
            // 
            // l_categorie
            // 
            l_categorie.AutoSize = true;
            l_categorie.Location = new Point(185, 40);
            l_categorie.Name = "l_categorie";
            l_categorie.Size = new Size(72, 20);
            l_categorie.TabIndex = 6;
            l_categorie.Text = "catégorie";
            // 
            // l_modepaiement
            // 
            l_modepaiement.AutoSize = true;
            l_modepaiement.Location = new Point(185, 77);
            l_modepaiement.Name = "l_modepaiement";
            l_modepaiement.Size = new Size(48, 20);
            l_modepaiement.TabIndex = 7;
            l_modepaiement.Text = "mode";
            // 
            // l_description
            // 
            l_description.AutoSize = true;
            l_description.Location = new Point(52, 143);
            l_description.Name = "l_description";
            l_description.Size = new Size(83, 20);
            l_description.TabIndex = 8;
            l_description.Text = "description";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(310, 178);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Modifier";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.ForeColor = Color.DarkBlue;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(158, 312);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 10;
            button2.Text = "Contester la dépense";
            button2.UseVisualStyleBackColor = false;
            // 
            // FenetreTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(l_montant);
            Controls.Add(l_date_etat);
            Controls.Add(l_destinataire);
            Name = "FenetreTransaction";
            Text = "FenetreTransaction";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_destinataire;
        private Label l_date_etat;
        private Label l_montant;
        private Label label4;
        private GroupBox groupBox1;
        private Label l_description;
        private Label l_modepaiement;
        private Label l_categorie;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}