namespace Tarea1Unidad1.ClasesParaEjercicios
{
    
    public class CajeroAutomatico
    {
        public static int GestionRetiros(int Monto)
        {
            decimal SaldoDisponible = 10000m;
            bool sePuedeRetirar= false;
            int Cantidad500 =0,Cantidad200=0,Cantidad100=0;
            int Cantidad50 =0,Cantidad20=0;

            if(Monto % 20 ==0)
            {
                sePuedeRetirar = true;
            }
            else
            {
                Console.WriteLine("ERROR: La cantidad ingresada debe ser multiplo de 20");
            }

            if(sePuedeRetirar && Monto <= SaldoDisponible)
            {
                Console.WriteLine("\n============ RETIRO AUTORIZADO ============\n");
                if(Monto > 0)
                {
                    Cantidad500 = Monto / 500;
                    Monto = Monto % 500;
                    Cantidad200 = Monto / 200;
                    Monto = Monto % 200;
                    Cantidad100 = Monto / 100;
                    Monto = Monto % 100;
                    Cantidad50 = Monto / 50;
                    Monto = Monto % 50;
                    Cantidad20 = Monto / 20;
                    Monto = Monto % 20;
                }
                SaldoDisponible -= Monto;
            }
            else
            {
                Console.WriteLine("ERROR: La cantidad ingresada no es valida");
                return 0;
            }

            Console.WriteLine($"Usted recibirá: ");

            Console.WriteLine($"{Cantidad500} billetes de 500\n");
            Console.WriteLine($"{Cantidad200} billetes de 200\n");
            Console.WriteLine($"{Cantidad100} billetes de 100\n");
            Console.WriteLine($"{Cantidad50} billetes de 50\n");
            Console.WriteLine($"{Cantidad20} billetes de 20\n");
            return 0;


            
        }
    }
}