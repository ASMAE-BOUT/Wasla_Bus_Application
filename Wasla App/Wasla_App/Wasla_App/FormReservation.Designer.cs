namespace WaslaApp
{
    partial class FormReservation
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxDepart;
        private System.Windows.Forms.ComboBox comboBoxArrivee;
        private System.Windows.Forms.ComboBox comboBoxCompagnie;
        private System.Windows.Forms.DateTimePicker dateTimePickerVoyage;
        private System.Windows.Forms.NumericUpDown numericUpDownPassagers;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.Label lblCompagnie;
        private System.Windows.Forms.Label lblDateVoyage;
        private System.Windows.Forms.Label lblPassagers;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.DataGridView dataGridViewResults;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelForm = new Panel();
            comboBoxDepart = new ComboBox();
            comboBoxArrivee = new ComboBox();
            comboBoxCompagnie = new ComboBox();
            dateTimePickerVoyage = new DateTimePicker();
            numericUpDownPassagers = new NumericUpDown();
            btnRechercher = new Button();
            btnReserver = new Button();
            lblDepart = new Label();
            lblArrivee = new Label();
            lblCompagnie = new Label();
            lblDateVoyage = new Label();
            lblPassagers = new Label();
            dataGridViewResults = new DataGridView();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPassagers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.Transparent;
            panelForm.Controls.Add(comboBoxDepart);
            panelForm.Controls.Add(comboBoxArrivee);
            panelForm.Controls.Add(comboBoxCompagnie);
            panelForm.Controls.Add(dateTimePickerVoyage);
            panelForm.Controls.Add(numericUpDownPassagers);
            panelForm.Controls.Add(btnRechercher);
            panelForm.Controls.Add(btnReserver);
            panelForm.Controls.Add(lblDepart);
            panelForm.Controls.Add(lblArrivee);
            panelForm.Controls.Add(lblCompagnie);
            panelForm.Controls.Add(lblDateVoyage);
            panelForm.Controls.Add(lblPassagers);
            panelForm.Controls.Add(dataGridViewResults);
            panelForm.Location = new Point(1, 41);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(484, 621);
            panelForm.TabIndex = 0;
            // 
            // comboBoxDepart
            // 
            comboBoxDepart.FormattingEnabled = true;
            comboBoxDepart.Location = new Point(160, 48);
            comboBoxDepart.Name = "comboBoxDepart";
            comboBoxDepart.Size = new Size(250, 29);
            comboBoxDepart.TabIndex = 0;
            // 
            // comboBoxArrivee
            // 
            comboBoxArrivee.FormattingEnabled = true;
            comboBoxArrivee.Location = new Point(160, 98);
            comboBoxArrivee.Name = "comboBoxArrivee";
            comboBoxArrivee.Size = new Size(250, 29);
            comboBoxArrivee.TabIndex = 1;
            comboBoxArrivee.SelectedIndexChanged += comboBoxArrivee_SelectedIndexChanged;
            // 
            // comboBoxCompagnie
            // 
            comboBoxCompagnie.FormattingEnabled = true;
            comboBoxCompagnie.Location = new Point(160, 148);
            comboBoxCompagnie.Name = "comboBoxCompagnie";
            comboBoxCompagnie.Size = new Size(250, 29);
            comboBoxCompagnie.TabIndex = 2;
            // 
            // dateTimePickerVoyage
            // 
            dateTimePickerVoyage.Location = new Point(160, 198);
            dateTimePickerVoyage.Name = "dateTimePickerVoyage";
            dateTimePickerVoyage.Size = new Size(250, 29);
            dateTimePickerVoyage.TabIndex = 3;
            // 
            // numericUpDownPassagers
            // 
            numericUpDownPassagers.Location = new Point(160, 248);
            numericUpDownPassagers.Name = "numericUpDownPassagers";
            numericUpDownPassagers.Size = new Size(250, 29);
            numericUpDownPassagers.TabIndex = 4;
            // 
            // btnRechercher
            // 
            btnRechercher.BackColor = Color.FromArgb(0, 168, 89);
            btnRechercher.FlatStyle = FlatStyle.Flat;
            btnRechercher.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRechercher.ForeColor = Color.White;
            btnRechercher.Location = new Point(160, 298);
            btnRechercher.Name = "btnRechercher";
            btnRechercher.Size = new Size(250, 40);
            btnRechercher.TabIndex = 5;
            btnRechercher.Text = "Rechercher";
            btnRechercher.UseVisualStyleBackColor = false;
            btnRechercher.Click += btnRechercher_Click;
            // 
            // btnReserver
            // 
            btnReserver.BackColor = Color.FromArgb(255, 128, 0);
            btnReserver.FlatStyle = FlatStyle.Flat;
            btnReserver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReserver.ForeColor = Color.White;
            btnReserver.Location = new Point(160, 350);
            btnReserver.Name = "btnReserver";
            btnReserver.Size = new Size(250, 40);
            btnReserver.TabIndex = 12;
            btnReserver.Text = "Réserver";
            btnReserver.UseVisualStyleBackColor = false;
            btnReserver.Click += btnReserver_Click;
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.BackColor = Color.Black;
            lblDepart.ForeColor = Color.Yellow;
            lblDepart.Location = new Point(20, 50);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(113, 21);
            lblDepart.TabIndex = 6;
            lblDepart.Text = "Ville de départ:";
            // 
            // lblArrivee
            // 
            lblArrivee.AutoSize = true;
            lblArrivee.BackColor = Color.Black;
            lblArrivee.ForeColor = Color.Yellow;
            lblArrivee.Location = new Point(20, 100);
            lblArrivee.Name = "lblArrivee";
            lblArrivee.Size = new Size(108, 21);
            lblArrivee.TabIndex = 7;
            lblArrivee.Text = "Ville d'arrivée:";
            // 
            // lblCompagnie
            // 
            lblCompagnie.AutoSize = true;
            lblCompagnie.BackColor = Color.Black;
            lblCompagnie.ForeColor = Color.Yellow;
            lblCompagnie.Location = new Point(20, 150);
            lblCompagnie.Name = "lblCompagnie";
            lblCompagnie.Size = new Size(93, 21);
            lblCompagnie.TabIndex = 8;
            lblCompagnie.Text = "Compagnie:";
            // 
            // lblDateVoyage
            // 
            lblDateVoyage.AutoSize = true;
            lblDateVoyage.BackColor = Color.Black;
            lblDateVoyage.ForeColor = Color.Yellow;
            lblDateVoyage.Location = new Point(20, 200);
            lblDateVoyage.Name = "lblDateVoyage";
            lblDateVoyage.Size = new Size(120, 21);
            lblDateVoyage.TabIndex = 9;
            lblDateVoyage.Text = "Date de voyage:";
            // 
            // lblPassagers
            // 
            lblPassagers.AutoSize = true;
            lblPassagers.BackColor = Color.Black;
            lblPassagers.ForeColor = Color.Yellow;
            lblPassagers.Location = new Point(20, 250);
            lblPassagers.Name = "lblPassagers";
            lblPassagers.Size = new Size(81, 21);
            lblPassagers.TabIndex = 10;
            lblPassagers.Text = "Passagers:";
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.AllowUserToAddRows = false;
            dataGridViewResults.AllowUserToDeleteRows = false;
            dataGridViewResults.AllowUserToResizeColumns = false;
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewResults.BackgroundColor = Color.Khaki;
            dataGridViewResults.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewResults.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewResults.Location = new Point(-3, 431);
            dataGridViewResults.Margin = new Padding(2);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.ReadOnly = true;
            dataGridViewResults.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 128);
            dataGridViewResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewResults.RowTemplate.Height = 20;
            dataGridViewResults.Size = new Size(484, 187);
            dataGridViewResults.TabIndex = 11;
            dataGridViewResults.CellContentClick += dataGridViewResults_CellContentClick;
            // 
            // FormReservation
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Wasla_App.Properties.Resources.maxresdefault__1_;
            ClientSize = new Size(480, 661);
            Controls.Add(panelForm);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(51, 51, 51);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormReservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Réserver un Billet";
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPassagers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
        }
    }
}
