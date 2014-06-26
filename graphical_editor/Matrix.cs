using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;

namespace DrawingEngine.Common
{
    class Matrix
    {
        public double[,] Data 
        {
            get;
            private set;
        }

        public Matrix(): this(1)
        {
        }

        public Matrix(double[,] array)
        {
            Data = new double[4, 4];
            Data = array;
        }

        public Matrix(double v)     
        {
            Data = new double[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Data[i, j] = (i == j) ? v : 0.0;
            Data[3, 3] = 1;
        }

        public double this[int row, int column]
        {
            get 
            {
                if (row < 0 || row >= Data.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException("row");
                }
                if (column < 0 || column >= Data.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("column");
                }
                return Data[row, column];
            }
            set 
            {
                if (row < 0 || row >= Data.GetLength(0))
                {
                    throw new ArgumentOutOfRangeException("row");
                }
                if (column < 0 || column >= Data.GetLength(1))
                {
                    throw new ArgumentOutOfRangeException("column");
                }
                Data[row, column] = value;
            }
        }

        //Транспонирование
        public void Transpose()
        {
            double tmp;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (i != j)
                    {
                        tmp = Data[i,j];
                        Data[i, j] = Data[j, i];
                        Data[j, i] = tmp;
                    }
        }

        //Умножение матриц
        public static Matrix Multiply(Matrix A, Matrix B)
        {
            Matrix result = new Matrix();
            double sum;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    sum = 0;
                    for (int k = 0; k < 4; k++)
                        sum += A.Data[i,k] * B.Data[k,j];
                    result.Data[i,j] = sum;
                }
            return result;
        }

        //Умножение матрицы на точку
        public Point3D Multiply(Point3D point)
        {
            Point3D result = new Point3D();
            result.X = point.X * Data[0, 0] + point.Y * Data[1, 0] + point.Z * Data[2, 0] + Data[3, 0];
            result.Y = point.X * Data[0, 1] + point.Y * Data[1, 1] + point.Z * Data[2, 1] + Data[3, 1];
            result.Z = point.X * Data[0, 2] + point.Y * Data[1, 2] + point.Z * Data[2, 2] + Data[3, 2];

            double denom = point.X * Data[0, 3] + point.Y * Data[1, 3] + point.Z * Data[2, 3] + Data[3, 3];

            if(denom != 1.0)
                result = result / denom;

            return result;
        }

        //Умножение матрицы на число
        public void Multiply(double k)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    Data[i, j] *= k;
        }

        //Копирование матрицы
        public Matrix Clone()
        {
            return new Matrix(Data);
        }

        // Vector to Matrix
        public static Matrix Translate(Vector3D vec)
        {
            Matrix matrix = new Matrix();
            matrix[0, 3] = vec.x;
            matrix[1, 3] = vec.y;
            matrix[2, 3] = vec.z;

            return matrix;
        }

        //Перенос
        public void Move(double x, double y, double z)
        {
            Matrix other = new Matrix();
            other.Data[3, 0] = x;
            other.Data[3, 1] = y;
            other.Data[3, 2] = z;
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Масштабирование
        public void Scale(double x, double y, double z)
        {
            Matrix other = new Matrix();
            other.Data[0, 0] = x;
            other.Data[1, 1] = y;
            other.Data[2, 2] = z;
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Поворот по Х
        public void RotateX(double angle)
        {
            Matrix other = new Matrix();
            other.Data[1, 1] = Math.Cos(angle);
            other.Data[2, 1] = -Math.Sin(angle);
            other.Data[1, 2] = Math.Sin(angle);
            other.Data[2, 2] = Math.Cos(angle);
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Поворот по У
        public void RotateY(double angle)
        {
            Matrix other = new Matrix();
            other.Data[0, 0] = Math.Cos(angle);
            other.Data[2, 0] = -Math.Sin(angle);
            other.Data[0, 2] = Math.Sin(angle);
            other.Data[2, 2] = Math.Cos(angle);
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Поворот по Z
        public void RotateZ(double angle)
        {
            Matrix other = new Matrix();
            other.Data[0, 0] = Math.Cos(angle);
            other.Data[1, 0] = -Math.Sin(angle);
            other.Data[0, 1] = Math.Sin(angle);
            other.Data[1, 1] = Math.Cos(angle);
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Поворот вокруг оси
        public void Rotate(Vector3D axis, double angle)
        {
            Matrix other = new Matrix();
            other.Data[0, 0] = axis.x * axis.x + (1 - axis.x * axis.x) * Math.Cos(angle);
            other.Data[0, 1] = axis.x * axis.y * (1 - Math.Cos(angle)) + axis.z * Math.Sin(angle);
            other.Data[0, 2] = axis.x * axis.z * (1 - Math.Cos(angle)) - axis.y * Math.Sin(angle);
            other.Data[0, 3] = 0;

            other.Data[1, 0] = axis.x * axis.y * (1 - Math.Cos(angle)) - axis.z * Math.Sin(angle);
            other.Data[1, 1] = axis.y * axis.y + (1 - axis.y * axis.y) * Math.Cos(angle);
            other.Data[1, 2] = axis.y * axis.z * (1 - Math.Cos(angle)) + axis.x * Math.Sin(angle);
            other.Data[1, 3] = 0;

            other.Data[2, 0] = axis.x * axis.z * (1 - Math.Cos(angle)) + axis.y * Math.Sin(angle);
            other.Data[2, 1] = axis.y * axis.z * (1 - Math.Cos(angle)) - axis.x * Math.Sin(angle);
            other.Data[2, 2] = axis.z * axis.z + (1 - axis.z * axis.z) * Math.Cos(angle);
            other.Data[2, 3] = 0;

            other.Data[3, 0] = 0;
            other.Data[3, 1] = 0;
            other.Data[3, 2] = 0;
            other.Data[3, 3] = 1;

            this.Data = Matrix.Multiply(this, other).Data;
        }

        public void Rotate(Vector3D axis, double angle, Point3D point)
        {
            Matrix other = new Matrix();
            other.Move(-point.X, -point.Y, -point.Z);
            other.Rotate(axis, angle);
            other.Move(point.X, point.Y, point.Z);

            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Отражение по Y
        public void MirrorY()
        {
            Matrix other = new Matrix();
            other.Data[0, 0] = -1;
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Отражение по X
        public void MirrorX()
        {
            Matrix other = new Matrix();
            other.Data[1, 1] = -1;
            this.Data = Matrix.Multiply(this, other).Data;
        }

        //Отражение по Z
        public void MirrorZ()
        {
            Matrix other = new Matrix();
            other.Data[2, 2] = -1;
            this.Data = Matrix.Multiply(this, other).Data;
        }
    }
}
