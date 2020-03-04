using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             

        }

       class Convertir
        {
           public string []tipo = {"Moneda", "Almacenamiento" };

            public string [] [] etiquetas =
            {
            new string [] = { "Dólares", "Colones", "Yenes", "Rupia", "Peso (Chileno)", "Peso(Mexicano)", "Peso (Argentino)"},
            new string [] = { "Megabyte", "Bit", "Byte", "kilobyte", "Gigabyte", "terabyte" },

            };

            public double[][] valores =
            {
                new double [] = {1, 8.75, 111.27, 69.75, 667.08, 19.36, 39.69, 0.00026 },
                new double [] = {1, 8,388,608,  1,048,576, 1,024, 0.0009765625, 0.00000095367431660625 }
            };

          

    }
}