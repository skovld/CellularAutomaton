namespace CellularAutomatonForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GenerationTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEvol = new System.Windows.Forms.ToolStripButton();
            this.btnGO = new System.Windows.Forms.ToolStripButton();
            this.btnAgain = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnFillMatrix = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addtimeTSSB = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStrip_timebtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.oneSecTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fhmsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.thfmsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.fmsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.onemsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.removetimeTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.colorDialogOpen = new System.Windows.Forms.ToolStripButton();
            this.backcolorDialogOpen = new System.Windows.Forms.ToolStripButton();
            this.rulesChListBox = new System.Windows.Forms.CheckedListBox();
            this.thorChB = new System.Windows.Forms.CheckBox();
            this.glControl1 = new OpenTK.GLControl();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorCellsDialog = new System.Windows.Forms.ColorDialog();
            this.colorBackDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.redactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.stepsClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem_random0 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_random = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_generate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_step = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutPaintingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellcolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backcolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabel_steps = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel_cellscount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel_X = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel_Y = new System.Windows.Forms.ToolStripStatusLabel();
            this.shadowBtn = new System.Windows.Forms.Button();
            this.rulesBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.rulesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerationTimer
            // 
            this.GenerationTimer.Tick += new System.EventHandler(this.GenerationTimer_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator3,
            this.btnEvol,
            this.btnGO,
            this.btnAgain,
            this.toolStripSeparator9,
            this.btnClear,
            this.btnFillMatrix,
            this.toolStripSeparator1,
            this.btnZoomIn,
            this.btnZoomOut,
            this.toolStripSeparator2,
            this.addtimeTSSB,
            this.removetimeTSB,
            this.toolStripSeparator7,
            this.colorDialogOpen,
            this.backcolorDialogOpen});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1349, 25);
            this.toolStrip.TabIndex = 13;
            this.toolStrip.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Открыть конфигурацию файл (Ctrl+O)";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Сохранить конфигурацию (Ctrl+S)";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEvol
            // 
            this.btnEvol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEvol.Image = ((System.Drawing.Image)(resources.GetObject("btnEvol.Image")));
            this.btnEvol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEvol.Name = "btnEvol";
            this.btnEvol.Size = new System.Drawing.Size(23, 22);
            this.btnEvol.Text = "Следующее поколение (S)";
            this.btnEvol.Click += new System.EventHandler(this.btnEvol_Click);
            // 
            // btnGO
            // 
            this.btnGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGO.Image = ((System.Drawing.Image)(resources.GetObject("btnGO.Image")));
            this.btnGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(23, 22);
            this.btnGO.Text = "Запустить (G)";
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnAgain
            // 
            this.btnAgain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgain.Image = ((System.Drawing.Image)(resources.GetObject("btnAgain.Image")));
            this.btnAgain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(23, 22);
            this.btnAgain.Text = "Заново (Ctrl + Z)";
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "Очистить (C)";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFillMatrix
            // 
            this.btnFillMatrix.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFillMatrix.Image = ((System.Drawing.Image)(resources.GetObject("btnFillMatrix.Image")));
            this.btnFillMatrix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFillMatrix.Name = "btnFillMatrix";
            this.btnFillMatrix.Size = new System.Drawing.Size(23, 22);
            this.btnFillMatrix.Text = "Случайное заполнение (R)";
            this.btnFillMatrix.Click += new System.EventHandler(this.btnFillMatrix_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.Text = "Увеличить (Ctrl+\'+\')";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.Text = "Уменьшить (Ctrl+\'-\')";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addtimeTSSB
            // 
            this.addtimeTSSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addtimeTSSB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_timebtn,
            this.toolStripSeparator8,
            this.oneSecTSMI,
            this.fhmsTSMI,
            this.thfmsTSMI,
            this.fmsTSMI,
            this.onemsTSMI});
            this.addtimeTSSB.Image = ((System.Drawing.Image)(resources.GetObject("addtimeTSSB.Image")));
            this.addtimeTSSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addtimeTSSB.Name = "addtimeTSSB";
            this.addtimeTSSB.Size = new System.Drawing.Size(32, 22);
            this.addtimeTSSB.Text = "Увеличить скорость";
            this.addtimeTSSB.ButtonClick += new System.EventHandler(this.addtimeTSSB_ButtonClick);
            // 
            // ToolStrip_timebtn
            // 
            this.ToolStrip_timebtn.Name = "ToolStrip_timebtn";
            this.ToolStrip_timebtn.Size = new System.Drawing.Size(179, 22);
            this.ToolStrip_timebtn.Text = "Текущая задержка:";
            this.ToolStrip_timebtn.Click += new System.EventHandler(this.ToolStrip_timebtn_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(176, 6);
            // 
            // oneSecTSMI
            // 
            this.oneSecTSMI.Name = "oneSecTSMI";
            this.oneSecTSMI.Size = new System.Drawing.Size(179, 22);
            this.oneSecTSMI.Text = "1 с";
            this.oneSecTSMI.Click += new System.EventHandler(this.oneSecTSMI_Click);
            // 
            // fhmsTSMI
            // 
            this.fhmsTSMI.Name = "fhmsTSMI";
            this.fhmsTSMI.Size = new System.Drawing.Size(179, 22);
            this.fhmsTSMI.Text = "500 мс";
            this.fhmsTSMI.Click += new System.EventHandler(this.fhmsTSMI_Click);
            // 
            // thfmsTSMI
            // 
            this.thfmsTSMI.Name = "thfmsTSMI";
            this.thfmsTSMI.Size = new System.Drawing.Size(179, 22);
            this.thfmsTSMI.Text = "250 мс";
            this.thfmsTSMI.Click += new System.EventHandler(this.thfmsTSMI_Click);
            // 
            // fmsTSMI
            // 
            this.fmsTSMI.Name = "fmsTSMI";
            this.fmsTSMI.Size = new System.Drawing.Size(179, 22);
            this.fmsTSMI.Text = "50 мс";
            this.fmsTSMI.Click += new System.EventHandler(this.fmsTSMI_Click);
            // 
            // onemsTSMI
            // 
            this.onemsTSMI.Name = "onemsTSMI";
            this.onemsTSMI.Size = new System.Drawing.Size(179, 22);
            this.onemsTSMI.Text = "1 мс";
            this.onemsTSMI.Click += new System.EventHandler(this.onemsTSMI_Click);
            // 
            // removetimeTSB
            // 
            this.removetimeTSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removetimeTSB.Image = ((System.Drawing.Image)(resources.GetObject("removetimeTSB.Image")));
            this.removetimeTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removetimeTSB.Name = "removetimeTSB";
            this.removetimeTSB.Size = new System.Drawing.Size(23, 22);
            this.removetimeTSB.Text = "Уменьшить скорость";
            this.removetimeTSB.Click += new System.EventHandler(this.removetimeTSB_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // colorDialogOpen
            // 
            this.colorDialogOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorDialogOpen.Image = ((System.Drawing.Image)(resources.GetObject("colorDialogOpen.Image")));
            this.colorDialogOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorDialogOpen.Name = "colorDialogOpen";
            this.colorDialogOpen.Size = new System.Drawing.Size(23, 22);
            this.colorDialogOpen.Text = "Цвет ячеек";
            this.colorDialogOpen.Click += new System.EventHandler(this.colorDialogOpen_Click);
            // 
            // backcolorDialogOpen
            // 
            this.backcolorDialogOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backcolorDialogOpen.Image = ((System.Drawing.Image)(resources.GetObject("backcolorDialogOpen.Image")));
            this.backcolorDialogOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backcolorDialogOpen.Name = "backcolorDialogOpen";
            this.backcolorDialogOpen.Size = new System.Drawing.Size(23, 22);
            this.backcolorDialogOpen.Text = "Цвет фона";
            this.backcolorDialogOpen.Click += new System.EventHandler(this.backcolorDialogOpen_Click);
            // 
            // rulesChListBox
            // 
            this.rulesChListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesChListBox.CausesValidation = false;
            this.rulesChListBox.CheckOnClick = true;
            this.rulesChListBox.ColumnWidth = 85;
            this.rulesChListBox.FormattingEnabled = true;
            this.rulesChListBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.rulesChListBox.Location = new System.Drawing.Point(6, 30);
            this.rulesChListBox.MultiColumn = true;
            this.rulesChListBox.Name = "rulesChListBox";
            this.rulesChListBox.Size = new System.Drawing.Size(180, 139);
            this.rulesChListBox.TabIndex = 0;
            this.rulesChListBox.TabStop = false;
            this.rulesChListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.rulesChListBox_ItemCheck);
            // 
            // thorChB
            // 
            this.thorChB.AutoSize = true;
            this.thorChB.Location = new System.Drawing.Point(6, 181);
            this.thorChB.Name = "thorChB";
            this.thorChB.Size = new System.Drawing.Size(45, 17);
            this.thorChB.TabIndex = 17;
            this.thorChB.Text = "Тор";
            this.thorChB.UseVisualStyleBackColor = true;
            this.thorChB.CheckedChanged += new System.EventHandler(this.thorChB_CheckedChanged);
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 54);
            this.glControl1.MaximumSize = new System.Drawing.Size(20000, 20000);
            this.glControl1.MinimumSize = new System.Drawing.Size(100, 100);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(100, 100);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(983, 54);
            this.vScrollBar1.Maximum = 500;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 437);
            this.vScrollBar1.TabIndex = 18;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(0, 523);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(989, 17);
            this.hScrollBar1.TabIndex = 19;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem,
            this.redactToolStripMenuItem,
            this.generateToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_ToolStripMenuItem
            // 
            this.file_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createfileToolStripMenuItem,
            this.openupToolStripMenuItem,
            this.MenuItem_save,
            this.toolStripSeparator6,
            this.MenuItem_exit});
            this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            this.file_ToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.file_ToolStripMenuItem.Text = "Файл";
            // 
            // createfileToolStripMenuItem
            // 
            this.createfileToolStripMenuItem.Name = "createfileToolStripMenuItem";
            this.createfileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.createfileToolStripMenuItem.Text = "Создать";
            this.createfileToolStripMenuItem.Click += new System.EventHandler(this.createfileToolStripMenuItem_Click);
            // 
            // openupToolStripMenuItem
            // 
            this.openupToolStripMenuItem.Name = "openupToolStripMenuItem";
            this.openupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openupToolStripMenuItem.Text = "Открыть";
            this.openupToolStripMenuItem.Click += new System.EventHandler(this.openupToolStripMenuItem_Click);
            // 
            // MenuItem_save
            // 
            this.MenuItem_save.Name = "MenuItem_save";
            this.MenuItem_save.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_save.Text = "Сохранить";
            this.MenuItem_save.Click += new System.EventHandler(this.MenuItem_save_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItem_exit
            // 
            this.MenuItem_exit.Name = "MenuItem_exit";
            this.MenuItem_exit.Size = new System.Drawing.Size(152, 22);
            this.MenuItem_exit.Text = "Выход";
            this.MenuItem_exit.Click += new System.EventHandler(this.MenuItem_exit_Click);
            // 
            // redactToolStripMenuItem
            // 
            this.redactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.MenuItem_clear,
            this.stepsClearToolStripMenuItem,
            this.toolStripSeparator4,
            this.MenuItem_random0,
            this.MenuItem_random,
            this.toolStripSeparator5,
            this.configurationToolStripMenuItem});
            this.redactToolStripMenuItem.Name = "redactToolStripMenuItem";
            this.redactToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.redactToolStripMenuItem.Text = "Правка";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.cancelToolStripMenuItem.Text = "Отменить";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // MenuItem_clear
            // 
            this.MenuItem_clear.Name = "MenuItem_clear";
            this.MenuItem_clear.Size = new System.Drawing.Size(233, 22);
            this.MenuItem_clear.Text = "Очистить";
            this.MenuItem_clear.Click += new System.EventHandler(this.MenuItem_clear_Click);
            // 
            // stepsClearToolStripMenuItem
            // 
            this.stepsClearToolStripMenuItem.Name = "stepsClearToolStripMenuItem";
            this.stepsClearToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.stepsClearToolStripMenuItem.Text = "Обнулить количество шагов";
            this.stepsClearToolStripMenuItem.Click += new System.EventHandler(this.stepsClearToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(230, 6);
            // 
            // MenuItem_random0
            // 
            this.MenuItem_random0.Name = "MenuItem_random0";
            this.MenuItem_random0.Size = new System.Drawing.Size(233, 22);
            this.MenuItem_random0.Text = "Случайное заполнение";
            this.MenuItem_random0.Click += new System.EventHandler(this.MenuItem_random0_Click);
            // 
            // MenuItem_random
            // 
            this.MenuItem_random.Name = "MenuItem_random";
            this.MenuItem_random.Size = new System.Drawing.Size(233, 22);
            this.MenuItem_random.Text = "Вероятностное заполнение";
            this.MenuItem_random.Click += new System.EventHandler(this.MenuItem_random_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(230, 6);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.configurationToolStripMenuItem.Text = "Описание конфигурации";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_generate,
            this.MenuItem_step,
            this.withoutPaintingToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.generateToolStripMenuItem.Text = "Пуск";
            // 
            // MenuItem_generate
            // 
            this.MenuItem_generate.Image = global::CellularAutomatonForm.Properties.Resources.playImg;
            this.MenuItem_generate.Name = "MenuItem_generate";
            this.MenuItem_generate.Size = new System.Drawing.Size(203, 22);
            this.MenuItem_generate.Text = "Пуск";
            this.MenuItem_generate.Click += new System.EventHandler(this.MenuItem_generate_Click);
            // 
            // MenuItem_step
            // 
            this.MenuItem_step.Image = ((System.Drawing.Image)(resources.GetObject("MenuItem_step.Image")));
            this.MenuItem_step.Name = "MenuItem_step";
            this.MenuItem_step.Size = new System.Drawing.Size(203, 22);
            this.MenuItem_step.Text = "Шаг";
            this.MenuItem_step.Click += new System.EventHandler(this.MenuItem_step_Click);
            // 
            // withoutPaintingToolStripMenuItem
            // 
            this.withoutPaintingToolStripMenuItem.Name = "withoutPaintingToolStripMenuItem";
            this.withoutPaintingToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.withoutPaintingToolStripMenuItem.Text = "Запуск без прорисовки";
            this.withoutPaintingToolStripMenuItem.Click += new System.EventHandler(this.withoutPaintingToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delayToolStripMenuItem,
            this.cellcolToolStripMenuItem,
            this.backcolorToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.optionsToolStripMenuItem.Text = "Настройка";
            // 
            // delayToolStripMenuItem
            // 
            this.delayToolStripMenuItem.Name = "delayToolStripMenuItem";
            this.delayToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.delayToolStripMenuItem.Text = "Задержка";
            this.delayToolStripMenuItem.Click += new System.EventHandler(this.delayToolStripMenuItem_Click);
            // 
            // cellcolToolStripMenuItem
            // 
            this.cellcolToolStripMenuItem.Name = "cellcolToolStripMenuItem";
            this.cellcolToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cellcolToolStripMenuItem.Text = "Цвет ячеек";
            this.cellcolToolStripMenuItem.Click += new System.EventHandler(this.cellcolToolStripMenuItem_Click);
            // 
            // backcolorToolStripMenuItem
            // 
            this.backcolorToolStripMenuItem.Name = "backcolorToolStripMenuItem";
            this.backcolorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.backcolorToolStripMenuItem.Text = "Цвет фона";
            this.backcolorToolStripMenuItem.Click += new System.EventHandler(this.backcolorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help0ToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // help0ToolStripMenuItem
            // 
            this.help0ToolStripMenuItem.Name = "help0ToolStripMenuItem";
            this.help0ToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.help0ToolStripMenuItem.Text = "Справка";
            this.help0ToolStripMenuItem.Click += new System.EventHandler(this.help0ToolStripMenuItem_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // buttonToolStripMenuItem
            // 
            this.buttonToolStripMenuItem.Name = "buttonToolStripMenuItem";
            this.buttonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buttonToolStripMenuItem.Text = "button";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_steps,
            this.toolStripLabel_cellscount,
            this.toolStripLabel_X,
            this.toolStripLabel_Y});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1349, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabel_steps
            // 
            this.toolStripLabel_steps.AutoSize = false;
            this.toolStripLabel_steps.Name = "toolStripLabel_steps";
            this.toolStripLabel_steps.Size = new System.Drawing.Size(118, 17);
            this.toolStripLabel_steps.Text = "toolStripStatusLabel1";
            // 
            // toolStripLabel_cellscount
            // 
            this.toolStripLabel_cellscount.AutoSize = false;
            this.toolStripLabel_cellscount.Name = "toolStripLabel_cellscount";
            this.toolStripLabel_cellscount.Size = new System.Drawing.Size(118, 17);
            this.toolStripLabel_cellscount.Text = "toolStripStatusLabel2";
            // 
            // toolStripLabel_X
            // 
            this.toolStripLabel_X.AutoSize = false;
            this.toolStripLabel_X.Name = "toolStripLabel_X";
            this.toolStripLabel_X.Size = new System.Drawing.Size(118, 17);
            this.toolStripLabel_X.Text = "toolStripStatusLabel3";
            // 
            // toolStripLabel_Y
            // 
            this.toolStripLabel_Y.AutoSize = false;
            this.toolStripLabel_Y.Name = "toolStripLabel_Y";
            this.toolStripLabel_Y.Size = new System.Drawing.Size(118, 17);
            this.toolStripLabel_Y.Text = "toolStripStatusLabel4";
            // 
            // shadowBtn
            // 
            this.shadowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shadowBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.shadowBtn.Location = new System.Drawing.Point(1307, 24);
            this.shadowBtn.Name = "shadowBtn";
            this.shadowBtn.Size = new System.Drawing.Size(25, 25);
            this.shadowBtn.TabIndex = 23;
            this.shadowBtn.Text = "-";
            this.shadowBtn.UseVisualStyleBackColor = true;
            this.shadowBtn.Click += new System.EventHandler(this.shadowBtn_Click);
            // 
            // rulesBox
            // 
            this.rulesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rulesBox.Controls.Add(this.label2);
            this.rulesBox.Controls.Add(this.label1);
            this.rulesBox.Controls.Add(this.rulesChListBox);
            this.rulesBox.Controls.Add(this.thorChB);
            this.rulesBox.Location = new System.Drawing.Point(1139, 50);
            this.rulesBox.Name = "rulesBox";
            this.rulesBox.Size = new System.Drawing.Size(192, 204);
            this.rulesBox.TabIndex = 24;
            this.rulesBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Born";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Survive";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1349, 562);
            this.Controls.Add(this.rulesBox);
            this.Controls.Add(this.shadowBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.glControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cellular Automaton";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.rulesBox.ResumeLayout(false);
            this.rulesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GenerationTimer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnEvol;
        private System.Windows.Forms.ToolStripButton btnGO;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton addtimeTSSB;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckedListBox rulesChListBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem oneSecTSMI;
        private System.Windows.Forms.CheckBox thorChB;
        private System.Windows.Forms.ToolStripMenuItem fhmsTSMI;
        private System.Windows.Forms.ToolStripMenuItem thfmsTSMI;
        private System.Windows.Forms.ToolStripMenuItem fmsTSMI;
        private System.Windows.Forms.ToolStripMenuItem onemsTSMI;
        private System.Windows.Forms.ToolStripButton removetimeTSB;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton colorDialogOpen;
        private System.Windows.Forms.ColorDialog colorCellsDialog;
        private System.Windows.Forms.ToolStripButton backcolorDialogOpen;
        private System.Windows.Forms.ToolStripButton btnAgain;
        private System.Windows.Forms.ColorDialog colorBackDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_exit;
        private System.Windows.Forms.ToolStripMenuItem redactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_random;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_generate;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_step;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_clear;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_random0;
        private System.Windows.Forms.ToolStripButton btnFillMatrix;
        private System.Windows.Forms.ToolStripMenuItem buttonToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_steps;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_cellscount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_X;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabel_Y;
        private System.Windows.Forms.ToolStripMenuItem help0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_timebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.Button shadowBtn;
        private System.Windows.Forms.GroupBox rulesBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem stepsClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutPaintingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellcolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backcolorToolStripMenuItem;

    }
}

