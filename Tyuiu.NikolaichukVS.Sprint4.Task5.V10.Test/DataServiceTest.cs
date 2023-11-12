using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint4.Task5.V10.Lib;

namespace Tyuiu.NikolaichukVS.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -3, -2, 5, 1, 3 },
                                          { 1, -3, 7, -1, 6 },
                                          { -1, 2, 4, 5, -2 },
                                          { -2, 1, 2, 3, -4 },
                                          { -4, 2, 1, 5, -3 } };

            int res = ds.Calculate(mas2);
            int wait = 48;

            Assert.AreEqual(wait, res);
        }
    }
}
