﻿using System.Collections.Generic;
using System.Drawing;

namespace GUI
{
    public static class ThemeColor
    {
        //la idea es tener los colores por modulo, por ejemplo, todos los que sean ≡0(4) van a ser colores a utilizar en la pestaña home

        public static List<string> ColorList = new List<string>() {
            "#78A0FF", // color para el primer boton (home)
            "#BD152D", // nuevo color para el segundo (settings)
            "#F5C0AE", // color para el tercero (notes)
            "#D0F5D8", // color para el cuarto (data)
            "#A678FF", // color para el quinto boton (home)
            "#BD4915", // nuevo color para el sexto (settings)
            "#5EBDA7", // color para el séptimo (notes)
            "#BD2B15", // nuevo color para el octavo (data)
            "#7977FF", // color para el noveno boton (home)
            "#D65F69", // color para el décimo (settings)
            "#B3FAE9", // color para el undécimo (notes)
            "#F9D5DA", // color para el duodécimo (data)
            "#78CBFF", // color para el decimotercero boton (home)
            "#BD6615", // nuevo color para el decimocuarto (settings)
            "#A6634C", // color para el decimoquinto (notes)
            "#63A671", // color para el decimosexto (data)
            "#D378FF", // color para el decimoséptimo boton (home)
            "#BD6254", // nuevo color para el decimoctavo (settings)
            "#477A6E", // color para el decimonoveno (notes)
            "#7A595E", // color para el vigésimo (data)
            "#CECDFF", // color para el vigesimoprimer boton (home)
            "#1D5751", // color para el vigesimosegundo (settings)
            "#521F0F", // color para el vigesimotercer (notes)
            "#1A5226", // color para el vigesimocuarto (data)
            "#78A0FF", // color para el vigesimoquinto boton (home)
            "#BD152D", // nuevo color para el vigesimosexto (settings)
            "#A6634C"  // color para el vigesimoséptimo (notes)
        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
