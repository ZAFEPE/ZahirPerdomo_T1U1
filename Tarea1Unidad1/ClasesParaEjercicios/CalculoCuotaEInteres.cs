using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class CalculoCuotaEInteres
    {
        public static decimal cuotaMensualFija(decimal monto, decimal interesAnual, decimal plazo)
        {
            decimal PorcentajeInteres = interesAnual / 100;
            decimal interesMensual= PorcentajeInteres/12m;
            
            return (monto * interesMensual) / (decimal)(1 - Math.Pow((double)(1+interesMensual),(double)-plazo));
        }
        public static decimal InteresTotal(decimal CuotaMensual, decimal Plazo, decimal Monto)
        {
            return (CuotaMensual * Plazo) - Monto;
        }
    }
}