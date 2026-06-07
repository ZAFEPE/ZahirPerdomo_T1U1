namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class ConvertirTemperatura
    {
        public static decimal CelciusAFahrenheit(decimal celcius)
        {
            return (celcius * 1.8m)+32m;
        }
        public static decimal CelciusAKelvin(decimal celcius)
        {
            return celcius + 273.15m;
        }
        public static decimal FahrenheitACelcius(decimal fahrenheit)
        {
            return (fahrenheit - 32m) / 1.8m;
        }
        public static decimal FahrenheitAKelvin(decimal fahrenheit)
        {
            return ((fahrenheit - 32m) / 1.8m) + 273.15m;
        }
        public static decimal KelvinACelcius(decimal kelvin)
        {
            return kelvin - 273.15m;
        }
        public static decimal KelvinAFahrenheit(decimal kelvin)
        {
            return ((kelvin - 273.15m) * 1.8m) + 32m;
        }
            
        public static decimal AdministrarConversiones (int Base, int Conversion, decimal ValorIngresado)
        {
            
            if(Base == 1 && Conversion == 2)
            {
                return CelciusAFahrenheit(ValorIngresado);
            }
            if(Base == 1 && Conversion == 3)
            {
                return CelciusAKelvin(ValorIngresado);
            }
            if(Base == 2 && Conversion == 1)
            {
                return FahrenheitACelcius(ValorIngresado);
            }
            if(Base == 2 && Conversion == 3)
            {
                return FahrenheitAKelvin(ValorIngresado);
            }
            if(Base == 3 && Conversion == 1)
            {
                return KelvinACelcius(ValorIngresado);
            }
            if(Base == 3 && Conversion == 2)
            {
                return KelvinAFahrenheit(ValorIngresado);
            }
            
            return ValorIngresado;
            
        }
    }
}
