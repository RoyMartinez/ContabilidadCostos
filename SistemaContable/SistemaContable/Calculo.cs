using System;
using System;

namespace SistemaContable
{
    public class Calculo
    {


        public double HorasExtras(double horas)
        {
            double horas_extras = 0;
            if (horas > 40)
            {
                horas_extras = horas - 40;
                return horas_extras;
            }
            return horas_extras;
        }

        public double SalarioBruto(double salario, double horas)
        {
            double horas_extras = HorasExtras(horas);    
            double pago_extra = 0;
            double salario_bruto = 0;
            if (horas > 40)
            {
                pago_extra = (salario / 240.0) * 2 * horas_extras;
                salario_bruto = salario + pago_extra;
                return salario_bruto;
            }
             pago_extra = (salario / 240.0) * 2 * horas_extras;
             salario_bruto = salario + pago_extra;
            return salario_bruto;
        }

        public double INSS_Laboral(double bruto)
        {
            return bruto * 0.07;
        }

        public double INSS_Patronal(double bruto)
        {
            return bruto * 0.225;
        }

        public double INATEC(double bruto)
        {
            return bruto * 0.02;
        }





        public double IR(double bruto)
        {
            double BaseImponible = bruto - INSS_Laboral(bruto);
            double anual = BaseImponible * 12;
            double IRanual = 0;

            if (anual >= 0 && anual <= 100000)
            {
                IRanual = 0;
            }
            else if (anual > 100000 && anual <= 200000)
            {
                IRanual = (anual - 100000) * 0.15;
            }
            else if (anual > 200000 && anual <= 350000)
            {
                IRanual = ((anual - 200000) * 0.2) + 15000;
            }
            else if (anual > 350000 && anual <= 500000)
            {
                IRanual = ((anual - 350000) * 0.25) + 45000;
            }
            else if (anual > 500000)
            {
                IRanual = ((anual - 500000) * 0.3) + 82500;
            }

            return IRanual / 12;
        }
    }
}