using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiagramFramework;

namespace ObjectDiagram
{
    public partial class MainForm : Form
    {
        private Diagram _diagram = null;
        private ViewPort _viewport = null;
        private DiagramFramework.Point lastMouseDown = null;
        private DiagramFramework.Color[] colors = new DiagramFramework.Color[] {
            new DiagramFramework.Color(System.Drawing.Color.Red.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.Green.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.Blue.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.Yellow.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.Brown.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.LightBlue.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.LightGreen.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.DarkBlue.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.DarkGreen.ToArgb()),
            new DiagramFramework.Color(System.Drawing.Color.DarkRed.ToArgb())
            };

        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdCreateRectangle_Click(object sender, EventArgs e)
        {
            RectangleDiagramItem item = new RectangleDiagramItem() { Color = colors[random.Next(colors.Length - 1)], Left = 100, Top = 100, Width = 100, Height = 100 };

            _diagram.AddToTop(item);

            _viewport.Clear(new DiagramFramework.Color(0xFF, 0xFF, 0xFF));
            _diagram.Paint(_viewport);
            Invalidate();
        }

        private void cmdCreateTriangle_Click(object sender, EventArgs e)
        {
            TriangleDiagramItem item = new TriangleDiagramItem() { Color = colors[random.Next(colors.Length - 1)], Left = 100, Top = 100, Width = 100, Height = 100 };

            _diagram.AddToTop(item);

            _viewport.Clear(new DiagramFramework.Color(0xFF, 0xFF, 0xFF));
            _diagram.Paint(_viewport);
            Invalidate();
        }        
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            _diagram = new Diagram();
            _viewport = new FormViewPort(this.diagramPanel);
        }

        private void diagramPanel_OnMouseDown(object sender, MouseEventArgs e)
        {
            lastMouseDown = new DiagramFramework.Point(e.X, e.Y);

            foreach (DiagramItem selectedItem in _diagram)
            {
                selectedItem.IsSelected = false;
            }
            
            DiagramItem item = _diagram.FindByPoint(lastMouseDown);

            if (item != null)
            {
                item.IsSelected = true;
                _diagram.MoveToTop(item);
            }

            _viewport.Clear(new DiagramFramework.Color(0xFF, 0xFF, 0xFF));
            _diagram.Paint(_viewport);

            Invalidate();
        }

        private void diagramPanel_OnMouseMove(object sender, MouseEventArgs e)
        {
            if (lastMouseDown != null)
            {
                int distanceX = e.X - lastMouseDown.X;
                int distanceY = e.Y - lastMouseDown.Y;

                lastMouseDown = new DiagramFramework.Point(e.X, e.Y);

                foreach (DiagramItem selectedItem in _diagram)
                {
                    if (selectedItem.IsSelected)
                    {
                        selectedItem.Left += distanceX;
                        selectedItem.Top += distanceY;
                    }
                }

                _viewport.Clear(new DiagramFramework.Color(0xFF, 0xFF, 0xFF));
                _diagram.Paint(_viewport);
                Invalidate();
            }
        }

        private void diagramPanel_OnMouseUp(object sender, MouseEventArgs e)
        {
            lastMouseDown = null;
        }


        private void diagramPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var mouseXY = new DiagramFramework.Point(e.X, e.Y);

            DiagramItem item = _diagram.FindByPoint(mouseXY);

            if (item != null)
            {
                item.IsSelected = true;
                _diagram.MoveToTop(item);

                var colorDialog = new ColorDialog();
                colorDialog.Color = System.Drawing.Color.FromArgb(item.Color.A, item.Color.R, item.Color.G, item.Color.B);
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    item.Color = new DiagramFramework.Color(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                }
            }

            _viewport.Clear(new DiagramFramework.Color(0xFF, 0xFF, 0xFF));
            _diagram.Paint(_viewport);
            Invalidate();
        }

    }
}
