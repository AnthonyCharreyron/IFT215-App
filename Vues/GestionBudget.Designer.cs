namespace AppliBoursoBank
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionBudget));
            label1 = new Label();
            panel1 = new Panel();
            l_month = new Label();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            l_totmensuel = new Label();
            label11 = new Label();
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
            cb_recettes = new ComboBox();
            cb_all = new ComboBox();
            panel1.SuspendLayout();
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
            label1.Location = new Point(465, -1);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 1;
            label1.Text = "Gestion budgétaire";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(l_month);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(166, 158);
            panel1.Margin = new Padding(2);
            panel1.MaximumSize = new Size(1161, 606);
            panel1.MinimumSize = new Size(1161, 606);
            panel1.Name = "panel1";
            panel1.Size = new Size(1161, 606);
            panel1.TabIndex = 2;
            // 
            // l_month
            // 
            l_month.AutoSize = true;
            l_month.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_month.ForeColor = Color.MediumVioletRed;
            l_month.Location = new Point(535, 38);
            l_month.Margin = new Padding(4, 0, 4, 0);
            l_month.Name = "l_month";
            l_month.Size = new Size(53, 25);
            l_month.TabIndex = 5;
            l_month.Text = "Mois";
            l_month.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            tabControl1.Location = new Point(38, 60);
            tabControl1.Margin = new Padding(2);
            tabControl1.MaximumSize = new Size(1088, 518);
            tabControl1.MinimumSize = new Size(1088, 518);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1088, 518);
            tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(cb_all);
            tabPage3.Controls.Add(l_totmensuel);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(flp_general);
            tabPage3.Controls.Add(chartAll);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Margin = new Padding(4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1080, 480);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Général";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // l_totmensuel
            // 
            l_totmensuel.AutoSize = true;
            l_totmensuel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_totmensuel.ForeColor = Color.MediumVioletRed;
            l_totmensuel.Location = new Point(209, 28);
            l_totmensuel.Margin = new Padding(4, 0, 4, 0);
            l_totmensuel.Name = "l_totmensuel";
            l_totmensuel.Size = new Size(84, 25);
            l_totmensuel.TabIndex = 14;
            l_totmensuel.Text = "montant";
            l_totmensuel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.MediumVioletRed;
            label11.Location = new Point(75, 28);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(137, 25);
            label11.TabIndex = 10;
            label11.Text = "Total mensuel :";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(660, 28);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(200, 25);
            label13.TabIndex = 13;
            label13.Text = "Liste des transactions :";
            // 
            // flp_general
            // 
            flp_general.AutoScroll = true;
            flp_general.BackColor = Color.Transparent;
            flp_general.Location = new Point(474, 81);
            flp_general.Margin = new Padding(4);
            flp_general.MaximumSize = new Size(560, 358);
            flp_general.MinimumSize = new Size(560, 358);
            flp_general.Name = "flp_general";
            flp_general.Size = new Size(560, 358);
            flp_general.TabIndex = 12;
            // 
            // chartAll
            // 
            chartArea1.Name = "ChartArea1";
            chartAll.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartAll.Legends.Add(legend1);
            chartAll.Location = new Point(6, 69);
            chartAll.Margin = new Padding(2);
            chartAll.Name = "chartAll";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartAll.Series.Add(series1);
            chartAll.Size = new Size(461, 402);
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
            tabPage1.Size = new Size(1080, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dépenses";
            // 
            // cb_depenses
            // 
            cb_depenses.FormattingEnabled = true;
            cb_depenses.IntegralHeight = false;
            cb_depenses.Location = new Point(883, 20);
            cb_depenses.Name = "cb_depenses";
            cb_depenses.Size = new Size(182, 33);
            cb_depenses.TabIndex = 10;
            // 
            // l_totdepenses
            // 
            l_totdepenses.AutoSize = true;
            l_totdepenses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_totdepenses.ForeColor = Color.MediumVioletRed;
            l_totdepenses.Location = new Point(209, 28);
            l_totdepenses.Margin = new Padding(4, 0, 4, 0);
            l_totdepenses.Name = "l_totdepenses";
            l_totdepenses.Size = new Size(84, 25);
            l_totdepenses.TabIndex = 9;
            l_totdepenses.Text = "montant";
            l_totdepenses.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.MediumVioletRed;
            label10.Location = new Point(75, 28);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(137, 25);
            label10.TabIndex = 6;
            label10.Text = "Total dépensé :";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 28);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 8;
            label2.Text = "Liste des transactions :";
            // 
            // flp_depenses
            // 
            flp_depenses.AutoScroll = true;
            flp_depenses.BackColor = Color.Transparent;
            flp_depenses.Location = new Point(474, 81);
            flp_depenses.Margin = new Padding(4);
            flp_depenses.MaximumSize = new Size(560, 358);
            flp_depenses.MinimumSize = new Size(560, 358);
            flp_depenses.Name = "flp_depenses";
            flp_depenses.Size = new Size(560, 358);
            flp_depenses.TabIndex = 7;
            // 
            // chartDepenses
            // 
            chartArea2.Name = "ChartArea1";
            chartDepenses.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartDepenses.Legends.Add(legend2);
            chartDepenses.Location = new Point(6, 69);
            chartDepenses.Margin = new Padding(2);
            chartDepenses.Name = "chartDepenses";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartDepenses.Series.Add(series2);
            chartDepenses.Size = new Size(461, 402);
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
            tabPage2.Size = new Size(1080, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recettes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // l_totrecettes
            // 
            l_totrecettes.AutoSize = true;
            l_totrecettes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_totrecettes.ForeColor = Color.MediumVioletRed;
            l_totrecettes.Location = new Point(192, 28);
            l_totrecettes.Margin = new Padding(4, 0, 4, 0);
            l_totrecettes.Name = "l_totrecettes";
            l_totrecettes.Size = new Size(84, 25);
            l_totrecettes.TabIndex = 11;
            l_totrecettes.Text = "montant";
            l_totrecettes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.MediumVioletRed;
            label12.Location = new Point(92, 28);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(102, 25);
            label12.TabIndex = 10;
            label12.Text = "Total reçu :";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(660, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(200, 25);
            label3.TabIndex = 9;
            label3.Text = "Liste des transactions :";
            // 
            // flp_recettes
            // 
            flp_recettes.AutoScroll = true;
            flp_recettes.Location = new Point(474, 81);
            flp_recettes.Margin = new Padding(4);
            flp_recettes.MaximumSize = new Size(560, 358);
            flp_recettes.MinimumSize = new Size(560, 358);
            flp_recettes.Name = "flp_recettes";
            flp_recettes.Size = new Size(560, 358);
            flp_recettes.TabIndex = 8;
            // 
            // chartRecettes
            // 
            chartArea3.Name = "ChartArea1";
            chartRecettes.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartRecettes.Legends.Add(legend3);
            chartRecettes.Location = new Point(6, 69);
            chartRecettes.Margin = new Padding(2);
            chartRecettes.Name = "chartRecettes";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartRecettes.Series.Add(series3);
            chartRecettes.Size = new Size(461, 402);
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
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1478, 106);
            panel2.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1375, 9);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 88);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Location = new Point(232, 6);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1, 87);
            panel11.TabIndex = 12;
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(1069, 6);
            panel10.Margin = new Padding(4);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 87);
            panel10.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(779, 6);
            panel9.Margin = new Padding(4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1, 87);
            panel9.TabIndex = 10;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(650, 6);
            panel8.Margin = new Padding(4);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 87);
            panel8.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(525, 6);
            panel7.Margin = new Padding(4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 87);
            panel7.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(344, 6);
            panel6.Margin = new Padding(4);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 87);
            panel6.TabIndex = 7;
            // 
            // p_logo
            // 
            p_logo.Image = Properties.Resources.logo;
            p_logo.Location = new Point(2, 4);
            p_logo.Margin = new Padding(4);
            p_logo.Name = "p_logo";
            p_logo.Size = new Size(229, 98);
            p_logo.SizeMode = PictureBoxSizeMode.CenterImage;
            p_logo.TabIndex = 6;
            p_logo.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(1071, 10);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Padding = new Padding(12, 25, 12, 25);
            label9.Size = new Size(187, 80);
            label9.TabIndex = 5;
            label9.Text = "Bourse et Actus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(784, 10);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Padding = new Padding(12, 25, 12, 25);
            label8.Size = new Size(273, 80);
            label8.TabIndex = 4;
            label8.Text = "Bons plans et Parrainage";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(655, 10);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Padding = new Padding(12, 25, 12, 25);
            label7.Size = new Size(116, 80);
            label7.TabIndex = 3;
            label7.Text = "Produits";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(526, 1);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(15, 35, 15, 35);
            label6.Size = new Size(122, 100);
            label6.TabIndex = 2;
            label6.Text = "Services";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(350, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(12, 25, 12, 25);
            label5.Size = new Size(167, 80);
            label5.TabIndex = 1;
            label5.Text = "Mes comptes";
            // 
            // l_menuaccueil
            // 
            l_menuaccueil.AutoSize = true;
            l_menuaccueil.BackColor = Color.SkyBlue;
            l_menuaccueil.Font = new Font("Segoe UI", 10.8F);
            l_menuaccueil.ForeColor = Color.DarkBlue;
            l_menuaccueil.Location = new Point(235, -1);
            l_menuaccueil.Margin = new Padding(4, 0, 4, 0);
            l_menuaccueil.Name = "l_menuaccueil";
            l_menuaccueil.Padding = new Padding(12, 35, 12, 35);
            l_menuaccueil.Size = new Size(105, 100);
            l_menuaccueil.TabIndex = 0;
            l_menuaccueil.Text = "Accueil";
            // 
            // link_accueil
            // 
            link_accueil.AutoSize = true;
            link_accueil.Font = new Font("Segoe UI", 10F);
            link_accueil.LinkColor = Color.Black;
            link_accueil.Location = new Point(71, 115);
            link_accueil.Margin = new Padding(4, 0, 4, 0);
            link_accueil.Name = "link_accueil";
            link_accueil.Size = new Size(82, 28);
            link_accueil.TabIndex = 11;
            link_accueil.TabStop = true;
            link_accueil.Text = "Accueil/";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(245, 115);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(188, 28);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Gestion budgétaire/";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 10F);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(154, 115);
            linkLabel2.Margin = new Padding(4, 0, 4, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(90, 28);
            linkLabel2.TabIndex = 13;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Services/";
            // 
            // cb_recettes
            // 
            cb_recettes.FormattingEnabled = true;
            cb_recettes.IntegralHeight = false;
            cb_recettes.Location = new Point(882, 20);
            cb_recettes.Name = "cb_recettes";
            cb_recettes.Size = new Size(182, 33);
            cb_recettes.TabIndex = 12;
            // 
            // cb_all
            // 
            cb_all.FormattingEnabled = true;
            cb_all.IntegralHeight = false;
            cb_all.Location = new Point(895, 3);
            cb_all.Name = "cb_all";
            cb_all.Size = new Size(182, 33);
            cb_all.TabIndex = 15;
            // 
            // GestionBudget
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 759);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(link_accueil);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            MaximumSize = new Size(1500, 815);
            MinimumSize = new Size(1500, 815);
            Name = "GestionBudget";
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label11;
        private Label label13;
        private FlowLayoutPanel flp_general;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAll;
        private ComboBox cb_depenses;
        private ComboBox cb_recettes;
        private ComboBox cb_all;
    }
}