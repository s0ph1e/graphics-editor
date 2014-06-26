using System;
using System.Drawing;
using System.Windows.Forms;
using DrawingEngine.Drawing2D;
using DrawingEngine.Objects;
using DrawingEngine.Drawing3D;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using DrawingEngine.Common;

namespace DrawingEngine
{
    public partial class MainForm : Form
    {

        // Движок рендеринга
        Render engine;

        // Список объектов
        List<SportFrame> sportFrames = new List<SportFrame>();

        // Необходимо перерисовать picturebox
        bool needReDraw = false;

        // Панорамирование
        bool panorama = false;

        // Строка, в которой записаны ошибки
        string errors = "";

        public MainForm()
        {
            InitializeComponent();

            cbObjects.Items.Add("Все объекты");
            cbObjects.SelectedIndex = 0;

            // Создали движок
            engine = new Render(picture.Height, picture.Width);

            // Заставляем обновиться камере
            btnSetCamera_Click(null, null);
            lblErrors.Text = errors;

            UpdateImg();
        }

        private void FileMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из редактора?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void redrawTimer_Tick(object sender, EventArgs e)
        {
            if (needReDraw)
            {
                this.picture.Image = new Bitmap(this.picture.Width, this.picture.Height);
                engine.SetGraphic(Graphics.FromImage(this.picture.Image));
                engine.ReDraw();

                // Очищаем текст сообщения об ошибке
                lblErrors.Text = "";
                needReDraw = false;
            }
        }


        private void btnSetCamera_Click(object sender, EventArgs e)
        {
            double near = Convert.ToDouble(txtNear.Text);
            double far = Convert.ToDouble(txtFar.Text);
            if (near < 0 || far <= 0)
            {
                lblErrors.Text += "Ближнаяя и дальняя плоскости отсечения должны быть положительными. \t";
                return;
            }
            if (near >= far)
            {
                lblErrors.Text += "Ближняя плоскость должна быть меньше дальней. \t";
                return;
            }
            engine.setCameraPosition(Convert.ToDouble(txtPositionX.Text), Convert.ToDouble(txtPositionY.Text), Convert.ToDouble(txtPositionZ.Text));
            engine.setCameraTarget(Convert.ToDouble(txtTargetX.Text), Convert.ToDouble(txtTargetY.Text), Convert.ToDouble(txtTargetZ.Text));
            engine.setCameraNearPlane(near);
            engine.setCameraFarPlane(far);
            UpdateImg();
        }


        // Функция возвращает true если все параметры верны и false иначе
        private bool ValidateParameters(double stairsTubeLenght, double stairsTubeWidth, double stairsTubeHeight, int stairsCount, double stairsRadius, double stairsLenght, double barTubeWidth, double barTubeHeight, double barRadius, double barLenght)
        {
            bool result = true;
            errors = "";

            if (stairsTubeLenght <= 0 || stairsTubeWidth <= 0 || stairsTubeHeight <= 0 || stairsCount <= 0 || stairsRadius <= 0 || stairsLenght <= 0 || barTubeWidth <= 0 || barTubeHeight <= 0 || barRadius <= 0 || barLenght <= 0)
            {
                errors += "Все параметры должны быть положительными. \t";
                result = false;
            }

            if (stairsTubeHeight < 10*stairsTubeLenght || stairsTubeHeight < 10*stairsTubeWidth)
            {
                errors += "Высота основания лестницы должна быть в 10 или более раз больше длины и ширины. \t";
                result = false;
            }
            if (stairsCount <= 0)
            {
                errors += "Количество ступенек должно быть целым положительным числом. \t";
                result = false;
            }
            if (stairsCount > stairsTubeHeight / (4 * stairsRadius))
            {
                errors += "Максимальное количество ступенек должно быть <= (высота основания/4*радиус ступеньки). \t";
                result = false;
            }
            if (2 * stairsRadius > stairsTubeWidth)
            {
                errors += "Радиус ступеньки должен быть <= (ширина основания/2). \t";
                result = false;
            }
            if (stairsLenght <= 2 * stairsRadius)
            {
                errors += "Длина ступеньки должна быть больше ее диаметра. \t";
                result = false;
            }
            if (barLenght < stairsLenght)
            {
                errors += "Длина турника должна быть больше длины ступеньки лестницы. \t";
                result = false;
            }
            if (2 * barRadius > stairsTubeLenght)
            {
                errors += "Радиус турника должен быть <= (длина основания/2). \t";
                result = false;
            }
            if (barLenght <= 2*barRadius)
            {
                errors += "Длина турника должна быть больше его диаметра. \t";
                result = false;
            }
            if (barTubeHeight > stairsTubeHeight)
            {
                errors += "Высота основания турника должна быть <= высота основания лестницы. \t";
                result = false;
            }
            if (barTubeHeight < 10 * barTubeWidth)
            {
                errors += "Высота основания турника должна быть в 10 или более раз больше ширины.\t";
                result = false;
            }

            return result; ;
        }

        private void UpdateImg()
        {
            // Удаляем текущие выбранные объекты
            engine.Clear();

            // Обновляем список объектов в движке
            foreach (SportFrame sport in sportFrames)
            {
                engine.addObjects(sport.GetObjects());
            }

            /*
            if (cbObjects.SelectedIndex == 0)
            {
                // Обновляем список объектов в движке
                foreach (SportFrame sport in sportFrames)
                {
                    engine.addObjects(sport.GetObjects());
                }
            }
            else
            {
                // Добавляем выбранный объект
                engine.addObjects(sportFrames[cbObjects.SelectedIndex - 1].GetObjects());
            }
            */
            needReDraw = true;
        }

        private void ParallelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SetProecType(Render.ProecType.Parallel);
            needReDraw = true;
        }

        private void CentralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SetProecType(Render.ProecType.Central);
            needReDraw = true;
        }

        private void edgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SetViewType(Render.ViewType.Edges);
            needReDraw = true;
        }

        private void facesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engine.SetViewType(Render.ViewType.Faces);
            needReDraw = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void rotateType_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            if (((RadioButton)sender).Tag.ToString() == "Own")
                engine.SetRotateType(Render.RotateType.Own);
            else
                engine.SetRotateType(Render.RotateType.Global);
        }

        #region Field checks
        ErrorProvider provider = new ErrorProvider();
        private void txtRotateX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try{
                Double.Parse(txtRotateX.Text);
                provider.SetError(txtRotateX, String.Empty);
            }
            catch
            {
                provider.SetError(txtRotateX, "Неверное значение угла поворота по X!");
                e.Cancel = true;
            }                
        }

        private void txtRotateY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtRotateY.Text);
                provider.SetError(txtRotateY, String.Empty);
            }
            catch
            {
                provider.SetError(txtRotateY, "Неверное значение угла поворота  по Y!");
                e.Cancel = true;
            }  
        }

        private void txtRotateZ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtRotateZ.Text);
                provider.SetError(txtRotateZ, String.Empty);
            }
            catch
            {
                provider.SetError(txtRotateZ, "Неверное значение угла поворота  по Z!");
                e.Cancel = true;
            }  
        }

        private void txtMoveX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtMoveX.Text);
                provider.SetError(txtMoveX, String.Empty);
            }
            catch
            {
                provider.SetError(txtMoveX, "Неверное значение величины переноса  по X!");
                e.Cancel = true;
            }  
        }

        private void txtMoveY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtMoveY.Text);
                provider.SetError(txtMoveY, String.Empty);
            }
            catch
            {
                provider.SetError(txtMoveY, "Неверное значение величины переноса  по Y!");
                e.Cancel = true;
            }  
        }

        private void txtMoveZ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtMoveZ.Text);
                provider.SetError(txtMoveZ, String.Empty);
            }
            catch
            {
                provider.SetError(txtMoveZ, "Неверное значение величины переноса  по Z!");
                e.Cancel = true;
            }  
        }

        private void txtScaleX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtScaleX.Text);
                provider.SetError(txtScaleX, String.Empty);
            }
            catch
            {
                provider.SetError(txtScaleX, "Неверное значение коеффициента масштабирования  по X!");
                e.Cancel = true;
            }  
        }

        private void txtScaleY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtScaleY.Text);
                provider.SetError(txtScaleY, String.Empty);
            }
            catch
            {
                provider.SetError(txtScaleY, "Неверное значение коеффициента масштабирования по Y!");
                e.Cancel = true;
            }
        }

        private void txtScaleZ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtScaleZ.Text);
                provider.SetError(txtScaleZ, String.Empty);
            }
            catch
            {
                provider.SetError(txtScaleZ, "Неверное значение коеффициента масштабирования по Z!");
                e.Cancel = true;
            }
        }

        private void txtPositionX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtPositionX.Text);
                provider.SetError(txtPositionX, String.Empty);
            }
            catch
            {
                provider.SetError(txtPositionX, "Неверное значение позиции камеры по X!");
                e.Cancel = true;
            }
        }

        private void txtPositionY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtPositionY.Text);
                provider.SetError(txtPositionY, String.Empty);
            }
            catch
            {
                provider.SetError(txtPositionY, "Неверное значение позиции камеры по Y!");
                e.Cancel = true;
            }
        }

        private void txtPositionZ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtPositionZ.Text);
                provider.SetError(txtPositionZ, String.Empty);
            }
            catch
            {
                provider.SetError(txtPositionZ, "Неверное значение позиции камеры по Z!");
                e.Cancel = true;
            }
        }

        private void txtTargetX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtTargetX.Text);
                provider.SetError(txtTargetX, String.Empty);
            }
            catch
            {
                provider.SetError(txtTargetX, "Неверное значение цели камеры по X!");
                e.Cancel = true;
            }
        }

        private void txtTargetY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtTargetY.Text);
                provider.SetError(txtTargetY, String.Empty);
            }
            catch
            {
                provider.SetError(txtTargetY, "Неверное значение цели камеры по Y!");
                e.Cancel = true;
            }
        }

        private void txtTargetZ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtTargetZ.Text);
                provider.SetError(txtTargetZ, String.Empty);
            }
            catch
            {
                provider.SetError(txtTargetZ, "Неверное значение цели камеры по X!");
                e.Cancel = true;
            }
        }

        private void txtNear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtNear.Text);
                provider.SetError(txtNear, String.Empty);
            }
            catch
            {
                provider.SetError(txtNear, "Неверное значение ближнего экрана!");
                e.Cancel = true;
            }
        }

        private void txtFar_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtFar.Text);
                provider.SetError(txtFar, String.Empty);
            }
            catch
            {
                provider.SetError(txtFar, "Неверное значение дальнего экрана!");
                e.Cancel = true;
            }
        }

        #endregion

        // Счетчик объектов. Необходим для именования.
        private int objectCounter = 1;

        private void btnAddNewObject_Click(object sender, EventArgs e)
        {
            
            Point3D basepoint = new Point3D(Convert.ToDouble(txtObjPointX.Text), Convert.ToDouble(txtObjPointY.Text), Convert.ToDouble(txtObjPointZ.Text));

            double tubeLenght = Convert.ToDouble(txtStairsTubeLenght.Text);
            double stairsTubeWidth = Convert.ToDouble(txtStairsTubeWidth.Text);
            double stairsTubeHeight = Convert.ToDouble(txtStairsTubeHeight.Text);
            int stairsCount = Convert.ToInt32(txtStairsCount.Text);
            double stairsRadius = Convert.ToDouble(txtStairsRadius.Text);
            double stairsLenght = Convert.ToDouble(txtStairsLenght.Text);
            double barTubeWidth = Convert.ToDouble(txtBarTubeWidth.Text);
            double barTubeHeight = Convert.ToDouble(txtBarTubeHeight.Text);
            double barRadius = Convert.ToDouble(txtBarRadius.Text);
            double barLenght = Convert.ToDouble(txtBarLenght.Text);

            // Если какой-либо параметр неправильный - выходим из функции
            if (!ValidateParameters(tubeLenght, stairsTubeWidth, stairsTubeHeight, stairsCount, stairsRadius, stairsLenght, barTubeWidth, barTubeHeight, barRadius, barLenght))
            {
                lblErrors.Text = errors;
                return;
            }

            // Создаем наш объект
            // Тут должны задаваться и передаваться параметры объекта
            SportFrame sport = new SportFrame(basepoint,tubeLenght, stairsTubeWidth, stairsTubeHeight, stairsCount, stairsRadius,stairsLenght, barTubeWidth, barTubeHeight, barRadius, barLenght);
            
            // Устанавливаем id для фигуры и ее составляющих
            sport.setID(objectCounter);

            // Добавили объект в список
            sportFrames.Add(sport);

            if (Intersection())
            {
                sportFrames.Remove(sport);
                MessageBox.Show("Твердотельные объекты не могут пересекаться! Объект не создан!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Добавляем объекты в движок
            engine.addObjects(sport.GetObjects());

            // Добавляем объект в комбобокс
            cbObjects.Items.Add("object_" + objectCounter++);

            // Перерисовываем изображение
            needReDraw = true;
        }

        private void btnRemoveObject_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedIndex == 0)
            {
                lblErrors.Text = "Выберете объект для удаления!";
                return;
            }

            // Удаляем объект
            sportFrames.RemoveAt(cbObjects.SelectedIndex - 1);

            // Удаляем из комбобокса
            int old_selected = cbObjects.SelectedIndex;
            cbObjects.Items.RemoveAt(old_selected);
            cbObjects.SelectedIndex = old_selected - 1;

            // Обновляем картинку и список
            UpdateImg();
        }
        #region validating
        private void txtObjPointX_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtObjPointX.Text);
                provider.SetError(txtObjPointX, String.Empty);
            }
            catch
            {
                provider.SetError(txtObjPointX, "Неверное значение базовой точки объекта по Х!");
                e.Cancel = true;
            }
        }

        private void txtObjPointY_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtObjPointY.Text);
                provider.SetError(txtObjPointY, String.Empty);
            }
            catch
            {
                provider.SetError(txtObjPointY, "Неверное значение базовой точки по объекта Y!");
                e.Cancel = true;
            }
        }

        private void txtObjPointZ_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtObjPointZ.Text);
                provider.SetError(txtObjPointZ, String.Empty);
            }
            catch
            {
                provider.SetError(txtObjPointZ, "Неверное значение базовой точки по объекта Z!");
                e.Cancel = true;
            }
        }

        private void txtStairsTubeLenght_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtStairsTubeLenght.Text);
                provider.SetError(txtStairsTubeLenght, String.Empty);
            }
            catch
            {
                provider.SetError(txtStairsTubeLenght, "Неверное значение длины основания!");
                e.Cancel = true;
            }
        }

        private void txtStairsTubeWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtStairsTubeWidth.Text);
                provider.SetError(txtStairsTubeWidth, String.Empty);
            }
            catch
            {
                provider.SetError(txtStairsTubeWidth, "Неверное значение ширины основания лестницы!");
                e.Cancel = true;
            }
        }

        private void txtStairsTubeHeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtStairsTubeHeight.Text);
                provider.SetError(txtStairsTubeHeight, String.Empty);
            }
            catch
            {
                provider.SetError(txtStairsTubeHeight, "Неверное значение высоты основания лестницы!");
                e.Cancel = true;
            }
        }

        private void txtStairsCount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Int32.Parse(txtStairsCount.Text);
                provider.SetError(txtStairsCount, String.Empty);
            }
            catch
            {
                provider.SetError(txtStairsCount, "Неверное значение количества ступенек!");
                e.Cancel = true;
            }
        }

        private void txtStairsRadius_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtStairsRadius.Text);
                provider.SetError(txtStairsRadius, String.Empty);
            }
            catch
            {
                provider.SetError(txtStairsRadius, "Неверное значение радиуса ступеньки!");
                e.Cancel = true;
            }
        }

        private void txtStairsLenght_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtStairsLenght.Text);
                provider.SetError(txtStairsLenght, String.Empty);
            }
            catch
            {
                provider.SetError(txtStairsLenght, "Неверное значение длины ступеньки!");
                e.Cancel = true;
            }
        }

        private void txtBarTubeWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtBarTubeWidth.Text);
                provider.SetError(txtBarTubeWidth, String.Empty);
            }
            catch
            {
                provider.SetError(txtBarTubeWidth, "Неверное значение ширины основания турника!");
                e.Cancel = true;
            }
        }

        private void txtBarTubeHeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtBarTubeHeight.Text);
                provider.SetError(txtBarTubeHeight, String.Empty);
            }
            catch
            {
                provider.SetError(txtBarTubeHeight, "Неверное значение высоты основания турника!");
                e.Cancel = true;
            }
        }

        private void txtBarRadius_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtBarRadius.Text);
                provider.SetError(txtBarRadius, String.Empty);
            }
            catch
            {
                provider.SetError(txtBarRadius, "Неверное значение радиуса турника!");
                e.Cancel = true;
            }
        }

        private void txtBarLenght_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Double.Parse(txtBarLenght.Text);
                provider.SetError(txtBarLenght, String.Empty);
            }
            catch
            {
                provider.SetError(txtBarLenght, "Неверное значение длины турника!");
                e.Cancel = true;
            }
        }
        #endregion 
        private void btnRotate_Click(object sender, EventArgs e)
        {
            UpdateEngine();
            engine.setRotate(Convert.ToDouble(txtRotateX.Text), Convert.ToDouble(txtRotateY.Text), Convert.ToDouble(txtRotateZ.Text));
            if (Intersection())
            {
                engine.setRotate(-Convert.ToDouble(txtRotateX.Text), -Convert.ToDouble(txtRotateY.Text), -Convert.ToDouble(txtRotateZ.Text));
                MessageBox.Show("Твердотельные объекты не могут пересекаться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateImg();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            UpdateEngine();
            engine.setMove(Convert.ToDouble(txtMoveX.Text), Convert.ToDouble(txtMoveY.Text), Convert.ToDouble(txtMoveZ.Text));
            if (Intersection())
            {
                engine.setMove(-Convert.ToDouble(txtMoveX.Text), -Convert.ToDouble(txtMoveY.Text), -Convert.ToDouble(txtMoveZ.Text));
                MessageBox.Show("Твердотельные объекты не могут пересекаться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateImg();
        }

        private void btnMirror_Click(object sender, EventArgs e)
        {
            UpdateEngine();
            engine.setMirror(chbMirrorX.Checked, chbMirrorY.Checked, chbMirrorZ.Checked);
            UpdateImg();
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            UpdateEngine();
            engine.setScale(Convert.ToDouble(txtScaleX.Text), Convert.ToDouble(txtScaleY.Text), Convert.ToDouble(txtScaleZ.Text));
            if (Intersection())
            {
                engine.setScale(1/Convert.ToDouble(txtScaleX.Text), 1/Convert.ToDouble(txtScaleY.Text), 1/Convert.ToDouble(txtScaleZ.Text));
                MessageBox.Show("Твердотельные объекты не могут пересекаться!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateImg();
        }

        private void UpdateEngine()
        {
            engine.Clear();
            if (cbObjects.SelectedIndex == 0)
            {
                // Обновляем список объектов в движке
                foreach (SportFrame sport in sportFrames)
                {
                    engine.addObjects(sport.GetObjects());
                }
            }
            else
            {
                // Добавляем выбранный объект
                engine.addObjects(sportFrames[cbObjects.SelectedIndex - 1].GetObjects());
            }
        }

        // Запуск панорамирования
        private void bntPlay_Click(object sender, EventArgs e)
        {
            panorama = true;
        }

        // Остановка панорамирования
        private void btnStop_Click(object sender, EventArgs e)
        {
            panorama = false;
            UpdateImg();
            needReDraw = true;
        }

        // Таймер панорамирования
        private void panoramaTimer_Tick(object sender, EventArgs e)
        {
            if (panorama)
            {
                if (cbObjects.SelectedIndex == 0)
                {
                    /*
                    btnStop_Click(null, null);
                    MessageBox.Show("Выберите один объект для панорамирования!");
                    return;
                     */
                    
                    engine.Clear();
                    engine.rotateCamera(new Vector3D(0, 1, 0), new Point3D());
                    UpdateEngine();
                    UpdateImg();
                    
                }
                else
                {
                    engine.Clear();
                    // Добавляем выбранный объект
                    engine.addObjects(sportFrames[cbObjects.SelectedIndex - 1].GetObjects());

                    // Вращаем камеру вокруг выбранного объекта
                    engine.rotateCamera(new Vector3D(0, 1, 0), sportFrames[cbObjects.SelectedIndex - 1].getCenter());
                }

                //Записываем цель камеры
                txtTargetX.Text = engine.getCameraTarget().X.ToString();
                txtTargetY.Text = engine.getCameraTarget().Y.ToString();
                txtTargetZ.Text = engine.getCameraTarget().Z.ToString();

                // Записываем позицию камеры в текстбокс
                txtPositionX.Text = engine.getCameraPosition().X.ToString();
                txtPositionY.Text = engine.getCameraPosition().Y.ToString();
                txtPositionZ.Text = engine.getCameraPosition().Z.ToString();

                // Перерисовать
                needReDraw = true;
            }
        }

        public bool Intersection()
        {
            for (int i = 0; i < sportFrames.Count; i++)
            {
                for (int j = i + 1; j < sportFrames.Count; j++)
                {
                    Vector3D distance = new Vector3D(sportFrames[i].getCenter(), sportFrames[j].getCenter());
                    if (distance.Length() < (sportFrames[i].getRadius() + sportFrames[j].getRadius()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void FileMenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName);
                writer.WriteLine("Точка положения камеры: " + engine.getCameraPosition().X.ToString() + "; " + engine.getCameraPosition().Y.ToString() + "; " + engine.getCameraPosition().Z.ToString());
                writer.WriteLine("Точка цели камеры: " + engine.getCameraTarget().X.ToString() + "; " + engine.getCameraTarget().Y.ToString() + "; " + engine.getCameraTarget().Z.ToString());
                writer.WriteLine("Ближний план камеры: " + engine.getCameraNearPlane().ToString());
                writer.WriteLine("Дальний план камеры: " + engine.getCameraFarPlane().ToString());
                writer.WriteLine("Количество объектов: " + sportFrames.Count);
                for (int i = 0; i < sportFrames.Count; i++)
                {
                    writer.WriteLine("\tОбъект № " + (i + 1));
                    writer.WriteLine("Базовая точка: " + sportFrames[i].getBasePoint().X.ToString() + "; " + sportFrames[i].getBasePoint().Y.ToString() + "; " + sportFrames[i].getBasePoint().Z.ToString());
                    writer.WriteLine("Длина основания: " + sportFrames[i].getStairsTubeLenght().ToString());
                    writer.WriteLine("Ширина основания лестницы: " + sportFrames[i].getStairsTubeWidth().ToString());
                    writer.WriteLine("Высота основания лестницы: " + sportFrames[i].getStairsTubeHeight().ToString());
                    writer.WriteLine("Количество ступенек: " + sportFrames[i].getStairsCount().ToString());
                    writer.WriteLine("Радиус ступенек: " + sportFrames[i].getStairsRadius().ToString());
                    writer.WriteLine("Длина ступенек: " + sportFrames[i].getStairsLenght().ToString());
                    writer.WriteLine("Ширина основания турника: " + sportFrames[i].getBarTubeWidth().ToString());
                    writer.WriteLine("Высота основания турника: " + sportFrames[i].getBarTubeHeight().ToString());
                    writer.WriteLine("Радиус турника: " + sportFrames[i].getBarRadius().ToString());
                    writer.WriteLine("Длина турника: " + sportFrames[i].getBarLenght().ToString());
                    writer.WriteLine("Матрица преобразований: ");
                    for (int j = 0; j < 4; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            writer.Write(sportFrames[i].getMatrix().Data[j, k].ToString() + " ");
                        }
                        writer.Write("\n");
                    }
                }
                writer.Close();
            }
        }

        private void FileMenuLoad_Click(object sender, EventArgs e)
        {
            if (sportFrames.Count > 0)
            {
                lblErrors.Text = "Невозможно загрузить из файла т.к. текущая сцена не пуста.";
                return;
            }
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader reader = new StreamReader(dialog.FileName);
                    string[] buffer;


                    // Читаем положение камеры
                    buffer = reader.ReadLine().Split(':');
                    buffer = buffer[1].Split(';');
                    txtPositionX.Text = buffer[0];
                    txtPositionY.Text = buffer[1];
                    txtPositionZ.Text = buffer[2];

                    // Читаем цель камеры
                    buffer = reader.ReadLine().Split(':');
                    buffer = buffer[1].Split(';');
                    txtTargetX.Text = buffer[0];
                    txtTargetY.Text = buffer[1];
                    txtTargetZ.Text = buffer[2];

                    // Читаем ближний план камеры
                    buffer = reader.ReadLine().Split(':');
                    txtNear.Text = buffer[1];

                    // Читаем дальний план
                    buffer = reader.ReadLine().Split(':');
                    txtFar.Text = buffer[1];

                    // Читаем количество ступенек
                    int count = Convert.ToInt32(reader.ReadLine().Split(':')[1]);
                    for (int i = 0; i < count; i++)
                    {
                        reader.ReadLine();

                        // Читаем базовую точку
                        buffer = reader.ReadLine().Split(':');
                        buffer = buffer[1].Split(';');
                        Point3D basePoint = new Point3D(Convert.ToDouble(buffer[0]), Convert.ToDouble(buffer[1]), Convert.ToDouble(buffer[2]));

                        // Читаем длину основания
                        buffer = reader.ReadLine().Split(':');
                        double tubeLenght = Convert.ToDouble(buffer[1]);

                        // Читаем ширину основания лестницы
                        buffer = reader.ReadLine().Split(':');
                        double stairsTubeWidth = Convert.ToDouble(buffer[1]);

                        // Читаем высоту основания лестницы
                        buffer = reader.ReadLine().Split(':');
                        double stairsTubeHeight = Convert.ToDouble(buffer[1]);

                        // Читаем количество ступенек
                        buffer = reader.ReadLine().Split(':');
                        int stairsCount = Convert.ToInt32(buffer[1]);

                        // Читаем радиус ступеньки
                        buffer = reader.ReadLine().Split(':');
                        double stairsRadius = Convert.ToDouble(buffer[1]);

                        // Читаем длину ступеньки
                        buffer = reader.ReadLine().Split(':');
                        double stairsLenght = Convert.ToDouble(buffer[1]);

                        // Читаем ширину основания турника
                        buffer = reader.ReadLine().Split(':');
                        double barTubeWidth = Convert.ToDouble(buffer[1]);

                        // Читаем высоту основания турника
                        buffer = reader.ReadLine().Split(':');
                        double barTubeHeight = Convert.ToDouble(buffer[1]);

                        // Читаем радиус турника
                        buffer = reader.ReadLine().Split(':');
                        double barRadius = Convert.ToDouble(buffer[1]);

                        // Читаем длину турника
                        buffer = reader.ReadLine().Split(':');
                        double barLenght = Convert.ToDouble(buffer[1]);

                        reader.ReadLine(); // Пропускаем строку

                        // Читаем матрицу преобразований
                        Matrix item_matrix = new Matrix();
                        for (int m = 0; m < 4; m++)
                        {
                            buffer = reader.ReadLine().Split(' ');
                            for (int n = 0; n < 4; n++)
                            {
                                item_matrix[m, n] = Convert.ToDouble(buffer[n]);
                            }
                        }

                        // Создаем и добавляем объект
                        SportFrame item = new SportFrame(basePoint, tubeLenght, stairsTubeWidth, stairsTubeHeight, stairsCount, stairsRadius, stairsLenght, barTubeWidth, barTubeHeight, barRadius, barLenght);

                        // Применяю матрицу преобразований НЕ ПРИМЕНЯЕТСЯ!! ПОЧЕМУ??? АААА!!! ПАНИКА!!!
                        item.setMatrix(item_matrix);

                        // Добавляем в список объектов
                        sportFrames.Add(item);


                        // Добавляем объекты в движок
                        engine.addObjects(item.GetObjects());

                        // Добавляем объект в комбобокс
                        cbObjects.Items.Add("object_" + objectCounter++);

                        // Обновляем камеру
                        btnSetCamera_Click(null, null);

                        // Перерисовываем изображение
                        needReDraw = true;
                    }
                }
            }
            catch 
            {
                lblErrors.Text = "Выбран неверный файл сцены.";
            }
        }
    }
}
