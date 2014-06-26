using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;

namespace DrawingEngine.Sort
{
    class FaceComparer:IComparer<Face>
    {
        public int Compare(Face face1, Face face2)
        {
            Point3D camPos = SortObjects.cameraPosition;
            /*
            Point3 centerOfLine1 = new Point3((face1.point1.X + face1.point2.X) / 2, (face1.point1.Y + face1.point2.Y) / 2, (face1.point1.Z + face1.point2.Z) / 2);
            Point3 centerOfTriangle1 = new Point3((centerOfLine1.X + face1.point3.X) / 2, (centerOfLine1.Y + face1.point3.Y) / 2, (centerOfLine1.Z + face1.point3.Z) / 2);

            Point3 centerOfLine2 = new Point3((face2.point1.X + face2.point2.X) / 2, (face2.point1.Y + face2.point2.Y) / 2, (face2.point1.Z + face2.point2.Z) / 2);
            Point3 centerOfTriangle2 = new Point3((centerOfLine2.X + face2.point3.X) / 2, (centerOfLine2.Y + face2.point3.Y) / 2, (centerOfLine2.Z + face2.point3.Z) / 2);

            return (centerOfTriangle1.Z > centerOfTriangle2.Z) ? -1 : (centerOfTriangle1.Z < centerOfTriangle2.Z) ? 1 : 0;
            */
            
            /*
            double avgZ1 = (face1.point1.Z + face1.point2.Z + face1.point3.Z) / 3;
            double avgZ2 = (face2.point1.Z + face2.point2.Z + face2.point3.Z) / 3;

            return (avgZ1 > avgZ2) ? -1 : (avgZ1 < avgZ2) ? 1 : 0;
            */
            
            double avgDist1 = ((new Vector3D(camPos, face1.point1).Length() + new Vector3D(camPos, face1.point2).Length() + new Vector3D(camPos, face1.point3).Length()) / 3);
            double avgDist2 = ((new Vector3D(camPos, face2.point1).Length() + new Vector3D(camPos, face2.point2).Length() + new Vector3D(camPos, face2.point3).Length()) / 3);
            return (avgDist1 > avgDist2) ? -1 : (avgDist1 < avgDist2) ? 1 : 0; 
            
            /*
            double max1 = Math.Max(new Vector3(camPos, face1.point1).Length(), Math.Max(new Vector3(camPos, face1.point2).Length(), new Vector3(camPos, face1.point3).Length()));
            double max2 = Math.Max(new Vector3(camPos, face2.point1).Length(), Math.Max(new Vector3(camPos, face2.point2).Length(), new Vector3(camPos, face2.point3).Length()));
            return (max1 > max2) ? -1 : (max1 < max2) ? 1 : 0; 
             */
        }
    }
}
