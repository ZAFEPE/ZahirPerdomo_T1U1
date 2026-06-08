using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class CalculoHorasPagadas
    {
        public static decimal PagoTotal(decimal HorasTrabajadas,decimal TarifaPorHora)
        {
            decimal pagoBase = 0m;
            decimal pagoExtra = 0m;
            decimal pagoTotal = 0m;

            if (HorasTrabajadas <= 44)
            {
                pagoBase = HorasTrabajadas * TarifaPorHora;
                pagoTotal = pagoBase;
            }
            else
            {
                decimal HorasExtras = HorasTrabajadas - 44;
                
                pagoBase = 44 * TarifaPorHora;
                pagoExtra = HorasExtras * (TarifaPorHora * 1.5m);
                pagoTotal = pagoBase + pagoExtra;
            }


            Console.WriteLine($"Pago por Horas Normales: {pagoBase:N2}");
            Console.WriteLine($"Pago por Horas Extras: {pagoExtra:N2}");
            
            return pagoTotal;
        }
        
    }
}