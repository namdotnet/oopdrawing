using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramFramework
{
    public class Color
    {
        public int A { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }

        public Color(int argb)
        {
            this.A = (argb >> 24) & 0xFF;
            this.R = (argb >> 16) & 0xFF;
            this.G = (argb >> 8) & 0xFF;
            this.B = (argb) & 0xFF;
        }

        public Color(int r, int g, int b)
        {
            this.A = 0xFF;
            this.R = r;
            this.G = g;
            this.B = b;
        }
    }
}
