using System;
using System.Globalization;
using System.Windows.Media;

namespace Convertidor.Colores
{
    public class Colores
    {
        /// <summary>
        ///
        /// </summary>
        public void ToArgb(string colorcode)
        {
            int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.AllowHexSpecifier);

            Console.Write("El valor en ARGB es: {0} \n", argb);

            FromArgb(argb);
            IntToColor(argb);
            IntToColor2();
            IntToColor3("Brown");
        }

        /// <summary>
        ///
        /// </summary>
        public void FromArgb(int argb)
        {
            System.Drawing.Color clr = System.Drawing.Color.FromArgb(argb);

            Console.Write("El valor de ARGB a System.Drawing.Color es: {0} \n", clr.ToString());
        }

        /// <summary>
        ///
        /// </summary>
        private void IntToColor(int argb)
        {
            System.Drawing.Color x = System.Drawing.Color.FromArgb(argb);

            var solid = new SolidColorBrush(Color.FromArgb(x.A, x.R, x.G, x.B));

            Console.Write("El valor de ARGB a SolidColorBrush es: {0} \n", solid.ToString());
        }

        private void IntToColor2()
        {
            var tt = (SolidColorBrush)new BrushConverter().ConvertFromString("Brown");

            Console.Write("\n **************** \n\n");
            Console.Write("El valor de Café a SolidColorBrush es: {0} \n", tt.ToString());
        }

        private void IntToColor3(string color)
        {
            var converter = new BrushConverter();
            var brush = (Brush)converter.ConvertFromString(color);

            Console.Write("El valor en Brush es: {0}", brush.ToString());
        }
    }
}