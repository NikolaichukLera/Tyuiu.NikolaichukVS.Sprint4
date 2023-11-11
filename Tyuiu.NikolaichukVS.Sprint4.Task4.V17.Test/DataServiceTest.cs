using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint4.Task4.V17.Lib;

namespace Tyuiu.NikolaichukVS.Sprint4.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 2, 3, 2, 4, 3 },
                                          { 4, 7, 4, 2, 2 },
                                          { 5, 2, 3, 4, 6 },
                                          { 5, 2, 7, 6, 5 },
                                          { 6, 3, 5, 7, 7 } };

            int res = ds.Calculate(mas2);
            int wait = 46;

            Assert.AreEqual(wait, res);
        }
    }
}
