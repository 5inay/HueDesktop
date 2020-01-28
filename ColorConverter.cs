using System;
using System.Drawing;

namespace HueDesktop
{
    class ColorConverter
    {
        private static readonly PointF rGamutB = new PointF( 0.675f, 0.322f );
        private static readonly PointF gGamutB = new PointF( 0.409f, 0.518f );
        private static readonly PointF bGamutB = new PointF( 0.167f, 0.040f );
        private static readonly double RG = findLength(rGamutB, gGamutB);
        private static readonly double GB = findLength(gGamutB, bGamutB);
        private static readonly double BR = findLength(bGamutB, rGamutB);
        private static double areaOfGamutB = areaOfTriangle(RG, GB, BR);

        public static void colorToXY(double red, double green, double blue, out double X, out double Y)
        {
            //The following code excerpt is taken directly from Philips Hue Developer Guide page found here:
            //https://www.developers.meethue.com/documentation/color-conversions-rgb-xy (login may be required)
            red = (red > 0.04045) ? Math.Pow((red + 0.055) / (1.0 + 0.055), 2.4) : (red / 12.92);
            green = (green > 0.04045) ? Math.Pow((green + 0.055) / (1.0 + 0.055), 2.4) : (green / 12.92);
            blue = (blue > 0.04045) ? Math.Pow((blue + 0.055) / (1.0 + 0.055), 2.4) : (blue / 12.92);

            double EXX = red * 0.664511 + green * 0.154324 + blue * 0.162028;
            double WHY = red * 0.283881 + green * 0.668433 + blue * 0.047685;
            double ZEE = red * 0.000088 + green * 0.072310 + blue * 0.986039;

            X = EXX / (EXX + WHY + ZEE);
            Y = WHY / (EXX + WHY + ZEE); 
        }

        private static double areaOfTriangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        private static double findLength(PointF a, PointF b)
        {
            return (Math.Sqrt(Math.Pow((b.X - a.X), 2.0) + Math.Pow((b.Y - a.Y), 2.0)));
        }

        public static Byte[] xyBriToRgb(double x, double y, int bri)
        {
            var z = 1.0 - x - y;
            var Y = bri / 255.0; // Brightness of lamp
            var X = (Y / y) * x;
            var Z = (Y / y) * z;
            var r = X * 1.612 - Y * 0.203 - Z * 0.302;
            var g = -X * 0.509 + Y * 1.412 + Z * 0.066;
            var b = X * 0.026 - Y * 0.072 + Z * 0.962;
            r = r <= 0.0031308 ? 12.92 * r : (1.0 + 0.055) * Math.Pow(r, (1.0 / 2.4)) - 0.055;
            g = g <= 0.0031308 ? 12.92 * g : (1.0 + 0.055) * Math.Pow(g, (1.0 / 2.4)) - 0.055;
            b = b <= 0.0031308 ? 12.92 * b : (1.0 + 0.055) * Math.Pow(b, (1.0 / 2.4)) - 0.055;
            var maxValue = Math.Max(Math.Max(r, g), b);
            r /= maxValue;
            g /= maxValue;
            b /= maxValue;
            r = r * 255;
            if (r < 0)
            {
                r = 255;
            };
            g = g * 255;
            if (g < 0)
            {
                g = 255;
            }
            b = b * 255;
            if (b < 0)
            {
                b = 255;
            }

            Byte[] RGB = new byte[]
            {
                Convert.ToByte(Convert.ToInt32(r)),
                Convert.ToByte(Convert.ToInt32(g)),
                Convert.ToByte(Convert.ToInt32(b))
            };

            return RGB;
        }
    }
}
