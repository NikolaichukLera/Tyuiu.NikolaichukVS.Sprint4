using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NikolaichukVS.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            int max = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array[3, j] > max)
                    {
                        max = array[3, j];
                    }
                }
            }
            return max;

        }
    }
}
