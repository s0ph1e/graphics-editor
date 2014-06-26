using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;
using DrawingEngine.Common;

namespace DrawingEngine.Objects
{
    class SportFrame
    {
        // id
        private int id;
        
        // Список объектов
        private List<SimpleObject> objects = new List<SimpleObject>();

        private Point3D basePoint;       // Базовая точка
        private double stairsTubeLenght;    // Длина основания
        private double stairsTubeWidth;     // Ширина основания лестницы
        private double stairsTubeHeight;    // Высота основания лестницы
        private int stairsCount;            // Количество ступенек
        private double stairsRadius;        // Радиус ступеньки
        private double stairsLenght;        // Длина ступеньки
        private double barTubeWidth;        // Ширина основания турника
        private double barTubeHeight;       // Высота основания турника
        private double barRadius;           // Радиус турника
        private double barLenght;           // Длина турника

        private Point3D center;              // Центральная точка
        private double radius;              // Радиус сферы, ограничивающей фигуру
        
        
        public SportFrame(Point3D basePoint, double stairsTubeLenght, double stairsTubeWidth, double stairsTubeHeight, int stairsCount, double stairsRadius, double stairsLenght, double barTubeWidth, double barTubeHeight, double barRadius, double barLenght)
        {
            this.basePoint = basePoint;
            this.stairsTubeLenght = stairsTubeLenght;
            this.stairsTubeWidth = stairsTubeWidth;
            this.stairsTubeHeight = stairsTubeHeight;
            this.stairsCount = stairsCount;
            this.stairsRadius = stairsRadius;
            this.stairsLenght = stairsLenght;
            this.barTubeWidth = barTubeWidth;
            this.barTubeHeight = barTubeHeight;
            this.barRadius = barRadius;
            this.barLenght = barLenght;


            // Левое основание лестницы
            objects.Add(new Box(new Point3D(basePoint.X, basePoint.Y, basePoint.Z), stairsTubeLenght, stairsTubeHeight, stairsTubeWidth));
            
            // Правое основание лестницы
            objects.Add(new Box(new Point3D(basePoint.X + stairsTubeLenght + stairsLenght, basePoint.Y, basePoint.Z), stairsTubeLenght, stairsTubeHeight, stairsTubeWidth));

            // Ступеньки
            for (int i = 1; i<=stairsCount; i++)
            {
                objects.Add(new Cylinder(new Point3D(basePoint.X + stairsTubeLenght, basePoint.Y + (stairsTubeHeight / stairsCount) * i - (stairsTubeHeight / stairsCount)/2, basePoint.Z + stairsTubeWidth / 2), stairsRadius, stairsLenght));
            }

            // Основание турника
            objects.Add(new Box(new Point3D(basePoint.X + stairsTubeLenght + stairsLenght, basePoint.Y, basePoint.Z - barLenght - barTubeWidth), stairsTubeLenght, barTubeHeight, barTubeWidth));
            

            // Турник (из-за особенностей реализации цилиндра нужно переносить в начало координат, поворачивать и переносить обратно)
            Cylinder bar = new Cylinder(new Point3D(basePoint.X + stairsTubeLenght + stairsLenght + stairsTubeLenght/2, basePoint.Y + barTubeHeight - barRadius, basePoint.Z - barLenght), barRadius, barLenght);
            bar.Move(-(basePoint.X + stairsTubeLenght + stairsLenght + stairsTubeLenght / 2), -(basePoint.Y + barTubeHeight - barRadius), -(basePoint.Z - barLenght));
            bar.RotateY(90);
            bar.Move(basePoint.X + stairsTubeLenght + stairsLenght + stairsTubeLenght / 2, basePoint.Y + barTubeHeight - barRadius, basePoint.Z - barLenght);
            objects.Add(bar);

            // Вычисляем центр
            center = new Point3D(basePoint.X + (2* stairsTubeLenght + stairsLenght)/2, basePoint.Y + stairsTubeHeight/2, basePoint.Z + (stairsTubeWidth + barLenght + barTubeWidth)/2);
        }

        public List<SimpleObject> GetObjects()
        {
            return this.objects;
        }

        public Point3D getBasePoint()
        {
            return this.basePoint;
        }

        public double getStairsTubeLenght()
        {
            return this.stairsTubeLenght;
        }

        public double getStairsTubeWidth()
        {
            return this.stairsTubeWidth;
        }

        public double getStairsTubeHeight()
        {
            return this.stairsTubeHeight;
        }

        public int getStairsCount()
        {
            return this.stairsCount;
        }

        public double getStairsRadius()
        {
            return this.stairsRadius;
        }

        public double getStairsLenght()
        {
            return this.stairsLenght;
        }

        public double getBarTubeWidth()
        {
            return this.barTubeWidth;
        }

        public double getBarTubeHeight()
        {
            return this.barTubeHeight;
        }

        public double getBarRadius()
        {
            return this.barRadius;
        }

        public double getBarLenght()
        {
            return this.barLenght;
        }

        public Matrix getMatrix()
        {
            return objects[0].getMatrix();
        }

        public void setMatrix(Matrix matrix)
        {
            foreach (SimpleObject obj in GetObjects())
            {
                obj.setMatrix(matrix);
            }
        }

        public void setID(int id)
        {
            this.id = id;
            foreach (SimpleObject obj in this.GetObjects())
            {
                obj.setID(id);
            }
        }

        public int getID()
        {
            return this.id;
        }

        public Point3D getCenter()
        {
            return this.getMatrix().Multiply(this.center);
        }

        private void ComputeRadius()
        {
            this.radius = 0;

            foreach (SimpleObject obj in this.GetObjects())
            {
                foreach (Point3D point in obj.PointList)
                {
                    double dist_to_vertex = new Vector3D(this.getCenter(), point).Length();

                    if (dist_to_vertex > this.radius)
                        this.radius = dist_to_vertex;
                }
            }
        }

        public double getRadius()
        {
            ComputeRadius();
            return this.radius;
        }

        
    }
}
