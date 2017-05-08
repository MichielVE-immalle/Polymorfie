using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace polymorfie
{
    public abstract class Shape
    {
        protected int x;
        protected int y;
        protected int size = 75;
        protected SolidColorBrush Brush = new SolidColorBrush(Colors.Black);

        public abstract void DisplayOn(Canvas canvas);
    }
}
