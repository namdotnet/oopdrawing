using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramFramework
{
    public abstract class DiagramItem
    {
        public string Name { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public abstract void Paint(ViewPort viewport);
        public abstract bool IsInside(Point point);
    }
}
