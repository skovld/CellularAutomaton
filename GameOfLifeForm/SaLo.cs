using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CellularAutomatonForm
{
    static class SaLo
    {
        static string separator = "#";

        /// <summary>
        /// Метод осуществляет сохранение данных в файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="surv">Массив с правилами выживания</param>
        /// <param name="born">Массив с правилами рождения</param>
        /// <param name="matrix">Матрица с клетками</param>
        /// <param name="configur">Строка с конфигурацией</param>
        public static void SaveData(string path, bool[] surv, bool[] born, byte[,] matrix, string configur)
        {
            StreamWriter fstr_out = new StreamWriter(path);
       
            //Сохраняем правила выживания
            for (int i = 0; i < surv.Length; i++)
                if (surv[i])
                    fstr_out.Write("true" + separator );
                else
                    fstr_out.Write("false" + separator);
            fstr_out.WriteLine();

            //Сохраняем правила рождения
            for (int i = 0; i < born.Length; i++)
                if (born[i])
                    fstr_out.Write("true" + separator);
                else
                    fstr_out.Write("false" + separator);
            
            fstr_out.WriteLine();
            //Сохраняем клетки
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    fstr_out.Write(matrix[i, j]);
                fstr_out.WriteLine();
            }

            fstr_out.WriteLine(configur);
            
            fstr_out.Flush();
            fstr_out.Close();
        }

        /// <summary>
        /// Метод осуществляет загрузку данных из файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="surv">Массив с правилами выживания</param>
        /// <param name="born">Массив с правилами рождения</param>
        /// <param name="memory_matrix">Матрица с клетками</param>
        /// <param name="configur">Строка с конфигурацией</param>
        public static void LoadData(string path, bool[] surv, bool[] born, byte[,] memory_matrix, ref string configur)
        {
            //configur = "";
            StreamReader fstr_in = new StreamReader(path);

            //Загружаем правила выживания
            string[] data = fstr_in.ReadLine().Split('#');
            for (int i = 0; i < surv.Length; i++)
                surv[i] = bool.Parse(data[i]);
            //Загружаем правила рождения
            data = fstr_in.ReadLine().Split('#');
            for (int i = 0; i < born.Length; i++)
                born[i] = bool.Parse(data[i]);

            //Загружаем ячейки
            for (int i = 0; i < memory_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < memory_matrix.GetLength(1); j++)
                    if (fstr_in.Read() == '0')
                        memory_matrix[i, j] = 0;
                    else
                        memory_matrix[i, j] = 1;
                fstr_in.ReadLine();
            }

            configur = fstr_in.ReadToEnd();
            fstr_in.Close();
        }
    }
}
