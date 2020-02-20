using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones
{
    class Conversores
    {
        public string[] Tipo = { "Monedas", "Longitud", "Peso", "Volumen", "Almacenamiento" };

        public string[][] Etiquetas =
        {
             new string [] { "Dolar($)", "Colones(SV)", "Yenes(¥)", "Rupias(₹)", "Lempiras(L)", "Peso MX($)", "BitCoin(฿)", "Quetzal(Q)", "Euro(€)", "Cordoba(C$)", "Balboa(B)", "Peso Argentino($)", "Peso Chileno", "Peso Colombiano($)", "Soles(Peru)(S/.)", "Dolar Canadiense(C$)", "Dolar Beliceño(BZ$)", "Inglaterra-Libra(£)", "Egipto-Lbra(ج.م)", "Dinamarca-Corona(kr)"},         
             new string [] {"Metro(m)","Decimetro(dm)","Centimetro(cm)","Milimetro(mm)", "Micrometro(µm)", "Nanometro(nm)", "Milla","Yarda","Pie","Pulgada","Milla nautica", "Kilometro(km)", "Hectometro(hm)", "decametro(dam)", "Megametro(Mm)", "gigametro(Gm)", "Terametro(Tm)", "Petametro(Pm)", "Exametro(Em)", "Zettametro(Zm)" },
             new string []{"Gramo(g)","Kilogramo(kg)","Miligramo(mg)", "Microgramo(µg)", "Tonelada Larga(t)","Tonelada Corta(t)","Stone(st)","Libra(lb)","Onza(oz)","Tonelada(t)","Arroba(a)","Quintal(q)","Quilate(kt)","Decigramo(dg)","Decagramo(dg)","Nanogramo(ng)","Hecto gramo(hg)","Masa de la Tierra","Masa del Sol" },
             new string []{"Litro","Galon Estadounidense","Cuarto Estadounidense","Pinta Estadouidense","Taza Americana Oficial","Onza Liquida Estadouunidense","Cucharada Estadounidense","Cucharadita Estadounidense","Metro Cubico","Mililitro","Galon Imperial","Cuarto Ìmperial","Pinta Imperial","Taza Imperial","Onza Liquida Imperial","Cucharada Imperial","Cucharadita Imperial","Pie Cubico","Pulgada Cubica" },
             new string []{"Megabyte","bit","Kilobit","Kibibit","Megabit","Mebibit","Gigabit","Gibibit","Terabit","Tebibit","Petabit","Pebibit","Byte","Kilobyte","Kibibyte","Megabyte","Mebibyte","Gigabyte","Gibibyte","Terabyte","Tebibyte",}
        };
        double[][] valores =
       {
             new double[] { 1, 8.75, 111.26, 69.75, 24.36, 19.36, 0.00026, 7.69, 0.88,32.95,1.00,39.95, 667.65, 3126.73,3.30, 1.33, 2.02, 0.76772, 15.6251, 6.89216},
             new double [] {1, 10,100,1000,1e+6,1e+9,0.000621371,1.09361,3.28084,39.3701,0.000539957,0.001,0.01,0.1,1e-6,1e-9,1e-12, 1e-15, 1e-18, 1e-21 },
             new double [] {1,0.001,1000,1000000, 9.84207e-7, -3.00363794048959, 0.000157473, 0.00220462, 0.035274, -3.28171817154095, 11339000, 0.00002042900919305,5, 10 ,0.1 , 1000000000 , 0.01, 1.673360107095e-28, -20.4085908577048 },
             new double [] {1, 0.264172, 1.05669, 2.11338, 4.16667, 33.814, 67.628, 202.884 , 0.001, 1000, 0.219969, 0.879877, 1.75975, 3.51951, 3.51951, 56.3121, 168.936, 0.0353147, 61.0237 },
             new double []{1,8e+6, 8000 , 7812.5 , 8 , 7.62939, 0.008 , 0.00745058, 8e-6, 7.276e-6 , 8e-9 , 7.1054e-9, 1e+6, 1000 , 976.563, 0.953674 , 0.001 , 0.000931323, 1e-6, 9.0949e-7 }
        };
        public double convertir(int Tengo, int Quiero, double Cantidad, int opcion)
            {
            return Math.Round(valores[opcion][Quiero] / valores[opcion][Tengo] * Cantidad, 2);
        }
    }
            
}
