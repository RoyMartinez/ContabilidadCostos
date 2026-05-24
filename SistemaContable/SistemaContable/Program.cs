using System;

namespace SistemaContable
{
    public class Principal
    {
        static void Main()
        {
            Trabajador t = new Trabajador();
            Calculo c = new Calculo();

            Console.WriteLine("==== Sistema de Nomina ======");
            Console.WriteLine();

           
            Console.Write("Ingrese el nombre completo del empleado: ");
            t.Nombre = Console.ReadLine();

           
            Console.Write("Ingrese el cargo del empleado: ");
            t.Cargo = Console.ReadLine();

            
            Console.Write("Ingrese el area de trabajo del empleado: ");
            t.Area = Console.ReadLine();

            Console.Write("Ingrese si es MOD, MOI, Gasto de ventas, Gasto administrativo: ");
            t.Clasificacion = Console.ReadLine();

            Console.Write("Ingrese el salario mensual ordinario: ");
            t.Salario = double.Parse(Console.ReadLine());

            Console.Write("Ingrese las horas ordinarias: ");
            t.Horas = double.Parse(Console.ReadLine());

            


            double bruto = c.SalarioBruto(t.Salario,t.Horas) ;

        
           

         
            double inss = c.INSS_Laboral(bruto);
            double ir = c.IR(bruto);
            double neto = bruto - inss - ir;
            double inatec = c.INATEC(bruto);
            double inssPatronal = c.INSS_Patronal(bruto);

       
            Console.WriteLine("Nomina");
            Console.WriteLine();
            Console.WriteLine($"Empleado: {t.Nombre}");
            
            Console.WriteLine($"Horas trabajadas: {t.Horas}");

            Console.WriteLine($"Horas extras: {c.HorasExtras(t.Horas)}");
            Console.WriteLine($"Salario bruto: {bruto}");
            Console.WriteLine($"INSS Laboral (7%): {inss}");
            Console.WriteLine($"IR: {ir}");
            Console.WriteLine($"Salario Neto: {neto}");
            Console.WriteLine($"INATEC (2%): {inatec}");
            Console.WriteLine($"INSS Patronal (22.5%): {inssPatronal}");

          
        }
    }
}