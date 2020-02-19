using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor_mundial
{
    class Conversor
    {

        public string[] tipo = { "Monedas", "Longitud", "Peso", "Volumen", "Almacenamiento" };

        public string[][] Viñetas =
            {
            new string[] { "Dolar", "ColonesSV", "Yenes", "Rupias", "Lempiras", "Peso MX", "Bitcoin", "Quetzal", "Euro", "Cordoba", "Balboa", "Peso Argentino", "Peso Chileno", "Soles Peru", "Dolar Canadiense", "Dolar Baliceño","Rial","Peso Filipo","Franco Suizo","Boliviano","Corona Islandesa","Corona Noruega"},
            new string[] {"Metro","Cm","Pulgada","pie","Varas","Yardas","Km","Millas","Milimetro","MicroMetro","NanoMetro"},
            new string [] {"Kilogramo","Gramo","Miligramo","MicroGramo","Libra","Onza", "Tonelada", "Stone"},
            new string[] {"Litro", "MiliLitro", "Metro Cubico", "Galon", "Pie Cubico", "Taza Americana"},
            new string[] {"Megabyte","Kilobyte","Gigabyte","Terabyte","Pentabyte","Exabyte","Byte","Bit"}
             };
        double[][] valores = 
            { 
        new double[] { 1.00, 8.75, 111.26, 69.75, 24.36, 19.36, 0.00026, 7.69, 0.88, 32.95, 1.00, 39.95, 667.65, 3126.73, 3.30, 1.33,2.02,0.38,50.55,0.11,6.93,127.28},
        new double[] {1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371, 1000, 1e+6, 1e+9},
        new double[] {1, 1024, 9.77e-4, 9.54e-7, 9.31e-10, 9.09e-13, 8e+6, 1e+6},
        new double[] {1, 1000, 0.001, 0.264172, 0.0353147, 4.167 },
        new double[] {1, 100, 1e-4, 3.861e-5, 119.599, 1076.391, 155000.31, 0.01 }
            };
        public double Conver(int de, int a, double cantidad,int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad,2);
        }

    }
}

