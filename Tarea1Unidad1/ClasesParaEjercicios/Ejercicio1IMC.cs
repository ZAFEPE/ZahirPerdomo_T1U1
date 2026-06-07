namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class Ejercicio1IMC
    {
        public Ejercicio1IMC(decimal Altura, decimal Peso)
        {
            

            decimal IMC = Peso/(Altura*Altura);//calculo del IMC de una vez en la variable IMC
            Console.WriteLine($"Su indice de masa corporal es de: {IMC:N2}");
            if (IMC < 19)
            {
                Console.WriteLine("Usted esta debajo de su peso saludable.");
            }
            else if(IMC < 25)
            {
                Console.WriteLine("Usted esta en un peso saludable.");
            }
            else if(IMC < 30)
            {
                Console.WriteLine("Usted tiene sobre peso.");
            }
            else if(IMC > 30)
            {
                Console.WriteLine("Usted sufre de obesidad.");
            }
        }
    }
}