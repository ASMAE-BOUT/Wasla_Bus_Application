namespace WaslaApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuAccueil;
        private System.Windows.Forms.ToolStripMenuItem menuReserverBillet;
        private System.Windows.Forms.ToolStripMenuItem menuMesBillets;
        private System.Windows.Forms.ToolStripMenuItem menuParametres;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMessage;

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
            menuStrip = new MenuStrip();
            menuAccueil = new ToolStripMenuItem();
            menuReserverBillet = new ToolStripMenuItem();
            menuMesBillets = new ToolStripMenuItem();
            menuParametres = new ToolStripMenuItem();
            lblTitle = new Label();
            lblMessage = new Label();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.Gold;
            menuStrip.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip.ImeMode = ImeMode.NoControl;
            menuStrip.Items.AddRange(new ToolStripItem[] { menuAccueil, menuReserverBillet, menuMesBillets, menuParametres });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(480, 29);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // menuAccueil
            // 
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.Name = "menuAccueil";
            menuAccueil.Size = new Size(71, 25);
            menuAccueil.Text = "Accueil";
            menuAccueil.Click += menuAccueil_Click;
            // 
            // menuReserverBillet
            // 
            menuReserverBillet.ForeColor = Color.Black;
            menuReserverBillet.Name = "menuReserverBillet";
            menuReserverBillet.Size = new Size(143, 25);
            menuReserverBillet.Text = "Réserver un Billet";
            menuReserverBillet.Click += menuReserverBillet_Click;
            // 
            // menuMesBillets
            // 
            menuMesBillets.ForeColor = Color.Black;
            menuMesBillets.Name = "menuMesBillets";
            menuMesBillets.Size = new Size(96, 25);
            menuMesBillets.Text = "Mes Billets";
            menuMesBillets.Click += menuMesBillets_Click;
            // 
            // menuParametres
            // 
            menuParametres.ForeColor = Color.Black;
            menuParametres.Name = "menuParametres";
            menuParametres.Size = new Size(100, 25);
            menuParametres.Text = "Paramètres";
            menuParametres.Click += menuParametres_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Yellow;
            lblTitle.Location = new Point(0, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(480, 75);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "BIENVENUE À WASLA\r\n@version 1.0";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Yellow;
            lblMessage.Location = new Point(0, 606);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(480, 46);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "Wasla est l'application idéale pour réserver vos billets de bus au Maroc. Facile, rapide et sécurisé, faites le choix malin avec Wasla!";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.Moccasin;
            BackgroundImage = Wasla_App.Properties.Resources.maxresdefault;
            ClientSize = new Size(480, 661);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.Moccasin;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wasla - Application de Réservation";
            Load += FormMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
