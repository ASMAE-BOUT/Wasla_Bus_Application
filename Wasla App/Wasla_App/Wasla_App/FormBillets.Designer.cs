namespace WaslaApp
{
    partial class FormBillets
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBillets;
        private System.Windows.Forms.Button btnTelecharger;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Panel panelForm;

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
            panelForm = new Panel();
            button1 = new Button();
            dataGridViewBillets = new DataGridView();
            btnTelecharger = new Button();
            btnAnnuler = new Button();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBillets).BeginInit();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.Moccasin;
            panelForm.Controls.Add(button1);
            panelForm.Controls.Add(dataGridViewBillets);
            panelForm.Controls.Add(btnTelecharger);
            panelForm.Controls.Add(btnAnnuler);
            panelForm.Location = new Point(20, 201);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(440, 385);
            panelForm.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(130, 329);
            button1.Name = "button1";
            button1.Size = new Size(180, 40);
            button1.TabIndex = 3;
            button1.Text = "Retour";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridViewBillets
            // 
            dataGridViewBillets.AllowUserToAddRows = false;
            dataGridViewBillets.AllowUserToResizeColumns = false;
            dataGridViewBillets.AllowUserToResizeRows = false;
            dataGridViewBillets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewBillets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewBillets.BackgroundColor = Color.Moccasin;
            dataGridViewBillets.BorderStyle = BorderStyle.None;
            dataGridViewBillets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBillets.Location = new Point(0, 0);
            dataGridViewBillets.Name = "dataGridViewBillets";
            dataGridViewBillets.Size = new Size(440, 250);
            dataGridViewBillets.TabIndex = 0;
            // 
            // btnTelecharger
            // 
            btnTelecharger.BackColor = Color.FromArgb(0, 168, 89);
            btnTelecharger.FlatStyle = FlatStyle.Flat;
            btnTelecharger.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTelecharger.ForeColor = Color.White;
            btnTelecharger.Location = new Point(20, 270);
            btnTelecharger.Name = "btnTelecharger";
            btnTelecharger.Size = new Size(180, 40);
            btnTelecharger.TabIndex = 1;
            btnTelecharger.Text = "Télécharger le Billet (PDF)";
            btnTelecharger.UseVisualStyleBackColor = false;
            btnTelecharger.Click += btnTelecharger_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.BackColor = Color.FromArgb(255, 111, 0);
            btnAnnuler.FlatStyle = FlatStyle.Flat;
            btnAnnuler.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAnnuler.ForeColor = Color.White;
            btnAnnuler.Location = new Point(240, 270);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(180, 40);
            btnAnnuler.TabIndex = 2;
            btnAnnuler.Text = "Annuler le Billet";
            btnAnnuler.UseVisualStyleBackColor = false;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // FormBillets
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Wasla_App.Properties.Resources.maxresdefault__1_;
            ClientSize = new Size(480, 661);
            Controls.Add(panelForm);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(51, 51, 51);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormBillets";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mes Billets";
            panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBillets).EndInit();
            ResumeLayout(false);
        }

        private Button button1;
    }
}
