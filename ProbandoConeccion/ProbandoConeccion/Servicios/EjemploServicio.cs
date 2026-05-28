using ProbandoConeccion.ADOs;
using ProbandoConeccion.Entidades;

namespace ProbandoConeccion.Servicios;

public static class EjemploServicio
{
    public static void ListarRegistros()
    {
        EjemploADO ejemploADO = new EjemploADO();
        Console.WriteLine("LISTADO DE REGISTROS");
        Console.WriteLine("====================");

        List<Ejemplo> registros = ejemploADO.Obtener();

        if (registros.Count == 0)
        {
            Console.WriteLine("No hay registros.");
            return;
        }

        foreach (Ejemplo item in registros)
        {
            Console.WriteLine($"Id: {item.Id}");
            Console.WriteLine($"Nombre: {item.Nombre}");
            Console.WriteLine($"Edad: {item.Edad}");
            Console.WriteLine($"Fecha creación: {item.FechaCreacion}");
            Console.WriteLine("----------------------------");
        }
    }

    public static void BuscarPorId()
    {
        EjemploADO ejemploADO = new EjemploADO();
        Console.WriteLine("BUSCAR REGISTRO POR ID");
        Console.WriteLine("======================");

        Console.Write("Ingrese el Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Ejemplo registro = ejemploADO.ObtenerPorId(id);

        if (registro.Id == 0)
        {
            Console.WriteLine("No se encontró el registro.");
            return;
        }

        Console.WriteLine($"Id: {registro.Id}");
        Console.WriteLine($"Nombre: {registro.Nombre}");
        Console.WriteLine($"Edad: {registro.Edad}");
        Console.WriteLine($"Fecha creación: {registro.FechaCreacion}");
    }

    public static void AgregarRegistro()
    {
        EjemploADO ejemploADO = new EjemploADO();
        Console.WriteLine("AGREGAR REGISTRO");
        Console.WriteLine("================");

        Ejemplo nuevoRegistro = new Ejemplo();

        Console.Write("Ingrese el nombre: ");
        nuevoRegistro.Nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese la edad: ");
        nuevoRegistro.Edad = Convert.ToInt32(Console.ReadLine());

        nuevoRegistro.FechaCreacion = DateTime.Now;

        bool resultado = ejemploADO.Agregar(nuevoRegistro);

        if (resultado)
        {
            Console.WriteLine("Registro agregado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pudo agregar el registro.");
        }
    }

    public static void ActualizarRegistro()
    {
        EjemploADO ejemploADO = new EjemploADO();
        Console.WriteLine("ACTUALIZAR REGISTRO");
        Console.WriteLine("===================");

        Ejemplo registro = new Ejemplo();

        Console.Write("Ingrese el Id del registro a actualizar: ");
        registro.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el nuevo nombre: ");
        registro.Nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese la nueva edad: ");
        registro.Edad = Convert.ToInt32(Console.ReadLine());

        registro.FechaCreacion = DateTime.Now;

        bool resultado = ejemploADO.Actualizar(registro);

        if (resultado)
        {
            Console.WriteLine("Registro actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pudo actualizar el registro. Puede que el Id no exista.");
        }
    }

    public static void EliminarRegistro()
    {
        EjemploADO ejemploADO = new EjemploADO();
        Console.WriteLine("ELIMINAR REGISTRO");
        Console.WriteLine("=================");

        Ejemplo registro = new Ejemplo();

        Console.Write("Ingrese el Id del registro a eliminar: ");
        registro.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.Write("¿Está seguro que desea eliminar este registro? S/N: ");
        string? confirmacion = Console.ReadLine();

        if (confirmacion?.ToUpper() != "S")
        {
            Console.WriteLine("Eliminación cancelada.");
            return;
        }

        bool resultado = ejemploADO.Eliminar(registro);

        if (resultado)
        {
            Console.WriteLine("Registro eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("No se pudo eliminar el registro. Puede que el Id no exista.");
        }
    }
}
