using System;

namespace Convertidor.Colores
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //string colorcode = "#FF0000FF";
            string colorcode = "#FF330066";

            Console.WriteLine("Valor Hexadecimal es:" + colorcode + "\n");

            Colores color = new Colores();
            color.ToArgb(colorcode);

            Console.Read();
        }
    }
}