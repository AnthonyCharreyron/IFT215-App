﻿namespace AppliBoursoBank
{
    partial class GestionBudget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionBudget));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            panel1 = new Panel();
            p_nextMonth = new PictureBox();
            p_previousMonth = new PictureBox();
            l_month = new Label();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            cb_all = new ComboBox();
            l_totmensuel = new Label();
            l_balancemensuelle = new Label();
            label13 = new Label();
            flp_general = new FlowLayoutPanel();
            chartAll = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage1 = new TabPage();
            cb_depenses = new ComboBox();
            l_totdepenses = new Label();
            label10 = new Label();
            label2 = new Label();
            flp_depenses = new FlowLayoutPanel();
            chartDepenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage2 = new TabPage();
            cb_recettes = new ComboBox();
            l_totrecettes = new Label();
            label12 = new Label();
            label3 = new Label();
            flp_recettes = new FlowLayoutPanel();
            chartRecettes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            p_logo = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            l_menuaccueil = new Label();
            link_accueil = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)p_nextMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_previousMonth).BeginInit();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartAll).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDepenses).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRecettes).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)p_logo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(372, -1);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 1;
            label1.Text = "Gestion budgétaire";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(p_nextMonth);
            panel1.Controls.Add(p_previousMonth);
            panel1.Controls.Add(l_month);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(133, 126);
            panel1.Margin = new Padding(2);
            panel1.MaximumSize = new Size(929, 485);
            panel1.MinimumSize = new Size(929, 485);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 485);
            panel1.TabIndex = 2;
            // 
            // p_nextMonth
            // 
            p_nextMonth.Image = (Image)resources.GetObject("p_nextMonth.Image");
            p_nextMonth.Location = new Point(539, 28);
            p_nextMonth.MaximumSize = new Size(25, 25);
            p_nextMonth.MinimumSize = new Size(25, 25);
            p_nextMonth.Name = "p_nextMonth";
            p_nextMonth.Size = new Size(25, 25);
            p_nextMonth.TabIndex = 7;
            p_nextMonth.TabStop = false;
            // 
            // p_previousMonth
            // 
            p_previousMonth.Image = Properties.Resources.flecheGauche;
            p_previousMonth.Location = new Point(362, 28);
            p_previousMonth.MaximumSize = new Size(25, 25);
            p_previousMonth.MinimumSize = new Size(25, 25);
            p_previousMonth.Name = "p_previousMonth";
            p_previousMonth.Size = new Size(25, 25);
            p_previousMonth.TabIndex = 6;
            p_previousMonth.TabStop = false;
            // 
            // l_month
            // 
            l_month.AutoSize = true;
            l_month.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_month.ForeColor = Color.MediumVioletRed;
            l_month.Location = new Point(403, 33);
            l_month.Name = "l_month";
            l_month.Size = new Size(42, 20);
            l_month.TabIndex = 5;
            l_month.Text = "Mois";
            l_month.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(30, 48);
            tabControl1.Margin = new Padding(2);
            tabControl1.MaximumSize = new Size(870, 414);
            tabControl1.MinimumSize = new Size(870, 414);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 414);
            tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cb_all);
            tabPage3.Controls.Add(l_totmensuel);
            tabPage3.Controls.Add(l_balancemensuelle);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(flp_general);
            tabPage3.Controls.Add(chartAll);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(862, 376);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Général";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_all
            // 
            cb_all.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_all.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_all.FormattingEnabled = true;
            cb_all.IntegralHeight = false;
            cb_all.Items.AddRange(new object[] { "Toutes", "Loisirs", "Alimentation", "Transports", "Logement", "Santé", "Revenus", "Autre" });
            cb_all.Location = new Point(681, 55);
            cb_all.Margin = new Padding(2);
            cb_all.Name = "cb_all";
            cb_all.Size = new Size(146, 28);
            cb_all.TabIndex = 15;
            // 
            // l_totmensuel
            // 
            l_totmensuel.AutoSize = true;
            l_totmensuel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_totmensuel.ForeColor = Color.MediumVioletRed;
            l_totmensuel.Location = new Point(191, 22);
            l_totmensuel.Name = "l_totmensuel";
            l_totmensuel.Size = new Size(67, 20);
            l_totmensuel.TabIndex = 14;
            l_totmensuel.Text = "montant";
            l_totmensuel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_balancemensuelle
            // 
            l_balancemensuelle.AutoSize = true;
            l_balancemensuelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_balancemensuelle.ForeColor = Color.MediumVioletRed;
            l_balancemensuelle.Location = new Point(49, 22);
            l_balancemensuelle.Name = "l_balancemensuelle";
            l_balancemensuelle.Size = new Size(143, 20);
            l_balancemensuelle.TabIndex = 10;
            l_balancemensuelle.Text = "Balance mensuelle :";
            l_balancemensuelle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(528, 22);
            label13.Name = "label13";
            label13.Size = new Size(160, 20);
            label13.TabIndex = 13;
            label13.Text = "Liste des transactions :";
            // 
            // flp_general
            // 
            flp_general.AutoScroll = true;
            flp_general.BackColor = Color.Transparent;
            flp_general.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flp_general.Location = new Point(378, 83);
            flp_general.MaximumSize = new Size(448, 286);
            flp_general.MinimumSize = new Size(448, 286);
            flp_general.Name = "flp_general";
            flp_general.Size = new Size(448, 286);
            flp_general.TabIndex = 12;
            // 
            // chartAll
            // 
            chartArea1.Name = "ChartArea1";
            chartAll.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartAll.Legends.Add(legend1);
            chartAll.Location = new Point(5, 55);
            chartAll.Margin = new Padding(2);
            chartAll.Name = "chartAll";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartAll.Series.Add(series1);
            chartAll.Size = new Size(369, 322);
            chartAll.TabIndex = 11;
            chartAll.Text = "chart1";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(cb_depenses);
            tabPage1.Controls.Add(l_totdepenses);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(flp_depenses);
            tabPage1.Controls.Add(chartDepenses);
            tabPage1.ForeColor = Color.Black;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(862, 376);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dépenses";
            // 
            // cb_depenses
            // 
            cb_depenses.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_depenses.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_depenses.FormattingEnabled = true;
            cb_depenses.IntegralHeight = false;
            cb_depenses.Items.AddRange(new object[] { "Toutes", "Loisirs", "Alimentation", "Transports", "Logement", "Santé", "Revenus", "Autre" });
            cb_depenses.Location = new Point(681, 55);
            cb_depenses.Margin = new Padding(2);
            cb_depenses.Name = "cb_depenses";
            cb_depenses.Size = new Size(146, 28);
            cb_depenses.TabIndex = 10;
            // 
            // l_totdepenses
            // 
            l_totdepenses.AutoSize = true;
            l_totdepenses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_totdepenses.ForeColor = Color.MediumVioletRed;
            l_totdepenses.Location = new Point(167, 22);
            l_totdepenses.Name = "l_totdepenses";
            l_totdepenses.Size = new Size(67, 20);
            l_totdepenses.TabIndex = 9;
            l_totdepenses.Text = "montant";
            l_totdepenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MediumVioletRed;
            label10.Location = new Point(60, 22);
            label10.Name = "label10";
            label10.Size = new Size(111, 20);
            label10.TabIndex = 6;
            label10.Text = "Total dépensé :";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(528, 22);
            label2.Name = "label2";
            label2.Size = new Size(160, 20);
            label2.TabIndex = 8;
            label2.Text = "Liste des transactions :";
            // 
            // flp_depenses
            // 
            flp_depenses.AutoScroll = true;
            flp_depenses.BackColor = Color.Transparent;
            flp_depenses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flp_depenses.Location = new Point(378, 82);
            flp_depenses.MaximumSize = new Size(448, 286);
            flp_depenses.MinimumSize = new Size(448, 286);
            flp_depenses.Name = "flp_depenses";
            flp_depenses.Size = new Size(448, 286);
            flp_depenses.TabIndex = 7;
            // 
            // chartDepenses
            // 
            chartArea2.Name = "ChartArea1";
            chartDepenses.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDepenses.Legends.Add(legend2);
            chartDepenses.Location = new Point(5, 55);
            chartDepenses.Margin = new Padding(2);
            chartDepenses.Name = "chartDepenses";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDepenses.Series.Add(series2);
            chartDepenses.Size = new Size(369, 322);
            chartDepenses.TabIndex = 6;
            chartDepenses.Text = "chart1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cb_recettes);
            tabPage2.Controls.Add(l_totrecettes);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(flp_recettes);
            tabPage2.Controls.Add(chartRecettes);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(862, 376);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recettes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_recettes
            // 
            cb_recettes.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_recettes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_recettes.FormattingEnabled = true;
            cb_recettes.IntegralHeight = false;
            cb_recettes.Items.AddRange(new object[] { "Toutes", "Loisirs", "Alimentation", "Transports", "Logement", "Santé", "Revenus", "Autre" });
            cb_recettes.Location = new Point(681, 55);
            cb_recettes.Margin = new Padding(2);
            cb_recettes.Name = "cb_recettes";
            cb_recettes.Size = new Size(146, 28);
            cb_recettes.TabIndex = 12;
            // 
            // l_totrecettes
            // 
            l_totrecettes.AutoSize = true;
            l_totrecettes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_totrecettes.ForeColor = Color.MediumVioletRed;
            l_totrecettes.Location = new Point(154, 22);
            l_totrecettes.Name = "l_totrecettes";
            l_totrecettes.Size = new Size(67, 20);
            l_totrecettes.TabIndex = 11;
            l_totrecettes.Text = "montant";
            l_totrecettes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MediumVioletRed;
            label12.Location = new Point(74, 22);
            label12.Name = "label12";
            label12.Size = new Size(84, 20);
            label12.TabIndex = 10;
            label12.Text = "Total reçu :";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(528, 22);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 9;
            label3.Text = "Liste des transactions :";
            // 
            // flp_recettes
            // 
            flp_recettes.AutoScroll = true;
            flp_recettes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flp_recettes.Location = new Point(378, 82);
            flp_recettes.MaximumSize = new Size(448, 286);
            flp_recettes.MinimumSize = new Size(448, 286);
            flp_recettes.Name = "flp_recettes";
            flp_recettes.Size = new Size(448, 286);
            flp_recettes.TabIndex = 8;
            // 
            // chartRecettes
            // 
            chartArea3.Name = "ChartArea1";
            chartRecettes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRecettes.Legends.Add(legend3);
            chartRecettes.Location = new Point(5, 55);
            chartRecettes.Margin = new Padding(2);
            chartRecettes.Name = "chartRecettes";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRecettes.Series.Add(series3);
            chartRecettes.Size = new Size(369, 322);
            chartRecettes.TabIndex = 7;
            chartRecettes.Text = "chart1";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(p_logo);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(l_menuaccueil);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 84);
            panel2.TabIndex = 6;
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
            // p_logo
            // 
            p_logo.Image = Properties.Resources.logo;
            p_logo.Location = new Point(2, 3);
            p_logo.Name = "p_logo";
            p_logo.Size = new Size(183, 78);
            p_logo.SizeMode = PictureBoxSizeMode.CenterImage;
            p_logo.TabIndex = 6;
            p_logo.TabStop = false;
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
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(421, 1);
            label6.Name = "label6";
            label6.Padding = new Padding(12, 28, 12, 28);
            label6.Size = new Size(99, 81);
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
            // l_menuaccueil
            // 
            l_menuaccueil.AutoSize = true;
            l_menuaccueil.BackColor = Color.SkyBlue;
            l_menuaccueil.Font = new Font("Segoe UI", 10.8F);
            l_menuaccueil.ForeColor = Color.DarkBlue;
            l_menuaccueil.Location = new Point(188, -1);
            l_menuaccueil.Name = "l_menuaccueil";
            l_menuaccueil.Padding = new Padding(10, 28, 10, 28);
            l_menuaccueil.Size = new Size(87, 81);
            l_menuaccueil.TabIndex = 0;
            l_menuaccueil.Text = "Accueil";
            // 
            // link_accueil
            // 
            link_accueil.AutoSize = true;
            link_accueil.Font = new Font("Segoe UI", 10F);
            link_accueil.LinkColor = Color.Black;
            link_accueil.Location = new Point(57, 92);
            link_accueil.Name = "link_accueil";
            link_accueil.Size = new Size(71, 23);
            link_accueil.TabIndex = 11;
            link_accueil.TabStop = true;
            link_accueil.Text = "Accueil/";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(196, 92);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 23);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gestion budgétaire/";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(123, 92);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(77, 23);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Services/";
            // 
            // GestionBudget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 614);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(link_accueil);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximumSize = new Size(1204, 661);
            MinimumSize = new Size(1204, 661);
            Name = "GestionBudget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)p_nextMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_previousMonth).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartAll).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDepenses).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRecettes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)p_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepenses;
        private FlowLayoutPanel flp_depenses;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private PictureBox p_logo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label l_menuaccueil;
        private LinkLabel link_accueil;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRecettes;
        private Label label3;
        private FlowLayoutPanel flp_recettes;
        private Label l_month;
        private Label label10;
        private Label l_totdepenses;
        private Label l_totrecettes;
        private Label label12;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private TabPage tabPage3;
        private Label l_totmensuel;
        private Label l_balancemensuelle;
        private Label label13;
        private FlowLayoutPanel flp_general;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private ComboBox cb_depenses;
        private ComboBox cb_recettes;
        private ComboBox cb_all;
        private PictureBox p_nextMonth;
        private PictureBox p_previousMonth;
    }
}