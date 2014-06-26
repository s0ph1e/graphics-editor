using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;

namespace DrawingEngine.Sort
{
    class SortObjects
    {
        public static Point3D cameraPosition;
        public static void Sort(Point3D cameraPos, ref List<Face> faces)
        {
            cameraPosition = cameraPos;
            faces.Sort(new FaceComparer());
        }
    }
}
