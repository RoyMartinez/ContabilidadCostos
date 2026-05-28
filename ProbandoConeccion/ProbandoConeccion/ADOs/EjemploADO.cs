using Microsoft.Data.SqlClient;
using ProbandoConeccion.Utilidades;
using ProbandoConeccion.Entidades;

namespace ProbandoConeccion.ADOs
{
    public class EjemploADO
    {
        public List<Ejemplo> Obtener()
        {
            List<Ejemplo> Resultado = new List<Ejemplo>();
            
            using (SqlConnection cnn = new Coneccion().creaConnecion())
            {
                cnn.Open();
                string Select = """
                Select Id,Nombre,Edad,FechaCreacion
                From Ejemplo;
                """;


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = Select;

                SqlDataReader Lector = cmd.ExecuteReader();

                while (Lector.Read()) 
                {
                    Ejemplo Registro = new Ejemplo();

                    Registro.Id = Lector.GetInt32(Lector.GetOrdinal("Id"));
                    Registro.Nombre = Lector.GetString(Lector.GetOrdinal("Nombre"));
                    Registro.Edad = Lector.GetInt32(Lector.GetOrdinal("Edad"));
                    Registro.FechaCreacion = Lector.GetDateTime(Lector.GetOrdinal("FechaCreacion"));
                    Resultado.Add(Registro);
                }

            }
            return Resultado;
        }
        public Ejemplo ObtenerPorId(int Id)
        {
            Ejemplo Resultado = new Ejemplo();

            using (SqlConnection cnn = new Coneccion().creaConnecion())
            {
                cnn.Open();
                string Select = $"""
                Select Id,Nombre,Edad,FechaCreacion
                From Ejemplo
                Where Id = {Id};
                """;


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = Select;

                SqlDataReader Lector = cmd.ExecuteReader();

                while (Lector.Read())
                {
                    Resultado.Id = Lector.GetInt32(Lector.GetOrdinal("Id"));
                    Resultado.Nombre = Lector.GetString(Lector.GetOrdinal("Nombre"));
                    Resultado.Edad = Lector.GetInt32(Lector.GetOrdinal("Edad"));
                    Resultado.FechaCreacion = Lector.GetDateTime(Lector.GetOrdinal("FechaCreacion"));
                }

            }
            return Resultado;
        }
        public bool Agregar(Ejemplo Data)
        {
            using (SqlConnection cnn = new Coneccion().creaConnecion())
            {
                cnn.Open();
                string Insert = """
                INSERT INTO Ejemplo
                (Nombre, Edad, FechaCreacion)
                VALUES
                (@Nombre, @Edad, @FechaCreacion);
                """;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = Insert;

                cmd.Parameters.AddWithValue("@Nombre", Data.Nombre);
                cmd.Parameters.AddWithValue("@Edad", Data.Edad);
                cmd.Parameters.AddWithValue("@FechaCreacion", Data.FechaCreacion);

                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }
        public bool Actualizar(Ejemplo Data)
        {
            using (SqlConnection cnn = new Coneccion().creaConnecion())
            {
                cnn.Open();
                string Update = """
                UPDATE Ejemplo
                SET 
                    Nombre = @Nombre,
                    Edad = @Edad,
                    FechaCreacion = @FechaCreacion
                WHERE Id = @Id;
                """;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = Update;

                cmd.Parameters.AddWithValue("@Id", Data.Id);
                cmd.Parameters.AddWithValue("@Nombre", Data.Nombre);
                cmd.Parameters.AddWithValue("@Edad", Data.Edad);
                cmd.Parameters.AddWithValue("@FechaCreacion", Data.FechaCreacion);

                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }
        public bool Eliminar(Ejemplo Data)
        {
            using (SqlConnection cnn = new Coneccion().creaConnecion())
            {
                cnn.Open();
                string Delete = """
                DELETE FROM Ejemplo
                WHERE Id = @Id;
                """;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = Delete;

                cmd.Parameters.AddWithValue("@Id", Data.Id);

                int filasAfectadas = cmd.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }
    }
}
