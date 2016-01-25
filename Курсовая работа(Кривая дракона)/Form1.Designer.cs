namespace Курсовая_работа_Кривая_дракона_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInform = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPctBox = new System.Windows.Forms.Panel();
            this.trb = new System.Windows.Forms.TrackBar();
            this.pctBoxColorNow = new System.Windows.Forms.PictureBox();
            this.pctBox = new System.Windows.Forms.PictureBox();
            this.grbNavigation = new System.Windows.Forms.GroupBox();
            this.chkBoxScroll = new System.Windows.Forms.CheckBox();
            this.cmbAlngle = new System.Windows.Forms.ComboBox();
            this.btnZoomP = new System.Windows.Forms.Button();
            this.btnZoomM = new System.Windows.Forms.Button();
            this.btnRotLeft = new System.Windows.Forms.Button();
            this.btnRotRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.numMove = new System.Windows.Forms.NumericUpDown();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnInform = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.btnRound = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.chList = new System.Windows.Forms.CheckedListBox();
            this.pctColor2 = new System.Windows.Forms.PictureBox();
            this.pctColor3 = new System.Windows.Forms.PictureBox();
            this.pctColor4 = new System.Windows.Forms.PictureBox();
            this.pctColor1 = new System.Windows.Forms.PictureBox();
            this.cmbBoxDepth = new System.Windows.Forms.ComboBox();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.cmbBoxBrush = new System.Windows.Forms.ComboBox();
            this.pctBoxColor = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lnShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lnShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tbc = new System.Windows.Forms.TabControl();
            this.mnuStrip.SuspendLayout();
            this.pnlPctBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxColorNow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).BeginInit();
            this.grbNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMove)).BeginInit();
            this.tbpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxColor)).BeginInit();
            this.tbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip
            // 
            this.mnuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAbout,
            this.mnuInform});
            this.mnuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.mnuStrip.Location = new System.Drawing.Point(12, 9);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuStrip.Size = new System.Drawing.Size(97, 80);
            this.mnuStrip.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSaveAs,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(48, 19);
            this.mnuFile.Text = "&Файл";
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(162, 22);
            this.mnuSaveAs.Text = "&Сохранить как...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(162, 22);
            this.mnuExit.Text = "&Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(94, 19);
            this.mnuAbout.Text = "&О программе";
            this.mnuAbout.Click += new System.EventHandler(this.mnuInform_Click);
            // 
            // mnuInform
            // 
            this.mnuInform.Name = "mnuInform";
            this.mnuInform.Size = new System.Drawing.Size(65, 19);
            this.mnuInform.Text = "&Справка";
            this.mnuInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // pnlPctBox
            // 
            this.pnlPctBox.Controls.Add(this.trb);
            this.pnlPctBox.Controls.Add(this.pctBoxColorNow);
            this.pnlPctBox.Controls.Add(this.pctBox);
            this.pnlPctBox.Location = new System.Drawing.Point(140, 43);
            this.pnlPctBox.Name = "pnlPctBox";
            this.pnlPctBox.Size = new System.Drawing.Size(542, 560);
            this.pnlPctBox.TabIndex = 1;
            // 
            // trb
            // 
            this.trb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trb.LargeChange = 1;
            this.trb.Location = new System.Drawing.Point(2, 3);
            this.trb.Maximum = 40;
            this.trb.Minimum = -40;
            this.trb.Name = "trb";
            this.trb.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb.Size = new System.Drawing.Size(45, 554);
            this.trb.TabIndex = 3;
            this.trb.Visible = false;
            this.trb.Scroll += new System.EventHandler(this.trb_Scroll);
            // 
            // pctBoxColorNow
            // 
            this.pctBoxColorNow.Location = new System.Drawing.Point(437, 17);
            this.pctBoxColorNow.Name = "pctBoxColorNow";
            this.pctBoxColorNow.Size = new System.Drawing.Size(81, 81);
            this.pctBoxColorNow.TabIndex = 1;
            this.pctBoxColorNow.TabStop = false;
            this.pctBoxColorNow.Paint += new System.Windows.Forms.PaintEventHandler(this.pctBoxColorNow_Paint);
            // 
            // pctBox
            // 
            this.pctBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBox.Location = new System.Drawing.Point(0, 0);
            this.pctBox.Name = "pctBox";
            this.pctBox.Size = new System.Drawing.Size(542, 560);
            this.pctBox.TabIndex = 0;
            this.pctBox.TabStop = false;
            this.pctBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pctBox_Paint);
            // 
            // grbNavigation
            // 
            this.grbNavigation.BackColor = System.Drawing.Color.Transparent;
            this.grbNavigation.Controls.Add(this.chkBoxScroll);
            this.grbNavigation.Controls.Add(this.cmbAlngle);
            this.grbNavigation.Controls.Add(this.btnZoomP);
            this.grbNavigation.Controls.Add(this.btnZoomM);
            this.grbNavigation.Controls.Add(this.btnRotLeft);
            this.grbNavigation.Controls.Add(this.btnRotRight);
            this.grbNavigation.Controls.Add(this.btnDown);
            this.grbNavigation.Controls.Add(this.numMove);
            this.grbNavigation.Controls.Add(this.btnUp);
            this.grbNavigation.Controls.Add(this.btnLeft);
            this.grbNavigation.Controls.Add(this.btnRight);
            this.grbNavigation.Location = new System.Drawing.Point(12, 96);
            this.grbNavigation.Name = "grbNavigation";
            this.grbNavigation.Size = new System.Drawing.Size(112, 434);
            this.grbNavigation.TabIndex = 10;
            this.grbNavigation.TabStop = false;
            this.grbNavigation.Text = "Навигация";
            // 
            // chkBoxScroll
            // 
            this.chkBoxScroll.AutoSize = true;
            this.chkBoxScroll.Location = new System.Drawing.Point(13, 314);
            this.chkBoxScroll.Name = "chkBoxScroll";
            this.chkBoxScroll.Size = new System.Drawing.Size(78, 30);
            this.chkBoxScroll.TabIndex = 11;
            this.chkBoxScroll.Text = "Полоса\r\nпрокрутки";
            this.chkBoxScroll.UseVisualStyleBackColor = true;
            this.chkBoxScroll.CheckedChanged += new System.EventHandler(this.chkBoxScroll_CheckedChanged);
            // 
            // cmbAlngle
            // 
            this.cmbAlngle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlngle.FormattingEnabled = true;
            this.cmbAlngle.Items.AddRange(new object[] {
            "pi",
            "pi/2",
            "pi/3",
            "pi/4",
            "pi/5",
            "pi/6"});
            this.cmbAlngle.Location = new System.Drawing.Point(13, 249);
            this.cmbAlngle.Name = "cmbAlngle";
            this.cmbAlngle.Size = new System.Drawing.Size(83, 21);
            this.cmbAlngle.TabIndex = 17;
            // 
            // btnZoomP
            // 
            this.btnZoomP.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomP.Image")));
            this.btnZoomP.Location = new System.Drawing.Point(10, 356);
            this.btnZoomP.Name = "btnZoomP";
            this.btnZoomP.Size = new System.Drawing.Size(39, 39);
            this.btnZoomP.TabIndex = 9;
            this.btnZoomP.UseVisualStyleBackColor = true;
            this.btnZoomP.Click += new System.EventHandler(this.btnZoomP_Click);
            // 
            // btnZoomM
            // 
            this.btnZoomM.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomM.Image")));
            this.btnZoomM.Location = new System.Drawing.Point(55, 356);
            this.btnZoomM.Name = "btnZoomM";
            this.btnZoomM.Size = new System.Drawing.Size(39, 39);
            this.btnZoomM.TabIndex = 10;
            this.btnZoomM.UseVisualStyleBackColor = true;
            this.btnZoomM.Click += new System.EventHandler(this.btnZoomM_Click);
            // 
            // btnRotLeft
            // 
            this.btnRotLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnRotLeft.Image")));
            this.btnRotLeft.Location = new System.Drawing.Point(14, 198);
            this.btnRotLeft.Name = "btnRotLeft";
            this.btnRotLeft.Size = new System.Drawing.Size(39, 39);
            this.btnRotLeft.TabIndex = 16;
            this.btnRotLeft.UseVisualStyleBackColor = true;
            this.btnRotLeft.Click += new System.EventHandler(this.btnRotLeft_Click);
            // 
            // btnRotRight
            // 
            this.btnRotRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRotRight.Image")));
            this.btnRotRight.Location = new System.Drawing.Point(59, 198);
            this.btnRotRight.Name = "btnRotRight";
            this.btnRotRight.Size = new System.Drawing.Size(39, 39);
            this.btnRotRight.TabIndex = 15;
            this.btnRotRight.UseVisualStyleBackColor = true;
            this.btnRotRight.Click += new System.EventHandler(this.btnRotRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(14, 120);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(39, 39);
            this.btnDown.TabIndex = 12;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // numMove
            // 
            this.numMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numMove.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMove.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMove.Location = new System.Drawing.Point(14, 43);
            this.numMove.Name = "numMove";
            this.numMove.Size = new System.Drawing.Size(82, 26);
            this.numMove.TabIndex = 13;
            this.numMove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMove.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnUp
            // 
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(59, 75);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(39, 39);
            this.btnUp.TabIndex = 9;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(14, 75);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(39, 39);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(59, 120);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(39, 39);
            this.btnRight.TabIndex = 10;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnInform
            // 
            this.btnInform.Image = ((System.Drawing.Image)(resources.GetObject("btnInform.Image")));
            this.btnInform.Location = new System.Drawing.Point(991, 12);
            this.btnInform.Name = "btnInform";
            this.btnInform.Size = new System.Drawing.Size(39, 42);
            this.btnInform.TabIndex = 20;
            this.btnInform.UseVisualStyleBackColor = true;
            this.btnInform.Click += new System.EventHandler(this.btnInform_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(946, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.Location = new System.Drawing.Point(822, 31);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(75, 23);
            this.btnPaint.TabIndex = 18;
            this.btnPaint.Text = "Ок";
            this.btnPaint.UseVisualStyleBackColor = true;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(712, 34);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(75, 20);
            this.txtBox.TabIndex = 17;
            this.txtBox.Text = "0";
            // 
            // tbpSettings
            // 
            this.tbpSettings.Controls.Add(this.btnRound);
            this.tbpSettings.Controls.Add(this.chList);
            this.tbpSettings.Controls.Add(this.pctColor2);
            this.tbpSettings.Controls.Add(this.pctColor3);
            this.tbpSettings.Controls.Add(this.pctColor4);
            this.tbpSettings.Controls.Add(this.pctColor1);
            this.tbpSettings.Controls.Add(this.cmbBoxDepth);
            this.tbpSettings.Controls.Add(this.lblDepth);
            this.tbpSettings.Controls.Add(this.lblStyle);
            this.tbpSettings.Controls.Add(this.cmbBoxBrush);
            this.tbpSettings.Controls.Add(this.pctBoxColor);
            this.tbpSettings.Controls.Add(this.shapeContainer1);
            this.tbpSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(309, 509);
            this.tbpSettings.TabIndex = 0;
            this.tbpSettings.Text = "Параметры";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // btnRound
            // 
            this.btnRound.ImageIndex = 1;
            this.btnRound.ImageList = this.imgList;
            this.btnRound.Location = new System.Drawing.Point(16, 319);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(30, 30);
            this.btnRound.TabIndex = 25;
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "круг.jpg");
            this.imgList.Images.SetKeyName(1, "угол.jpg");
            // 
            // chList
            // 
            this.chList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chList.CheckOnClick = true;
            this.chList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chList.FormattingEnabled = true;
            this.chList.Items.AddRange(new object[] {
            "",
            "",
            "",
            ""});
            this.chList.Location = new System.Drawing.Point(274, 368);
            this.chList.Name = "chList";
            this.chList.Size = new System.Drawing.Size(18, 60);
            this.chList.TabIndex = 23;
            // 
            // pctColor2
            // 
            this.pctColor2.BackColor = System.Drawing.Color.White;
            this.pctColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctColor2.Location = new System.Drawing.Point(232, 372);
            this.pctColor2.Name = "pctColor2";
            this.pctColor2.Size = new System.Drawing.Size(25, 25);
            this.pctColor2.TabIndex = 22;
            this.pctColor2.TabStop = false;
            this.pctColor2.BackColorChanged += new System.EventHandler(this.pctColor1_BackColorChanged);
            this.pctColor2.Click += new System.EventHandler(this.pctColor2_Click);
            // 
            // pctColor3
            // 
            this.pctColor3.BackColor = System.Drawing.Color.White;
            this.pctColor3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctColor3.Location = new System.Drawing.Point(232, 403);
            this.pctColor3.Name = "pctColor3";
            this.pctColor3.Size = new System.Drawing.Size(25, 25);
            this.pctColor3.TabIndex = 21;
            this.pctColor3.TabStop = false;
            this.pctColor3.BackColorChanged += new System.EventHandler(this.pctColor1_BackColorChanged);
            this.pctColor3.Click += new System.EventHandler(this.pctColor3_Click);
            // 
            // pctColor4
            // 
            this.pctColor4.BackColor = System.Drawing.Color.White;
            this.pctColor4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctColor4.Location = new System.Drawing.Point(232, 434);
            this.pctColor4.Name = "pctColor4";
            this.pctColor4.Size = new System.Drawing.Size(25, 25);
            this.pctColor4.TabIndex = 20;
            this.pctColor4.TabStop = false;
            this.pctColor4.BackColorChanged += new System.EventHandler(this.pctColor1_BackColorChanged);
            this.pctColor4.Click += new System.EventHandler(this.pctColor4_Click);
            // 
            // pctColor1
            // 
            this.pctColor1.BackColor = System.Drawing.Color.White;
            this.pctColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctColor1.Location = new System.Drawing.Point(232, 341);
            this.pctColor1.Name = "pctColor1";
            this.pctColor1.Size = new System.Drawing.Size(25, 25);
            this.pctColor1.TabIndex = 19;
            this.pctColor1.TabStop = false;
            this.pctColor1.BackColorChanged += new System.EventHandler(this.pctColor1_BackColorChanged);
            this.pctColor1.Click += new System.EventHandler(this.pctColor1_Click);
            // 
            // cmbBoxDepth
            // 
            this.cmbBoxDepth.FormattingEnabled = true;
            this.cmbBoxDepth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbBoxDepth.Location = new System.Drawing.Point(105, 404);
            this.cmbBoxDepth.Name = "cmbBoxDepth";
            this.cmbBoxDepth.Size = new System.Drawing.Size(101, 21);
            this.cmbBoxDepth.Sorted = true;
            this.cmbBoxDepth.TabIndex = 8;
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(10, 407);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(86, 13);
            this.lblDepth.TabIndex = 7;
            this.lblDepth.Text = "Толщина линий";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(13, 375);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(70, 13);
            this.lblStyle.TabIndex = 5;
            this.lblStyle.Text = "Стиль линий";
            // 
            // cmbBoxBrush
            // 
            this.cmbBoxBrush.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBoxBrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxBrush.FormattingEnabled = true;
            this.cmbBoxBrush.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbBoxBrush.Location = new System.Drawing.Point(105, 372);
            this.cmbBoxBrush.Name = "cmbBoxBrush";
            this.cmbBoxBrush.Size = new System.Drawing.Size(101, 21);
            this.cmbBoxBrush.TabIndex = 4;
            this.cmbBoxBrush.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbBoxBrush_DrawItem);
            this.cmbBoxBrush.SelectedIndexChanged += new System.EventHandler(this.cmbBoxBrush_SelectedIndexChanged);
            // 
            // pctBoxColor
            // 
            this.pctBoxColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctBoxColor.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxColor.Image")));
            this.pctBoxColor.Location = new System.Drawing.Point(6, 6);
            this.pctBoxColor.Name = "pctBoxColor";
            this.pctBoxColor.Size = new System.Drawing.Size(300, 300);
            this.pctBoxColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctBoxColor.TabIndex = 0;
            this.pctBoxColor.TabStop = false;
            this.pctBoxColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctBoxColor_MouseDown);
            this.pctBoxColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pctBoxColor_MouseMove);
            this.pctBoxColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctBoxColor_MouseUp);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lnShape4,
            this.lnShape3,
            this.lnShape2,
            this.lnShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(303, 503);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // lnShape4
            // 
            this.lnShape4.Enabled = false;
            this.lnShape4.Name = "lnShape4";
            this.lnShape4.SelectionColor = System.Drawing.SystemColors.ControlText;
            this.lnShape4.X1 = 251;
            this.lnShape4.X2 = 276;
            this.lnShape4.Y1 = 445;
            this.lnShape4.Y2 = 418;
            // 
            // lnShape3
            // 
            this.lnShape3.Enabled = false;
            this.lnShape3.Name = "lnShape3";
            this.lnShape3.SelectionColor = System.Drawing.SystemColors.ControlText;
            this.lnShape3.X1 = 249;
            this.lnShape3.X2 = 277;
            this.lnShape3.Y1 = 414;
            this.lnShape3.Y2 = 401;
            // 
            // lnShape2
            // 
            this.lnShape2.Enabled = false;
            this.lnShape2.Name = "lnShape2";
            this.lnShape2.SelectionColor = System.Drawing.SystemColors.ControlText;
            this.lnShape2.X1 = 252;
            this.lnShape2.X2 = 271;
            this.lnShape2.Y1 = 381;
            this.lnShape2.Y2 = 386;
            // 
            // lnShape1
            // 
            this.lnShape1.Enabled = false;
            this.lnShape1.Name = "lnShape1";
            this.lnShape1.SelectionColor = System.Drawing.SystemColors.ControlText;
            this.lnShape1.X1 = 251;
            this.lnShape1.X2 = 271;
            this.lnShape1.Y1 = 350;
            this.lnShape1.Y2 = 370;
            // 
            // tbc
            // 
            this.tbc.Controls.Add(this.tbpSettings);
            this.tbc.Location = new System.Drawing.Point(713, 68);
            this.tbc.Name = "tbc";
            this.tbc.SelectedIndex = 0;
            this.tbc.Size = new System.Drawing.Size(317, 535);
            this.tbc.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1051, 639);
            this.Controls.Add(this.btnInform);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.grbNavigation);
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.pnlPctBox);
            this.Controls.Add(this.mnuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrip;
            this.Name = "Form1";
            this.Text = "Кривая Дракона";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.pnlPctBox.ResumeLayout(false);
            this.pnlPctBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxColorNow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox)).EndInit();
            this.grbNavigation.ResumeLayout(false);
            this.grbNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMove)).EndInit();
            this.tbpSettings.ResumeLayout(false);
            this.tbpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctColor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxColor)).EndInit();
            this.tbc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.Panel pnlPctBox;
        private System.Windows.Forms.PictureBox pctBox;
        private System.Windows.Forms.ToolStripMenuItem mnuInform;
        private System.Windows.Forms.PictureBox pctBoxColorNow;
        private System.Windows.Forms.GroupBox grbNavigation;
        private System.Windows.Forms.CheckBox chkBoxScroll;
        private System.Windows.Forms.Button btnZoomP;
        private System.Windows.Forms.Button btnZoomM;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.NumericUpDown numMove;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnInform;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.TrackBar trb;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.PictureBox pctColor2;
        private System.Windows.Forms.PictureBox pctColor3;
        private System.Windows.Forms.PictureBox pctColor4;
        private System.Windows.Forms.PictureBox pctColor1;
        private System.Windows.Forms.ComboBox cmbBoxDepth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.ComboBox cmbBoxBrush;
        private System.Windows.Forms.PictureBox pctBoxColor;
        private System.Windows.Forms.TabControl tbc;
        private System.Windows.Forms.Button btnRotLeft;
        private System.Windows.Forms.Button btnRotRight;
        private System.Windows.Forms.ComboBox cmbAlngle;
        private System.Windows.Forms.CheckedListBox chList;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lnShape1;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.ImageList imgList;
    }
}

