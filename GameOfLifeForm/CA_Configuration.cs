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
    public partial class CA_Configuration : Form
    {
        private string config;                  //Строка с данными о конфигурации

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="configur"></param>
        public CA_Configuration(string configur)
        {
            config = configur;
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CA_Configuration_Load(object sender, EventArgs e)
        {
            richTextBox.Text = config;
        }

        /// <summary>
        /// Обработчик изменения текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            config = richTextBox.Text;
        }

        /// <summary>
        /// Метод возвращает строку с данными о конфигурации
        /// </summary>
        /// <returns></returns>
        public string GetConfig()
        {
            config = richTextBox.Text;
            return config;
        }
    }
}
