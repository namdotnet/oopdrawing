using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramFramework
{
    public abstract class ViewPort
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Clear(Color color);
        public abstract void FillPolygon(Point[] points, Color color);
        public abstract void DrawPolygon(Point[] points, Color color);
        public abstract void FillRectangle(int x, int y, int width, int height, Color color);
        public abstract void DrawRectangle(int x, int y, int width, int height, Color color);
        public abstract void DrawText(Point point, string text, Color color); 
    }
}
