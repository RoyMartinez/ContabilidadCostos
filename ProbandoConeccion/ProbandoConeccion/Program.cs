using ProbandoConeccion.Servicios;

int opcion = -1;

while (opcion != 0)
{
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("       CRUD DE EJEMPLO");
    Console.WriteLine("==================================");
    Console.WriteLine("1. Listar registros");
    Console.WriteLine("2. Buscar registro por Id");
    Console.WriteLine("3. Agregar registro");
    Console.WriteLine("4. Actualizar registro");
    Console.WriteLine("5. Eliminar registro");
    Console.WriteLine("0. Salir");
    Console.WriteLine("==================================");
    Console.Write("Seleccione una opción: ");

    string? input = Console.ReadLine();

    if (!int.TryParse(input, out opcion))
    {
        Console.WriteLine("Opción inválida.");
        Pausar();
        continue;
    }

    Console.Clear();

    switch (opcion)
    {
        case 1:
            EjemploServicio.ListarRegistros();
            break;

        case 2:
            EjemploServicio.BuscarPorId();
            break;

        case 3:
            EjemploServicio.AgregarRegistro();
            break;

        case 4:
            EjemploServicio.ActualizarRegistro();
            break;

        case 5:
            EjemploServicio.EliminarRegistro();
            break;

        case 0:
            Console.WriteLine("Saliendo del sistema...");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

    if (opcion != 0)
    {
        Pausar();
    }
}


static void Pausar()
{
    Console.WriteLine();
    Console.WriteLine("Presione cualquier tecla para continuar...");
    Console.ReadKey();
}