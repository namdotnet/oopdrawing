using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramFramework
{
    public class TriangleDiagramItem : DiagramItem
    {
        private static Color BORDER_COLOR = new Color(0x50, 0, 0);
        private static Color HANDLE_COLOR = new Color(0, 0, 0);

        public override void Paint(ViewPort viewport)
        {
            Point[] vertexs = new Point[3];
            vertexs[0] = new Point(this.Left + (this.Width / 2), this.Top);
            vertexs[1] = new Point(this.Left, this.Top + this.Height);
            vertexs[2] = new Point(this.Left + this.Width, this.Top + this.Height);

            viewport.FillPolygon(vertexs, this.Color);
            viewport.DrawPolygon(vertexs, BORDER_COLOR);

            if (this.IsSelected)
            {
                viewport.FillRectangle(vertexs[0].X - 3, this.Top - 3, 6, 6, HANDLE_COLOR);
                viewport.FillRectangle(this.Left - 3, this.Top + this.Height - 3, 6, 6, HANDLE_COLOR);
                viewport.FillRectangle(this.Left + this.Width - 3, this.Top + this.Height - 3, 6, 6, HANDLE_COLOR);
            }
        }

        public override bool IsInside(Point point)
        {
            //need to be rewritten
            return point.X >= this.Left && point.X <= (this.Left + this.Width) && point.Y >= this.Top && point.Y <= (this.Top + this.Height);
        }
    }
}
