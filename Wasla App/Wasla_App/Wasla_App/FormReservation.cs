using Microsoft.Data.SqlClient;
using System.Data;

namespace WaslaApp
{
    public partial class FormReservation : Form
    {
        private string connectionString = "Data Source=DESKTOP-3HOM7H2\\SQLEXPRESS;Initial Catalog=WaslaDB;Integrated Security=True;TrustServerCertificate=True";

        public FormReservation()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT NomVille FROM Villes", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string ville = reader["NomVille"]?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(ville))
                    {
                        comboBoxDepart.Items.Add(ville);
                        comboBoxArrivee.Items.Add(ville);
                    }
                }
                reader.Close();

                cmd = new SqlCommand("SELECT NomCompagnie FROM Compagnies", connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string compagnie = reader["NomCompagnie"]?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(compagnie))
                    {
                        comboBoxCompagnie.Items.Add(compagnie);
                    }
                }
                reader.Close();
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string villeDepart = comboBoxDepart.SelectedItem?.ToString() ?? string.Empty;
            string villeArrivee = comboBoxArrivee.SelectedItem?.ToString() ?? string.Empty;
            string compagnie = comboBoxCompagnie.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(villeDepart) || string.IsNullOrEmpty(villeArrivee) || string.IsNullOrEmpty(compagnie))
            {
                MessageBox.Show("Veuillez sélectionner une ville de départ, une ville d'arrivée, et une compagnie.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connexion réussie");

                    string query = "SELECT L.NomLigne, C.NomCompagnie, V1.NomVille AS VilleDepart, V2.NomVille AS VilleArrivee, B.NewBilletID " +
                                   "FROM Billets B " +
                                   "JOIN LignesBus L ON B.LigneID = L.LigneID " +
                                   "JOIN Compagnies C ON B.CompagnieID = C.CompagnieID " +
                                   "JOIN Villes V1 ON L.VilleDepartID = V1.VilleID " +
                                   "JOIN Villes V2 ON L.VilleArriveeID = V2.VilleID " +
                                   "WHERE V1.NomVille = @VilleDepart AND V2.NomVille = @VilleArrivee AND C.NomCompagnie = @Compagnie";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@VilleDepart", villeDepart);
                    cmd.Parameters.AddWithValue("@VilleArrivee", villeArrivee);
                    cmd.Parameters.AddWithValue("@Compagnie", compagnie);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewResults.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Aucun bus trouvé pour cet itinéraire.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void btnReserver_Click(object sender, EventArgs e)
        {
            string villeDepart = comboBoxDepart.SelectedItem?.ToString() ?? string.Empty;
            string villeArrivee = comboBoxArrivee.SelectedItem?.ToString() ?? string.Empty;
            string compagnie = comboBoxCompagnie.SelectedItem?.ToString() ?? string.Empty;
            DateTime dateVoyage = dateTimePickerVoyage.Value;
            int passagers = (int)numericUpDownPassagers.Value;

            if (string.IsNullOrEmpty(villeDepart) || string.IsNullOrEmpty(villeArrivee) || string.IsNullOrEmpty(compagnie) || passagers <= 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de réserver.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string queryLigneID = @"SELECT L.LigneID
                                    FROM LignesBus L
                                    JOIN Villes V1 ON L.VilleDepartID = V1.VilleID
                                    JOIN Villes V2 ON L.VilleArriveeID = V2.VilleID
                                    JOIN Compagnies C ON L.CompagnieID = C.CompagnieID
                                    WHERE V1.NomVille = @VilleDepart AND V2.NomVille = @VilleArrivee AND C.NomCompagnie = @Compagnie";

                    SqlCommand cmdLigneID = new SqlCommand(queryLigneID, connection);
                    cmdLigneID.Parameters.AddWithValue("@VilleDepart", villeDepart);
                    cmdLigneID.Parameters.AddWithValue("@VilleArrivee", villeArrivee);
                    cmdLigneID.Parameters.AddWithValue("@Compagnie", compagnie);

                    object ligneIDResult = cmdLigneID.ExecuteScalar();

                    if (ligneIDResult == null)
                    {
                        MessageBox.Show("Aucune ligne de bus trouvée pour cette sélection.");
                        return;
                    }

                    int ligneID = Convert.ToInt32(ligneIDResult);

                    string queryInsertBillet = @"INSERT INTO Billets (LigneID, CompagnieID, NomUtilisateur, DateVoyage, NumeroSiege, StatutPaiement)
                                         VALUES (@LigneID, 
                                                 (SELECT CompagnieID FROM Compagnies WHERE NomCompagnie = @Compagnie), 
                                                 @NomUtilisateur, 
                                                 @DateVoyage, 
                                                 @NumeroSiege, 
                                                 'Réservé')";

                    SqlCommand cmdInsertBillet = new SqlCommand(queryInsertBillet, connection);
                    cmdInsertBillet.Parameters.AddWithValue("@LigneID", ligneID);
                    cmdInsertBillet.Parameters.AddWithValue("@Compagnie", compagnie);
                    cmdInsertBillet.Parameters.AddWithValue("@NomUtilisateur", "UtilisateurTest");
                    cmdInsertBillet.Parameters.AddWithValue("@DateVoyage", dateVoyage);
                    cmdInsertBillet.Parameters.AddWithValue("@NumeroSiege", 1);

                    int rowsAffected = cmdInsertBillet.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Réservation réussie.");
                        FormPaiement formPaiement = new FormPaiement(dataGridViewResults);
                        formPaiement.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Échec de la réservation.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void comboBoxArrivee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
