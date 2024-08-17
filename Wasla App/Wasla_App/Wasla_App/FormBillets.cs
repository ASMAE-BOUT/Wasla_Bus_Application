using Microsoft.Data.SqlClient;
using System.Data;

namespace WaslaApp
{
    public partial class FormBillets : Form
    {
        private string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=WaslaDB;Integrated Security=True;TrustServerCertificate=True";

        public FormBillets()
        {
            InitializeComponent();
            LoadBillets();
        }

        private void LoadBillets()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Billets", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewBillets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewBillets.DataSource = dt;

                dataGridViewBillets.Columns["NomUtilisateur"].Width = 200;
            }
        }

        private void btnTelecharger_Click(object sender, EventArgs e)
        {
            if (dataGridViewBillets.SelectedRows.Count > 0)
            {
                int billetID = Convert.ToInt32(dataGridViewBillets.SelectedRows[0].Cells["NewBilletID"].Value);
                MessageBox.Show("Billet téléchargé avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un billet à télécharger.");
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (dataGridViewBillets.SelectedRows.Count > 0)
            {
                int billetID = Convert.ToInt32(dataGridViewBillets.SelectedRows[0].Cells["NewBilletID"].Value);

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM Billets WHERE NewBilletID = @NewBilletID";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@NewBilletID", billetID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Billet annulé avec succès.");
                            LoadBillets();
                        }
                        else
                        {
                            MessageBox.Show("Échec de l'annulation du billet.");
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
                MessageBox.Show("Veuillez sélectionner un billet à annuler.");
            }
        }
    }
}
