namespace DrawingEngine
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.edgesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProecMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.proecMenuParallel = new System.Windows.Forms.ToolStripMenuItem();
            this.proecMenuCentral = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redrawTimer = new System.Windows.Forms.Timer(this.components);
            this.gbCamera = new System.Windows.Forms.GroupBox();
            this.bntPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSetCamera = new System.Windows.Forms.Button();
            this.lblFar = new System.Windows.Forms.Label();
            this.txtFar = new System.Windows.Forms.TextBox();
            this.lblNear = new System.Windows.Forms.Label();
            this.txtNear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTagret = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTargetX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTargetY = new System.Windows.Forms.TextBox();
            this.txtTargetZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPositionX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPositionY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPositionZ = new System.Windows.Forms.TextBox();
            this.txtRotateX = new System.Windows.Forms.TextBox();
            this.txtRotateY = new System.Windows.Forms.TextBox();
            this.txtRotateZ = new System.Windows.Forms.TextBox();
            this.lblRotate = new System.Windows.Forms.Label();
            this.lblRotateX = new System.Windows.Forms.Label();
            this.lblRotateY = new System.Windows.Forms.Label();
            this.lblRotateZ = new System.Windows.Forms.Label();
            this.txtMoveX = new System.Windows.Forms.TextBox();
            this.txtMoveY = new System.Windows.Forms.TextBox();
            this.txtMoveZ = new System.Windows.Forms.TextBox();
            this.lblMove = new System.Windows.Forms.Label();
            this.lblMoveX = new System.Windows.Forms.Label();
            this.lblMoveY = new System.Windows.Forms.Label();
            this.lblMoveZ = new System.Windows.Forms.Label();
            this.lblMirror = new System.Windows.Forms.Label();
            this.txtScaleX = new System.Windows.Forms.TextBox();
            this.txtScaleY = new System.Windows.Forms.TextBox();
            this.txtScaleZ = new System.Windows.Forms.TextBox();
            this.lblScale = new System.Windows.Forms.Label();
            this.lblScaleX = new System.Windows.Forms.Label();
            this.lblScaleY = new System.Windows.Forms.Label();
            this.lblScaleZ = new System.Windows.Forms.Label();
            this.chbMirrorX = new System.Windows.Forms.CheckBox();
            this.chbMirrorY = new System.Windows.Forms.CheckBox();
            this.chbMirrorZ = new System.Windows.Forms.CheckBox();
            this.rbRotateTypeGlobal = new System.Windows.Forms.RadioButton();
            this.rbRotateTypeOwn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
            this.cbObjects = new System.Windows.Forms.ComboBox();
            this.btnAddNewObject = new System.Windows.Forms.Button();
            this.btnRemoveObject = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBarLenght = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBarRadius = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtBarTubeHeight = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBarTubeWidth = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtStairsLenght = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtStairsRadius = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStairsCount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtStairsTubeHeight = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStairsTubeWidth = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStairsTubeLenght = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObjPointZ = new System.Windows.Forms.TextBox();
            this.txtObjPointY = new System.Windows.Forms.TextBox();
            this.txtObjPointX = new System.Windows.Forms.TextBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.panoramaTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbCamera.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(171, 36);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(516, 418);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.viewMenu,
            this.ProecMenu,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuSave,
            this.FileMenuLoad,
            this.FileMenuExit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(48, 20);
            this.FileMenu.Text = "Файл";
            // 
            // FileMenuSave
            // 
            this.FileMenuSave.Name = "FileMenuSave";
            this.FileMenuSave.Size = new System.Drawing.Size(132, 22);
            this.FileMenuSave.Text = "Сохранить";
            this.FileMenuSave.Click += new System.EventHandler(this.FileMenuSave_Click);
            // 
            // FileMenuLoad
            // 
            this.FileMenuLoad.Name = "FileMenuLoad";
            this.FileMenuLoad.Size = new System.Drawing.Size(132, 22);
            this.FileMenuLoad.Text = "Загрузить";
            this.FileMenuLoad.Click += new System.EventHandler(this.FileMenuLoad_Click);
            // 
            // FileMenuExit
            // 
            this.FileMenuExit.Name = "FileMenuExit";
            this.FileMenuExit.Size = new System.Drawing.Size(132, 22);
            this.FileMenuExit.Text = "Выход";
            this.FileMenuExit.Click += new System.EventHandler(this.FileMenuExit_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgesToolStripMenuItem,
            this.facesToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(39, 20);
            this.viewMenu.Text = "Вид";
            // 
            // edgesToolStripMenuItem
            // 
            this.edgesToolStripMenuItem.Name = "edgesToolStripMenuItem";
            this.edgesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.edgesToolStripMenuItem.Text = "Рёбра";
            this.edgesToolStripMenuItem.Click += new System.EventHandler(this.edgesToolStripMenuItem_Click);
            // 
            // facesToolStripMenuItem
            // 
            this.facesToolStripMenuItem.Name = "facesToolStripMenuItem";
            this.facesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.facesToolStripMenuItem.Text = "Грани";
            this.facesToolStripMenuItem.Click += new System.EventHandler(this.facesToolStripMenuItem_Click);
            // 
            // ProecMenu
            // 
            this.ProecMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proecMenuParallel,
            this.proecMenuCentral});
            this.ProecMenu.Name = "ProecMenu";
            this.ProecMenu.Size = new System.Drawing.Size(108, 20);
            this.ProecMenu.Text = "Проецирование";
            // 
            // proecMenuParallel
            // 
            this.proecMenuParallel.Name = "proecMenuParallel";
            this.proecMenuParallel.Size = new System.Drawing.Size(155, 22);
            this.proecMenuParallel.Text = "Параллельное";
            this.proecMenuParallel.Click += new System.EventHandler(this.ParallelToolStripMenuItem_Click);
            // 
            // proecMenuCentral
            // 
            this.proecMenuCentral.Name = "proecMenuCentral";
            this.proecMenuCentral.Size = new System.Drawing.Size(155, 22);
            this.proecMenuCentral.Text = "Центральное";
            this.proecMenuCentral.Click += new System.EventHandler(this.CentralToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // redrawTimer
            // 
            this.redrawTimer.Enabled = true;
            this.redrawTimer.Interval = 10;
            this.redrawTimer.Tick += new System.EventHandler(this.redrawTimer_Tick);
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.bntPlay);
            this.gbCamera.Controls.Add(this.btnStop);
            this.gbCamera.Controls.Add(this.btnSetCamera);
            this.gbCamera.Controls.Add(this.lblFar);
            this.gbCamera.Controls.Add(this.txtFar);
            this.gbCamera.Controls.Add(this.lblNear);
            this.gbCamera.Controls.Add(this.txtNear);
            this.gbCamera.Controls.Add(this.label5);
            this.gbCamera.Controls.Add(this.lblTagret);
            this.gbCamera.Controls.Add(this.label7);
            this.gbCamera.Controls.Add(this.txtTargetX);
            this.gbCamera.Controls.Add(this.label8);
            this.gbCamera.Controls.Add(this.txtTargetY);
            this.gbCamera.Controls.Add(this.txtTargetZ);
            this.gbCamera.Controls.Add(this.label1);
            this.gbCamera.Controls.Add(this.lblPosition);
            this.gbCamera.Controls.Add(this.label2);
            this.gbCamera.Controls.Add(this.txtPositionX);
            this.gbCamera.Controls.Add(this.label3);
            this.gbCamera.Controls.Add(this.txtPositionY);
            this.gbCamera.Controls.Add(this.label4);
            this.gbCamera.Controls.Add(this.txtPositionZ);
            this.gbCamera.Location = new System.Drawing.Point(694, 274);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(180, 180);
            this.gbCamera.TabIndex = 38;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Камера";
            // 
            // bntPlay
            // 
            this.bntPlay.Image = ((System.Drawing.Image)(resources.GetObject("bntPlay.Image")));
            this.bntPlay.Location = new System.Drawing.Point(96, 135);
            this.bntPlay.Name = "bntPlay";
            this.bntPlay.Size = new System.Drawing.Size(34, 30);
            this.bntPlay.TabIndex = 58;
            this.bntPlay.UseVisualStyleBackColor = true;
            this.bntPlay.Click += new System.EventHandler(this.bntPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(131, 135);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(34, 30);
            this.btnStop.TabIndex = 57;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSetCamera
            // 
            this.btnSetCamera.Location = new System.Drawing.Point(10, 138);
            this.btnSetCamera.Name = "btnSetCamera";
            this.btnSetCamera.Size = new System.Drawing.Size(69, 23);
            this.btnSetCamera.TabIndex = 39;
            this.btnSetCamera.Text = "Изменить";
            this.btnSetCamera.UseVisualStyleBackColor = true;
            this.btnSetCamera.Click += new System.EventHandler(this.btnSetCamera_Click);
            // 
            // lblFar
            // 
            this.lblFar.AutoSize = true;
            this.lblFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFar.Location = new System.Drawing.Point(95, 111);
            this.lblFar.Name = "lblFar";
            this.lblFar.Size = new System.Drawing.Size(32, 17);
            this.lblFar.TabIndex = 56;
            this.lblFar.Text = "Far";
            // 
            // txtFar
            // 
            this.txtFar.Location = new System.Drawing.Point(130, 110);
            this.txtFar.Name = "txtFar";
            this.txtFar.Size = new System.Drawing.Size(35, 20);
            this.txtFar.TabIndex = 55;
            this.txtFar.Text = "5000";
            this.txtFar.Validating += new System.ComponentModel.CancelEventHandler(this.txtFar_Validating);
            // 
            // lblNear
            // 
            this.lblNear.AutoSize = true;
            this.lblNear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNear.Location = new System.Drawing.Point(10, 111);
            this.lblNear.Name = "lblNear";
            this.lblNear.Size = new System.Drawing.Size(43, 17);
            this.lblNear.TabIndex = 54;
            this.lblNear.Text = "Near";
            // 
            // txtNear
            // 
            this.txtNear.Location = new System.Drawing.Point(54, 110);
            this.txtNear.Name = "txtNear";
            this.txtNear.Size = new System.Drawing.Size(35, 20);
            this.txtNear.TabIndex = 53;
            this.txtNear.Text = "50";
            this.txtNear.Validating += new System.ComponentModel.CancelEventHandler(this.txtNear_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Z";
            // 
            // lblTagret
            // 
            this.lblTagret.AutoSize = true;
            this.lblTagret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTagret.Location = new System.Drawing.Point(7, 61);
            this.lblTagret.Name = "lblTagret";
            this.lblTagret.Size = new System.Drawing.Size(46, 17);
            this.lblTagret.TabIndex = 48;
            this.lblTagret.Text = "Цель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Y";
            // 
            // txtTargetX
            // 
            this.txtTargetX.Location = new System.Drawing.Point(25, 80);
            this.txtTargetX.Name = "txtTargetX";
            this.txtTargetX.Size = new System.Drawing.Size(35, 20);
            this.txtTargetX.TabIndex = 46;
            this.txtTargetX.Text = "0";
            this.txtTargetX.Validating += new System.ComponentModel.CancelEventHandler(this.txtTargetX_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "X";
            // 
            // txtTargetY
            // 
            this.txtTargetY.Location = new System.Drawing.Point(77, 80);
            this.txtTargetY.Name = "txtTargetY";
            this.txtTargetY.Size = new System.Drawing.Size(35, 20);
            this.txtTargetY.TabIndex = 47;
            this.txtTargetY.Text = "0";
            this.txtTargetY.Validating += new System.ComponentModel.CancelEventHandler(this.txtTargetY_Validating);
            // 
            // txtTargetZ
            // 
            this.txtTargetZ.Location = new System.Drawing.Point(130, 80);
            this.txtTargetZ.Name = "txtTargetZ";
            this.txtTargetZ.Size = new System.Drawing.Size(35, 20);
            this.txtTargetZ.TabIndex = 49;
            this.txtTargetZ.Text = "0";
            this.txtTargetZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtTargetZ_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Z";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPosition.Location = new System.Drawing.Point(7, 16);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(72, 17);
            this.lblPosition.TabIndex = 40;
            this.lblPosition.Text = "Позиция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Y";
            // 
            // txtPositionX
            // 
            this.txtPositionX.Location = new System.Drawing.Point(25, 35);
            this.txtPositionX.Name = "txtPositionX";
            this.txtPositionX.Size = new System.Drawing.Size(35, 20);
            this.txtPositionX.TabIndex = 39;
            this.txtPositionX.Text = "300";
            this.txtPositionX.Validating += new System.ComponentModel.CancelEventHandler(this.txtPositionX_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "X";
            // 
            // txtPositionY
            // 
            this.txtPositionY.Location = new System.Drawing.Point(77, 35);
            this.txtPositionY.Name = "txtPositionY";
            this.txtPositionY.Size = new System.Drawing.Size(35, 20);
            this.txtPositionY.TabIndex = 40;
            this.txtPositionY.Text = "10";
            this.txtPositionY.Validating += new System.ComponentModel.CancelEventHandler(this.txtPositionY_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Move";
            // 
            // txtPositionZ
            // 
            this.txtPositionZ.Location = new System.Drawing.Point(130, 35);
            this.txtPositionZ.Name = "txtPositionZ";
            this.txtPositionZ.Size = new System.Drawing.Size(35, 20);
            this.txtPositionZ.TabIndex = 41;
            this.txtPositionZ.Text = "-300";
            this.txtPositionZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtPositionZ_Validating);
            // 
            // txtRotateX
            // 
            this.txtRotateX.Location = new System.Drawing.Point(14, 68);
            this.txtRotateX.Name = "txtRotateX";
            this.txtRotateX.Size = new System.Drawing.Size(35, 20);
            this.txtRotateX.TabIndex = 3;
            this.txtRotateX.Text = "0";
            this.txtRotateX.Validating += new System.ComponentModel.CancelEventHandler(this.txtRotateX_Validating);
            // 
            // txtRotateY
            // 
            this.txtRotateY.Location = new System.Drawing.Point(55, 69);
            this.txtRotateY.Name = "txtRotateY";
            this.txtRotateY.Size = new System.Drawing.Size(35, 20);
            this.txtRotateY.TabIndex = 4;
            this.txtRotateY.Text = "0";
            this.txtRotateY.Validating += new System.ComponentModel.CancelEventHandler(this.txtRotateY_Validating);
            // 
            // txtRotateZ
            // 
            this.txtRotateZ.Location = new System.Drawing.Point(96, 68);
            this.txtRotateZ.Name = "txtRotateZ";
            this.txtRotateZ.Size = new System.Drawing.Size(35, 20);
            this.txtRotateZ.TabIndex = 5;
            this.txtRotateZ.Text = "0";
            this.txtRotateZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtRotateZ_Validating);
            // 
            // lblRotate
            // 
            this.lblRotate.AutoSize = true;
            this.lblRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRotate.Location = new System.Drawing.Point(10, 30);
            this.lblRotate.Name = "lblRotate";
            this.lblRotate.Size = new System.Drawing.Size(71, 17);
            this.lblRotate.TabIndex = 6;
            this.lblRotate.Text = "Поворот";
            // 
            // lblRotateX
            // 
            this.lblRotateX.AutoSize = true;
            this.lblRotateX.Location = new System.Drawing.Point(22, 52);
            this.lblRotateX.Name = "lblRotateX";
            this.lblRotateX.Size = new System.Drawing.Size(14, 13);
            this.lblRotateX.TabIndex = 7;
            this.lblRotateX.Text = "X";
            // 
            // lblRotateY
            // 
            this.lblRotateY.AutoSize = true;
            this.lblRotateY.Location = new System.Drawing.Point(65, 52);
            this.lblRotateY.Name = "lblRotateY";
            this.lblRotateY.Size = new System.Drawing.Size(14, 13);
            this.lblRotateY.TabIndex = 8;
            this.lblRotateY.Text = "Y";
            // 
            // lblRotateZ
            // 
            this.lblRotateZ.AutoSize = true;
            this.lblRotateZ.Location = new System.Drawing.Point(107, 52);
            this.lblRotateZ.Name = "lblRotateZ";
            this.lblRotateZ.Size = new System.Drawing.Size(14, 13);
            this.lblRotateZ.TabIndex = 9;
            this.lblRotateZ.Text = "Z";
            // 
            // txtMoveX
            // 
            this.txtMoveX.Location = new System.Drawing.Point(14, 133);
            this.txtMoveX.Name = "txtMoveX";
            this.txtMoveX.Size = new System.Drawing.Size(35, 20);
            this.txtMoveX.TabIndex = 10;
            this.txtMoveX.Text = "0";
            this.txtMoveX.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoveX_Validating);
            // 
            // txtMoveY
            // 
            this.txtMoveY.Location = new System.Drawing.Point(55, 133);
            this.txtMoveY.Name = "txtMoveY";
            this.txtMoveY.Size = new System.Drawing.Size(35, 20);
            this.txtMoveY.TabIndex = 11;
            this.txtMoveY.Text = "0";
            this.txtMoveY.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoveY_Validating);
            // 
            // txtMoveZ
            // 
            this.txtMoveZ.Location = new System.Drawing.Point(96, 133);
            this.txtMoveZ.Name = "txtMoveZ";
            this.txtMoveZ.Size = new System.Drawing.Size(35, 20);
            this.txtMoveZ.TabIndex = 12;
            this.txtMoveZ.Text = "0";
            this.txtMoveZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoveZ_Validating);
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMove.Location = new System.Drawing.Point(10, 97);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(113, 17);
            this.lblMove.TabIndex = 13;
            this.lblMove.Text = "Перемещение";
            // 
            // lblMoveX
            // 
            this.lblMoveX.AutoSize = true;
            this.lblMoveX.Location = new System.Drawing.Point(22, 117);
            this.lblMoveX.Name = "lblMoveX";
            this.lblMoveX.Size = new System.Drawing.Size(14, 13);
            this.lblMoveX.TabIndex = 14;
            this.lblMoveX.Text = "X";
            // 
            // lblMoveY
            // 
            this.lblMoveY.AutoSize = true;
            this.lblMoveY.Location = new System.Drawing.Point(65, 117);
            this.lblMoveY.Name = "lblMoveY";
            this.lblMoveY.Size = new System.Drawing.Size(14, 13);
            this.lblMoveY.TabIndex = 15;
            this.lblMoveY.Text = "Y";
            // 
            // lblMoveZ
            // 
            this.lblMoveZ.AutoSize = true;
            this.lblMoveZ.Location = new System.Drawing.Point(107, 117);
            this.lblMoveZ.Name = "lblMoveZ";
            this.lblMoveZ.Size = new System.Drawing.Size(14, 13);
            this.lblMoveZ.TabIndex = 16;
            this.lblMoveZ.Text = "Z";
            // 
            // lblMirror
            // 
            this.lblMirror.AutoSize = true;
            this.lblMirror.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMirror.Location = new System.Drawing.Point(697, 459);
            this.lblMirror.Name = "lblMirror";
            this.lblMirror.Size = new System.Drawing.Size(92, 17);
            this.lblMirror.TabIndex = 20;
            this.lblMirror.Text = "Отражение";
            this.lblMirror.Visible = false;
            // 
            // txtScaleX
            // 
            this.txtScaleX.Location = new System.Drawing.Point(14, 204);
            this.txtScaleX.Name = "txtScaleX";
            this.txtScaleX.Size = new System.Drawing.Size(35, 20);
            this.txtScaleX.TabIndex = 24;
            this.txtScaleX.Text = "1";
            this.txtScaleX.Validating += new System.ComponentModel.CancelEventHandler(this.txtScaleX_Validating);
            // 
            // txtScaleY
            // 
            this.txtScaleY.Location = new System.Drawing.Point(55, 204);
            this.txtScaleY.Name = "txtScaleY";
            this.txtScaleY.Size = new System.Drawing.Size(35, 20);
            this.txtScaleY.TabIndex = 25;
            this.txtScaleY.Text = "1";
            this.txtScaleY.Validating += new System.ComponentModel.CancelEventHandler(this.txtScaleY_Validating);
            // 
            // txtScaleZ
            // 
            this.txtScaleZ.Location = new System.Drawing.Point(98, 204);
            this.txtScaleZ.Name = "txtScaleZ";
            this.txtScaleZ.Size = new System.Drawing.Size(35, 20);
            this.txtScaleZ.TabIndex = 26;
            this.txtScaleZ.Text = "1";
            this.txtScaleZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtScaleZ_Validating);
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScale.Location = new System.Drawing.Point(10, 166);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(146, 17);
            this.lblScale.TabIndex = 27;
            this.lblScale.Text = "Масштабирование";
            // 
            // lblScaleX
            // 
            this.lblScaleX.AutoSize = true;
            this.lblScaleX.Location = new System.Drawing.Point(22, 187);
            this.lblScaleX.Name = "lblScaleX";
            this.lblScaleX.Size = new System.Drawing.Size(14, 13);
            this.lblScaleX.TabIndex = 28;
            this.lblScaleX.Text = "X";
            // 
            // lblScaleY
            // 
            this.lblScaleY.AutoSize = true;
            this.lblScaleY.Location = new System.Drawing.Point(65, 187);
            this.lblScaleY.Name = "lblScaleY";
            this.lblScaleY.Size = new System.Drawing.Size(14, 13);
            this.lblScaleY.TabIndex = 29;
            this.lblScaleY.Text = "Y";
            // 
            // lblScaleZ
            // 
            this.lblScaleZ.AutoSize = true;
            this.lblScaleZ.Location = new System.Drawing.Point(107, 187);
            this.lblScaleZ.Name = "lblScaleZ";
            this.lblScaleZ.Size = new System.Drawing.Size(14, 13);
            this.lblScaleZ.TabIndex = 30;
            this.lblScaleZ.Text = "Z";
            // 
            // chbMirrorX
            // 
            this.chbMirrorX.AutoSize = true;
            this.chbMirrorX.Location = new System.Drawing.Point(701, 479);
            this.chbMirrorX.Name = "chbMirrorX";
            this.chbMirrorX.Size = new System.Drawing.Size(33, 17);
            this.chbMirrorX.TabIndex = 31;
            this.chbMirrorX.Text = "X";
            this.chbMirrorX.UseVisualStyleBackColor = true;
            this.chbMirrorX.Visible = false;
            // 
            // chbMirrorY
            // 
            this.chbMirrorY.AutoSize = true;
            this.chbMirrorY.Location = new System.Drawing.Point(742, 479);
            this.chbMirrorY.Name = "chbMirrorY";
            this.chbMirrorY.Size = new System.Drawing.Size(33, 17);
            this.chbMirrorY.TabIndex = 32;
            this.chbMirrorY.Text = "Y";
            this.chbMirrorY.UseVisualStyleBackColor = true;
            this.chbMirrorY.Visible = false;
            // 
            // chbMirrorZ
            // 
            this.chbMirrorZ.AutoSize = true;
            this.chbMirrorZ.Location = new System.Drawing.Point(783, 479);
            this.chbMirrorZ.Name = "chbMirrorZ";
            this.chbMirrorZ.Size = new System.Drawing.Size(33, 17);
            this.chbMirrorZ.TabIndex = 33;
            this.chbMirrorZ.Text = "Z";
            this.chbMirrorZ.UseVisualStyleBackColor = true;
            this.chbMirrorZ.Visible = false;
            // 
            // rbRotateTypeGlobal
            // 
            this.rbRotateTypeGlobal.AutoSize = true;
            this.rbRotateTypeGlobal.Checked = true;
            this.rbRotateTypeGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRotateTypeGlobal.Location = new System.Drawing.Point(120, 33);
            this.rbRotateTypeGlobal.Name = "rbRotateTypeGlobal";
            this.rbRotateTypeGlobal.Size = new System.Drawing.Size(55, 17);
            this.rbRotateTypeGlobal.TabIndex = 36;
            this.rbRotateTypeGlobal.TabStop = true;
            this.rbRotateTypeGlobal.Tag = "Global";
            this.rbRotateTypeGlobal.Text = "Global";
            this.rbRotateTypeGlobal.UseVisualStyleBackColor = true;
            this.rbRotateTypeGlobal.Visible = false;
            this.rbRotateTypeGlobal.CheckedChanged += new System.EventHandler(this.rotateType_CheckedChanged);
            // 
            // rbRotateTypeOwn
            // 
            this.rbRotateTypeOwn.AutoSize = true;
            this.rbRotateTypeOwn.BackColor = System.Drawing.SystemColors.Control;
            this.rbRotateTypeOwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbRotateTypeOwn.Location = new System.Drawing.Point(120, 14);
            this.rbRotateTypeOwn.Name = "rbRotateTypeOwn";
            this.rbRotateTypeOwn.Size = new System.Drawing.Size(47, 17);
            this.rbRotateTypeOwn.TabIndex = 37;
            this.rbRotateTypeOwn.Tag = "Own";
            this.rbRotateTypeOwn.Text = "Own";
            this.rbRotateTypeOwn.UseVisualStyleBackColor = false;
            this.rbRotateTypeOwn.Visible = false;
            this.rbRotateTypeOwn.CheckedChanged += new System.EventHandler(this.rotateType_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnScale);
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.btnRotate);
            this.groupBox2.Controls.Add(this.rbRotateTypeOwn);
            this.groupBox2.Controls.Add(this.rbRotateTypeGlobal);
            this.groupBox2.Controls.Add(this.lblScaleZ);
            this.groupBox2.Controls.Add(this.lblScaleY);
            this.groupBox2.Controls.Add(this.lblScaleX);
            this.groupBox2.Controls.Add(this.lblScale);
            this.groupBox2.Controls.Add(this.txtScaleZ);
            this.groupBox2.Controls.Add(this.txtScaleY);
            this.groupBox2.Controls.Add(this.txtScaleX);
            this.groupBox2.Controls.Add(this.lblMoveZ);
            this.groupBox2.Controls.Add(this.lblMoveY);
            this.groupBox2.Controls.Add(this.lblMoveX);
            this.groupBox2.Controls.Add(this.lblMove);
            this.groupBox2.Controls.Add(this.txtMoveZ);
            this.groupBox2.Controls.Add(this.txtMoveY);
            this.groupBox2.Controls.Add(this.txtMoveX);
            this.groupBox2.Controls.Add(this.lblRotateZ);
            this.groupBox2.Controls.Add(this.lblRotateY);
            this.groupBox2.Controls.Add(this.lblRotateX);
            this.groupBox2.Controls.Add(this.lblRotate);
            this.groupBox2.Controls.Add(this.txtRotateZ);
            this.groupBox2.Controls.Add(this.txtRotateY);
            this.groupBox2.Controls.Add(this.txtRotateX);
            this.groupBox2.Location = new System.Drawing.Point(693, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 241);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Преобразования";
            // 
            // btnScale
            // 
            this.btnScale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScale.BackgroundImage")));
            this.btnScale.Location = new System.Drawing.Point(143, 195);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(31, 29);
            this.btnScale.TabIndex = 41;
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnMove
            // 
            this.btnMove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMove.BackgroundImage")));
            this.btnMove.Location = new System.Drawing.Point(143, 124);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(31, 29);
            this.btnMove.TabIndex = 39;
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRotate.BackgroundImage")));
            this.btnRotate.Location = new System.Drawing.Point(143, 59);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(31, 29);
            this.btnRotate.TabIndex = 38;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnMirror
            // 
            this.btnMirror.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMirror.BackgroundImage")));
            this.btnMirror.Location = new System.Drawing.Point(830, 467);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(31, 29);
            this.btnMirror.TabIndex = 40;
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Visible = false;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // cbObjects
            // 
            this.cbObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObjects.FormattingEnabled = true;
            this.cbObjects.Location = new System.Drawing.Point(8, 36);
            this.cbObjects.Name = "cbObjects";
            this.cbObjects.Size = new System.Drawing.Size(157, 21);
            this.cbObjects.TabIndex = 40;
            // 
            // btnAddNewObject
            // 
            this.btnAddNewObject.Location = new System.Drawing.Point(8, 57);
            this.btnAddNewObject.Name = "btnAddNewObject";
            this.btnAddNewObject.Size = new System.Drawing.Size(69, 23);
            this.btnAddNewObject.TabIndex = 41;
            this.btnAddNewObject.Text = "Добавить";
            this.btnAddNewObject.UseVisualStyleBackColor = true;
            this.btnAddNewObject.Click += new System.EventHandler(this.btnAddNewObject_Click);
            // 
            // btnRemoveObject
            // 
            this.btnRemoveObject.Location = new System.Drawing.Point(94, 57);
            this.btnRemoveObject.Name = "btnRemoveObject";
            this.btnRemoveObject.Size = new System.Drawing.Size(71, 23);
            this.btnRemoveObject.TabIndex = 42;
            this.btnRemoveObject.Text = "Удалить";
            this.btnRemoveObject.UseVisualStyleBackColor = true;
            this.btnRemoveObject.Click += new System.EventHandler(this.btnRemoveObject_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBarLenght);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtBarRadius);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtBarTubeHeight);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtBarTubeWidth);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtStairsLenght);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtStairsRadius);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtStairsCount);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtStairsTubeHeight);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtStairsTubeWidth);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtStairsTubeLenght);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtObjPointZ);
            this.groupBox1.Controls.Add(this.txtObjPointY);
            this.groupBox1.Controls.Add(this.txtObjPointX);
            this.groupBox1.Location = new System.Drawing.Point(8, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 367);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры объекта";
            // 
            // txtBarLenght
            // 
            this.txtBarLenght.Location = new System.Drawing.Point(114, 334);
            this.txtBarLenght.Name = "txtBarLenght";
            this.txtBarLenght.Size = new System.Drawing.Size(35, 20);
            this.txtBarLenght.TabIndex = 36;
            this.txtBarLenght.Text = "30";
            this.txtBarLenght.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarLenght_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(6, 337);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 35;
            this.label22.Text = "Длина турника";
            // 
            // txtBarRadius
            // 
            this.txtBarRadius.Location = new System.Drawing.Point(114, 310);
            this.txtBarRadius.Name = "txtBarRadius";
            this.txtBarRadius.Size = new System.Drawing.Size(35, 20);
            this.txtBarRadius.TabIndex = 34;
            this.txtBarRadius.Text = "5";
            this.txtBarRadius.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarRadius_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(6, 313);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Радиус турника";
            // 
            // txtBarTubeHeight
            // 
            this.txtBarTubeHeight.Location = new System.Drawing.Point(113, 282);
            this.txtBarTubeHeight.Name = "txtBarTubeHeight";
            this.txtBarTubeHeight.Size = new System.Drawing.Size(35, 20);
            this.txtBarTubeHeight.TabIndex = 32;
            this.txtBarTubeHeight.Text = "90";
            this.txtBarTubeHeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarTubeHeight_Validating);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(5, 276);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 26);
            this.label20.TabIndex = 31;
            this.label20.Text = "Высота основания \r\nтурника";
            // 
            // txtBarTubeWidth
            // 
            this.txtBarTubeWidth.Location = new System.Drawing.Point(113, 247);
            this.txtBarTubeWidth.Name = "txtBarTubeWidth";
            this.txtBarTubeWidth.Size = new System.Drawing.Size(35, 20);
            this.txtBarTubeWidth.TabIndex = 30;
            this.txtBarTubeWidth.Text = "9";
            this.txtBarTubeWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtBarTubeWidth_Validating);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(5, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 26);
            this.label21.TabIndex = 29;
            this.label21.Text = "Ширина основания \r\nтурника";
            // 
            // txtStairsLenght
            // 
            this.txtStairsLenght.Location = new System.Drawing.Point(114, 220);
            this.txtStairsLenght.Name = "txtStairsLenght";
            this.txtStairsLenght.Size = new System.Drawing.Size(35, 20);
            this.txtStairsLenght.TabIndex = 28;
            this.txtStairsLenght.Text = "20";
            this.txtStairsLenght.Validating += new System.ComponentModel.CancelEventHandler(this.txtStairsLenght_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(6, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Длина ступеньки";
            // 
            // txtStairsRadius
            // 
            this.txtStairsRadius.Location = new System.Drawing.Point(114, 196);
            this.txtStairsRadius.Name = "txtStairsRadius";
            this.txtStairsRadius.Size = new System.Drawing.Size(35, 20);
            this.txtStairsRadius.TabIndex = 26;
            this.txtStairsRadius.Text = "4";
            this.txtStairsRadius.Validating += new System.ComponentModel.CancelEventHandler(this.txtStairsRadius_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(6, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Радиус ступеньки";
            // 
            // txtStairsCount
            // 
            this.txtStairsCount.Location = new System.Drawing.Point(114, 173);
            this.txtStairsCount.Name = "txtStairsCount";
            this.txtStairsCount.Size = new System.Drawing.Size(35, 20);
            this.txtStairsCount.TabIndex = 24;
            this.txtStairsCount.Text = "6";
            this.txtStairsCount.Validating += new System.ComponentModel.CancelEventHandler(this.txtStairsCount_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Число ступенек";
            // 
            // txtStairsTubeHeight
            // 
            this.txtStairsTubeHeight.Location = new System.Drawing.Point(114, 148);
            this.txtStairsTubeHeight.Name = "txtStairsTubeHeight";
            this.txtStairsTubeHeight.Size = new System.Drawing.Size(35, 20);
            this.txtStairsTubeHeight.TabIndex = 22;
            this.txtStairsTubeHeight.Text = "120";
            this.txtStairsTubeHeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtStairsTubeHeight_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 26);
            this.label16.TabIndex = 21;
            this.label16.Text = "Высота основания \r\nлестницы";
            // 
            // txtStairsTubeWidth
            // 
            this.txtStairsTubeWidth.Location = new System.Drawing.Point(114, 113);
            this.txtStairsTubeWidth.Name = "txtStairsTubeWidth";
            this.txtStairsTubeWidth.Size = new System.Drawing.Size(35, 20);
            this.txtStairsTubeWidth.TabIndex = 20;
            this.txtStairsTubeWidth.Text = "10";
            this.txtStairsTubeWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtStairsTubeWidth_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 26);
            this.label15.TabIndex = 19;
            this.label15.Text = "Ширина основания \r\nлестницы";
            // 
            // txtStairsTubeLenght
            // 
            this.txtStairsTubeLenght.Location = new System.Drawing.Point(114, 83);
            this.txtStairsTubeLenght.Name = "txtStairsTubeLenght";
            this.txtStairsTubeLenght.Size = new System.Drawing.Size(35, 20);
            this.txtStairsTubeLenght.TabIndex = 18;
            this.txtStairsTubeLenght.Text = "10";
            this.txtStairsTubeLenght.Validating += new System.ComponentModel.CancelEventHandler(this.txtStairsTubeLenght_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Длина основания";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Базовая точка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "X";
            // 
            // txtObjPointZ
            // 
            this.txtObjPointZ.Location = new System.Drawing.Point(98, 53);
            this.txtObjPointZ.Name = "txtObjPointZ";
            this.txtObjPointZ.Size = new System.Drawing.Size(35, 20);
            this.txtObjPointZ.TabIndex = 12;
            this.txtObjPointZ.Text = "-100";
            this.txtObjPointZ.Validating += new System.ComponentModel.CancelEventHandler(this.txtObjPointZ_Validating);
            // 
            // txtObjPointY
            // 
            this.txtObjPointY.Location = new System.Drawing.Point(57, 53);
            this.txtObjPointY.Name = "txtObjPointY";
            this.txtObjPointY.Size = new System.Drawing.Size(35, 20);
            this.txtObjPointY.TabIndex = 11;
            this.txtObjPointY.Text = "-100";
            this.txtObjPointY.Validating += new System.ComponentModel.CancelEventHandler(this.txtObjPointY_Validating);
            // 
            // txtObjPointX
            // 
            this.txtObjPointX.Location = new System.Drawing.Point(16, 53);
            this.txtObjPointX.Name = "txtObjPointX";
            this.txtObjPointX.Size = new System.Drawing.Size(35, 20);
            this.txtObjPointX.TabIndex = 10;
            this.txtObjPointX.Text = "-100";
            this.txtObjPointX.Validating += new System.ComponentModel.CancelEventHandler(this.txtObjPointX_Validating);
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(15, 457);
            this.lblErrors.MaximumSize = new System.Drawing.Size(860, 0);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 13);
            this.lblErrors.TabIndex = 49;
            // 
            // panoramaTimer
            // 
            this.panoramaTimer.Enabled = true;
            this.panoramaTimer.Interval = 10;
            this.panoramaTimer.Tick += new System.EventHandler(this.panoramaTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.btnMirror);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveObject);
            this.Controls.Add(this.btnAddNewObject);
            this.Controls.Add(this.cbObjects);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chbMirrorZ);
            this.Controls.Add(this.gbCamera);
            this.Controls.Add(this.chbMirrorY);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chbMirrorX);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.lblMirror);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Графический редактор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbCamera.ResumeLayout(false);
            this.gbCamera.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuSave;
        private System.Windows.Forms.ToolStripMenuItem FileMenuLoad;
        private System.Windows.Forms.ToolStripMenuItem FileMenuExit;
        private System.Windows.Forms.Timer redrawTimer;
        private System.Windows.Forms.GroupBox gbCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPositionX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPositionY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPositionZ;
        private System.Windows.Forms.TextBox txtRotateX;
        private System.Windows.Forms.TextBox txtRotateY;
        private System.Windows.Forms.TextBox txtRotateZ;
        private System.Windows.Forms.Label lblRotate;
        private System.Windows.Forms.Label lblRotateX;
        private System.Windows.Forms.Label lblRotateY;
        private System.Windows.Forms.Label lblRotateZ;
        private System.Windows.Forms.TextBox txtMoveX;
        private System.Windows.Forms.TextBox txtMoveY;
        private System.Windows.Forms.TextBox txtMoveZ;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.Label lblMoveX;
        private System.Windows.Forms.Label lblMoveY;
        private System.Windows.Forms.Label lblMoveZ;
        private System.Windows.Forms.Label lblMirror;
        private System.Windows.Forms.TextBox txtScaleX;
        private System.Windows.Forms.TextBox txtScaleY;
        private System.Windows.Forms.TextBox txtScaleZ;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblScaleX;
        private System.Windows.Forms.Label lblScaleY;
        private System.Windows.Forms.Label lblScaleZ;
        private System.Windows.Forms.CheckBox chbMirrorX;
        private System.Windows.Forms.CheckBox chbMirrorY;
        private System.Windows.Forms.CheckBox chbMirrorZ;
        private System.Windows.Forms.RadioButton rbRotateTypeGlobal;
        private System.Windows.Forms.RadioButton rbRotateTypeOwn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTagret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTargetX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTargetY;
        private System.Windows.Forms.TextBox txtTargetZ;
        private System.Windows.Forms.Label lblFar;
        private System.Windows.Forms.TextBox txtFar;
        private System.Windows.Forms.Label lblNear;
        private System.Windows.Forms.TextBox txtNear;
        private System.Windows.Forms.Button btnSetCamera;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem ProecMenu;
        private System.Windows.Forms.ToolStripMenuItem proecMenuParallel;
        private System.Windows.Forms.ToolStripMenuItem proecMenuCentral;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem edgesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbObjects;
        private System.Windows.Forms.Button btnAddNewObject;
        private System.Windows.Forms.Button btnRemoveObject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStairsLenght;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtStairsRadius;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStairsCount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtStairsTubeHeight;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStairsTubeWidth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStairsTubeLenght;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtObjPointZ;
        private System.Windows.Forms.TextBox txtObjPointY;
        private System.Windows.Forms.TextBox txtObjPointX;
        private System.Windows.Forms.TextBox txtBarLenght;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtBarRadius;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBarTubeHeight;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBarTubeWidth;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnMirror;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button bntPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer panoramaTimer;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

