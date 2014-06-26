using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;
using DrawingEngine.Common;

namespace DrawingEngine.Objects
{
    abstract class SimpleObject
    {
        // Начальная и конечная точки оси Х
        protected Point3D firstPointAxisX;
        protected Point3D lastPointAxisX;

        // Начальная и конечная точки оси Y
        protected Point3D firstPointAxisY;
        protected Point3D lastPointAxisY;

        // Начальная и конечная точки оси Z
        protected Point3D firstPointAxisZ;
        protected Point3D lastPointAxisZ;

        // ID объекта
        protected int id;

        // Список точек
        protected List<Point3D> sourcePointsList = new List<Point3D>();

        // Текущий список точек
        protected List<Point3D> currentPointList = new List<Point3D>();

        // Матрица преобразований объекта
        protected Matrix matrix = new Matrix();

        // Список ребер
        protected List<Edge> edgesList = new List<Edge>();

        // Список граней
        protected List<Face> faceList = new List<Face>();

        // Абстрактные методы. Должны быть перегружены с дочернем классе
        protected abstract void updateEdges();
        protected abstract void updateFaces();
        public abstract List<Edge> EdgesList { get; set; }
        public abstract List<Face> FaceList { get; set; }
        public abstract List<Point3D> PointList { get; set; }
        

        public void RotateX(double angleInDegrees)
        {
            matrix.RotateX(Converter.toRadians(angleInDegrees));
            UpdateCurrentPoints();
        }

        public void RotateY(double angleInDegrees)
        {
            matrix.RotateY(Converter.toRadians(angleInDegrees));
            UpdateCurrentPoints();
        }

        public void RotateZ(double angleInDegrees)
        {
            matrix.RotateZ(Converter.toRadians(angleInDegrees));
            UpdateCurrentPoints();
        }

        public void RotateAxisX(double angleInDegrees)
        {
            Vector3D vectorX = new Vector3D(UpdatePoint(this.firstPointAxisX), UpdatePoint(this.lastPointAxisX));
            vectorX.Normalize();
            matrix.Rotate(vectorX, Converter.toRadians(angleInDegrees), UpdatePoint(this.firstPointAxisX));
            UpdateCurrentPoints();
        }

        public void RotateAxisY(double angleInDegrees)
        {
            Vector3D vectorY = new Vector3D(UpdatePoint(this.firstPointAxisY), UpdatePoint(this.lastPointAxisY));
            vectorY.Normalize();
            matrix.Rotate(vectorY, Converter.toRadians(angleInDegrees), UpdatePoint(this.firstPointAxisY));
            UpdateCurrentPoints();
        }

        public void RotateAxisZ(double angleInDegrees)
        {
            Vector3D vectorZ = new Vector3D(UpdatePoint(this.firstPointAxisZ), UpdatePoint(this.lastPointAxisZ));
            vectorZ.Normalize();
            matrix.Rotate(vectorZ, Converter.toRadians(angleInDegrees), UpdatePoint(this.firstPointAxisZ));
            UpdateCurrentPoints();
        }

        public void Move(double x, double y, double z)
        {
            matrix.Move(x, y, z);
            UpdateCurrentPoints();
        }

        public void Scale(double x, double y, double z)
        {
            matrix.Scale(x, y, z);
            UpdateCurrentPoints();
        }

        public void Mirror(bool x, bool y, bool z)
        {
            if (x) matrix.MirrorX();
            if (y) matrix.MirrorY();
            if (z) matrix.MirrorZ();
            UpdateCurrentPoints();
        }

        public void UpdateCurrentPoints()
        {
            List<Point3D> newData = new List<Point3D>();
            foreach (Point3D point in sourcePointsList)
            {
                newData.Add(UpdatePoint(point));
            }

            currentPointList = newData;

            updateEdges();
            updateFaces();
        }

        private Point3D UpdatePoint(Point3D point)
        {
            return matrix.Multiply(point);
        }

        public Point3D getCenterObject()
        {
            Point3D updateLastPointAxisX = UpdatePoint(lastPointAxisX);
            Point3D updateFirstPointAxisX = UpdatePoint(firstPointAxisX);
            Point3D updateLastPointAxisY = UpdatePoint(lastPointAxisY);
            Point3D updateFirstPointAxisY = UpdatePoint(firstPointAxisY);
            Point3D updateLastPointAxisZ = UpdatePoint(lastPointAxisZ);
            Point3D updateFirstPointAxisZ = UpdatePoint(firstPointAxisZ);
            return new Point3D((updateLastPointAxisX.X + updateFirstPointAxisX.X) / 2, (updateLastPointAxisY.Y + updateFirstPointAxisY.Y) / 2, (updateLastPointAxisZ.Z + updateFirstPointAxisZ.Z) / 2);
        }

        public Matrix getMatrix()
        {
            return this.matrix;
        }

        public void setMatrix(Matrix matrix)
        {
            this.matrix = Matrix.Multiply(this.getMatrix(), matrix);
            UpdateCurrentPoints();
        }

        public int getID()
        {
            return this.id;
        }

        public void setID(int id)
        {
            this.id = id;
        }
    }
}
