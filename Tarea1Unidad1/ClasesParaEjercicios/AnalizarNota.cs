namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class AnalizarNota
    {
        public AnalizarNota (int nota)
        {
            if(nota<65 && nota> 0)
            {
                Console.WriteLine("========== Usted a REPROBADO con una F ==========");
                Console.WriteLine("No ha alcanzado los requisitos minimos de aprendizaje en la asignatura.");
            }
            else if( nota < 70)
            {
                Console.WriteLine("========== Usted a APROBADO con una D ==========");
                Console.WriteLine("El rendimiento es deficiente pero ha alcanzado los requisitos minimos de la asignatura.");
            }
            else if( nota <80)
            {
                Console.WriteLine("========== Usted a APROBADO con una C ==========");
                Console.WriteLine("A aprobado la asignatura cumpliendo con lo esperado en aprendizaje para la asignatura.");
            }
            else if( nota < 90)
            {
                Console.WriteLine("========== Usted a APROBADO con una B ==========");
                Console.WriteLine("A aprobado la asignatura cumpliendo por encima de lo esperado en aprendizaje para la asignatura.");
            }
            else if( nota <= 100 )
            {
                Console.WriteLine("========== Usted a APROBADO con una A ==========");
                Console.WriteLine("A aprobado la asignatura cumpliendo muy por encima de lo esperado en aprendizaje para la asignatura.");
            }
            
        }
    }
}