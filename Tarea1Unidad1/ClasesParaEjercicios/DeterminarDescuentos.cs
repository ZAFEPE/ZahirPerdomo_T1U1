using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class DeterminarDescuentos
    {
        public DeterminarDescuentos(decimal Monto)
        {
            decimal PrecioFinal=0m;
            if(Monto >=500 && Monto <= 999)
            {
                PrecioFinal = Monto - (Monto*0.05m);
                Console.WriteLine($"El precio original es: {Monto}\nEl descuento aplicado es del 5%\nEl precio final es: {PrecioFinal:N2}");
            }
            else if (Monto >=1000 && Monto <= 2499)
            {
                PrecioFinal = Monto - (Monto*0.1m);
                Console.WriteLine($"El precio original es: {Monto}\nEl descuento aplicado es del 10%\nEl precio final es: {PrecioFinal:N2}");
            }
            else if (Monto >= 2500)
            {
                PrecioFinal = Monto - (Monto*0.15m);
                Console.WriteLine($"El precio original es: {Monto}\nEl descuento aplicado es del 15%\nEl precio final es: {PrecioFinal:N2}");
            }
            else if(Monto <500 && Monto >0)
            {
                Console.WriteLine($"Usted no aplica para un descuento\nEl precio final es: {Monto}");
            }
            else
            {
                Console.WriteLine("ERROR: El monto ingresado no es valido");
            }



        }
    }
}