using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawingEngine.Drawing3D;
using DrawingEngine.Common;

namespace DrawingEngine
{
    // Ламот. Стр. 549
    class Camera
    {
        // Позиция камеры в мировых координатах
        private Point3D Position;

        // UVN-камера
        private Vector3D u;
        private Vector3D v;
        private Vector3D n;

        // Вектор направления
        private Vector3D direction;

        // Точка, куда смотрит камера в модели UVN
        private Point3D target;

        // Фокусное расстрояние
        public double view_dist { get; private set; }

        public double viewplane_width { get; private set; }
        public double viewplane_height { get; private set; }

        // Соотношение ширины и длины экрана
        private double aspect_ratio;

        // Угол обзора
        private double fov;

        private double near_clip_z;     // Ближний экран
        private double far_clip_z;      // Дальний экран

        private double viewport_width;     // size of screen/viewport
        private double viewport_height;
        private double viewport_center_x;  // center of view port (final image destination)
        private double viewport_center_y;

        private Matrix mcam;    // storage for the world to camVector transform matrix
        private Matrix mper;    // storage for the camVector to perspective transform matrix
        private Matrix mscr;    // storage for the perspective to screen transform matrix

        public Camera(Point3D position, Point3D target, double near, double far, double fov, double viewport_width, double viewport_height)
        {
            this.Position = position;
            this.direction = new Vector3D(position, target);

            this.u = new Vector3D(1, 0, 0);
            this.v = new Vector3D(0, 1, 0);
            this.n = new Vector3D(0, 0, 1);

            this.near_clip_z = near;
            this.far_clip_z = far;

            this.fov = fov;

            this.aspect_ratio = viewport_width / viewport_height;
            /*
            viewplane_width = 2.0;
            viewplane_height = 2.0 / this.aspect_ratio;
            */

            viewplane_width = viewport_width;
            viewplane_height = viewport_height;
            

            this.viewport_width = viewport_width;
            this.viewport_height = viewport_height;

            this.viewport_center_x = (viewport_width - 1) / 2;
            this.viewport_center_y = (viewport_height - 1) / 2;

            double tan_fov_div2 = Math.Tan(Converter.toRadians(fov / 2));
            this.view_dist = (0.5 * near_clip_z) * (viewport_width) * tan_fov_div2;
            if (target != null)
                this.target = target;
            else
                this.target = new Point3D();
            /*
            if (fov == 90)
            {
                Point3 pt_origin = new Point3();

                Vector3 vn; // Нормаль к плану

                // Правый план
                vn = new Vector3(1, 0, -1); // x=z план
                rt_clip_plane = new Plane3(pt_origin, vn, true);

                // Левый план
                vn = new Vector3(-1, 0, -1);// -x=z план
                lt_clip_plane = new Plane3(pt_origin, vn, true);

                // Верхний план
                vn = new Vector3(0, 1, -1);// y=z план
                tp_clip_plane = new Plane3(pt_origin, vn, true);

                // нижний план
                vn = new Vector3(0, -1, -1);// -y=z план
                bt_clip_plane = new Plane3(pt_origin, vn, true);

            }
            else
            {
                Point3 pt_origin = new Point3(0, 0, 0);
                Vector3 vn;

                vn = new Vector3(view_dist, 0, -viewplane_width / 2.0);
                rt_clip_plane = new Plane3(pt_origin, vn, true);

                vn = new Vector3(-view_dist, 0, -viewplane_width / 2.0);
                lt_clip_plane = new Plane3(pt_origin, vn, true);

                vn = new Vector3(0, view_dist, -viewplane_width / 2.0);
                tp_clip_plane = new Plane3(pt_origin, vn, true);

                vn = new Vector3(0, -view_dist, -viewplane_width / 2.0);
                bt_clip_plane = new Plane3(pt_origin, vn, true);
            }
            */
            BuildMatrix();
        }

        private void BuildMatrix()
        {
            Matrix mt_inv, mt_uvn;

            mt_inv = new Matrix(new double[,] { 
                                         {1, 0, 0, 0},
                                         {0, 1, 0, 0},
                                         {0, 0, 1, 0},
                                         {-Position.X, -Position.Y, -Position.Z, 1}
            });

            n = new Vector3D(Position, target);
            v = new Vector3D(0, 1, 0);
            u = Vector3D.VectorMultiply(v, n);
            v = Vector3D.VectorMultiply(n, u);

            u.Normalize();
            v.Normalize();
            n.Normalize();

            mt_uvn = new Matrix(new double[,] { 
                                         {u.X, v.X, n.X, 0},
                                         {u.Y, v.Y, n.Y, 0},
                                         {u.Z, v.Z, n.Z, 0},
                                         {0, 0, 0, 1}
            });

            mcam = Matrix.Multiply(mt_inv, mt_uvn);

        }

        public List<Face> FacesToCamera(List<Face> faces)
        {
            List<Face> result = new List<Face>();
            foreach (Face face in faces)
            {
                Face newface = new Face(mcam.Multiply(face.point1), mcam.Multiply(face.point2), mcam.Multiply(face.point3));
                result.Add(newface);
            }

            return result;
        }

        // Превращение координат точки в координаты камеры
        public List<Point3D> PointsToCamera(List<Point3D> points)
        {
            List<Point3D> result = new List<Point3D>();
            foreach (Point3D point in points)
            {
                Point3D newpoint = new Point3D(mcam.Multiply(point).X, mcam.Multiply(point).Y, mcam.Multiply(point).Z);
                result.Add(newpoint);
            }
            return result;
        }

        // Исправляем фокус при изменении ближней отсекающей плоскости
        public void reCalcFocus(double near)
        {
            double tan_fov_div2 = Math.Tan(Converter.toRadians(fov / 2));
            this.view_dist = (0.5 * near_clip_z) * (viewport_width) * tan_fov_div2; 
        }
        

        #region Set & Get methods

        public void SetPosition(Point3D pos)
        {
            this.Position = pos;
            BuildMatrix();
        }

        public Point3D GetPosition()
        {
            return this.Position;
        }

        public void SetTarget(Point3D pos)
        {
            this.target = pos;
            BuildMatrix();
        }

        public Point3D GetTarget()
        {
            return this.target;
        }

        public void SetFov(double fov)
        {
            this.fov = fov;
        }


        public double GetFov()
        {
            return this.fov;
        }

        public void SetNearPlane(double near)
        {
            this.near_clip_z = near;
            BuildMatrix();
        }

        public double getNearPlane()
        {
            return this.near_clip_z;
        }

        public void SetFarPlane(double far)
        {
            this.far_clip_z = far;
            BuildMatrix();
        }

        public double getFarPlane()
        {
            return this.far_clip_z;
        }

        public Matrix getMatrix()
        {
            return this.mcam;
        }

        #endregion
    }
}
