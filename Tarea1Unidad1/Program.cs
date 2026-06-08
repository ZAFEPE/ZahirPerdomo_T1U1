using Tarea1Unidad1.ClasesParaEjercicios;

namespace Tarea1Unidad1
{
    class Program
    {
        static void Main(string[]args)
        {
            // Ejercicio1();
            // Ejercicio2();
            // Ejercicio3();
            // Ejercicio4();
            // Ejercicio5();
            // Ejercicio6();
            // Ejercicio7();
            // Ejercicio8();
            // Ejercicio9();
            // Ejercicio10();
            // Ejercicio11();
            Ejercicio12();
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
            /*
            El programa muestra un menu de seleccion y lo almacena en una variable, en caso de que elijan salir el programa se cerrara
            al preguntar la temperatura base y a cual la quieren convertir la variable resultado almacena lo que devuelve la clase 
            convertir temperatura donde AdministrarConversiones se encarga de asignar que tipo de conversion se hará,
            */
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
            Console.WriteLine("Ingrese la cantidad de Lempiras: ");
            int.TryParse(Console.ReadLine(), out int Monto);

            GestionarDinero gestionarDinero = new GestionarDinero(Monto);
        }
        static void Ejercicio4()
        {
            Console.WriteLine("Ingrese el monto de dinero: ");
            int.TryParse(Console.ReadLine(), out int Monto);
            Console.WriteLine("Ingrese la tasa de interes anual en porcentaje: ");
            int.TryParse(Console.ReadLine(), out int InteresAnual);
            Console.WriteLine("Ingrese el plazo en meses: ");
            int.TryParse(Console.ReadLine(), out int Plazo);
            Console.Clear();
            decimal CuotaMensualFija = CalculoCuotaEInteres.cuotaMensualFija(Monto,InteresAnual,Plazo); 
            decimal InteresTotal = CalculoCuotaEInteres.InteresTotal(CuotaMensualFija,Plazo,Monto);
            if(CuotaMensualFija < 0 || InteresTotal < 0)
            {
                Console.WriteLine("Los valores ingresados no son validos");
            }
            else
            {
                Console.WriteLine($"La cuota mensual fija es : {CuotaMensualFija:N2}");
                Console.WriteLine($"El interes total es : {InteresTotal:N2}"); 
            }
            
        }
        static void Ejercicio5()
        {
            Console.WriteLine("!!!!! Ingrese las horas en formato de 24hrs !!!!!");
            //registra la hora 1
            Console.WriteLine("Ingrese la hora #1: ");
            int.TryParse(Console.ReadLine(), out int hora1);
            Console.WriteLine("Ingrese la hora minuto #1: ");
            int.TryParse(Console.ReadLine(), out int minuto1);
            Console.WriteLine("Ingrese la hora segundo #1: ");
            int.TryParse(Console.ReadLine(), out int segundo1);
            // registra la hora 2
            Console.WriteLine("Ingrese la hora #2: ");
            int.TryParse(Console.ReadLine(), out int hora2);
            Console.WriteLine("Ingrese la hora minuto #2: ");
            int.TryParse(Console.ReadLine(), out int minuto2);
            Console.WriteLine("Ingrese la hora segundo #2: ");
            int.TryParse(Console.ReadLine(), out int segundo2);
            Console.Clear();
            TimeSpan Hora1 = new TimeSpan(hora1,minuto1,segundo1);
            TimeSpan Hora2 = new TimeSpan(hora2,minuto2,segundo2);
            TimeSpan DiferenciaDeHora = Hora2 - Hora1;

            int ResultadoHora = DiferenciaDeHora.Hours;
            int ResultadoMinuto = DiferenciaDeHora.Minutes;
            int ResultadoSegundo = DiferenciaDeHora.Seconds;

            Console.WriteLine($"La diferencia de horas es de {ResultadoHora} horas, {ResultadoMinuto} minutos y {ResultadoSegundo} segundos.");

        }
        static void Ejercicio6()
        {
            Console.WriteLine("Ingrese el numero de la eleccion que desea: ");
            Console.WriteLine("1. Calcuar Area.\n2. Calcular Perimetro.\n3. Salir.");
            int.TryParse(Console.ReadLine(), out int eleccionCalculo);
            if(eleccionCalculo==3)return;
            Console.Clear();
            
            Console.WriteLine("Ingrese el número de la figura que desea calcular:");
            Console.WriteLine("1. Circulo.\n2. Triángulo.\n3. Rectángulo.\n4. Trapecio.\n5. Salir.");
            int.TryParse(Console.ReadLine(), out int eleccionForma);
            if(eleccionCalculo==5)return;
            Console.Clear();

            decimal resultado = CalculoAreaYPerimetro.RegistroDeDatos(eleccionCalculo,eleccionForma);

            Console.WriteLine($"El resultado de el calculo es: {resultado}");

        }
        static void Ejercicio7()
        {
            Console.WriteLine("Ingrese el numero de la eleccion que desea convertir: ");
            Console.WriteLine("1. Bytes.\n2. Kilobytes.\n3. MegaBytes.\n4. GigaBytes.\n5. TeraBytes\n6. Salir");
            int.TryParse(Console.ReadLine(), out int DatoBase);
            if(DatoBase==6)return;
            Console.Clear();
            
            Console.WriteLine("Ingrese el número de la eleccion a la que desea convertir:");
            Console.WriteLine("1. Bytes.\n2. Kilobytes.\n3. MegaBytes.\n4. GigaBytes.\n5. TeraBytes\n6. Salir");
            int.TryParse(Console.ReadLine(), out int EleccionConversion);
            if(EleccionConversion==6)return;
            Console.Clear();

            Console.WriteLine("Ingrese la cantidad a convertir:");
            int.TryParse(Console.ReadLine(), out int CantidadIngresada);
            if(EleccionConversion==6)return;

            decimal resultado = CalculoConversionDatos.RegistroDeDatos(DatoBase,EleccionConversion,CantidadIngresada);

            Console.WriteLine($"El resultado de el calculo es: {resultado:N10}");
        }
        static void Ejercicio8()
        {
            Console.WriteLine("Ingrese las horas trabajadas: ");
            int.TryParse(Console.ReadLine(), out int HorasTrabajadas);
            Console.WriteLine("Ingrese la tarifa por hora: ");
            int.TryParse(Console.ReadLine(), out int TarifaPorHora);

            if(TarifaPorHora<=0 || HorasTrabajadas<=0 )
            {
                Console.WriteLine("Los valores ingresados no son validos");
                return;
            }

            decimal resultado = CalculoHorasPagadas.PagoTotal(HorasTrabajadas,TarifaPorHora);
            Console.WriteLine($"El Pago Total es de: {resultado}");

        }
        static void Ejercicio9()
        {
            Console.WriteLine("Ingrese el Lado #1");
            decimal.TryParse(Console.ReadLine(), out decimal Lado1);
            Console.WriteLine("Ingrese el Lado #2");
            decimal.TryParse(Console.ReadLine(), out decimal Lado2);
            Console.WriteLine("Ingrese el Lado #3");
            decimal.TryParse(Console.ReadLine(), out decimal Lado3);

            if(Lado1<=0 || Lado2<=0 || Lado3<=0)
            {
                Console.WriteLine("Los valores ingresados no son validos");
                return;
            }
            string Resultado = DeterminarTipoTriangulo.DeterminarPorLados(Lado1,Lado2,Lado3);
            
            Console.WriteLine($"El tipo de triangulo por sus lados y por sus angulos es: {Resultado}");

        }
        static void Ejercicio10()
        {
            Console.WriteLine("Ingrese su nota de 0 a 100: ");
            int.TryParse(Console.ReadLine(), out int Nota);
            if(Nota<0 || Nota >100)
            {
                Console.WriteLine("Los valores ingresados no son validos");
                return;
            }
            AnalizarNota analizarNota = new AnalizarNota(Nota);
        }
        static void Ejercicio11()
        {
            Console.WriteLine("Ingrese el monto de compra: ");
            decimal.TryParse(Console.ReadLine(), out decimal MontoAPagar);
            Console.Clear();
            DeterminarDescuentos determinarDescuentos = new DeterminarDescuentos(MontoAPagar);

        }
        static void Ejercicio12()
        {
            Console.WriteLine("Ingrese el año: ");
            int.TryParse(Console.ReadLine(), out int Anio);
            Console.WriteLine("Ingrese el mes: ");
            int.TryParse(Console.ReadLine(), out int Mes);

            DiasDelMes.CalcularDias(Anio,Mes);

        }
        static void Ejercicio13()
        {
            Console.WriteLine("Ingrese");
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



