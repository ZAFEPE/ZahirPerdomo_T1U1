namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class DiasDelMes
    {
        public static int CalcularDias(int anio, int mes)
        {
            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Error: El número de mes ingresado debe estar entre 1 y 12");
                return 0;
            }
           
            bool esBisiesto = (anio % 4 == 0 && anio %100 != 0) || (anio % 400== 0);

            int cantidadDias = 0;

            if (mes ==2)
            {
                if (esBisiesto)
                {
                    cantidadDias = 29;
                }
                else
                {
                    cantidadDias = 28;
                }
            }
        
            else if (mes ==4 || mes == 6 || mes == 9 || mes== 11)
            {
                cantidadDias = 30;
            }
      
            else
            {
                cantidadDias =31;
            }
            
            Console.WriteLine($"RESULTADO DEL CALENDARIO");
            if (esBisiesto)
            {
                Console.WriteLine($"El año {anio} SÍ es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {anio} NO es bisiesto.");
            }
            Console.WriteLine($"El mes {mes} tiene {cantidadDias} días.");

            return cantidadDias;
        }
    }
}