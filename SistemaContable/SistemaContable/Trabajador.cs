using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SistemaContable
{
    public class Trabajador
    {
        private string nombre;
        private string cargo;
        private string area;
        private string clasificacion;
        private double horas;
        private double horas_extras;
        private double salario;


        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("El nombre no puede quedar vacio");
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public string Cargo
        {
            get { return cargo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("El cargo no puede quedar vacio");
                }
                else
                {
                    cargo = value;
                }
            }
        }

        public string Area
        {
            get { return area; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("El area no puede quedar vacio");
                }
                else
                {
                    area = value;
                }
            }
        }

        public string Clasificacion
        {
            get { return clasificacion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("La clasificacion no puede quedar vacio");
                }
                else
                {
                    cargo = value;
                }
            }
        }


        public double Horas
        {
            get { return horas; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ingrese horas trabajadas validas");
                }
                else
                {
                    horas = value;
                }
            }
        }


        public double Horas_Extras
        {
            get { return horas_extras; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ingrese horas extras trabajadas validas");
                }
                else
                {
                    horas_extras = value;
                }
            }
        }

        public double Salario
        {
            get { return salario; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ingrese un salario valido");
                }
                else
                {
                    salario = value;
                }
            }
        }


     
    }
}