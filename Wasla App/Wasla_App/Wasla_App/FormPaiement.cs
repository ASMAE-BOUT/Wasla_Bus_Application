using Microsoft.Data.SqlClient;

namespace WaslaApp
{
    public partial class FormPaiement : Form
    {
        private string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=WaslaDB;Integrated Security=True;TrustServerCertificate=True";
        private DataGridView dataGridViewResults;

        public FormPaiement(DataGridView dgvResults)
        {
            InitializeComponent();
            dataGridViewResults = dgvResults;
        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            if (dataGridViewResults.SelectedRows.Count > 0)
            {
                int billetID = Convert.ToInt32(dataGridViewResults.SelectedRows[0].Cells["NewBilletID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "UPDATE Billets SET StatutPaiement = 'Payé' WHERE NewBilletID = @NewBilletID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@NewBilletID", billetID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Paiement réussi.");
                            OpenFormBillets();
                        }
                        else
                        {
                            MessageBox.Show("Échec du paiement.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un billet à payer.");
            }
        }

        private void SavePaymentToDatabase()
        {
            string nomUtilisateur = txtNom.Text;
            string telephone = txtTelephone.Text;
            string email = txtEmail.Text;

            string methodePaiement = comboBoxMethodePaiement.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(methodePaiement))
            {
                MessageBox.Show("Veuillez sélectionner une méthode de paiement.");
                return;
            }

            decimal montant = 100;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Paiements (NomUtilisateur, Telephone, Email, MethodePaiement, Montant, DatePaiement) " +
                                   "VALUES (@NomUtilisateur, @Telephone, @Email, @MethodePaiement, @Montant, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@NomUtilisateur", nomUtilisateur);
                    cmd.Parameters.AddWithValue("@Telephone", telephone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MethodePaiement", methodePaiement);
                    cmd.Parameters.AddWithValue("@Montant", montant);

                    cmd.ExecuteNonQuery();
                }

                GenerateReceipt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du traitement du paiement : " + ex.Message);
            }
        }

        private void GenerateReceipt()
        {
            MessageBox.Show("Reçu généré avec succès !");
        }

        private void OpenFormBillets()
        {
            FormBillets formBillets = new FormBillets();
            formBillets.ShowDialog();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
