using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingEngine.Drawing2D
{
    public class Point2D
    {
        private double x;
        private double y;

        public Point2D()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point2D operator / (Point2D point, double d)
        {
            point.X = point.X / d;
            point.Y = point.Y / d;
            return point;
        }

        #region Get & Set methods

        // X set/get methods
        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        // Y set/get methods
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        #endregion
    }
}
