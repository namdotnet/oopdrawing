using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ObjectDiagram
{
    class FormViewPort : DiagramFramework.ViewPort
    {
        public Control _control;

        public FormViewPort(Control control)
        {
            this._control = control;
        }

        public override void FillPolygon(DiagramFramework.Point[] points, DiagramFramework.Color color)
        {
            Graphics g = _control.CreateGraphics();
            PointF[] ps = new PointF[points.Length];

            for (int i = 0; i < points.Length; i++)
                ps[i] = new PointF(points[i].X, points[i].Y);

            g.FillPolygon(new SolidBrush(Color.FromArgb(color.A, color.R, color.G, color.B)), ps);
        }

        public override void DrawPolygon(DiagramFramework.Point[] points, DiagramFramework.Color color)
        {
            Graphics g = _control.CreateGraphics();
            PointF[] ps = new PointF[points.Length];

            for (int i = 0; i < points.Length; i++)
                ps[i] = new PointF(points[i].X, points[i].Y);

            g.DrawPolygon(new Pen(Color.FromArgb(color.A, color.R, color.G, color.B)), ps);
        }

        public override void FillRectangle(int x, int y, int width, int height, DiagramFramework.Color color)
        {
            Graphics g = _control.CreateGraphics();

            g.FillRectangle(new SolidBrush(Color.FromArgb(color.A, color.R, color.G, color.B)), x, y, width, height);
        }

        public override void DrawRectangle(int x, int y, int width, int height, DiagramFramework.Color color)
        {
            Graphics g = _control.CreateGraphics();

            g.DrawRectangle(new Pen(Color.FromArgb(color.A, color.R, color.G, color.B)), x, y, width, height);
        }

        public override void DrawText(DiagramFramework.Point point, string text, DiagramFramework.Color color)
        {
            Graphics g = _control.CreateGraphics();
            //Font font = new Font(_control.Font.Name, currentSize, Label1.Font.Style);

            g.DrawString(text, _control.Font, new SolidBrush(Color.FromArgb(color.A, color.R, color.G, color.B)), new PointF(point.X, point.Y));
        }

        public override void Clear(DiagramFramework.Color color)
        {
            Graphics g = _control.CreateGraphics();

            g.Clear(Color.FromArgb(color.A, color.R, color.G, color.B));
        }
    }
}
