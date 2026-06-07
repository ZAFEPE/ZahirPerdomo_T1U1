using Tarea1Unidad1.Ejercicios;

namespace Tarea1Unidad1
{
    class Program
    {
        static void Main(string[]args)
        {
            // Ejercicio1();
            Ejercicio2();
            // Ejercicio3();
            // Ejercicio4();
            // Ejercicio5();
            // Ejercicio6();
            // Ejercicio7();
            // Ejercicio8();
            // Ejercicio9();
            // Ejercicio10();
            // Ejercicio11();
            // Ejercicio12();
            // Ejercicio13();
            // Ejercicio14();
            // Ejercicio15();
            // Ejercicio16();
            // Ejercicio17();
            // Ejercicio18();
            // Ejercicio19();
            // Ejercicio20();
            // Ejercicio21();
            // Ejercicio22();
            // Ejercicio23();
            // Ejercicio24();
            // Ejercicio25();
            // Ejercicio26();
            // Ejercicio27();
            // Ejercicio28();
            // Ejercicio29();
            // Ejercicio30();
            
        }

        static void Ejercicio1()
        {
            /*
            El programa pregunta peso y altura e intenta convertir lo que el usuario ingrese
            a decimal por si trata de ingresar texto
            */
            Console.WriteLine("Ingrese su altura en metros: ");
            decimal.TryParse(Console.ReadLine(), out decimal altura);
            Console.WriteLine("Ingrese su peso en kilogramos: ");
            decimal.TryParse(Console.ReadLine(), out decimal peso);
            if(altura <= 0 || peso <= 0)//Validación de números negativos o 0
            {
                Console.WriteLine("------------- La altura o el peso ingresados no son validos -------------");
                return;
            }
            Ejercicio1IMC ejercicio1 = new Ejercicio1IMC(altura,peso);
        }
        static void Ejercicio2()
        {
            
            Console.WriteLine("Ingrese el tipo de temperatura que desea convertir (Ingrese el numero correspondiente a su elección)");
            Console.WriteLine("1. Celcius\n2. Fahrenheit\n3. Kelvin\n4. Salir");
            int.TryParse(Console.ReadLine(), out int TemperaturaBase);
            if(TemperaturaBase == 4) return;
            Console.Clear();

            Console.WriteLine("Elija la temperatura a la que desea convertirla (Ingrese el numero correspondiente a su elección)");
            Console.WriteLine("1. Celcius\n2. Fahrenheit\n3. Kelvin\n4. Salir");
            int.TryParse(Console.ReadLine(), out int TemperaturaAConvertir);
            if(TemperaturaBase == 4) return;
            Console.Clear();

            Console.WriteLine("Ingrese la temperatura: ");
            decimal.TryParse(Console.ReadLine(), out decimal TemperaturaIngresada);

            decimal resultado = ConvertirTemperatura.AdministrarConversiones(TemperaturaBase,TemperaturaAConvertir,TemperaturaIngresada);
            Console.WriteLine($"El resultado es: {resultado:N1}");

            
        }
        static void Ejercicio3()
        {
            
        }
        static void Ejercicio4()
        {
            
        }
        static void Ejercicio5()
        {
            
        }
        static void Ejercicio6()
        {
            
        }
        static void Ejercicio7()
        {
            
        }
        static void Ejercicio8()
        {
            
        }
        static void Ejercicio9()
        {
            
        }
        static void Ejercicio10()
        {
            
        }
        static void Ejercicio11()
        {
            
        }
        static void Ejercicio12()
        {
            
        }
        static void Ejercicio13()
        {
            
        }
        static void Ejercicio14()
        {
            
        }
        static void Ejercicio15()
        {
            
        }
        static void Ejercicio16()
        {
            
        }
        static void Ejercicio17()
        {
            
        }
        static void Ejercicio18()
        {
            
        }
        static void Ejercicio19()
        {
            
        }
        static void Ejercicio20()
        {
            
        }
        static void Ejercicio21()
        {
            
        }
        static void Ejercicio22()
        {
            
        }
        static void Ejercicio23()
        {
            
        }
        static void Ejercicio24()
        {
            
        }
        static void Ejercicio25()
        {
            
        }
        static void Ejercicio26()
        {
            
        }
        static void Ejercicio27()
        {
            
        }
        static void Ejercicio28()
        {
            
        }
        static void Ejercicio29()
        {
            
        }
        static void Ejercicio30()
        {
            
        }


    }
}



