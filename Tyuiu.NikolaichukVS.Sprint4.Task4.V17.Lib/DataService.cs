using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NikolaichukVS.Sprint4.Task4.V17.Lib
{
    public class DataService : ISprint4Task4V17
    {
       
        int ISprint4Task4V17.Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i, j] % 2 ==0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}
