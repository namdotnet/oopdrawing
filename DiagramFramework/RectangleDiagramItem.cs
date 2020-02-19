using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramFramework
{
    public class RectangleDiagramItem : DiagramItem
    {
        private static Color BORDER_COLOR = new Color(0x50, 0, 0);
        private static Color HANDLE_COLOR = new Color(0, 0, 0);

        public override void Paint(ViewPort viewport)
        {
            viewport.FillRectangle(this.Left, this.Top, this.Width, this.Height, this.Color);
            viewport.DrawRectangle(this.Left, this.Top, this.Width, this.Height, BORDER_COLOR);

            if (this.IsSelected)
            {
                viewport.FillRectangle(this.Left - 3, this.Top - 3, 6, 6, HANDLE_COLOR);
                viewport.FillRectangle(this.Left + this.Width - 3, this.Top - 3, 6, 6, HANDLE_COLOR);
                viewport.FillRectangle(this.Left - 3, this.Top + this.Height - 3, 6, 6, HANDLE_COLOR);
                viewport.FillRectangle(this.Left + this.Width - 3, this.Top + this.Height - 3, 6, 6, HANDLE_COLOR);
            }
        }

        public override bool IsInside(Point point)
        {
            return point.X >= this.Left && point.X <= (this.Left + this.Width) && point.Y >= this.Top && point.Y <= (this.Top + this.Height);
        }
    }
}
