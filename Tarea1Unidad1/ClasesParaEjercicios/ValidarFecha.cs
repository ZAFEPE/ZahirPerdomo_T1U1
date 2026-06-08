namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class ValidarFecha
    {
        public static bool VerificarFechaReal(int dia,int mes, int anio)
        {
            if (mes < 1 || mes>12 || anio < 1)
            {
                Console.WriteLine("Error: El mes o el año no están en rangos válidos.");
                return false;
            }

            bool esBisiesto = (anio% 4 ==0 &&anio% 100 != 0) || (anio % 400 == 0);
            
            int diasMaximos = 0;

            if (mes == 2)
            {
                if (esBisiesto)
                {
                    diasMaximos = 29;
                }
                else
                {
                    diasMaximos = 28;
                }
            }
            else if (mes == 4||mes==6||mes==9||mes==11)
            {
                diasMaximos = 30;
            }
            else
            {
                diasMaximos =31;
            }

            if (dia < 1 || dia > diasMaximos)
            {
                Console.WriteLine($"Error: La fecha no es valida. El mes {mes} en el año {anio} solo tiene {diasMaximos} dias.");
                return false;
            }

            Console.WriteLine($"La fecha ingresada {dia}/{mes}/{anio} es valida.");
            return true;
        }
    }
}