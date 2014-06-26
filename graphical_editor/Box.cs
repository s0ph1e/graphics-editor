using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;
using DrawingEngine.Common;
using System.Drawing;

namespace DrawingEngine.Objects
{
    class Box : SimpleObject
    {
        // Базовая точка
        private Point3D basePoint;

        // Длина
        private double length;

        // Ширина
        private double width;

        // Высота
        private double height;

        public Box(Point3D basePoint, double width, double height, double length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
            this.basePoint = basePoint;
            fillPoints();
            fillAxis();
            this.currentPointList = sourcePointsList.ToList();
            updateEdges();
            updateFaces();
        }

        private void fillPoints()
        {
            this.sourcePointsList.Clear();

            // Формируем список точек бокса
            this.sourcePointsList.Add(this.basePoint);
            this.sourcePointsList.Add(new Point3D(this.basePoint.X + this.width, this.basePoint.Y, this.basePoint.Z));
            this.sourcePointsList.Add(new Point3D(this.basePoint.X + this.width, this.basePoint.Y + this.height, this.basePoint.Z));
            this.sourcePointsList.Add(new Point3D(this.basePoint.X, this.basePoint.Y + this.height, this.basePoint.Z));
            this.sourcePointsList.Add(new Point3D(this.basePoint.X, this.basePoint.Y, this.basePoint.Z + this.length));
            this.sourcePointsList.Add(new Point3D(this.basePoint.X + this.width, this.basePoint.Y, this.basePoint.Z + this.length));
            this.sourcePointsList.Add(new Point3D(this.basePoint.X + this.width, this.basePoint.Y + this.height, this.basePoint.Z + this.length));
            this.sourcePointsList.Add(new Point3D(this.basePoint.X, this.basePoint.Y + this.height, this.basePoint.Z + this.length));
        }

        private void fillAxis()
        {

            this.firstPointAxisX = new Point3D(this.basePoint.X, this.basePoint.Y + height / 2, this.basePoint.Z + length / 2);
            this.lastPointAxisX = new Point3D(this.basePoint.X + width, this.basePoint.Y + height / 2, this.basePoint.Z + length / 2);
            
            this.firstPointAxisY = new Point3D(this.basePoint.X + width / 2, this.basePoint.Y, this.basePoint.Z + length / 2);
            this.lastPointAxisY = new Point3D(this.basePoint.X + width / 2, this.basePoint.Y + height, this.basePoint.Z + length / 2);
            
            this.firstPointAxisZ = new Point3D(this.basePoint.X + width / 2, this.basePoint.Y + height / 2, this.basePoint.Z);
            this.lastPointAxisZ = new Point3D(this.basePoint.X + width / 2, this.basePoint.Y + height / 2, this.basePoint.Z + length);
        }

        protected override void updateEdges()
        {
            edgesList.Clear();

            // Формируем список ребер
            this.edgesList.Add(new Edge(currentPointList[0], currentPointList[1]));
            this.edgesList.Add(new Edge(currentPointList[1], currentPointList[2]));
            this.edgesList.Add(new Edge(currentPointList[2], currentPointList[3]));
            this.edgesList.Add(new Edge(currentPointList[3], currentPointList[0]));
            this.edgesList.Add(new Edge(currentPointList[0], currentPointList[2]));

            this.edgesList.Add(new Edge(currentPointList[4], currentPointList[5]));
            this.edgesList.Add(new Edge(currentPointList[5], currentPointList[6]));
            this.edgesList.Add(new Edge(currentPointList[6], currentPointList[7]));
            this.edgesList.Add(new Edge(currentPointList[7], currentPointList[4]));
            this.edgesList.Add(new Edge(currentPointList[7], currentPointList[5]));

            this.edgesList.Add(new Edge(currentPointList[0], currentPointList[4]));
            this.edgesList.Add(new Edge(currentPointList[3], currentPointList[7]));
            this.edgesList.Add(new Edge(currentPointList[4], currentPointList[3]));


            this.edgesList.Add(new Edge(currentPointList[1], currentPointList[5]));
            this.edgesList.Add(new Edge(currentPointList[2], currentPointList[6]));
            this.edgesList.Add(new Edge(currentPointList[1], currentPointList[6]));

            this.edgesList.Add(new Edge(currentPointList[3], currentPointList[6]));
            this.edgesList.Add(new Edge(currentPointList[1], currentPointList[4]));
        }

        protected override void updateFaces()
        {
            this.faceList.Clear();
            //левая грань +
            this.faceList.Add(new Face(this.currentPointList[7], this.currentPointList[3], this.currentPointList[4]));
            this.faceList.Add(new Face(this.currentPointList[0], this.currentPointList[4], this.currentPointList[3]));
            
            //правая грань +
            this.faceList.Add(new Face(this.currentPointList[2], this.currentPointList[6], this.currentPointList[1]));
            this.faceList.Add(new Face(this.currentPointList[5], this.currentPointList[1], this.currentPointList[6]));
            
            //передняя грань +
            this.faceList.Add(new Face(this.currentPointList[1], this.currentPointList[0], this.currentPointList[2]));
            this.faceList.Add(new Face(this.currentPointList[3], this.currentPointList[2], this.currentPointList[0])); 
            
            //нижняя грань 
            this.faceList.Add(new Face(this.currentPointList[0], this.currentPointList[1], this.currentPointList[4]));
            this.faceList.Add(new Face(this.currentPointList[5], this.currentPointList[4], this.currentPointList[1]));
            
            //верхняя грань
            this.faceList.Add(new Face(this.currentPointList[2], this.currentPointList[3], this.currentPointList[6]));
            this.faceList.Add(new Face(this.currentPointList[7], this.currentPointList[6], this.currentPointList[3]));
            
            //задняя грань +
            this.faceList.Add(new Face(this.currentPointList[4], this.currentPointList[5], this.currentPointList[7]));
            this.faceList.Add(new Face(this.currentPointList[6], this.currentPointList[7], this.currentPointList[5]));
        }
        
        #region Gets & Sets methods

        public override List<Face> FaceList
        {
            get
            {
                return this.faceList;
            }
            set
            {
                this.faceList = value;
            }
        }

        // TODO: Deprecated
        public override List<Point3D> PointList
        {
            get
            {
                return this.currentPointList;
            }
            set
            {
                this.currentPointList = value;
            }
        }

        public override List<Edge> EdgesList
        {
            get
            {
                return this.edgesList;
            }
            set
            {
                this.edgesList = value;
            }
        }

        #endregion
    }
}
