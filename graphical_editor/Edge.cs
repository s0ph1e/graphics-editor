using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawingEngine.Drawing3D
{
    class Edge
    {
        // Первая точка ребра
        public Point3D firstPoint { get; private set; }

        // Вторая точка ребра
        public Point3D secondPoint { get; private set; }

        public Edge(Point3D firstPoint, Point3D secondPoint)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
        }


    }
}
