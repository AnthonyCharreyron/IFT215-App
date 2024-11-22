namespace AppliBoursoBank
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            l_categorie3 = new Label();
            l_etat3 = new Label();
            l_montant3 = new Label();
            l_date3 = new Label();
            l_dest3 = new Label();
            panel4 = new Panel();
            l_categorie2 = new Label();
            l_etat2 = new Label();
            l_montant2 = new Label();
            l_date2 = new Label();
            l_dest2 = new Label();
            panel1 = new Panel();
            l_categorie1 = new Label();
            l_etat1 = new Label();
            l_montant1 = new Label();
            l_date1 = new Label();
            l_dest1 = new Label();
            l_solde = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
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
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_budget).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_infocarte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_infocompte).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_virement).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(431, 121);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 0;
            label1.Text = "Compte courant :";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(189, 334);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(821, 259);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dernières transactions";
            // 
            // panel5
            // 
            panel5.Controls.Add(l_categorie3);
            panel5.Controls.Add(l_etat3);
            panel5.Controls.Add(l_montant3);
            panel5.Controls.Add(l_date3);
            panel5.Controls.Add(l_dest3);
            panel5.Location = new Point(6, 168);
            panel5.Name = "panel5";
            panel5.Size = new Size(809, 65);
            panel5.TabIndex = 5;
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
            // panel4
            // 
            panel4.Controls.Add(l_categorie2);
            panel4.Controls.Add(l_etat2);
            panel4.Controls.Add(l_montant2);
            panel4.Controls.Add(l_date2);
            panel4.Controls.Add(l_dest2);
            panel4.Location = new Point(6, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(809, 65);
            panel4.TabIndex = 4;
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
            // panel1
            // 
            panel1.Controls.Add(l_categorie1);
            panel1.Controls.Add(l_etat1);
            panel1.Controls.Add(l_montant1);
            panel1.Controls.Add(l_date1);
            panel1.Controls.Add(l_dest1);
            panel1.Location = new Point(6, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 65);
            panel1.TabIndex = 0;
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
            l_solde.ForeColor = Color.DodgerBlue;
            l_solde.Location = new Point(607, 121);
            l_solde.Name = "l_solde";
            l_solde.Size = new Size(72, 31);
            l_solde.TabIndex = 4;
            l_solde.Text = "200 $";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1179, 80);
            panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(9, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.ForeColor = Color.DodgerBlue;
            label9.Location = new Point(866, 28);
            label9.Name = "label9";
            label9.Size = new Size(135, 25);
            label9.TabIndex = 5;
            label9.Text = "Bourse et Actus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(634, 28);
            label8.Name = "label8";
            label8.Size = new Size(205, 25);
            label8.TabIndex = 4;
            label8.Text = "Bons plans et Parrainage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(529, 28);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 3;
            label7.Text = "Produits";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = Color.DodgerBlue;
            label6.Location = new Point(428, 28);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 2;
            label6.Text = "Services";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(284, 28);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 1;
            label5.Text = "Mes comptes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(192, 28);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 0;
            label4.Text = "Accueil";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
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
            panel3.Location = new Point(189, 182);
            panel3.Name = "panel3";
            panel3.Size = new Size(821, 140);
            panel3.TabIndex = 6;
            // 
            // img_budget
            // 
            img_budget.Image = Properties.Resources.gestionbudget;
            img_budget.Location = new Point(680, 10);
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
            img_infocompte.Name = "img_infocompte";
            img_infocompte.Size = new Size(105, 105);
            img_infocompte.SizeMode = PictureBoxSizeMode.CenterImage;
            img_infocompte.TabIndex = 8;
            img_infocompte.TabStop = false;
            // 
            // img_virement
            // 
            img_virement.Image = Properties.Resources.echange1;
            img_virement.InitialImage = null;
            img_virement.Location = new Point(32, 10);
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
            label13.Location = new Point(677, 113);
            label13.Name = "label13";
            label13.Size = new Size(113, 20);
            label13.TabIndex = 7;
            label13.Text = "Gestion budget";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
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
            label11.Location = new Point(254, 111);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 5;
            label11.Text = "Infos compte";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 616);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(l_solde);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_budget).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_infocarte).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_infocompte).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_virement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Panel panel1;
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
        private Panel panel4;
        private Label l_etat2;
        private Label l_montant2;
        private Label l_date2;
        private Label l_dest2;
        private Label l_etat1;
        private Label l_montant1;
        private Panel panel5;
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
        private PictureBox pictureBox1;
    }
}
