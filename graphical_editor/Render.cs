using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DrawingEngine.Common;
using DrawingEngine.Drawing2D;
using DrawingEngine.Objects;
using DrawingEngine.Drawing3D;
using DrawingEngine.Sort;

namespace DrawingEngine
{
    class Render
    {
        /// <summary>
        /// Объект графики pictureBox'а для рисования
        /// </summary>
        private Graphics g = null;

        /// <summary>
        /// Камера
        /// </summary>
        private Camera camera;

        /// <summary>
        /// Высота области отрисовки
        /// </summary>
        private int canvasHeight;

        /// <summary>
        /// Ширина области отрисовки
        /// </summary>
        private int canvasWidth;

        /// <summary>
        /// Тип проецирования
        /// </summary>
        private ProecType proecType;

        private RotateType rotateType;

        private ViewType viewType;

        private Vector3D light;

        private Color color;

        // Список объектов на сцене
        private List<SimpleObject> objects = new List<SimpleObject>();

        public Render(int height, int width)
        {
            canvasHeight = height;
            canvasWidth = width;
            proecType = ProecType.Parallel;
            rotateType = RotateType.Global;
            viewType = ViewType.Faces;
            light = new Vector3D(0, 0, 100);
            color = Color.DarkOrchid;

            // Инициализируем камеру
            camera = new Camera(new Point3D(300, 100, -300), new Point3D(), 5, 5000, 90, width, height);
        }

        // Добавить новый объект
        public void addObject(SimpleObject obj)
        {
            objects.Add(obj);
        }

        public void addObjects(List<SimpleObject> objects)
        {
            foreach (SimpleObject obj in objects)
            {
                this.addObject(obj);
            }
        }

        public void setRotate(double x, double y, double z)
        {
            if (this.rotateType == RotateType.Own)
            {
                foreach (SimpleObject obj in objects)
                {
                    obj.RotateAxisX(x);
                    obj.RotateAxisY(y);
                    obj.RotateAxisZ(z);
                }
            }
            else
            {
                foreach (SimpleObject obj in objects)
                {
                    obj.RotateX(x);
                    obj.RotateY(y);
                    obj.RotateZ(z);
                }
            }
        }

        public void setMove(double x, double y, double z)
        {
            foreach (SimpleObject obj in objects)
            {
                obj.Move(x, y, z);
            }
        }

        public void setScale(double x, double y, double z)
        {
            foreach (SimpleObject obj in objects)
            {
                obj.Scale(x, y, z);
            }
        }

        public void setMirror(bool x, bool y, bool z) 
        {
            foreach (SimpleObject obj in objects)
            {
                obj.Mirror(x, y, z);
            }   
        }

        public void setCameraPosition(double x, double y, double z)
        {
            camera.SetPosition(new Point3D(x, y, z));
        }

        public Point3D getCameraPosition()
        {
            return camera.GetPosition();
        }

        public void setCameraTarget(double x, double y, double z)
        {
            camera.SetTarget(new Point3D(x, y, z));
        }

        public Point3D getCameraTarget()
        {
            return camera.GetTarget();
        }

        public void setCameraNearPlane(double near)
        {
            camera.SetNearPlane(near);
            camera.reCalcFocus(near);
        }

        public double getCameraNearPlane()
        {
            return camera.getNearPlane();
        }

        public void setCameraFarPlane(double far)
        {
            camera.SetFarPlane(far);
        }

        public double getCameraFarPlane()
        {
            return camera.getFarPlane();
        }

        public void rotateCamera(Vector3D vector, Point3D point)
        {
            // Задаем целью камеры центр объекта
            camera.SetTarget(point);

            // Создаем матрицу для вращения
            Matrix rotate = new Matrix();
            rotate.Rotate(vector, Converter.toRadians(2), point);
            camera.SetPosition(rotate.Multiply(camera.GetPosition()));
        }

        /// <summary>
        /// Перерисовать фигуру
        /// </summary>
        public void ReDraw()
        {
            if (g == null)
            {
                throw new Exception("Объект Graphics не задан!");
            }

            // Очищаем область
            g.Clear(Color.White);

            // Собираем все грани в список
            List<Face> globalFaceList = new List<Face>();

            // Список id граней, которые не нужно отображать
            List<int> idList = new List<int>();

            // Дoбавляем в список id фигур, которые нужно удалить
            foreach (SimpleObject obj in objects)
            {
                if (CullObject(obj))
                {
                    idList.Add(obj.getID());
                    continue;
                }
            }

            // Проверяем id всех фигур и добавляем в список грани не отсекаемых
            foreach (SimpleObject obj in objects)
            {
                if (idList.Contains(obj.getID()))
                {
                    continue;
                }
                globalFaceList.AddRange(obj.FaceList);
            }
            
            // Сортируем собранные грани
            SortFaces(ref globalFaceList);

            // Отсекаем невидимые грани
            HideBackFaces(ref globalFaceList);

            // Рисуем грани
            DrawFaces(globalFaceList);
        }

        /// <summary>
        ///  Задать объект графики pictureBox'а для рисования
        /// </summary>
        /// <param name="g">Объект Graphics</param>
        public void SetGraphic(Graphics g)
        {
            this.g = g;
        }

        /// <summary>
        /// Изменение типа проецирование
        /// </summary>
        /// <param name="type">Перечисление типа Engine.ProecType</param>
        public void SetProecType(ProecType type)
        {
            if (type == this.proecType)
                return;

            this.proecType = type;
        }

        // Изменение типа вращения
        public void SetRotateType(RotateType type)
        {
            if (type == this.rotateType)
                return;

            this.rotateType = type;
        }

        // Изменение вида (ребра или грани)
        public void SetViewType(ViewType type)
        {
            if (type == this.viewType)
                return;

            this.viewType = type;
        }

        /// <summary>
        /// Удалить все объекты
        /// </summary>
        public void Clear()
        {
            objects.Clear();
        }

        private void SortFaces(ref List<Face> faces)
        {
            // Сортируем грани
            SortObjects.Sort(camera.GetPosition(), ref faces);
        }

        /// <summary>
        /// Отрисовка граней
        /// </summary>
        /// <param name="faces"></param>
        private void DrawFaces(List<Face> faces)
        {
            faces = camera.FacesToCamera(faces);

            foreach(Face face in faces)
            {

                Point3D point1 = face.point1;
                Point3D point2 = face.point2;
                Point3D point3 = face.point3;

                if (this.proecType == ProecType.Central)
                {
                    // Матрица для центрального проецирования
                    Matrix centralMatrix = new Matrix();
                    centralMatrix[2, 3] = 1 / camera.view_dist;

                    point1 = centralMatrix.Multiply(point1);
                    point2 = centralMatrix.Multiply(point2);
                    point3 = centralMatrix.Multiply(point3);
                }

                point1 = FixToMachinesCoords(point1);
                point2 = FixToMachinesCoords(point2);
                point3 = FixToMachinesCoords(point3);

                if (viewType == ViewType.Faces)
                {
                    g.FillPolygon(new SolidBrush(getColor(face)), new PointF[] { new PointF((float)point1.X, (float)point1.Y), new PointF((float)point2.X, (float)point2.Y), new PointF((float)point3.X, (float)point3.Y) });
                 //   g.DrawPolygon(new Pen(Color.Black), new PointF[] { new PointF((float)point1.X, (float)point1.Y), new PointF((float)point2.X, (float)point2.Y), new PointF((float)point3.X, (float)point3.Y) });
                }
                else
                {
                    g.DrawPolygon(new Pen(Color.Black), new PointF[] { new PointF((float)point1.X, (float)point1.Y), new PointF((float)point2.X, (float)point2.Y), new PointF((float)point3.X, (float)point3.Y) });
                }
            }
        }


        private bool CullObject(SimpleObject obj)
        {
            List<Point3D> cameraPoints = camera.PointsToCamera(obj.PointList);
            
            foreach (Point3D point in cameraPoints)
            {

                // Отбраковка по Z
                if (point.Z < camera.getNearPlane() || point.Z > camera.getFarPlane())
                { return true; }

                // Отбраковка по X
                //if (point.X > point.Z || -point.X > point.Z)                    
                if (point.X > camera.viewplane_width / 2 || point.X < -camera.viewplane_width / 2)
                { return true; }

                // Отбраковка по Y
                //if (point.Y > point.Z || -point.Y > point.Z)
                if (point.Y > camera.viewplane_height / 2 || point.Y < -camera.viewplane_height / 2)
                { return true; }
            }
            return false;
        }

        // Отсечение
        private void HideBackFaces(ref List<Face> faces)
        {
            List<Face> newFaces = new List<Face>();
            foreach (Face face in faces)
            {
                // Проверка на необходимость отображать грань
                Vector3D normale = face.getNormal();
                Vector3D camVector = new Vector3D(camera.GetTarget(), camera.GetPosition());

                double scalar = Vector3D.ScalarMultiply(normale, camVector);

                // Если скалярное произведение <0, то грань невидима
                if (scalar < 0)
                    continue;

                newFaces.Add(face);
            }

            faces = newFaces;
        }

        // Типы проецирования
        public enum ProecType
        {
            Central,
            Parallel
        }

        // Типы вращения
        public enum RotateType
        {
            Own,
            Global
        }

        // Типы вида
        public enum ViewType
        {
            Edges,
            Faces
        }

        public Color getColor(Face face)
        {
            // Находим коеффициент яркости - косинус между нормалью полигона и вектором источником света
            double koeff = Vector3D.ScalarMultiply(face.getNormal(), light);
            koeff /= light.Length();
            koeff = Math.Abs(koeff);

            // Получаем исходный цвет
            int currentColor = this.color.ToArgb();
            
            // Разложение на красный, зеленый, синий
            int r = (currentColor & 0x00FF0000) >> 16;
            int g = (currentColor & 0x0000FF00) >> 8;
            int b = (currentColor & 0x000000FF);

            // Получаем цвет для полигона - умножаем исходный цвет на косинус
            return Color.FromArgb(Convert.ToInt32(r * koeff), Convert.ToInt32(g * koeff), Convert.ToInt32(b * koeff));
        }

        /// <summary>
        /// Перенос центра координат в центр экрана
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private Point3D FixToMachinesCoords(Point3D input)
        {
            // матрица преобразования из логической системы координат (как на уроке математики) к машинной
            var toMachineCoordsionMatrix = new Matrix(new[,] { { 1.0, 0, 0, 0 }, { 0, -1.0, 0, 0 }, { 0, 0, -1.0, 0 }, { canvasWidth / 2, canvasHeight / 2, 0, 1.0 } });

            // чтобы всё отображалось как надо переводим полученный рисунок из логической системы координат в машинную
            Point3D output = new Point3D();
            output = toMachineCoordsionMatrix.Multiply(input);

            return output;
        }

    }
}
