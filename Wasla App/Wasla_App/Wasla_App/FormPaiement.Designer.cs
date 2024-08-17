namespace WaslaApp
{
    partial class FormPaiement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboBoxMethodePaiement;
        private System.Windows.Forms.Button btnPayer;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMethodePaiement;
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
            btnRetour = new Button();
            txtNom = new TextBox();
            txtTelephone = new TextBox();
            txtEmail = new TextBox();
            comboBoxMethodePaiement = new ComboBox();
            btnPayer = new Button();
            lblNom = new Label();
            lblTelephone = new Label();
            lblEmail = new Label();
            lblMethodePaiement = new Label();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.Transparent;
            panelForm.Controls.Add(btnRetour);
            panelForm.Controls.Add(txtNom);
            panelForm.Controls.Add(txtTelephone);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(comboBoxMethodePaiement);
            panelForm.Controls.Add(btnPayer);
            panelForm.Controls.Add(lblNom);
            panelForm.Controls.Add(lblTelephone);
            panelForm.Controls.Add(lblEmail);
            panelForm.Controls.Add(lblMethodePaiement);
            panelForm.Location = new Point(0, 20);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(482, 641);
            panelForm.TabIndex = 0;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(255, 128, 0);
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRetour.ForeColor = Color.White;
            btnRetour.Location = new Point(186, 285);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(250, 40);
            btnRetour.TabIndex = 0;
            btnRetour.Text = "Retour";
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(186, 30);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(250, 29);
            txtNom.TabIndex = 0;
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(186, 80);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(250, 29);
            txtTelephone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 130);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 29);
            txtEmail.TabIndex = 2;
            // 
            // comboBoxMethodePaiement
            // 
            comboBoxMethodePaiement.FormattingEnabled = true;
            comboBoxMethodePaiement.Items.AddRange(new object[] { "Carte Bancaire", "PayPal" });
            comboBoxMethodePaiement.Location = new Point(186, 180);
            comboBoxMethodePaiement.Name = "comboBoxMethodePaiement";
            comboBoxMethodePaiement.Size = new Size(250, 29);
            comboBoxMethodePaiement.TabIndex = 3;
            // 
            // btnPayer
            // 
            btnPayer.BackColor = Color.FromArgb(0, 168, 89);
            btnPayer.FlatStyle = FlatStyle.Flat;
            btnPayer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPayer.ForeColor = Color.White;
            btnPayer.Location = new Point(186, 230);
            btnPayer.Name = "btnPayer";
            btnPayer.Size = new Size(250, 40);
            btnPayer.TabIndex = 4;
            btnPayer.Text = "Payer";
            btnPayer.UseVisualStyleBackColor = false;
            btnPayer.Click += btnPayer_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Black;
            lblNom.Font = new Font("Segoe UI", 12F);
            lblNom.ForeColor = Color.Yellow;
            lblNom.Location = new Point(20, 33);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(48, 21);
            lblNom.TabIndex = 5;
            lblNom.Text = "Nom:";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.BackColor = SystemColors.ActiveCaptionText;
            lblTelephone.Font = new Font("Segoe UI", 12F);
            lblTelephone.ForeColor = Color.Yellow;
            lblTelephone.Location = new Point(20, 83);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(83, 21);
            lblTelephone.TabIndex = 6;
            lblTelephone.Text = "Téléphone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Black;
            lblEmail.CausesValidation = false;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.ForeColor = Color.Yellow;
            lblEmail.Location = new Point(20, 133);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblMethodePaiement
            // 
            lblMethodePaiement.AutoSize = true;
            lblMethodePaiement.BackColor = Color.Black;
            lblMethodePaiement.Font = new Font("Segoe UI", 12F);
            lblMethodePaiement.ForeColor = Color.Yellow;
            lblMethodePaiement.Location = new Point(20, 183);
            lblMethodePaiement.Name = "lblMethodePaiement";
            lblMethodePaiement.Size = new Size(164, 21);
            lblMethodePaiement.TabIndex = 8;
            lblMethodePaiement.Text = "Méthode de Paiement:";
            // 
            // FormPaiement
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Wasla_App.Properties.Resources.maxresdefault__1_;
            ClientSize = new Size(480, 661);
            Controls.Add(panelForm);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.FromArgb(51, 51, 51);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPaiement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paiement";
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnRetour;
    }
}
