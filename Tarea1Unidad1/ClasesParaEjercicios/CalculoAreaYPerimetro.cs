namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class CalculoAreaYPerimetro
    {
        //rectangulo
        public static decimal AreaRectangulo(decimal Base, decimal Altura)
        {
            return Base * Altura;
        }
        public static decimal PerimetroRectangulo(decimal Base, decimal Altura)
        {
            return (2m*Base) + (2m*Altura);
        }
        //circulo
        public static decimal AreaCirculo(decimal radio)
        {
            return (decimal)Math.PI * radio * radio;
        }
        public static decimal PerimetroCirculo(decimal radio)
        {
            return 2m * (decimal)Math.PI*radio;
        }
        //triangulo
        public static decimal AreaTriangulo(decimal Base, decimal Altura)
        {
            return (Base * Altura)/2m;
        }
        public static decimal PerimetroTriangulo(decimal Lado1, decimal Lado2, decimal Lado3)
        {
            return Lado1 + Lado2 + Lado3;
        }
        //trapecio
        public static decimal AreaTrapecio(decimal Base1, decimal Base2, decimal Altura)
        {
            return ((Base1+Base2)*Altura)/2m;
        }
        public static decimal PerimetroTrapecio(decimal Lado1, decimal Lado2, decimal Lado3, decimal Lado4)
        {
            return Lado1 + Lado2 + Lado3 + Lado4;
        }
        //Pedir datos yy llamar a las funciones estaticas para que realicen los procedimientos segun las elecciones hechas
        public static decimal RegistroDeDatos(int eleccionCalculo, int eleccionForma)
        {
            if(eleccionCalculo ==1 && eleccionForma == 1)
            {
                Console.WriteLine("Ingrese el radio: ");
                decimal.TryParse(Console.ReadLine(), out decimal Radio);
                return AreaCirculo(Radio);
            }
            if(eleccionCalculo ==1 && eleccionForma == 2)
            {
                Console.WriteLine("Ingrese la base: ");
                decimal.TryParse(Console.ReadLine(), out decimal Base);
                Console.WriteLine("Ingrese la altura: ");
                decimal.TryParse(Console.ReadLine(), out decimal Altura);
                return AreaTriangulo(Base,Altura);
            }
            if (eleccionCalculo ==1 && eleccionForma == 3)
            {
                Console.WriteLine("Ingrese la base: ");
                decimal.TryParse(Console.ReadLine(), out decimal Base);
                Console.WriteLine("Ingrese la altura: ");
                decimal.TryParse(Console.ReadLine(), out decimal Altura);
                return AreaRectangulo(Base,Altura);
            }
            if (eleccionCalculo ==1 && eleccionForma == 4)
            {
                Console.WriteLine("Ingrese la base #1: ");
                decimal.TryParse(Console.ReadLine(), out decimal Base1);
                Console.WriteLine("Ingrese la base #2: ");
                decimal.TryParse(Console.ReadLine(), out decimal Base2);
                Console.WriteLine("Ingrese la altura: ");
                decimal.TryParse(Console.ReadLine(), out decimal Altura);
                return AreaTrapecio(Base1,Base2,Altura);
            }
            if (eleccionCalculo ==2 && eleccionForma == 1)
            {
                Console.WriteLine("Ingrese el radio: ");
                decimal.TryParse(Console.ReadLine(), out decimal Radio);
                return PerimetroCirculo(Radio);
            }
            if (eleccionCalculo ==2 && eleccionForma == 2)
            {
                Console.WriteLine("Ingrese el lado #1: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado1);
                Console.WriteLine("Ingrese el lado #2: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado2);
                Console.WriteLine("Ingrese el lado #3: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado3);
                return PerimetroTriangulo(lado1,lado2,lado3);
            }
            if (eleccionCalculo ==2 && eleccionForma == 3)
            {
                Console.WriteLine("Ingrese la base: ");
                decimal.TryParse(Console.ReadLine(), out decimal Base);
                Console.WriteLine("Ingrese la altura: ");
                decimal.TryParse(Console.ReadLine(), out decimal Altura);
                return PerimetroRectangulo(Base,Altura);
            }
            if (eleccionCalculo ==2 && eleccionForma == 4)
            {
                Console.WriteLine("Ingrese el lado #1: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado1);
                Console.WriteLine("Ingrese el lado #2: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado2);
                Console.WriteLine("Ingrese el lado #3: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado3);
                Console.WriteLine("Ingrese el lado #4: ");
                decimal.TryParse(Console.ReadLine(), out decimal lado4);
               return PerimetroTrapecio(lado1,lado2,lado3,lado4);
            }
            return 0m;
        }
    }
}