using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program4.Models
{
    internal class Color
    {
        private int Red { get; set; }
        private int Green { get; set; }
        private int Blue { get; set; }
        private int Alpha { get; set; }

        public Color (int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public int GetGrayscale()
        {
            return (int)((Red + Green + Blue) / 3);
        }
    }
}
