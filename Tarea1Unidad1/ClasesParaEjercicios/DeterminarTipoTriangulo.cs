namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class DeterminarTipoTriangulo
    {
        public static string DeterminarPorLados(decimal lado1, decimal lado2, decimal lado3)
        {
            decimal a = lado1*lado1;
            decimal b = lado2*lado2;
            decimal c = lado3*lado3;

            if((lado1+lado2<=lado3) || (lado2+lado3<=lado1) || (lado1+lado3<=lado2))
            {
                Console.WriteLine("Las medidas ingresadas no son validas");
                return "Invalido";
            }

            string TipoPorLados = "";
            string TipoPorAngulos = "";

            if((lado1==lado2) && (lado2 ==lado3)) 
            {
                TipoPorLados = "Equilatero";
            }
            else if((lado1==lado2) || (lado2 ==lado3) || (lado3 == lado1)) 
            {
                TipoPorLados = "Isóceles";
            }
            else 
            {
                TipoPorLados = "Escaleno";
            }

            if(lado1>lado2 && lado1 > lado3)
            {
                c = lado1 * lado1;
            }
            else if(lado2>lado3 && lado2> lado1) 
            {
                c = lado2 * lado2;
            }
            else if(lado3>lado2 && lado3> lado1) 
            {
                c = lado3 * lado3;
            }


            if(c==(a + b))
            {
                TipoPorAngulos = "Rectangulo";
            }
            else if(c<(a + b))
            {
                TipoPorAngulos = "Acutangulo";
            }
            else if(c>(a + b))
            {
                TipoPorAngulos = "obtusangulo";
            }

            return (TipoPorLados + " Y " + TipoPorAngulos);
        }
        
    }
}