using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using System.IO;

namespace CellularAutomatonForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            GenerationTimer.Interval = 16;
        }

        delegate void CA_Step(byte[,] mainmatrix, byte[,] submatrix, bool[] surv, bool[] born); 
        CA_Step step;                                       //Делегат, принимающий метод Step || StepNT

        const int MIN_CELL_SIZE = 1;                        //Минимальный размер ячейки
        const int MAX_CELL_SIZE = 10;                       //Максимальный размер ячейки
        const string LIVE_CELLS_COUNT = "Число ячеек: "; 
        const string STEPS = "Число шагов: ";
        const string DELAY = "Текущая задержка: ";


        const int n = 500;                                  //Размер матрицы
        const int RULES = 9;                                //Количество правил (в общем случае: от 0 до 8)
        byte[,] Cells = new byte[n, n];                     //Главная матрица
        byte[,] Evolut = new byte[n, n];                    //Вспомогательная матрица
        byte[,] memarr = new byte[n, n];                    //Матрица до выполнения какого-либо действия
        bool[] r_surv = new bool[RULES];                    //Набор правил выживания ячейки
        bool[] r_born = new bool[RULES];                    //Набор правил рождения ячейки
        int squareDim = 2;                                  //Размер ячейки
        ulong evolution = 0;                                //Число шагов
        string config = "";                                 //Строка конфигурации

        bool trigger = true;                                //Триггер для сохранения текущего состояния КА

        int x_position = 0;                                 //Абсцисса для перемещения поля отрисовки
        int y_position = 0;                                 //Ордината для перемещения поля отрисовки

        Color cellC;                                        //Цвет ячеек
        Color backC;                                        //Цвет заливки



        /// <summary>
        /// Инициализирующий метод для массивов с правилами
        /// </summary>
        private void GetArrayOfRules()
        {
            for (int i = 0; i < RULES; i++)
                r_surv[i] = rulesChListBox.GetItemChecked(i);

            for (int i = RULES; i < 2 * RULES; i++)
                r_born[i % 9] = rulesChListBox.GetItemChecked(i);
        }

        /// <summary>
        /// Присвоение чекбоксам состояний после загрузки конфигурации
        /// </summary>
        private void SetArrayOfRules()
        {
            for (int i = 0; i < r_surv.Length; i++)
                if (r_surv[i])
                    rulesChListBox.SetItemCheckState(i, CheckState.Checked);
                else
                    rulesChListBox.SetItemCheckState(i, CheckState.Unchecked);

            for (int i = 0; i < r_born.Length; i++)
                if (r_born[i])
                    rulesChListBox.SetItemCheckState(i + RULES, CheckState.Checked);
                else
                    rulesChListBox.SetItemCheckState(i + RULES, CheckState.Unchecked);
        }
        
        /// <summary>
        /// Инициализация скроллбаров
        /// </summary>
        private void ScrollBarsInitialize()
        {
            hScrollBar1.Minimum = 0;
            vScrollBar1.Minimum = 0;

            hScrollBar1.Maximum = n * (squareDim + 1) - glControl1.Width;
            
            hScrollBar1.SmallChange = squareDim;


            
            vScrollBar1.Maximum = n * (squareDim + 1) - glControl1.Height + 10*squareDim;// magic numbers 
            vScrollBar1.LargeChange = vScrollBar1.Maximum / (n*squareDim) ;
            vScrollBar1.SmallChange = squareDim;
            vScrollBar1.Location = new Point(glControl1.Width, glControl1.Location.Y);
        }

        /// <summary>
        /// Возврат фокуса в начало координат
        /// </summary>
        private void DisplayToStartPosition()
        {
            x_position = 0;
            y_position = 0;
            try
            {
                vScrollBar1.Value = y_position;
                hScrollBar1.Value = x_position;
            }
            catch { }
            cameraChanged();
            paint(Cells);
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            step = new CA_Step(CellAutomaton.CellularAutomaton);


            glControl1.Size = new Size(n * (squareDim + 1), hScrollBar1.Location.Y - glControl1.Location.Y);   //617 is magic number | n * (squareDim + 1)
            cameraChanged();

            //Фон
            // panel1.BackColor = Color.Black;

            //Заполняем матрицу
            CellAutomaton.FillMatrix(Cells);
            memarr = (byte[,])Cells.Clone();

            //Генерация поколений выключена
            GenerationTimer.Enabled = false;

            //Конвеевская жизнь по умолчанию. S/B 23/3
            rulesChListBox.SetItemChecked(2, true);
            rulesChListBox.SetItemChecked(3, true);
            rulesChListBox.SetItemChecked(12, true);

            //Правила
            GetArrayOfRules();
            
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;

            cellC = Color.FromArgb(0, 255, 0); //Зеленый цвет
            backC = Color.Black;

            hScrollBar1.Width = glControl1.Width;
            vScrollBar1.Height = glControl1.Height;
            ScrollBarsInitialize();

            thorChB.Checked = true;

            toolStripLabel_steps.Text = "Число шагов: " + 0;
            toolStripLabel_X.Text = "X: " + 0;
            toolStripLabel_Y.Text = "Y: " + 0;

            FullSize();
        }

        /// <summary>
        /// Хоткеи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Oemplus && e.Modifiers == Keys.Control)
            {
                btnZoomIn_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.OemMinus && e.Modifiers == Keys.Control)
            {
                btnZoomOut_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.R && e.Modifiers == Keys.Control)
            {
                MenuItem_random_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                Cells = (byte[,])memarr.Clone();
                paint(Cells);
                return;
            }

            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                saveToolStripButton_Click(sender, e);
                return;
            }

            if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control)
            {
                openToolStripButton_Click(sender, e);
                return;
            }


            switch (e.KeyData)
            {
                case Keys.Q:
                    
                    return;
                case Keys.E:
                    shadowBtn_Click(this, null);
                    rulesChListBox.Focus();
                    return;
                case Keys.R:
                    btnFillMatrix_Click(sender, e);
                    return;
                case Keys.C:
                    btnClear_Click(sender, e);
                    stepsClearToolStripMenuItem_Click(sender, e);
                    return;
                case Keys.G:
                    if (trigger)
                        memarr = (byte[,])Cells.Clone();
                    rulesChListBox.Focus();
                    btnGO_Click(sender, e);
                    return;
                case Keys.S:
                    if (!GenerationTimer.Enabled)
                    {
                        memarr = (byte[,])Cells.Clone();
                        btnEvol_Click(sender, e);
                    }
                    return;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Следующее поколение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEvol_Click(object sender, EventArgs e)
        {
            step(Cells, Evolut, r_surv, r_born);
            paint(Cells);
            evolution++;
            toolStripLabel_steps.Text = STEPS + evolution;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Запустить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGO_Click(object sender, EventArgs e)
        {
            trigger = !trigger;
            GenerationTimer.Enabled = !GenerationTimer.Enabled;
            btnEvol.Enabled = !btnEvol.Enabled;
            btnAgain.Enabled = !btnAgain.Enabled;
            if (GenerationTimer.Enabled)
            {
                btnGO.Image = Image.FromFile(@"..\..\Resources\pauseImg.png");
                btnGO.Text = "Остановить (G)";
                MenuItem_generate.Text = "Стоп";
                MenuItem_generate.Image = Image.FromFile(@"..\..\Resources\pauseImg.png");
            }
            else
            {
                btnGO.Image = Image.FromFile(@"..\..\Resources\playImg.png");
                btnGO.Text = "Запустить (G)";
                MenuItem_generate.Text = "Пуск";
                MenuItem_generate.Image = Image.FromFile(@"..\..\Resources\playImg.png");
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Пуск"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_generate_Click(object sender, EventArgs e)
        {
            trigger = !trigger;
            GenerationTimer.Enabled = !GenerationTimer.Enabled;
            btnEvol.Enabled = !btnEvol.Enabled;
            btnAgain.Enabled = !btnAgain.Enabled;

            if (GenerationTimer.Enabled)
            {
                btnGO.Image = Image.FromFile(@"..\..\Resources\pauseImg.png");
                btnGO.Text = "Остановить (G)";
                MenuItem_generate.Text = "Стоп";
                MenuItem_generate.Image = Image.FromFile(@"..\..\Resources\pauseImg.png");
            }
            else
            {
                btnGO.Image = Image.FromFile(@"..\..\Resources\playImg.png");
                btnGO.Text = "Запустить (G)";
                MenuItem_generate.Text = "Пуск";
                MenuItem_generate.Image = Image.FromFile(@"..\..\Resources\playImg.png");
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear(Cells);
            toolStripLabel_steps.Text = STEPS + 0;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Случайное заполнение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillMatrix_Click(object sender, EventArgs e)
        {
            CellAutomaton.FillMatrix(Cells);
            paint(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Увеличить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (squareDim < MAX_CELL_SIZE)
            {
                squareDim += 1;
                ScrollBarsInitialize();
                DisplayToStartPosition();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Уменьшить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (squareDim  > MIN_CELL_SIZE)
            {
                squareDim -= 1;
                ScrollBarsInitialize();
                DisplayToStartPosition();
            }
        }

        /// <summary>
        /// Метод зануляет матрицу
        /// </summary>
        /// <param name="Cells_arr"></param>
        private void Clear(byte[,] Cells_arr)
        {
            for (int i = 0; i < Cells_arr.GetLength(0); i++)
                for (int j = 0; j < Cells_arr.GetLength(1); j++)
                {
                    Cells_arr[i, j] = 0;
                    Evolut[i, j] = 0;
                }
            paint(Cells);
        }

        /// <summary>
        /// Отрисовка ячеек
        /// </summary>
        public void paint(byte[,] _cells)
        {
            int counter = 0;
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            glControl1.MakeCurrent();
            GL.Begin(PrimitiveType.Quads);
            for (int i = 0, x = 0; i < _cells.GetLength(0); i++, x += squareDim + 1)
                for (int j = 0, y = 0; j < _cells.GetLength(1); j++, y += squareDim + 1)
                {
                    if (_cells[i, j] == 1)
                    {
                        drawSquare(y, glControl1.Height - squareDim - x, cellC);
                        counter++;
                    }
                }

            GL.End();
            glControl1.SwapBuffers();
            toolStripLabel_cellscount.Text = "Число ячеек: " + counter.ToString();
        }

        /// <summary>
        /// Метод для регулирования зоны отрисовки
        /// </summary>
        private void cameraChanged()
        {
            int w = glControl1.Width;
            int h = glControl1.Height;
            glControl1.MakeCurrent();
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            GL.Ortho(x_position, x_position + w, y_position, y_position + h, -1, 1);
            GL.Viewport(0, 0, w, h);

            GL.End();
        }

        /// <summary>
        /// Регулировка компонента отрисовки и скроллбаров
        /// </summary>
        private void FullSize()
        {
            glControl1.Size = new Size(this.Width - 2*vScrollBar1.Width, hScrollBar1.Location.Y - 1);
            vScrollBar1.Location = new Point(this.Width - 2*vScrollBar1.Width, vScrollBar1.Location.Y);
            hScrollBar1.Size = new Size(glControl1.Width, hScrollBar1.Size.Height);
            
            cameraChanged();
            paint(Cells);
        }

        /// <summary>
        /// Отрисовка ячейки
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="col"></param>
        private void drawSquare(int i, int j, Color col)
        {
            GL.Color3(col);

            GL.Vertex2(i, j);
            GL.Vertex2(i, j + squareDim);
            GL.Vertex2(i + squareDim, j + squareDim);
            GL.Vertex2(i + squareDim, j);
        }

        /// <summary>
        /// Обработчик отрисовки содержимого компонента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            paint(Cells);
        }

        /// <summary>
        /// Загрузка компонента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl1_Load(object sender, EventArgs e)
        {
            cameraChanged();
        }

        /// <summary>
        /// Обработчик нажатия на glControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl1_MouseDown(object sender, MouseEventArgs e)
        {
            
                int pixCollumn = (e.Y + Math.Abs(y_position)) / (squareDim + 1);
                int pixRow = (e.X + Math.Abs(x_position)) / (squareDim + 1);

                try
                {
                    if (Cells[pixCollumn, pixRow] == 1)
                        Cells[pixCollumn, pixRow] = 0;
                    else
                        Cells[pixCollumn, pixRow] = 1;
                    paint(Cells);
                }
                catch { }
            
        }


        #region timer.Interval control

        /// <summary>
        /// Обработчик тика таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerationTimer_Tick(object sender, EventArgs e)
        {
            step(Cells, Evolut, r_surv, r_born);
            paint(Cells);
            evolution++;
            toolStripLabel_steps.Text = "Число шагов: " + evolution;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "1 с"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oneSecTSMI_Click(object sender, EventArgs e)
        {
            GenerationTimer.Interval = 1000;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "500 мс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fhmsTSMI_Click(object sender, EventArgs e)
        {
            GenerationTimer.Interval = 500;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "250 мс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thfmsTSMI_Click(object sender, EventArgs e)
        {
            GenerationTimer.Interval = 250;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "50 мс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fmsTSMI_Click(object sender, EventArgs e)
        {
            GenerationTimer.Interval = 50;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "1 мс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onemsTSMI_Click(object sender, EventArgs e)
        {
            GenerationTimer.Interval = 1;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Увеличить скорость"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addtimeTSSB_ButtonClick(object sender, EventArgs e)
        {
            if (GenerationTimer.Interval > 51)
                GenerationTimer.Interval -= 50;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Уменьшить скорость"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removetimeTSB_Click(object sender, EventArgs e)
        {
            if (GenerationTimer.Interval <= 950)
                GenerationTimer.Interval += 50;
            ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
        }

        #endregion

        /// <summary>
        /// Обработчик скроллинга горизонтального скролбара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.SmallIncrement)
            {
                if (x_position <  n * (squareDim + 1) - glControl1.Width )
                {
                    x_position += squareDim;
                    cameraChanged();
                    paint(Cells);
                }
                return;
            }

            if (e.Type == ScrollEventType.SmallDecrement)
            {
                if (x_position > 0)
                {
                    x_position -= squareDim;
                    cameraChanged();
                    paint(Cells);
                }
                return;
            }

            if (e.Type == ScrollEventType.ThumbTrack && (e.NewValue > e.OldValue))
            {
                x_position = hScrollBar1.Value;
                cameraChanged();
                paint(Cells);
                return;
            }

            if (e.Type == ScrollEventType.ThumbTrack && (e.NewValue < e.OldValue))
            {
                x_position = hScrollBar1.Value;
                cameraChanged();
                paint(Cells);
                return;
            }
        }

        /// <summary>
        /// Обработчик скроллинга вертикального скроллбара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.SmallIncrement)
            {
                //Тык вниз
                if (Math.Abs(y_position) < n * (squareDim + 1) - glControl1.Height + 10*squareDim)  //<= // +1 костыли
                {
                    y_position -= (squareDim + 1);
                    cameraChanged();
                    paint(Cells);
                }
                return;
            }
            if (e.Type == ScrollEventType.SmallDecrement)
            {
                //Тык вверх
                if (y_position < 0)
                {
                    y_position += squareDim;
                    cameraChanged();
                    paint(Cells);
                }
                return;
            }
            
            if (e.Type == ScrollEventType.ThumbTrack && (e.NewValue > e.OldValue))                  //Инкремент
            {
                y_position = (-1) * vScrollBar1.Value;
                cameraChanged();
                paint(Cells);
                return;
            }

            if (e.Type == ScrollEventType.ThumbTrack && (e.NewValue < e.OldValue))                  //Декремент
            {
                y_position = (-1) * vScrollBar1.Value;
                cameraChanged();
                paint(Cells);
                return;
            }
        }

        /// <summary>
        /// Обработчик изменения состояния чекбокса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rulesChListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= RULES)
                r_born[e.Index % RULES] = e.NewValue == CheckState.Checked ? true : false;
            else
                r_surv[e.Index] = e.NewValue == CheckState.Checked ? true : false;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Цвет ячейки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorDialogOpen_Click(object sender, EventArgs e)
        {
            SetCellColor();
        }

        /// <summary>
        /// Метод, устанавливающий цвет ячейки
        /// </summary>
        private void SetCellColor()
        {
            colorCellsDialog.ShowDialog();
            cellC = colorCellsDialog.Color;
            paint(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Цвет фона"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backcolorDialogOpen_Click(object sender, EventArgs e)
        {
            SetBackColor();
        }

        /// <summary>
        /// Метод, устанавливающий цвет фона
        /// </summary>
        private void SetBackColor()
        {
            colorBackDialog.ShowDialog();
            backC = colorBackDialog.Color;
            GL.ClearColor(backC);
            paint(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Вероятностое заполнение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_random_Click(object sender, EventArgs e)
        {
            RandomForm rf = new RandomForm();

            //При закрытии формы передается значение рандома
            rf.FormClosing += (sender1, e1) =>
                {
                    if (rf.GetRandVal() != -1)                          //if nothing_changed;
                    {
                        CellAutomaton.DensityFillMatrix(Cells, rf.GetRandVal());
                        paint(Cells);
                    }
                };

            rf.ShowDialog();

        }

        /// <summary>
        /// Обработчик перемещения указателя мыши по элементу glControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            int pixCollumn = (e.Y + Math.Abs(y_position)) / (squareDim + 1);
            int pixRow = (e.X + Math.Abs(x_position)) / (squareDim + 1);

            toolStripLabel_X.Text = "X: " + pixRow.ToString();
            toolStripLabel_Y.Text = "Y: " + pixCollumn.ToString();


                if (e.Button == MouseButtons.Left)
                {
                    try
                    {
                        Cells[pixCollumn, pixRow] = 1;
                        paint(Cells);
                    }
                    catch { return; }
                    return;
                }

                if (e.Button == MouseButtons.Right)
                {
                    try
                    {
                        Cells[pixCollumn, pixRow] = 0;
                        paint(Cells);
                    }
                    catch { return; }
                    return;
                }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_clear_Click(object sender, EventArgs e)
        {
            Clear(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_save_Click(object sender, EventArgs e)
        {
            saveToolStripButton_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Случайное заполнение"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_random0_Click(object sender, EventArgs e)
        {
            btnFillMatrix_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Задержка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStrip_timebtn_Click(object sender, EventArgs e)
        {
            TimeForm time = new TimeForm();

            time.FormClosing += (sender1, e1) =>
            {
                if (time.GetTimeVal() > 0)                          //if nothing_changed;
                {
                    GenerationTimer.Interval = time.GetTimeVal();
                    ToolStrip_timebtn.Text = DELAY + GenerationTimer.Interval;
                    paint(Cells);
                }
            };

            time.ShowDialog();

        }

        /// <summary>
        /// Обработчик нажатия кнопки "Шаг"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_step_Click(object sender, EventArgs e)
        {
            btnEvol_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Описание конфигурации"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CA_Configuration configur = new CA_Configuration(config);

            configur.FormClosing += (sender1, e1) =>
            {
                config = configur.GetConfig();
            };

            configur.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Открыть файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "CA files (*.ca)|*.ca";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.FileName = "";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        SaLo.LoadData(openFileDialog1.FileName, r_surv, r_born, Cells, ref config);
                    }
                }
                catch 
                {

                    MessageBox.Show("Error: Could not read file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SetArrayOfRules();
            paint(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "CA files (*.ca)|*.ca";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {


                    SaLo.SaveData(saveFileDialog1.FileName, r_surv, r_born, Cells, config);

                }
                catch 
                {
                    MessageBox.Show("Error: Could not read file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        /// <summary>
        /// Обработчик изменения состояния чекбокса "Тор"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thorChB_CheckedChanged(object sender, EventArgs e)
        {
            if (thorChB.Checked)
            {
                step = CellAutomaton.CellularAutomaton;
                return;
            }

            step = CellAutomaton.CellularAutomatonNT;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки, скрывающей/раскрывающей правила
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shadowBtn_Click(object sender, EventArgs e)
        {
            if (rulesBox.Visible)
            {
                shadowBtn.Text = "+";
                rulesBox.Visible = !rulesBox.Visible;
                return;
            }
            shadowBtn.Text = "-";
            rulesBox.Visible = !rulesBox.Visible;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Заново"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgain_Click(object sender, EventArgs e)
        {
            Cells = (byte[,])memarr.Clone();
            paint(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramForm aboutProg = new AboutProgramForm();

            aboutProg.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Обнулить количество шагов"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stepsClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            evolution = 0;
            toolStripLabel_steps.Text = STEPS + evolution;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Запуск без прорисовки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void withoutPaintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadrForm cf = new CadrForm(Cells, Evolut, r_surv, r_born, thorChB.Checked);

            cf.FormClosing += (sender1, e1) =>
            {
                if (cf.gen() != null)
                {
                    evolution += (ulong)cf.cadrValue();
                    toolStripLabel_steps.Text = STEPS + evolution;

                    Cells = cf.gen();
                    paint(Cells);
                }
            };

            cf.ShowDialog();

        }

        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var mess = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (mess != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Задержка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip_timebtn_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Цвет ячеек"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cellcolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogOpen_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Цвет фона"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backcolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backcolorDialogOpen_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Открыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openToolStripButton_Click(sender, e);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Справка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void help0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Клеточный автомат — дискретная модель. Включает регулярную решётку ячеек, каждая из которых может находиться в одном из конечного множества состояний, таких как 1 и 0.\n\n\tSurvive - столбец, в котором указывается количество соседних клеток, при котором живая клетка будет жить в следующем поколении.\n\tBorn - столбец, в котором указывается количество соседних клеток, при котором мертвая клетка станет живой в следующем поколении.\n", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var messi = MessageBox.Show("Вы уверены, что хотите создать новую конфигурацию? Текущая конфигурация будет потеряна.", "Создать", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (messi != System.Windows.Forms.DialogResult.OK)
                return;

            Clear(Cells);
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отменить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cells = (byte[,])memarr.Clone();
            paint(Cells);
        }
    }
}