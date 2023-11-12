using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NikolaichukVS.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int rows = 3;
            int colums = 5;

            int[,] mtrx = new int[rows, colums];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * colums + j, 1));

                }
            }
            int count = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        count *= mtrx[i, j];
                    }
                }
            }
            return count;
        }
    }
}
