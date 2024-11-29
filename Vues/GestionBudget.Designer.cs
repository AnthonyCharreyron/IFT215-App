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
            label1 = new Label();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chartDepenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            l_dep_dest2 = new Label();
            l_dep_dest1 = new Label();
            l_dep_categorie2 = new Label();
            l_dep_categorie1 = new Label();
            l_dep_montant2 = new Label();
            l_dep_montant1 = new Label();
            tabPage2 = new TabPage();
            l_depot_dest2 = new Label();
            l_depot_dest1 = new Label();
            l_depot_categorie2 = new Label();
            l_depot_categorie1 = new Label();
            l_depot_montant2 = new Label();
            l_depot_montant1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDepenses).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(512, 126);
            label1.Name = "label1";
            label1.Size = new Size(187, 28);
            label1.TabIndex = 1;
            label1.Text = "Gestion budgétaire";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Location = new Point(162, 120);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 400);
            panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            tabControl1.Location = new Point(30, 48);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(818, 334);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(chartDepenses);
            tabPage1.Controls.Add(l_dep_dest2);
            tabPage1.Controls.Add(l_dep_dest1);
            tabPage1.Controls.Add(l_dep_categorie2);
            tabPage1.Controls.Add(l_dep_categorie1);
            tabPage1.Controls.Add(l_dep_montant2);
            tabPage1.Controls.Add(l_dep_montant1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(810, 301);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dépenses";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartDepenses
            // 
            chartArea1.Name = "ChartArea1";
            chartDepenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDepenses.Legends.Add(legend1);
            chartDepenses.Location = new Point(62, 20);
            chartDepenses.Margin = new Padding(2);
            chartDepenses.Name = "chartDepenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDepenses.Series.Add(series1);
            chartDepenses.Size = new Size(306, 267);
            chartDepenses.TabIndex = 6;
            chartDepenses.Text = "chart1";
            // 
            // l_dep_dest2
            // 
            l_dep_dest2.AutoSize = true;
            l_dep_dest2.Location = new Point(644, 98);
            l_dep_dest2.Margin = new Padding(2, 0, 2, 0);
            l_dep_dest2.Name = "l_dep_dest2";
            l_dep_dest2.Size = new Size(65, 20);
            l_dep_dest2.TabIndex = 5;
            l_dep_dest2.Text = "Amazon";
            // 
            // l_dep_dest1
            // 
            l_dep_dest1.AutoSize = true;
            l_dep_dest1.Location = new Point(644, 59);
            l_dep_dest1.Margin = new Padding(2, 0, 2, 0);
            l_dep_dest1.Name = "l_dep_dest1";
            l_dep_dest1.Size = new Size(65, 20);
            l_dep_dest1.TabIndex = 4;
            l_dep_dest1.Text = "Amazon";
            // 
            // l_dep_categorie2
            // 
            l_dep_categorie2.AutoSize = true;
            l_dep_categorie2.Location = new Point(533, 98);
            l_dep_categorie2.Margin = new Padding(2, 0, 2, 0);
            l_dep_categorie2.Name = "l_dep_categorie2";
            l_dep_categorie2.Size = new Size(74, 20);
            l_dep_categorie2.TabIndex = 3;
            l_dep_categorie2.Text = "Transport";
            // 
            // l_dep_categorie1
            // 
            l_dep_categorie1.AutoSize = true;
            l_dep_categorie1.Location = new Point(533, 59);
            l_dep_categorie1.Margin = new Padding(2, 0, 2, 0);
            l_dep_categorie1.Name = "l_dep_categorie1";
            l_dep_categorie1.Size = new Size(45, 20);
            l_dep_categorie1.TabIndex = 2;
            l_dep_categorie1.Text = "Loisir";
            // 
            // l_dep_montant2
            // 
            l_dep_montant2.AutoSize = true;
            l_dep_montant2.Location = new Point(465, 98);
            l_dep_montant2.Margin = new Padding(2, 0, 2, 0);
            l_dep_montant2.Name = "l_dep_montant2";
            l_dep_montant2.Size = new Size(59, 20);
            l_dep_montant2.TabIndex = 1;
            l_dep_montant2.Text = "-75,00€";
            // 
            // l_dep_montant1
            // 
            l_dep_montant1.AutoSize = true;
            l_dep_montant1.Location = new Point(465, 59);
            l_dep_montant1.Margin = new Padding(2, 0, 2, 0);
            l_dep_montant1.Name = "l_dep_montant1";
            l_dep_montant1.Size = new Size(59, 20);
            l_dep_montant1.TabIndex = 0;
            l_dep_montant1.Text = "-50,00€";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(l_depot_dest2);
            tabPage2.Controls.Add(l_depot_dest1);
            tabPage2.Controls.Add(l_depot_categorie2);
            tabPage2.Controls.Add(l_depot_categorie1);
            tabPage2.Controls.Add(l_depot_montant2);
            tabPage2.Controls.Add(l_depot_montant1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(810, 301);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Recette";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // l_depot_dest2
            // 
            l_depot_dest2.AutoSize = true;
            l_depot_dest2.Location = new Point(698, 121);
            l_depot_dest2.Margin = new Padding(2, 0, 2, 0);
            l_depot_dest2.Name = "l_depot_dest2";
            l_depot_dest2.Size = new Size(65, 20);
            l_depot_dest2.TabIndex = 6;
            l_depot_dest2.Text = "Amazon";
            // 
            // l_depot_dest1
            // 
            l_depot_dest1.AutoSize = true;
            l_depot_dest1.Location = new Point(698, 92);
            l_depot_dest1.Margin = new Padding(2, 0, 2, 0);
            l_depot_dest1.Name = "l_depot_dest1";
            l_depot_dest1.Size = new Size(65, 20);
            l_depot_dest1.TabIndex = 5;
            l_depot_dest1.Text = "Amazon";
            // 
            // l_depot_categorie2
            // 
            l_depot_categorie2.AutoSize = true;
            l_depot_categorie2.Location = new Point(606, 121);
            l_depot_categorie2.Margin = new Padding(2, 0, 2, 0);
            l_depot_categorie2.Name = "l_depot_categorie2";
            l_depot_categorie2.Size = new Size(45, 20);
            l_depot_categorie2.TabIndex = 4;
            l_depot_categorie2.Text = "Loisir";
            // 
            // l_depot_categorie1
            // 
            l_depot_categorie1.AutoSize = true;
            l_depot_categorie1.Location = new Point(606, 92);
            l_depot_categorie1.Margin = new Padding(2, 0, 2, 0);
            l_depot_categorie1.Name = "l_depot_categorie1";
            l_depot_categorie1.Size = new Size(45, 20);
            l_depot_categorie1.TabIndex = 3;
            l_depot_categorie1.Text = "Loisir";
            // 
            // l_depot_montant2
            // 
            l_depot_montant2.AutoSize = true;
            l_depot_montant2.Location = new Point(521, 121);
            l_depot_montant2.Margin = new Padding(2, 0, 2, 0);
            l_depot_montant2.Name = "l_depot_montant2";
            l_depot_montant2.Size = new Size(63, 20);
            l_depot_montant2.TabIndex = 2;
            l_depot_montant2.Text = "+50,00€";
            // 
            // l_depot_montant1
            // 
            l_depot_montant1.AutoSize = true;
            l_depot_montant1.Location = new Point(521, 92);
            l_depot_montant1.Margin = new Padding(2, 0, 2, 0);
            l_depot_montant1.Name = "l_depot_montant1";
            l_depot_montant1.Size = new Size(63, 20);
            l_depot_montant1.TabIndex = 1;
            l_depot_montant1.Text = "+50,00€";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(459, 137);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 234);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 616);
            Controls.Add(label1);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDepenses).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label l_dep_montant1;
        private Label l_dep_categorie1;
        private Label l_dep_montant2;
        private Label l_dep_categorie2;
        private Label l_depot_montant2;
        private Label l_depot_montant1;
        private Label l_depot_categorie2;
        private Label l_depot_categorie1;
        private Label l_dep_dest2;
        private Label l_dep_dest1;
        private Label l_depot_dest2;
        private Label l_depot_dest1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepenses;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}