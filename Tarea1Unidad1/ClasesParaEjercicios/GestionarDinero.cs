namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class GestionarDinero
    {
        public GestionarDinero(int CantidadDinero)
        {
            int Cantidad500=0;
            int Cantidad200=0;
            int Cantidad100=0;
            int Cantidad50=0;
            int Cantidad20=0;
            int Cantidad10=0;
            int Cantidad5=0;
            int Cantidad2=0;
            int Cantidad1=0;
            
            if(CantidadDinero > 0)
            {
                Cantidad500 = CantidadDinero / 500;
                CantidadDinero = CantidadDinero % 500;

                Cantidad200 = CantidadDinero / 200;
                CantidadDinero = CantidadDinero % 200;

                Cantidad100 = CantidadDinero / 100;
                CantidadDinero = CantidadDinero % 100;

                Cantidad50 = CantidadDinero / 50;
                CantidadDinero = CantidadDinero % 50;

                Cantidad20 = CantidadDinero / 20;
                CantidadDinero = CantidadDinero % 20;

                Cantidad10 = CantidadDinero / 10;
                CantidadDinero = CantidadDinero % 10;

                Cantidad5 = CantidadDinero / 5;
                CantidadDinero = CantidadDinero % 5;

                Cantidad2 = CantidadDinero / 2;
                CantidadDinero = CantidadDinero % 2;

                Cantidad1 = CantidadDinero / 1;
                CantidadDinero = CantidadDinero % 1;
            }
            else
            {
                Console.WriteLine("La cantidad ingresada no es valida");
                return;
            }
            
            Console.WriteLine($"Usted recibirá: ");

            Console.WriteLine($"{Cantidad500} billetes de 500\n");
            Console.WriteLine($"{Cantidad200} billetes de 200\n");
            Console.WriteLine($"{Cantidad100} billetes de 100\n");
            Console.WriteLine($"{Cantidad50} billetes de 50\n");
            Console.WriteLine($"{Cantidad20} billetes de 20\n");
            Console.WriteLine($"{Cantidad10} billetes de 10\n");
            Console.WriteLine($"{Cantidad5} billetes de 5\n");
            Console.WriteLine($"{Cantidad2} billetes de 2\n");
            Console.WriteLine($"{Cantidad1} billetes de 1\n");
            
        }
    }
}