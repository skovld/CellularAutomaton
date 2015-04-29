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
    public partial class RandomForm : Form
    {
        private const int nothing_changed = -1;         //Ничего не изменилось
        private int rand;                               //Случайности число

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public RandomForm()
        {
            this.KeyPreview = true;
            rand = nothing_changed;
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Cancel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deny_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "OK"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accept_Btn_Click(object sender, EventArgs e)
        {
            rand = (int)randomValue_numeric.Value;
            
            this.Close();
        }

        /// <summary>
        /// Метод возвращает значение %
        /// </summary>
        /// <returns></returns>
        public int GetRandVal()
        {
            return rand;
        }

        /// <summary>
        /// Обработчик нажатий на клавиатуру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

    }
}
