namespace AppliBoursoBank
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
            b_annulermodif = new Button();
            b_modifsave = new Button();
            l_description = new Label();
            l_modepaiement = new Label();
            l_categorie = new Label();
            label6 = new Label();
            label5 = new Label();
            cb_categorie = new ComboBox();
            cb_modepaiement = new ComboBox();
            tb_description = new TextBox();
            b_contester = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // l_destinataire
            // 
            l_destinataire.AutoSize = true;
            l_destinataire.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_destinataire.Location = new Point(34, 23);
            l_destinataire.Name = "l_destinataire";
            l_destinataire.Size = new Size(101, 23);
            l_destinataire.TabIndex = 0;
            l_destinataire.Text = "Destinataire";
            // 
            // l_date_etat
            // 
            l_date_etat.AutoSize = true;
            l_date_etat.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_date_etat.ForeColor = Color.Gray;
            l_date_etat.Location = new Point(37, 46);
            l_date_etat.Name = "l_date_etat";
            l_date_etat.Size = new Size(70, 17);
            l_date_etat.TabIndex = 1;
            l_date_etat.Text = "Date - état";
            // 
            // l_montant
            // 
            l_montant.AutoSize = true;
            l_montant.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_montant.Location = new Point(314, 34);
            l_montant.Name = "l_montant";
            l_montant.Size = new Size(94, 28);
            l_montant.TabIndex = 2;
            l_montant.Text = "Montant";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.MediumVioletRed;
            label4.Location = new Point(94, 32);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Catégorie :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(b_annulermodif);
            groupBox1.Controls.Add(b_modifsave);
            groupBox1.Controls.Add(l_description);
            groupBox1.Controls.Add(l_modepaiement);
            groupBox1.Controls.Add(l_categorie);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cb_categorie);
            groupBox1.Controls.Add(cb_modepaiement);
            groupBox1.Controls.Add(tb_description);
            groupBox1.Location = new Point(34, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 213);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Détails";
            // 
            // b_annulermodif
            // 
            b_annulermodif.BackColor = Color.LightCoral;
            b_annulermodif.Location = new Point(209, 178);
            b_annulermodif.Name = "b_annulermodif";
            b_annulermodif.Size = new Size(94, 29);
            b_annulermodif.TabIndex = 13;
            b_annulermodif.Tag = "";
            b_annulermodif.Text = "Annuler";
            b_annulermodif.UseVisualStyleBackColor = false;
            b_annulermodif.Visible = false;
            // 
            // b_modifsave
            // 
            b_modifsave.BackColor = Color.LightGray;
            b_modifsave.Location = new Point(310, 178);
            b_modifsave.Name = "b_modifsave";
            b_modifsave.Size = new Size(94, 29);
            b_modifsave.TabIndex = 9;
            b_modifsave.Tag = "modifier";
            b_modifsave.Text = "Modifier";
            b_modifsave.UseVisualStyleBackColor = false;
            // 
            // l_description
            // 
            l_description.AutoSize = true;
            l_description.ForeColor = Color.DodgerBlue;
            l_description.Location = new Point(209, 122);
            l_description.MaximumSize = new Size(180, 0);
            l_description.Name = "l_description";
            l_description.Size = new Size(83, 20);
            l_description.TabIndex = 8;
            l_description.Text = "description";
            // 
            // l_modepaiement
            // 
            l_modepaiement.AutoSize = true;
            l_modepaiement.ForeColor = Color.DodgerBlue;
            l_modepaiement.Location = new Point(209, 79);
            l_modepaiement.Name = "l_modepaiement";
            l_modepaiement.Size = new Size(48, 20);
            l_modepaiement.TabIndex = 7;
            l_modepaiement.Text = "mode";
            // 
            // l_categorie
            // 
            l_categorie.AutoSize = true;
            l_categorie.ForeColor = Color.DodgerBlue;
            l_categorie.Location = new Point(209, 34);
            l_categorie.Name = "l_categorie";
            l_categorie.Size = new Size(72, 20);
            l_categorie.TabIndex = 6;
            l_categorie.Text = "catégorie";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.MediumVioletRed;
            label6.Location = new Point(82, 119);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 5;
            label6.Text = "Description :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.MediumVioletRed;
            label5.Location = new Point(19, 76);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 4;
            label5.Text = "Mode de transaction :";
            // 
            // cb_categorie
            // 
            cb_categorie.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_categorie.FormattingEnabled = true;
            cb_categorie.Items.AddRange(new object[] { "Alimentation", "Loisirs", "Transports", "Logement", "Santé", "Revenus", "Autre" });
            cb_categorie.Location = new Point(209, 29);
            cb_categorie.Name = "cb_categorie";
            cb_categorie.Size = new Size(170, 28);
            cb_categorie.TabIndex = 11;
            cb_categorie.Visible = false;
            // 
            // cb_modepaiement
            // 
            cb_modepaiement.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_modepaiement.FormattingEnabled = true;
            cb_modepaiement.Items.AddRange(new object[] { "Carte bancaire", "Espèce", "Virement", "Chèque", "Autre" });
            cb_modepaiement.Location = new Point(209, 76);
            cb_modepaiement.Name = "cb_modepaiement";
            cb_modepaiement.Size = new Size(170, 28);
            cb_modepaiement.TabIndex = 12;
            cb_modepaiement.Visible = false;
            // 
            // tb_description
            // 
            tb_description.Location = new Point(209, 119);
            tb_description.MaximumSize = new Size(170, 60);
            tb_description.Multiline = true;
            tb_description.Name = "tb_description";
            tb_description.ScrollBars = ScrollBars.Vertical;
            tb_description.Size = new Size(170, 56);
            tb_description.TabIndex = 11;
            tb_description.Visible = false;
            // 
            // b_contester
            // 
            b_contester.BackColor = Color.SkyBlue;
            b_contester.ForeColor = Color.DarkBlue;
            b_contester.ImageAlign = ContentAlignment.BottomCenter;
            b_contester.Location = new Point(158, 312);
            b_contester.Name = "b_contester";
            b_contester.Size = new Size(160, 29);
            b_contester.TabIndex = 10;
            b_contester.Text = "Contester la dépense";
            b_contester.UseVisualStyleBackColor = false;
            // 
            // FenetreTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 353);
            Controls.Add(b_contester);
            Controls.Add(groupBox1);
            Controls.Add(l_montant);
            Controls.Add(l_date_etat);
            Controls.Add(l_destinataire);
            MaximumSize = new Size(500, 400);
            MinimumSize = new Size(500, 400);
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
        private Button b_modifsave;
        private Button b_contester;
        private TextBox tb_description;
        private ComboBox cb_modepaiement;
        private ComboBox cb_categorie;
        private Button b_annulermodif;
    }
}