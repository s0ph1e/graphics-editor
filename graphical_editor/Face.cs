using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawingEngine.Drawing3D
{
    class Face
    {
        public Point3D point1 { get; set; }
        public Point3D point2 { get; set; }
        public Point3D point3 { get; set; }

        public Face(Point3D point1, Point3D point2, Point3D point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public Vector3D getNormal()
        {
            Vector3D u = new Vector3D(point1, point2);
            Vector3D v = new Vector3D(point1, point3);
            Vector3D normale = Vector3D.VectorMultiply(u, v);
            normale.Normalize();
            return normale;
        }
    }
}
