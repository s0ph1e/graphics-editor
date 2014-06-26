using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing2D;

namespace DrawingEngine.Drawing3D
{
    public class Point3D:Point2D
    {
        private double z;

        public Point3D(double x, double y, double z):base(x, y)
        {
            this.z = z;
        }

        public Point3D():base()
        {
            this.z = 0;
        }

        public static Point3D operator / (Point3D point, double d)
        {
            point = (Point3D)((Point2D)point / d);
            point.Z = point.Z / d;
            return point;
        }

        #region Get & Set methods

        // X set/get methods
        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        #endregion

    }
}
