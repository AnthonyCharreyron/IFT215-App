﻿namespace AppliBoursoBank
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel12 = new Panel();
            p_transaction3 = new Panel();
            l_categorie3 = new Label();
            l_etat3 = new Label();
            l_montant3 = new Label();
            l_date3 = new Label();
            l_dest3 = new Label();
            p_transaction2 = new Panel();
            l_categorie2 = new Label();
            l_etat2 = new Label();
            l_montant2 = new Label();
            l_date2 = new Label();
            l_dest2 = new Label();
            p_transaction1 = new Panel();
            l_categorie1 = new Label();
            l_etat1 = new Label();
            l_montant1 = new Label();
            l_date1 = new Label();
            l_dest1 = new Label();
            l_solde = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            panel3 = new Panel();
            img_budget = new PictureBox();
            img_infocarte = new PictureBox();
            img_infocompte = new PictureBox();
            img_virement = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            p_transaction3.SuspendLayout();
            p_transaction2.SuspendLayout();
            p_transaction1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_budget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_infocarte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_infocompte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_virement).BeginInit();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(266, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Compte courant :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(panel12);
            groupBox1.Controls.Add(p_transaction3);
            groupBox1.Controls.Add(p_transaction2);
            groupBox1.Controls.Add(p_transaction1);
            groupBox1.Location = new Point(24, 227);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dernières transactions";
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Location = new Point(19, 94);
            panel12.Name = "panel12";
            panel12.Size = new Size(780, 1);
            panel12.TabIndex = 7;
            // 
            // p_transaction3
            // 
            p_transaction3.Controls.Add(l_categorie3);
            p_transaction3.Controls.Add(l_etat3);
            p_transaction3.Controls.Add(l_montant3);
            p_transaction3.Controls.Add(l_date3);
            p_transaction3.Controls.Add(l_dest3);
            p_transaction3.Location = new Point(6, 168);
            p_transaction3.Name = "p_transaction3";
            p_transaction3.Size = new Size(809, 65);
            p_transaction3.TabIndex = 5;
            // 
            // l_categorie3
            // 
            l_categorie3.AutoSize = true;
            l_categorie3.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            l_categorie3.Location = new Point(14, 22);
            l_categorie3.Name = "l_categorie3";
            l_categorie3.Size = new Size(80, 23);
            l_categorie3.TabIndex = 6;
            l_categorie3.Text = "Catégorie";
            // 
            // l_etat3
            // 
            l_etat3.AutoSize = true;
            l_etat3.Font = new Font("Segoe UI", 9F);
            l_etat3.ForeColor = Color.Gray;
            l_etat3.Location = new Point(733, 22);
            l_etat3.Name = "l_etat3";
            l_etat3.Size = new Size(35, 20);
            l_etat3.TabIndex = 3;
            l_etat3.Text = "Etat";
            // 
            // l_montant3
            // 
            l_montant3.AutoSize = true;
            l_montant3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            l_montant3.Location = new Point(524, 22);
            l_montant3.Name = "l_montant3";
            l_montant3.Size = new Size(77, 23);
            l_montant3.TabIndex = 2;
            l_montant3.Text = "Montant";
            // 
            // l_date3
            // 
            l_date3.AutoSize = true;
            l_date3.Font = new Font("Segoe UI", 10.2F);
            l_date3.Location = new Point(325, 22);
            l_date3.Name = "l_date3";
            l_date3.Size = new Size(46, 23);
            l_date3.TabIndex = 1;
            l_date3.Text = "Date";
            // 
            // l_dest3
            // 
            l_dest3.AutoSize = true;
            l_dest3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            l_dest3.Location = new Point(172, 22);
            l_dest3.Name = "l_dest3";
            l_dest3.Size = new Size(101, 23);
            l_dest3.TabIndex = 0;
            l_dest3.Text = "Destinataire";
            // 
            // p_transaction2
            // 
            p_transaction2.Controls.Add(l_categorie2);
            p_transaction2.Controls.Add(l_etat2);
            p_transaction2.Controls.Add(l_montant2);
            p_transaction2.Controls.Add(l_date2);
            p_transaction2.Controls.Add(l_dest2);
            p_transaction2.Location = new Point(6, 97);
            p_transaction2.Name = "p_transaction2";
            p_transaction2.Size = new Size(809, 65);
            p_transaction2.TabIndex = 4;
            // 
            // l_categorie2
            // 
            l_categorie2.AutoSize = true;
            l_categorie2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            l_categorie2.Location = new Point(14, 22);
            l_categorie2.Name = "l_categorie2";
            l_categorie2.Size = new Size(80, 23);
            l_categorie2.TabIndex = 5;
            l_categorie2.Text = "Catégorie";
            // 
            // l_etat2
            // 
            l_etat2.AutoSize = true;
            l_etat2.Font = new Font("Segoe UI", 9F);
            l_etat2.ForeColor = Color.Gray;
            l_etat2.Location = new Point(733, 22);
            l_etat2.Name = "l_etat2";
            l_etat2.Size = new Size(35, 20);
            l_etat2.TabIndex = 3;
            l_etat2.Text = "Etat";
            // 
            // l_montant2
            // 
            l_montant2.AutoSize = true;
            l_montant2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            l_montant2.Location = new Point(524, 22);
            l_montant2.Name = "l_montant2";
            l_montant2.Size = new Size(77, 23);
            l_montant2.TabIndex = 2;
            l_montant2.Text = "Montant";
            // 
            // l_date2
            // 
            l_date2.AutoSize = true;
            l_date2.Font = new Font("Segoe UI", 10.2F);
            l_date2.Location = new Point(325, 22);
            l_date2.Name = "l_date2";
            l_date2.Size = new Size(46, 23);
            l_date2.TabIndex = 1;
            l_date2.Text = "Date";
            // 
            // l_dest2
            // 
            l_dest2.AutoSize = true;
            l_dest2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            l_dest2.Location = new Point(172, 22);
            l_dest2.Name = "l_dest2";
            l_dest2.Size = new Size(101, 23);
            l_dest2.TabIndex = 0;
            l_dest2.Text = "Destinataire";
            // 
            // p_transaction1
            // 
            p_transaction1.Controls.Add(l_categorie1);
            p_transaction1.Controls.Add(l_etat1);
            p_transaction1.Controls.Add(l_montant1);
            p_transaction1.Controls.Add(l_date1);
            p_transaction1.Controls.Add(l_dest1);
            p_transaction1.Location = new Point(6, 26);
            p_transaction1.Name = "p_transaction1";
            p_transaction1.Size = new Size(809, 65);
            p_transaction1.TabIndex = 0;
            // 
            // l_categorie1
            // 
            l_categorie1.AutoSize = true;
            l_categorie1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            l_categorie1.Location = new Point(13, 22);
            l_categorie1.Name = "l_categorie1";
            l_categorie1.Size = new Size(80, 23);
            l_categorie1.TabIndex = 4;
            l_categorie1.Text = "Catégorie";
            // 
            // l_etat1
            // 
            l_etat1.AutoSize = true;
            l_etat1.Font = new Font("Segoe UI", 9F);
            l_etat1.ForeColor = Color.Gray;
            l_etat1.Location = new Point(733, 22);
            l_etat1.Name = "l_etat1";
            l_etat1.Size = new Size(35, 20);
            l_etat1.TabIndex = 3;
            l_etat1.Text = "Etat";
            // 
            // l_montant1
            // 
            l_montant1.AutoSize = true;
            l_montant1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            l_montant1.Location = new Point(524, 22);
            l_montant1.Name = "l_montant1";
            l_montant1.Size = new Size(77, 23);
            l_montant1.TabIndex = 2;
            l_montant1.Text = "Montant";
            // 
            // l_date1
            // 
            l_date1.AutoSize = true;
            l_date1.Font = new Font("Segoe UI", 10.2F);
            l_date1.Location = new Point(325, 22);
            l_date1.Name = "l_date1";
            l_date1.Size = new Size(46, 23);
            l_date1.TabIndex = 1;
            l_date1.Text = "Date";
            // 
            // l_dest1
            // 
            l_dest1.AutoSize = true;
            l_dest1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            l_dest1.Location = new Point(172, 22);
            l_dest1.Name = "l_dest1";
            l_dest1.Size = new Size(101, 23);
            l_dest1.TabIndex = 0;
            l_dest1.Text = "Destinataire";
            // 
            // l_solde
            // 
            l_solde.AutoSize = true;
            l_solde.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_solde.ForeColor = Color.DarkBlue;
            l_solde.Location = new Point(442, 14);
            l_solde.Name = "l_solde";
            l_solde.Size = new Size(108, 31);
            l_solde.TabIndex = 4;
            l_solde.Text = "Montant";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 84);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo;
            pictureBox3.Location = new Point(2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 78);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1100, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Location = new Point(186, 5);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 70);
            panel11.TabIndex = 12;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(855, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 70);
            panel10.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(623, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 70);
            panel9.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(520, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 70);
            panel8.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(420, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 70);
            panel7.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(275, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 70);
            panel6.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(857, 8);
            label9.Name = "label9";
            label9.Padding = new Padding(10, 20, 10, 20);
            label9.Size = new Size(155, 65);
            label9.TabIndex = 5;
            label9.Text = "Bourse et Actus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(627, 8);
            label8.Name = "label8";
            label8.Padding = new Padding(10, 20, 10, 20);
            label8.Size = new Size(225, 65);
            label8.TabIndex = 4;
            label8.Text = "Bons plans et Parrainage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(524, 8);
            label7.Name = "label7";
            label7.Padding = new Padding(10, 20, 10, 20);
            label7.Size = new Size(98, 65);
            label7.TabIndex = 3;
            label7.Text = "Produits";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(424, 8);
            label6.Name = "label6";
            label6.Padding = new Padding(10, 20, 10, 20);
            label6.Size = new Size(95, 65);
            label6.TabIndex = 2;
            label6.Text = "Services";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(280, 8);
            label5.Name = "label5";
            label5.Padding = new Padding(10, 20, 10, 20);
            label5.Size = new Size(139, 65);
            label5.TabIndex = 1;
            label5.Text = "Mes comptes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCyan;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(188, 1);
            label4.Name = "label4";
            label4.Padding = new Padding(10, 28, 10, 28);
            label4.Size = new Size(87, 81);
            label4.TabIndex = 0;
            label4.Text = "Accueil";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.ForeColor = Color.MediumVioletRed;
            label10.Location = new Point(47, 113);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 4;
            label10.Text = "Virements";
            // 
            // panel3
            // 
            panel3.Controls.Add(img_budget);
            panel3.Controls.Add(img_infocarte);
            panel3.Controls.Add(img_infocompte);
            panel3.Controls.Add(img_virement);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(24, 75);
            panel3.Name = "panel3";
            panel3.Size = new Size(821, 140);
            panel3.TabIndex = 6;
            // 
            // img_budget
            // 
            img_budget.Image = Properties.Resources.gestionbudget;
            img_budget.Location = new Point(680, 10);
            img_budget.MaximumSize = new Size(105, 105);
            img_budget.MinimumSize = new Size(105, 105);
            img_budget.Name = "img_budget";
            img_budget.Size = new Size(105, 105);
            img_budget.SizeMode = PictureBoxSizeMode.CenterImage;
            img_budget.TabIndex = 10;
            img_budget.TabStop = false;
            // 
            // img_infocarte
            // 
            img_infocarte.Image = Properties.Resources.infocarte;
            img_infocarte.Location = new Point(465, 9);
            img_infocarte.MaximumSize = new Size(105, 105);
            img_infocarte.MinimumSize = new Size(105, 105);
            img_infocarte.Name = "img_infocarte";
            img_infocarte.Size = new Size(105, 105);
            img_infocarte.SizeMode = PictureBoxSizeMode.CenterImage;
            img_infocarte.TabIndex = 9;
            img_infocarte.TabStop = false;
            // 
            // img_infocompte
            // 
            img_infocompte.Image = Properties.Resources.infocompte1;
            img_infocompte.Location = new Point(249, 7);
            img_infocompte.MaximumSize = new Size(105, 105);
            img_infocompte.MinimumSize = new Size(105, 105);
            img_infocompte.Name = "img_infocompte";
            img_infocompte.Size = new Size(105, 105);
            img_infocompte.SizeMode = PictureBoxSizeMode.CenterImage;
            img_infocompte.TabIndex = 8;
            img_infocompte.TabStop = false;
            // 
            // img_virement
            // 
            img_virement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            img_virement.Image = Properties.Resources.echange1;
            img_virement.InitialImage = null;
            img_virement.Location = new Point(32, 10);
            img_virement.MaximumSize = new Size(105, 105);
            img_virement.MinimumSize = new Size(105, 105);
            img_virement.Name = "img_virement";
            img_virement.Size = new Size(105, 105);
            img_virement.SizeMode = PictureBoxSizeMode.CenterImage;
            img_virement.TabIndex = 7;
            img_virement.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label13.ForeColor = Color.MediumVioletRed;
            label13.Location = new Point(656, 113);
            label13.Name = "label13";
            label13.Size = new Size(149, 20);
            label13.TabIndex = 7;
            label13.Text = "Recettes et dépenses";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label12.ForeColor = Color.MediumVioletRed;
            label12.Location = new Point(478, 113);
            label12.Name = "label12";
            label12.Size = new Size(80, 20);
            label12.TabIndex = 6;
            label12.Text = "Infos carte";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.ForeColor = Color.MediumVioletRed;
            label11.Location = new Point(237, 113);
            label11.Name = "label11";
            label11.Size = new Size(131, 20);
            label11.TabIndex = 5;
            label11.Text = "Gestion compte(s)";
            // 
            // panel13
            // 
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Location = new Point(44, 390);
            panel13.Name = "panel13";
            panel13.Size = new Size(780, 1);
            panel13.TabIndex = 8;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel14.Controls.Add(panel13);
            panel14.Controls.Add(panel3);
            panel14.Controls.Add(l_solde);
            panel14.Controls.Add(groupBox1);
            panel14.Controls.Add(label1);
            panel14.Location = new Point(165, 107);
            panel14.Name = "panel14";
            panel14.Size = new Size(868, 498);
            panel14.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(57, 92);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(71, 23);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Accueil/";
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 616);
            Controls.Add(linkLabel1);
            Controls.Add(panel14);
            Controls.Add(panel2);
            MaximumSize = new Size(1202, 663);
            MinimumSize = new Size(1202, 663);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            p_transaction3.ResumeLayout(false);
            p_transaction3.PerformLayout();
            p_transaction2.ResumeLayout(false);
            p_transaction2.PerformLayout();
            p_transaction1.ResumeLayout(false);
            p_transaction1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_budget).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_infocarte).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_infocompte).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_virement).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Panel p_transaction1;
        private Label l_solde;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private Panel panel3;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label l_dest1;
        private Label l_date1;
        private Panel p_transaction2;
        private Label l_etat2;
        private Label l_montant2;
        private Label l_date2;
        private Label l_dest2;
        private Label l_etat1;
        private Label l_montant1;
        private Panel p_transaction3;
        private Label l_etat3;
        private Label l_montant3;
        private Label l_date3;
        private Label l_dest3;
        private PictureBox img_virement;
        private PictureBox img_infocompte;
        private PictureBox img_infocarte;
        private PictureBox img_budget;
        private Label l_categorie2;
        private Label l_categorie1;
        private Label l_categorie3;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
    }
}
