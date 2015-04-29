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
    public partial class TimeForm : Form
    {
        private const int nothing_changed = -1;     //Ничего не изменилось
        private int time;                           //Значение задержки

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public TimeForm()
        {
            this.KeyPreview = true;
            time = nothing_changed;
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Отмена"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deny_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accept_Btn_Click(object sender, EventArgs e)
        {
            time = (int)timeValue_numeric.Value;
            this.Close();
        }

        /// <summary>
        /// Метод возвращает значение задержки
        /// </summary>
        /// <returns></returns>
        public int GetTimeVal()
        {
            return time;
        }

        /// <summary>
        /// Обработчик нажатия на клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
