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
            // Ejercicio12();
            // Ejercicio13();
            // Ejercicio14();
            // Ejercicio15();
            // Ejercicio16();
            // Ejercicio17();
            // Ejercicio18();
            Ejercicio19();
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
            Console.WriteLine("Ingrese el año: ");
            int.TryParse(Console.ReadLine(), out int Anio);
            Console.WriteLine("Ingrese el mes: ");
            int.TryParse(Console.ReadLine(), out int Mes);
            Console.WriteLine("Ingrese el dia: ");
            int.TryParse(Console.ReadLine(), out int Dia);

            ValidarFecha.VerificarFechaReal(Dia,Mes,Anio);
            
        }
        static void Ejercicio14()
        {
            Console.WriteLine("Ingrese el monto a retirar: ");
            int.TryParse(Console.ReadLine(), out int MontoARetirar);
            if(MontoARetirar <= 0)
            {
                Console.WriteLine("Los valores ingresados no son validos");
                return;
            }
            Console.Clear();
            CajeroAutomatico.GestionRetiros(MontoARetirar);

        }
        static void Ejercicio15()
        {
            Console.WriteLine("Ingrese el numero del que quiere ver las tablas: ");
            int.TryParse(Console.ReadLine(), out int tabla);
            int i;
            int resultado; 
            for(i=0; i <=12 ; i++)
            {
                resultado = i * tabla;
                Console.WriteLine($"El resultado de {tabla} x {i} = {resultado}");
            }
        }
        static void Ejercicio16()
        {
            Console.WriteLine("Ingrese el numero en el que se va a iniciar: ");
            int.TryParse(Console.ReadLine(), out int NumeroInicio);
            Console.WriteLine("Ingrese el numero en el que se va a finalizar: ");
            int.TryParse(Console.ReadLine(), out int NumeroFinal);

            CalcularNumerosPrimos calcularNumerosPrimos = new CalcularNumerosPrimos (NumeroInicio,NumeroFinal);
        }
        static void Ejercicio17()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que desea ver: ");
            int.TryParse(Console.ReadLine(), out int CantidadNumeros);
            if(CantidadNumeros <0)
            {
                Console.WriteLine("Los valores ingresados no son validos");
                return;
            }
            SerieDeFibonacci serieDeFibonacci = new SerieDeFibonacci(CantidadNumeros);
        }
        static void Ejercicio18()
        {   
            int n18 = 0;
            int r18 = 0;
            bool nValido = false;
            bool rValido = false;

            do
            {
                Console.Write("Ingrese el valor de n (Total de elementos): ");
                nValido = int.TryParse(Console.ReadLine(), out n18);
                
                if (!nValido || n18 < 0)
                {
                    Console.WriteLine("Error: Debe ingresar un número entero positivo para 'n'.\n");
                    nValido = false; 
                }
            } while (!nValido);

            do
            {
                Console.Write("Ingrese el valor de r (Elementos por grupo): ");
                rValido = int.TryParse(Console.ReadLine(), out r18);
                
                if (!rValido || r18 < 0)
                {
                    Console.WriteLine("Error: Debe ingresar un número entero positivo para 'r'.\n");
                    rValido = false;
                }
                else if (n18 < r18)
                {
                    Console.WriteLine($"Error: 'r' no puede ser mayor que 'n' ({n18}). Intente de nuevo.\n");
                    rValido = false; 
                }
            } while (!rValido);

            Combinatoria.CalcularCombinacion(n18, r18);
        }
        static void Ejercicio19()
        {
            JuegoAdivinanza.Adivinanzas();
        }
        static void Ejercicio20()
        {
            string contrasenia = "";
            bool cumpleRequisitos = false;

            do
            {
                Console.Write("Ingrese una contraseña a evaluar: ");
                contrasenia = Console.ReadLine() ?? "";

               
                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                
                foreach (char c in contrasenia)
                {
                    if (char.IsUpper(c)) tieneMayuscula = true;
                    else if (char.IsLower(c)) tieneMinuscula = true;
                    else if (char.IsDigit(c)) tieneNumero = true;
                    else if (!char.IsLetterOrDigit(c)) tieneEspecial = true; 
                }

                Console.ForegroundColor = ConsoleColor.Red;
                
                if (contrasenia.Length < 8) Console.WriteLine(" -> Falta: Mínimo 8 caracteres.");
                if (!tieneMayuscula) Console.WriteLine(" -> Falta: Al menos una letra MAYÚSCULA.");
                if (!tieneMinuscula) Console.WriteLine(" -> Falta: Al menos una letra minúscula.");
                if (!tieneNumero) Console.WriteLine(" -> Falta: Al menos un número.");
                if (!tieneEspecial) Console.WriteLine(" -> Falta: Al menos un carácter especial (ej: @, #, $, *).");
                Console.ResetColor();

                cumpleRequisitos = contrasenia.Length >= 8 && tieneMayuscula && tieneMinuscula && tieneNumero && tieneEspecial;

                if (!cumpleRequisitos)
                {
                    Console.WriteLine("Contraseña insegura. Intente de nuevo.\n");
                }

            } while (!cumpleRequisitos);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n¡Éxito! La contraseña cumple con todos los estándares de seguridad.");
        }
        static void Ejercicio21()
        {
            Console.WriteLine("1. Triángulo\n2. Triángulo Invertido\n3. Rombo\n4. Cuadrado Hueco\n5. Salir");
            Console.Write("Elija un patrón: ");
            int.TryParse(Console.ReadLine(), out int opcion);
            if (opcion < 1 || opcion > 4) return;

            Console.Write("Defina el tamaño del patrón (Filas/Líneas): ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 0) return;

            Console.Clear();
            switch (opcion)
            {
                case 1: // Triángulo normal
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine(new string('*', i));
                    }
                    break;

                case 2: // Triángulo invertido
                    for (int i = n; i >= 1; i--)
                    {
                        Console.WriteLine(new string('*', i));
                    }
                    break;

                case 3: // Rombo
                    if (n % 2 == 0) n++; 
                    // Parte superior
                    for (int i = 1; i <= n; i += 2)
                    {
                        Console.Write(new string(' ', (n - i) / 2));
                        Console.WriteLine(new string('*', i));
                    }
                    // Parte inferior
                    for (int i = n - 2; i >= 1; i -= 2)
                    {
                        Console.Write(new string(' ', (n - i) / 2));
                        Console.WriteLine(new string('*', i));
                    }
                    break;

                case 4: // Cuadrado Hueco
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            if (i == 1 || i == n || j == 1 || j == n)
                                Console.Write("* ");
                            else
                                Console.Write("  ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
        }
        static void Ejercicio22()
        {
            double ultimoResultado = 0;
            bool primerCalculo = true;
            int op = 0;

            do
            {
                Console.WriteLine($"\n[ Último Resultado Guardado: {ultimoResultado} ]");
                Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Potencia\n6. Raíz Cuadrada\n7. Porcentaje\n8. Limpiar (CE)\n0. Salir");
                Console.Write("Seleccione operación: ");
                int.TryParse(Console.ReadLine(), out op);

                if (op == 0) break;
                if (op == 8) { ultimoResultado = 0; primerCalculo = true; Console.Clear(); continue; }

                double num1 = ultimoResultado;
                
                if (primerCalculo && op != 6) 
                {
                    Console.Write("Ingrese el primer número: ");
                    double.TryParse(Console.ReadLine(), out num1);
                    primerCalculo = false;
                }

                double num2 = 0;
                
                if (op == 1 || op == 2 || op == 3 || op == 4 || op == 5 || op == 7)
                {
                    Console.Write(op == 5 ? "Ingrese el exponente: " : op == 7 ? "Ingrese el porcentaje (0-100): " : "Ingrese el siguiente número: ");
                    double.TryParse(Console.ReadLine(), out num2);
                }

                switch (op)
                {
                    case 1: ultimoResultado = num1 + num2; break;
                    case 2: ultimoResultado = num1 - num2; break;
                    case 3: ultimoResultado = num1 * num2; break;
                    case 4:
                        if (num2 == 0) Console.WriteLine("Error: No se puede dividir entre cero.");
                        else ultimoResultado = num1 / num2;
                        break;
                    case 5: ultimoResultado = Math.Pow(num1, num2); break;
                    case 6:
                        if (num1 < 0) Console.WriteLine("Error: Raíz imaginaria.");
                        else { ultimoResultado = Math.Sqrt(num1); primerCalculo = false; }
                        break;
                    case 7: ultimoResultado = num1 * (num2 / 100); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }

                Console.WriteLine($"=> Resultado de la operación: {ultimoResultado}");

            } while (op != 0);
        }
        static void Ejercicio23()
        {
            Console.Write("¿Cuántas calificaciones desea ingresar?: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 0) return;

            double[] notas = new double[n];
            double suma = 0;
            int aprobados = 0, reprobados = 0;

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write($"Nota del estudiante #{i + 1} (0-100): ");
                    double.TryParse(Console.ReadLine(), out notas[i]);
                } while (notas[i] < 0 || notas[i] > 100);

                suma += notas[i];
                if (notas[i] >= 65) aprobados++; 
                else reprobados++;
            }

            double promedio = suma / n;
            double notaMaxima = notas.Max();
            double notaMinima = notas.Min();

            
            double sumaVarianza = 0;
            foreach (double nota in notas)
            {
                sumaVarianza += Math.Pow(nota - promedio, 2);
            }
            double desviacionEstandar = Math.Sqrt(sumaVarianza / n);

            Console.WriteLine("\n--- ESTADÍSTICAS FINALES ---");
            Console.WriteLine($"Promedio General: {promedio:N2}%");
            Console.WriteLine($"Calificación Máxima: {notaMaxima}%");
            Console.WriteLine($"Calificación Mínima: {notaMinima}%");
            Console.WriteLine($"Cantidad Aprobados: {aprobados}");
            Console.WriteLine($"Cantidad Reprobados: {reprobados}");
            Console.WriteLine($"Desviación Estándar: {desviacionEstandar:N4}");
        }

        static void Ejercicio24()
        {
            int[] arreglo = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese entero para posición [{i}]: ");
                int.TryParse(Console.ReadLine(), out arreglo[i]);
            }

           
            Console.Write("\nElementos en posiciones pares del índice: ");
            for (int i = 0; i < 10; i += 2)
            {
                Console.Write($"[{i}]:{arreglo[i]}  ");
            }
            Console.WriteLine();

            
            int[] copiaBurbuja = (int[])arreglo.Clone();
            
            for (int i = 0; i < copiaBurbuja.Length - 1; i++)
            {
                for (int j = 0; j < copiaBurbuja.Length - 1 - i; j++)
                {
                    if (copiaBurbuja[j] > copiaBurbuja[j + 1])
                    {
                        int temp = copiaBurbuja[j];
                        copiaBurbuja[j] = copiaBurbuja[j + 1];
                        copiaBurbuja[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"Arreglo ordenado ascendentemente (Burbuja): {string.Join(", ", copiaBurbuja)}");
            
            int segundoMayor = copiaBurbuja[copiaBurbuja.Length - 2];
            Console.WriteLine($"Segundo elemento mayor detectado: {segundoMayor}");

            
            Console.Write("\nIngrese un número a buscar en el arreglo original: ");
            int.TryParse(Console.ReadLine(), out int buscar);
            bool encontrado = false;
            for (int i = 0; i < 10; i++)
            {
                if (arreglo[i] == buscar)
                {
                    Console.WriteLine($"¡Encontrado! El número {buscar} está en el índice original [{i}].");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado) Console.WriteLine("El número no se encuentra en el arreglo.");
        }

        static void Ejercicio25()
        {
            Console.Write("Ingrese el tamaño N del arreglo: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 0) return;

            int[] arreglo = new int[n];
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = i + 1; 
            }

            Console.WriteLine($"Arreglo base generado: {string.Join(", ", arreglo)}");
            Console.WriteLine("\n1. Rotar K posiciones a la izquierda\n2. Rotar K posiciones a la derecha\n3. Invertir el arreglo");
            Console.Write("Seleccione una opción: ");
            int.TryParse(Console.ReadLine(), out int opcion);

            if (opcion == 3)
            {
                Array.Reverse(arreglo);
                Console.WriteLine($"Arreglo invertido: {string.Join(", ", arreglo)}");
                return;
            }

            Console.Write("Ingrese la cantidad K de posiciones a rotar: ");
            int.TryParse(Console.ReadLine(), out int k);
            k = k % n;

            int[] resultado = new int[n];

            if (opcion == 1) 
            {
                for (int i = 0; i < n; i++)
                {
                    resultado[i] = arreglo[(i + k) % n];
                }
            }
            else if (opcion == 2) 
            {
                for (int i = 0; i < n; i++)
                {
                    resultado[(i + k) % n] = arreglo[i];
                }
            }

            Console.WriteLine($"Arreglo resultante tras rotación: {string.Join(", ", resultado)}");
        }

        static void Ejercicio26()
        {
            Random rnd = new Random();
            int[] aleatorios = new int[20];
            int[] frecuencias = new int[11]; 

            Console.Write("Números generados al azar: ");
            for (int i = 0; i < 20; i++)
            {
                aleatorios[i] = rnd.Next(1, 11);
                Console.Write(aleatorios[i] + " ");
                frecuencias[aleatorios[i]]++; 
            }
            Console.WriteLine("\n");

            int maxFrecuencia = -1, minFrecuencia = 99;
            int masFrecuente = 0, menosFrecuente = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Frecuencia del número {i}: {frecuencias[i]} veces.");
                
               
                if (frecuencias[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencias[i];
                    masFrecuente = i;
                }
                
                if (frecuencias[i] < minFrecuencia && frecuencias[i] > 0)
                {
                    minFrecuencia = frecuencias[i];
                    menosFrecuente = i;
                }
            }

            Console.WriteLine($"\nEl número MÁS frecuente es el: {masFrecuente} ({maxFrecuencia} veces).");
            Console.WriteLine($"El número MENOS frecuente es el: {menosFrecuente} ({minFrecuencia} veces).");
        }

        static void Ejercicio27()
        {
            double[] temp = new double[7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            double suma = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese temperatura para el {dias[i]} (°C): ");
                double.TryParse(Console.ReadLine(), out temp[i]);
                suma += temp[i];
            }

            double promedioSemanal = suma / 7;
            double maxTemp = temp.Max();
            double minTemp = temp.Min();
            string diaCaluroso = dias[Array.IndexOf(temp, maxTemp)];
            string diaFrio = dias[Array.IndexOf(temp, minTemp)];

            Console.WriteLine("\n--- REPORTE CLIMÁTICO SEMANAL ---");
            Console.WriteLine($"Promedio Semanal: {promedioSemanal:N2}°C");
            Console.WriteLine($"Días que superaron el promedio:");
            for (int i = 0; i < 7; i++)
            {
                if (temp[i] > promedioSemanal) Console.WriteLine($" -> {dias[i]} ({temp[i]}°C)");
            }

            Console.WriteLine($"Día más caluroso: {diaCaluroso} ({maxTemp}°C)");
            Console.WriteLine($"Día más frío: {diaFrio} ({minTemp}°C)");

            Console.WriteLine("\nVariación entre días consecutivos:");
            for (int i = 0; i < 6; i++)
            {
                double variacion = temp[i + 1] - temp[i];
                Console.WriteLine($" -> De {dias[i]} a {dias[i + 1]}: {variacion:+0.0;-0.0;0.0}°C");
            }
        }

        static void Ejercicio28()
        {
            Console.Write("Cantidad de estudiantes N a evaluar: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n <= 0) return;

            double[,] matrizNotas = new double[n, 3];
            double[] promedioEstudiantes = new double[n];
            double[] sumaParciales = new double[3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNotas del Estudiante #{i + 1}:");
                double sumaEstudiante = 0;
                for (int j = 0; j < 3; j++)
                {
                    do
                    {
                        Console.Write($"  -> Parcial {j + 1} (0-100): ");
                        double.TryParse(Console.ReadLine(), out matrizNotas[i, j]);
                    } while (matrizNotas[i, j] < 0 || matrizNotas[i, j] > 100);

                    sumaEstudiante += matrizNotas[i, j];
                    sumaParciales[j] += matrizNotas[i, j];
                }
                promedioEstudiantes[i] = sumaEstudiante / 3;
            }

            Console.Clear();
            Console.WriteLine("--- RESUMEN GENERAL DE RENDIMIENTO ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Estudiante #{i + 1} - Promedio: {promedioEstudiantes[i]:N2}%");
            }

            Console.WriteLine("\nPromedios globales por Parcial:");
            for (int j = 0; j < 3; j++)
            {
                double promParcial = sumaParciales[j] / n;
                Console.WriteLine($" -> Parcial {j + 1}: {promParcial:N2}%");
            }

            int mejorEstudianteIndex = Array.IndexOf(promedioEstudiantes, promedioEstudiantes.Max());
            Console.WriteLine($"\nEstudiante con mejor rendimiento: Estudiante #{mejorEstudianteIndex + 1} ({promedioEstudiantes.Max():N2}%)");

          
            double peorPromedioParcial = sumaParciales.Min() / n;
            int parcialDificilIndex = Array.IndexOf(sumaParciales, sumaParciales.Min());
            Console.WriteLine($"El parcial más difícil fue el: Parcial {parcialDificilIndex + 1} (Promedio más bajo: {peorPromedioParcial:N2}%)");
        }

        static void Ejercicio29()
        {
            char[,] tablero = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            int jugadorActual = 1;
            int movimientos = 0;
            bool juegoTerminado = false;

            do
            {
                Console.Clear();
                Console.WriteLine("=== TIC-TAC-TOE ===");
                Console.WriteLine($" Jugador 1 [X]  -  Jugador 2 [O]\n");
                Console.WriteLine($"     {tablero[0, 0]} | {tablero[0, 1]} | {tablero[0, 2]} ");
                Console.WriteLine("    ---|---|---");
                Console.WriteLine($"     {tablero[1, 0]} | {tablero[1, 1]} | {tablero[1, 2]} ");
                Console.WriteLine("    ---|---|---");
                Console.WriteLine($"     {tablero[2, 0]} | {tablero[2, 1]} | {tablero[2, 2]} \n");

                char marca = (jugadorActual == 1) ? 'X' : 'O';
                Console.Write($"Jugador {jugadorActual} ({marca}), elija una casilla disponible: ");
                int.TryParse(Console.ReadLine(), out int seleccion);

                
                bool movimientoValido = false;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tablero[i, j] == seleccion.ToString()[0])
                        {
                            tablero[i, j] = marca;
                            movimientoValido = true;
                            movimientos++;
                        }
                    }
                }

                if (!movimientoValido)
                {
                    Console.WriteLine("Casilla ocupada o inválida. Presione cualquier tecla...");
                    Console.ReadKey();
                    continue;
                }

                
                bool ganador = false;
                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2]) ganador = true; // Filas
                    if (tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i]) ganador = true; // Columnas
                }
                if (tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2]) ganador = true; // Diagonal Principal
                if (tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0]) ganador = true; // Diagonal Secundaria

                if (ganador)
                {
                    Console.Clear();
                    Console.WriteLine($"\n¡FELICIDADES! El Jugador {jugadorActual} ({marca}) ha ganado la partida.");
                    juegoTerminado = true;
                }
                else if (movimientos == 9)
                {
                    Console.Clear();
                    Console.WriteLine("\n¡Empate! Se han llenado todas las casillas.");
                    juegoTerminado = true;
                }
                else
                {
                    
                    jugadorActual = (jugadorActual == 1) ? 2 : 1;
                }

            } while (!juegoTerminado);
        }

        static void Ejercicio30()
        {           
            string[] nombres = { "Arroz (lb)", "Frijoles (lb)", "Azúcar (lb)", "Café (paquete)", "Harina (lb)" };
            int[] codigos = { 101, 102, 103, 104, 105 };
            int[] cantidades = { 50, 40, 30, 25, 60 };
            double[] precios = { 15.50, 22.00, 13.00, 45.00, 11.50 };

            int opcionMenu = 0;
            do
            {
                Console.WriteLine("\n=== SISTEMA DE INVENTARIO (5 PRODUCTOS) ===");
                Console.WriteLine("1. Mostrar Todo el Inventario\n2. Buscar Producto por Código\n3. Actualizar Stock/Cantidad\n4. Calcular Valor Total Financiero\n0. Volver al Menú Principal");
                Console.Write("Seleccione una opción: ");
                int.TryParse(Console.ReadLine(), out opcionMenu);

                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("CÓDIGO\t| NOMBRE\t\t| STOCK\t| PRECIO UNITARIO");
                        Console.WriteLine("---------------------------------------------------------");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"{codigos[i]}\t| {nombres[i].PadRight(15)}\t| {cantidades[i]}\t| L. {precios[i]:N2}");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el código del producto a buscar (101-105): ");
                        int.TryParse(Console.ReadLine(), out int buscarCod);
                        int idx = Array.IndexOf(codigos, buscarCod);
                        if (idx != -1)
                        {
                            Console.WriteLine($"\n[Producto Encontrado]: {nombres[idx]} | Stock: {cantidades[idx]} unidades | Precio: L. {precios[idx]:N2}");
                        }
                        else Console.WriteLine("Código no registrado.");
                        break;

                    case 3:
                        Console.Write("Ingrese código del producto a actualizar (101-105): ");
                        int.TryParse(Console.ReadLine(), out int modCod);
                        int modIdx = Array.IndexOf(codigos, modCod);
                        if (modIdx != -1)
                        {
                            Console.Write($"Cantidad actual de {nombres[modIdx]} es {cantidades[modIdx]}. Ingrese nuevo stock total: ");
                            int.TryParse(Console.ReadLine(), out cantidades[modIdx]);
                            Console.WriteLine("¡Stock actualizado con éxito!");
                        }
                        else Console.WriteLine("Código no registrado.");
                        break;

                    case 4:
                        Console.Clear();
                        double valorTotalGeneral = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            double valorProducto = cantidades[i] * precios[i];
                            valorTotalGeneral += valorProducto;
                            Console.WriteLine($" -> {nombres[i].PadRight(15)}: L. {valorProducto:N2}");
                        }

                        Console.WriteLine($"VALOR MONETARIO TOTAL DEL INVENTARIO: L. {valorTotalGeneral:N2}");
                        break;
                }

            } while (opcionMenu != 0);
        }
    }
}


