using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class Combinatoria
    {
        public static double CalcularFactorial(int numero)
        {
            if (numero < 0) return 0;
            
            double resultado = 1;
            
            for (int i = 1; i <= numero; i++)
            {
                resultado = resultado * i; 
            }
            return resultado;
        }
        public static void CalcularCombinacion(int n, int r)
        {
            if (n < r || n < 0 || r < 0)
            {
                Console.WriteLine("Error: 'n' debe ser mayor o igual que 'r', y ambos deben ser positivos.");
                return;
            }

            double factorialN = CalcularFactorial(n);
            double factorialR = CalcularFactorial(r);
            double factorialResta = CalcularFactorial(n - r);

            double combinacion = factorialN / (factorialR * factorialResta);

            Console.WriteLine($"Factorial de n ({n}!) = {factorialN}");
            Console.WriteLine($"Factorial de r ({r}!) = {factorialR}");
            Console.WriteLine($"Factorial de (n-r) (({n}-{r})!) = {factorialResta}");
            Console.WriteLine($"Resultado de C({n}, {r}) = {combinacion}");

        }
    }
}