using Microsoft.Data.SqlClient;

string connectionString =
    "Data Source=host.docker.internal,1433;Initial Catalog=testing;User ID=sa;Password=TuPassword123*;Encrypt=True;TrustServerCertificate=True;";

using SqlConnection cnn = new SqlConnection(connectionString);

cnn.Open();

Console.WriteLine("Conexión abierta correctamente.");