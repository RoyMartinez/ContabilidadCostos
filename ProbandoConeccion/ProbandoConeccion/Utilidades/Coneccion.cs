using Microsoft.Data.SqlClient;

namespace ProbandoConeccion.Utilidades;

public class Coneccion
{
    private string _CadenaConeccion;

    public Coneccion()
    {

        _CadenaConeccion = "Server=localhost;Database=CrudExample;Integrated Security = True;TrustServerCertificate=True";
        //_CadenaConeccion = "Server=127.0.0.1,1433;Database=CrudExample;User Id=rmartinez;Password=Abc123;TrustServerCertificate=True";
    }

    public SqlConnection creaConnecion() 
    {
        return new SqlConnection(_CadenaConeccion);
    }
}
