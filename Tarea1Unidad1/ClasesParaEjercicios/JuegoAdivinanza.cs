using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class JuegoAdivinanza
    {
        public static bool Adivinanzas()
        {
            Random random = new Random();
            int Aleatorio = random.Next(1, 101); 
            
            bool Ganador = false;
            int intentoUsuario = 0;
            int contadorIntentos = 0;

            Console.WriteLine("\n======== JUEGO DE ADIVINANZAS ========");
            Console.WriteLine("La computadora ha pensado un número entre 1 y 100.");
            Console.WriteLine("Intenta adivinarlo.\n");

            do
            {
                Console.Write("Introduce tu número: ");
                
                if (!int.TryParse(Console.ReadLine(), out intentoUsuario))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.\n");
                    continue; 
                }

                contadorIntentos++;


                if (intentoUsuario < Aleatorio)
                {
                    Console.WriteLine("¡Más ALTO!\n");
                }
                else if (intentoUsuario > Aleatorio)
                {
                    Console.WriteLine("¡Más BAJO!\n");
                }
                else
                {
                    Ganador = true;
                }
                if(contadorIntentos ==7)
                {
                    Console.WriteLine("Has agotado tus intentos, MEJOR SUERTE LA PROXIMA!");
                    return false;
                }

            } while (!Ganador); 


            Console.WriteLine($"¡FELICIDADES! Has adivinado el numero: {Aleatorio}");
            Console.WriteLine($"Te tomó {contadorIntentos} intentos lograrlo.");

            return Ganador;
        }   
    }
}