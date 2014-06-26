using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawingEngine.Drawing3D
{
    class Vector3D
    {
        public double x;
        public double y;
        public double z;

        public Vector3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        // Конструктор
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3D(Point3D first, Point3D last)
        {
            this.x = last.X - first.X;
            this.y = last.Y - first.Y;
            this.z = last.Z - first.Z;
        }

        // Конструктор копирования
        public Vector3D(Vector3D v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        // Суммирование вектора с текущим
        public void Add(Vector3D v)
        {
            this.x += v.x;
            this.y += v.y;
            this.z += v.z;
        }

        // Вычитание вектора из текущего
        public void Subtract(Vector3D v)
        {
            this.x -= v.x;
            this.y -= v.y;
            this.z -= v.z;
        }

        // Умножение вектора на число
        public void Multiplay(double a)
        {
            this.x *= a;
            this.y *= a;
            this.z *= a;
        }

        //Скалярное произведение
        public static double ScalarMultiply(Vector3D a, Vector3D b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        // Векторное произведение
        public static Vector3D VectorMultiply(Vector3D a, Vector3D b)
        {
            Vector3D result = new Vector3D(0,0,0);
			result.x = a.y * b.z - a.z * b.y;
			result.y = a.z * b.x - a.x * b.z;
            result.z = a.x * b.y - a.y * b.x;

            return result;
        }

        // Деление вектора на число
        public void Division(double a)
        {
            this.x /= a;
            this.y /= a;
            this.z /= a;
        }

        // Нормирование вектора
        public void Normalize()
        {
            double length = Length();
            if (length == 0)
                return;
            Division(Length());
        }

        // Обратный вектора
        public Vector3D Negative()
        {
            return new Vector3D(-x, -y, -z);
        }

        // Вычисляем длину вектора
        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        // Копируем вектор
        public Vector3D Copy()
        {
            return new Vector3D(this);
        }

        #region Set & Get Methods

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

        // Z set/get methods
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
