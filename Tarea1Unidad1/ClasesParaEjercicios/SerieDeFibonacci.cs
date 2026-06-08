namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class SerieDeFibonacci
    {
        public SerieDeFibonacci(int Cantidad)
        {
            int a = 0;
            int b = 1;
            decimal SumaTotal=1m;
            decimal promedio= 0m;
            if(Cantidad >=1)
            {
                Console.WriteLine($"{a}");
            }
            if(Cantidad >=2)
            {
                Console.WriteLine($"{b}");
            }

            for (int i = 3; i<=Cantidad;i++)
            {
                
                int siguiente = a + b;
                Console.WriteLine($"{siguiente}");
                SumaTotal += siguiente;
                a = b;
                b = siguiente;

            }
            promedio = SumaTotal/Cantidad;

            Console.WriteLine($"\nLa suma total es : {SumaTotal}\n Y el promedio es: {promedio:N2}");
        }
    }
}