namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class CalcularNumerosPrimos
    {
        public CalcularNumerosPrimos(int inicio, int final)
        {
            int contador = 0;

            for(int i= inicio; i <= final; i++)
            {
                contador =0;
                for(int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        contador++;
                    }
                }
                if(contador == 2)
                {
                    Console.WriteLine($"{i} es numero primo");
                }
            }

        }
    }
}