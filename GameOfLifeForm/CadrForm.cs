using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CellularAutomatonForm
{
    
    public partial class CadrForm : Form
    {
        private delegate void step(byte[,] cells, byte[,] evol, bool[] r_surv, bool[] r_born);


        step s;                     //Метод stepNT or step
        private int cadr = 0;       //Количество кадров
        private byte[,] Cells;      //Основная матрица
        private byte[,] Evol;       //Побочная матрица
        private bool[] r_surv;      //Правила выживания
        private bool[] r_born;      //Правила рождения
        private bool trigger0;      //Триггер

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public CadrForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="cells"></param>
        /// <param name="_evol"></param>
        /// <param name="_r_surv"></param>
        /// <param name="_r_born"></param>
        /// <param name="_check"></param>
        public CadrForm(byte[,] cells, byte[,] _evol, bool[] _r_surv, bool[] _r_born, bool _check)
        {
            InitializeComponent();
            Cells = (byte[,])cells.Clone();
            Evol = (byte[,])_evol.Clone();
            r_surv = (bool[])_r_surv.Clone();
            r_born = (bool[])_r_born.Clone();

            if (_check)
                s = CellAutomaton.CellularAutomaton;
            else
                s = CellAutomaton.CellularAutomatonNT;
            
        }


        int percent;                //Отображение процентов

        /// <summary>
        /// Обработчик тика таймера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CadrTimer_Tick(object sender, EventArgs e)
        {
            cadr++;
            s(Cells, Evol, r_surv, r_born);
            percent = (100 * cadr) / (int)numericUpDown1.Value;
            label2.Text = percent  + "%";
            progressBar1.Value = percent;
            if (cadr == (int)numericUpDown1.Value)
            {

                CadrTimer.Enabled = false;
                trigger0 = true;
                this.Close();
            }

        }

        /// <summary>
        /// Обработчик нажатия кнопки "Пуск"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptBtn_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100; //(int)numericUpDown1.Value;

            if ((int)numericUpDown1.Value == 0)
                this.Close();
            else
            {
                numericUpDown1.Enabled = false;

                CadrTimer.Enabled = true;
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void denyBtn_Click(object sender, EventArgs e)
        {
            trigger0 = false;
            this.Close();
        }

        /// <summary>
        /// Метод возвращает сгенерированную конфигурацию
        /// </summary>
        /// <returns></returns>
        public byte[,] gen()
        {
            if (trigger0)
            return (byte[,])Cells.Clone();

            return null;
        }

        /// <summary>
        /// Метод возвращает количество пропущенных поколений
        /// </summary>
        /// <returns></returns>
        public int cadrValue()
        {
            return cadr;
        }
    }
}
