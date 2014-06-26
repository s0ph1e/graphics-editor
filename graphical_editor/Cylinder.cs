using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;
using DrawingEngine.Common;

namespace DrawingEngine.Objects
{
    class Cylinder:SimpleObject
    {
        // Количество треугольников, в основаниях
        const int TRIANGLES = 40;

        // Точка центра нижнего основаня
        Point3D center;

        // Радиус цилиндра
        double radius;

        // Высота цилиндра
        double height;

        public Cylinder(Point3D center, double radius, double height)
        {
            this.center = new Point3D();
            this.radius = radius;
            this.height = height;
            fillPoints();
            fillAxis();
            this.currentPointList = sourcePointsList.ToList();
            this.Move(center.X, center.Y, center.Z);
            updateEdges();
            updateFaces();
        }

        private void fillPoints()
        {
            sourcePointsList.Clear();

            double angle = Converter.toRadians(360 / TRIANGLES);

            // Левое основание
            Matrix baseMatrix = new Matrix(); // Матрица, по которой будем поворачивать точки
            Point3D tmpPoint = new Point3D(); // Временная точка

            // Центр левого основания
            sourcePointsList.Add(center);

            // Точки, лежащие на окружности левого основания
            baseMatrix = new Matrix();
            tmpPoint = new Point3D(center.X, center.Y + radius, center.Z);
            for (int i = 0; i < TRIANGLES; i++)
            {
                baseMatrix.RotateX(angle);
                sourcePointsList.Add(baseMatrix.Multiply(tmpPoint));
            }

            // Центр правого основания
           sourcePointsList.Add(new Point3D(center.X + height, center.Y, center.Z));

            // Точки, лежащие на окружности правого основания
           baseMatrix = new Matrix();
           tmpPoint = new Point3D(center.X + height, center.Y + radius, center.Z);
            for (int i = 0; i < TRIANGLES; i ++)
            {
                baseMatrix.RotateX(angle);
                sourcePointsList.Add(baseMatrix.Multiply(tmpPoint));
            }   
        }

        private void fillAxis()
        {
            this.firstPointAxisX = new Point3D(this.center.X, this.center.Y, this.center.Z);
            this.lastPointAxisX = new Point3D(this.center.X + height, this.center.Y, this.center.Z);
            
            this.firstPointAxisY = new Point3D(this.center.X + height / 2, this.center.Y - radius, this.center.Z);
            this.lastPointAxisY = new Point3D(this.center.X + height / 2, this.center.Y + radius, this.center.Z);
            
            this.firstPointAxisZ = new Point3D(this.center.X + height / 2, this.center.Y, this.center.Z - radius);
            this.lastPointAxisZ = new Point3D(this.center.X + height / 2, this.center.Y, this.center.Z + radius);
        }

        protected override void updateEdges()
        {
            edgesList.Clear();
            
            //Формируем список ребер левого основания
            for (int i = 1; i <= TRIANGLES; i++)
            {
                //Левое основание
                this.edgesList.Add(new Edge(currentPointList[0], currentPointList[i])); // Радиус из центра в точку i
                if (i == TRIANGLES)  //Если точка последняя - то соединяем ее с первой
                {
                    this.edgesList.Add(new Edge(currentPointList[i], currentPointList[1]));
                }
                else                 
                {
                    this.edgesList.Add(new Edge(currentPointList[0], currentPointList[i + 1]));  // Радиус из центра в точку i+1
                    this.edgesList.Add(new Edge(currentPointList[i], currentPointList[i + 1]));  // Соединяем точки на окружности i и i+1
                }
            }
            
            for (int i = TRIANGLES + 2; i <= 2 * TRIANGLES + 1; i++)
            {
                //Правое основание
                this.edgesList.Add(new Edge(currentPointList[TRIANGLES + 1], currentPointList[i])); // Радиус из центра в точку i
                if (i == 2 * TRIANGLES + 1)   //Если точка последняя - то соединяем ее с первой
                {
                    this.edgesList.Add(new Edge(currentPointList[i], currentPointList[TRIANGLES + 2]));
                }
                else
                {
                    this.edgesList.Add(new Edge(currentPointList[TRIANGLES + 1], currentPointList[i + 1])); // Радиус из центра в точку i+1
                    this.edgesList.Add(new Edge(currentPointList[i], currentPointList[i + 1]));   // Соединяем точки на окружности i и i+1
                }
             }

            // Ребра цилиндра
            for (int i = 1; i <= TRIANGLES; i++)
            {
                // Прямая линия от точки левого основания к соответствующей точке на правом
                this.edgesList.Add(new Edge(currentPointList[i], currentPointList[TRIANGLES + 1 + i])); 
                // Косые линии
                if (i == TRIANGLES)  
                {
                    // Если последний шаг, то соединяем первую точку левого основания с последней точкой правого
                    this.edgesList.Add(new Edge(currentPointList[1], currentPointList[TRIANGLES + 1 + i]));
                }
                else 
                {
                    // Линия от i-й точки левого основания до i+1-й точки правого
                    this.edgesList.Add(new Edge(currentPointList[i + 1], currentPointList[TRIANGLES + 1 + i]));
                }
            }
            
        }

        protected override void updateFaces()
        {
            this.faceList.Clear();
            
            //// Грани левого основания
            //for (int i = 1; i <= TRIANGLES; i++)
            //{
            //    if (i == TRIANGLES)
            //    {
            //        this.faceList.Add(new Face(currentPointList[0], currentPointList[1], currentPointList[i]));
            //    }
            //    else
            //    {
            //        this.faceList.Add(new Face(currentPointList[0], currentPointList[i + 1], currentPointList[i]));
            //    }
            //}

            //// Грани правого основания
            //for (int i = TRIANGLES + 2; i <= 2 * TRIANGLES + 1; i++)
            //{
            //    if (i == 2 * TRIANGLES + 1)
            //    {
            //        this.faceList.Add(new Face(currentPointList[TRIANGLES + 1], currentPointList[i], currentPointList[TRIANGLES + 2]));
            //    }
            //    else
            //    {
            //        this.faceList.Add(new Face(currentPointList[TRIANGLES + 1], currentPointList[i], currentPointList[i+1]));
            //    }
            //}
            
            // Грани цилиндра
            for (int i = 2; i <= TRIANGLES; i++)
            {
                if (i == TRIANGLES)
                {
                    this.faceList.Add(new Face(currentPointList[1], currentPointList[2 * TRIANGLES + 1], currentPointList[TRIANGLES]));
                    this.faceList.Add(new Face(currentPointList[2 * TRIANGLES], currentPointList[TRIANGLES], currentPointList[2 * TRIANGLES + 1]));

                    this.faceList.Add(new Face(currentPointList[TRIANGLES + 2], currentPointList[1], currentPointList[2]));
                    this.faceList.Add(new Face(currentPointList[2 * TRIANGLES + 1], currentPointList[1], currentPointList[TRIANGLES + 2]));
                }
                else 
                {
                    this.faceList.Add(new Face(currentPointList[i + 1], currentPointList[TRIANGLES + 1 + i], currentPointList[i]));
                    this.faceList.Add(new Face(currentPointList[TRIANGLES + i], currentPointList[i], currentPointList[TRIANGLES + 1 + i]));
                }
            }

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
