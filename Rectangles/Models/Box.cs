using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Reflection;

namespace Rectangles.Models
{
    class Box
    {
        private Rectangle box;
        private Brush color;
        public double top { get; set; }
        public double left { get; set; }

        public Box(Brush b, double t, double l, double h, double w)
        {
            box = new Rectangle();
            color = b;
            top = t;
            left = l;
            box.Height = h;
            box.Width = w;
            fill();
        }

        public Rectangle getBox()
        {
            return box;
        }

        public void setOpacity(double o)
        {
            box.Opacity = o;
        }

        public double getBottom()
        {
            return top + box.Height - 1;
        }

        public double getRight()
        {
            return left + box.Width - 1;
        }

        public void setColor(Brush b)
        {
            color = b;
            fill();
        }

        private void fill()
        {
            box.Stroke = Brushes.Black;
            box.Fill = color;
        }
    }
}
