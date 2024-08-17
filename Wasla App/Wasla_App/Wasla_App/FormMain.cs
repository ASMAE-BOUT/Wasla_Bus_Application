namespace WaslaApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //LoadForm(new FormMain());
        }

        private void LoadForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            Controls.Add(form);
            form.Show();
        }

        private void menuAccueil_Click(object sender, EventArgs e)
        {
            LoadForm(new FormReservation());
        }

        private void menuReserverBillet_Click(object sender, EventArgs e)
        {
            LoadForm(new FormReservation());
        }

        private void menuMesBillets_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBillets());
        }

        private void menuParametres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Les paramètres seront bientôt disponibles.");
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void menuReserverBillet_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
