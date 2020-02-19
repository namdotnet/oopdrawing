using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiagramFramework
{
    public class Diagram : IEnumerable<DiagramItem>
    {
        private List<DiagramItem> _items;

        public Diagram()
        {
            _items = new List<DiagramItem>();
        }

        public void AddToTop(DiagramItem item)
        {
            lock (_items)
            {
                _items.Insert(0, item);
            }
        }

        public void MoveToTop(DiagramItem item)
        {
            lock (_items)
            {
                _items.Remove(item);
                _items.Insert(0, item);
            }
        }

        public DiagramItem FindByPoint(Point point)
        {
            lock(_items)
            {
                foreach (DiagramItem item in _items)
                {
                    if (item.IsInside(point))
                        return item;
                }

                return null;
            }
        }

        public void Paint(ViewPort viewport)
        {
            lock (_items)
            {
                for (int i = _items.Count - 1; i >= 0; i--)
                {
                    DiagramItem item = _items[i];
                    item.Paint(viewport);
                }
            }
        }

        public IEnumerator<DiagramItem> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
