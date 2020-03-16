using System;
using System.Collections.Generic;
using System.Text;

namespace RayTracerChallenge.Lib
{
    public class Canvas
    {
        private readonly Color[] pixels;

        public Canvas(int width, int height)
        {
            Width = width;
            Height = height;

            pixels = new Color[Height * Width];
            for(var i = 0; i < pixels.Length; i++)
            {
                pixels[i] = new Color(0.0, 0.0, 0.0);
            }
        }

        public int Height { get; }
        public int Width { get; }
        public IEnumerable<Color> Pixels => pixels;

        public void WritePixel(int x, int y, Color color)
        {
            int index = (y * Width) + x;
            pixels[index] = color;
        }

        public Color PixelAt(int x, int y)
        {
            int index = (y * Width) + x;
            return pixels[index];
        }

        public string ToPpm()
        {
            var scale = 255;
            var documentBuilder = new StringBuilder();
            documentBuilder.AppendLine("P3");
            documentBuilder.AppendLine($"{Width} {Height}");
            documentBuilder.AppendLine($"{scale}");

            var count = 0;
            var lineBuilder = new StringBuilder();
            foreach(var pixel in pixels)
            {
                var red = Math.Round(Math.Max(Math.Min(pixel.R * scale, scale), 0));
                var green = Math.Round(Math.Max(Math.Min(pixel.G * scale, scale), 0));
                var blue = Math.Round(Math.Max(Math.Min(pixel.B * scale, scale), 0));

                lineBuilder.Append($"{red} {green} {blue} ");

                if (count == Width - 1)
                {
                    count = 0;
                    documentBuilder.AppendLine(lineBuilder.ToString().TrimEnd(' '));
                    lineBuilder.Clear();
                }
                else
                {
                    count++;
                }
            }

            return documentBuilder.ToString();
        }
    }
}