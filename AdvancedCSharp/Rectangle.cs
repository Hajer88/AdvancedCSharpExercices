using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();
        public Point BottomRight
        {
            get { return bottomRight; }
            set { bottomRight = value; }
        }


            public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
    }
}
