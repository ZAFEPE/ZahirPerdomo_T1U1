namespace Tarea1Unidad1.ClasesParaEjercicios
{
    public class CalculoConversionDatos
    {
        //Una seccion donde estan todas las conversiones y la otra donde se decide que conversion usar, se que se ha de poder optimizar
        //pero no conozco ninguna otra
        public static decimal BytesAKilobytes(decimal Base)
        {
            return Base/1024;
        }
        public static decimal BytesAMegabytes(decimal Base)
        {
            return Base/ (decimal)Math.Pow(1024,2);
        }
        public static decimal BytesAGigabytes(decimal Base)
        {
            return Base/(decimal)Math.Pow(1024,3);
        }
        public static decimal BytesATerabytes(decimal Base)
        {
            return Base/(decimal)Math.Pow(1024,4);
        }
        public static decimal KilobytesABytes(decimal Base)
        {
            return Base * 1024m;
        }
        public static decimal KilobytesAMegabytes(decimal Base)
        {
            return Base / (decimal)Math.Pow(1024, 1); 
        }
        public static decimal KilobytesAGigabytes(decimal Base)
        {
            return Base / (decimal)Math.Pow(1024, 2); 
        }
        public static decimal KilobytesATerabytes(decimal Base)
        {
            return Base / (decimal)Math.Pow(1024, 3); 
        }
        public static decimal MegabytesABytes(decimal Base)
        {
            return Base * (decimal)Math.Pow(1024, 2); 
        }
        public static decimal MegabytesAKilobytes(decimal Base)
        {
            return Base * 1024m;
        }
        public static decimal MegabytesAGigabytes(decimal Base)
        {
            return Base / (decimal)Math.Pow(1024, 1);
        }
        public static decimal MegabytesATerabytes(decimal Base)
        {
            return Base / (decimal)Math.Pow(1024, 2);
        }
        public static decimal GigabytesABytes(decimal Base)
        {
            return Base * (decimal)Math.Pow(1024, 3); 
        }
        public static decimal GigabytesAKilobytes(decimal Base)
        {
            return Base * (decimal)Math.Pow(1024, 2); 
        }
        public static decimal GigabytesAMegabytes(decimal Base)
        {
            return Base * 1024m;
        }
        public static decimal GigabytesATerabytes(decimal Base)
        {
            return Base / (decimal)Math.Pow(1024, 1); 
        }
        public static decimal TerabytesABytes(decimal Base)
        {
            return Base * (decimal)Math.Pow(1024, 4); 
        }
        public static decimal TerabytesAKilobytes(decimal Base)
        {
            return Base * (decimal)Math.Pow(1024, 3);
        }
        public static decimal TerabytesAMegabytes(decimal Base)
        {
            return Base * (decimal)Math.Pow(1024, 2); 
        }
        public static decimal TerabytesAGigabytes(decimal Base)
        {
            return Base * 1024m;
        }
        //Administrar registros
        public static decimal RegistroDeDatos(int eleccionBase, int eleccionConversion, decimal DatoIngresado)
        {
            if(eleccionBase ==1 && eleccionConversion == 2)
            {
                return BytesAKilobytes(DatoIngresado);
            }
            if(eleccionBase ==1 && eleccionConversion == 3)
            {
                return BytesAMegabytes(DatoIngresado);
            }
            if(eleccionBase ==1 && eleccionConversion == 4)
            {
                return BytesAGigabytes(DatoIngresado);
            }
            if(eleccionBase ==1 && eleccionConversion == 5)
            {
                return BytesATerabytes(DatoIngresado);
            }
            if(eleccionBase ==2 && eleccionConversion == 1)
            {
                return KilobytesABytes(DatoIngresado);
            }
            if(eleccionBase ==2 && eleccionConversion == 3)
            {
                return KilobytesAMegabytes(DatoIngresado);
            }
            if(eleccionBase ==2 && eleccionConversion == 4)
            {
                return KilobytesAGigabytes(DatoIngresado);
            }
            if(eleccionBase ==2 && eleccionConversion == 5)
            {
                return KilobytesATerabytes(DatoIngresado);
            }
            if(eleccionBase ==3 && eleccionConversion == 1)
            {
                return MegabytesABytes(DatoIngresado);
            }
            if(eleccionBase ==3 && eleccionConversion == 2)
            {
                return MegabytesAKilobytes(DatoIngresado);
            }
            if(eleccionBase ==3 && eleccionConversion == 4)
            {
                return MegabytesAGigabytes(DatoIngresado);
            }
            if(eleccionBase ==3 && eleccionConversion == 5)
            {
                return MegabytesATerabytes(DatoIngresado);
            }
            if(eleccionBase ==4 && eleccionConversion == 1)
            {
                return GigabytesABytes(DatoIngresado);
            }
            if(eleccionBase ==4 && eleccionConversion == 2)
            {
                return GigabytesAKilobytes(DatoIngresado);
            }
            if(eleccionBase ==4 && eleccionConversion == 3)
            {
                return GigabytesAMegabytes(DatoIngresado);
            }
            if(eleccionBase ==4 && eleccionConversion == 5)
            {
                return GigabytesATerabytes(DatoIngresado);
            }
            if(eleccionBase ==5 && eleccionConversion == 1)
            {
                return TerabytesABytes(DatoIngresado);
            }
            if(eleccionBase ==5 && eleccionConversion == 2)
            {
                return TerabytesAKilobytes(DatoIngresado);
            }
            if(eleccionBase ==5 && eleccionConversion == 3)
            {
                return TerabytesAMegabytes(DatoIngresado);
            }
            if(eleccionBase ==5 && eleccionConversion == 4)
            {
                return TerabytesAGigabytes(DatoIngresado);
            }

            return DatoIngresado;
        }
    }
}