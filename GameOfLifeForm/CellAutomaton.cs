using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CellularAutomatonForm
{
    static class CellAutomaton
    {
        /// <summary>
        /// Метод заполняет матрицу живыми клетками
        /// </summary>
        /// <param name="matrix">Матрица для заполнения</param>
        public static void FillMatrix(byte[,] matrix)
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = (byte)(rand.Next(0, 2));
        }

        /// <summary>
        /// Метод заполняет каждую ячейку матрицы живой клеткой с вероятностью density
        /// </summary>
        /// <param name="matrix"></param>
        public static void DensityFillMatrix(byte[,] matrix, int density)
        {
            const int percentage = 100;
            Random rand = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (rand.Next(percentage) < density)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
                }
        }

        /// <summary>
        /// Метод переводит клеточный автомат в следующее поколение (тороидальное поле)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="born"></param>
        /// <param name="r_born"></param>
        /// <param name="r_surv"></param>
        public static void Step(byte[,] matrix, byte[,] born, bool[] r_born, bool[] r_surv)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == 0)
                    {
                        if (r_born[NumberOfLiveCellsInThoroidalArray(matrix, i, j)])
                            born[i, j] = 1;
                    }
                    else
                        if (r_surv[NumberOfLiveCellsInThoroidalArray(matrix, i, j)])
                        {
                            born[i, j] = 1;
                        }
        }

        /// <summary>
        /// Метод переводит клеточный автомат в следующее поколение (поле - ограниченная плоскость)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="born"></param>
        /// <param name="r_born"></param>
        /// <param name="r_surv"></param>
        public static void StepNT(byte[,] matrix, byte[,] born, bool[] r_born, bool[] r_surv)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] == 0)
                    {
                        if (r_born[NumberOfLiveCells(matrix, i, j)])
                            born[i, j] = 1;
                    }
                    else
                        if (r_surv[NumberOfLiveCells(matrix, i, j)])
                        {
                            born[i, j] = 1;
                        }
        }

        /// <summary>
        /// Метод возвращает количество живых клеток вокруг выбранной ячейки (поле - ограниченная плоскость)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="i0"></param>
        /// <param name="j0"></param>
        /// <returns></returns>
        static byte NumberOfLiveCells(byte[,] matrix, int i0, int j0)
        {
            //Если элемент находится в [0, j]. 
            if (i0 == 0)
                //[0, 0] - левый верхний угол.
                if (j0 == 0)
                    return (byte)(matrix[i0 + 1, j0] + matrix[i0 + 1, j0 + 1] + matrix[i0, j0 + 1]);
                else
                    //[0, n] - правый верхний угол.
                    if (j0 == matrix.GetLength(1) - 1)
                        return (byte)(matrix[i0, j0 - 1] + matrix[i0 + 1, j0 - 1] + matrix[i0 + 1, j0]);
                    else
                        //[0, j] - по верхней строке массива.
                        return (byte)(matrix[i0, j0 - 1] + matrix[i0, j0 + 1] + matrix[i0 + 1, j0 - 1] +
                            matrix[i0 + 1, j0] + matrix[i0 + 1, j0 + 1]);

            //Если элемент находится в [m, j]
            if (i0 == matrix.GetLength(0) - 1)
                if (j0 == 0)
                    //[m, 0] - левый нижний угол.
                    return (byte)(matrix[i0 - 1, j0] + matrix[i0 - 1, j0 + 1] + matrix[i0, j0 + 1]);
                else
                    //[m, n] - правый нижний угол.
                    if (j0 == matrix.GetLength(1) - 1)
                        return (byte)(matrix[i0, j0 - 1] + matrix[i0 - 1, j0 - 1] + matrix[i0 - 1, j0]);
                    else
                        //[m, j] - по нижней строчке массива
                        return (byte)(matrix[i0, j0 - 1] + matrix[i0, j0 + 1] + matrix[i0 - 1, j0 - 1]
                            + matrix[i0 - 1, j0] + matrix[i0 - 1, j0 + 1]);

            if (j0 == 0)
                return (byte)(matrix[i0, j0 + 1] + matrix[i0 - 1, j0] + matrix[i0 - 1, j0 + 1]
                    + matrix[i0 + 1, j0] + matrix[i0 + 1, j0 + 1]);
            if (j0 == matrix.GetLength(1) - 1)
                return (byte)(matrix[i0, j0 - 1] + matrix[i0 - 1, j0] + matrix[i0 + 1, j0]
                    + matrix[i0 - 1, j0 - 1] + matrix[i0 + 1, j0 - 1]);

            return (byte)(matrix[i0 - 1, j0 - 1] + matrix[i0, j0 - 1] + matrix[i0 + 1, j0 - 1]
                 + matrix[i0 - 1, j0] + matrix[i0 + 1, j0]
                 + matrix[i0 - 1, j0 + 1] + matrix[i0, j0 + 1] + matrix[i0 + 1, j0 + 1]);
        }

        /// <summary>
        /// Метод возвращает количество живых клеток вокруг выбранной ячейки (поле - тор)
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="i0"></param>
        /// <param name="j0"></param>
        /// <returns></returns>
        static byte NumberOfLiveCellsInThoroidalArray(byte[,] matrix, int i0, int j0)
        {
            int n = matrix.GetLength(0);
            int im1 = ((i0 - 1) + n) % n;
            int ip1 = (i0 + 1) % n;
            int jm1 = ((j0 - 1) + n) % n;
            int jp1 = (j0 + 1) % n;

            return (byte)(matrix[im1, jm1] + matrix[im1, j0] + matrix[im1, jp1] +
                   matrix[i0, jm1] + matrix[i0, jp1] +
                   matrix[ip1, jm1] + matrix[ip1, j0] + matrix[ip1, jp1]);
        }

        /// <summary>
        /// Метод перезаписывает исходную матрицу матрицей результата
        /// </summary>
        /// <param name="survival"></param>
        /// <param name="borned"></param>
        public static void StepOfEvolution(byte[,] survival, byte[,] borned)
        {
            for (int i = 0; i < borned.GetLength(0); i++)
                for (int j = 0; j < borned.GetLength(1); j++)
                {
                    survival[i, j] = borned[i, j];
                    borned[i, j] = 0;
                }

        }

        /// <summary>
        /// Метод отвечает за работу клеточного автомата в тороидальном поле
        /// </summary>
        /// <param name="cellular"></param>
        /// <param name="born"></param>
        /// <param name="r_surv"></param>
        /// <param name="r_born"></param>
        public static void CellularAutomaton(byte[,] cellular, byte[,] born, bool[] r_surv, bool[] r_born)
        {
            Step(cellular, born, r_born, r_surv);
            StepOfEvolution(cellular, born);
        }

        /// <summary>
        /// Метод отвечает за работу клеточного автомата в поле ограниченной плоскости
        /// </summary>
        /// <param name="cellular"></param>
        /// <param name="born"></param>
        /// <param name="r_surv"></param>
        /// <param name="r_born"></param>
        public static void CellularAutomatonNT(byte[,] cellular, byte[,] born, bool[] r_surv, bool[] r_born)
        {
            StepNT(cellular, born, r_born, r_surv);
            StepOfEvolution(cellular, born);
        }
    }
}
