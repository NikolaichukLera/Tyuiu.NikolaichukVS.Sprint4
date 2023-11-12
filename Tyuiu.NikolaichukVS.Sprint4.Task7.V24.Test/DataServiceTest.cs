using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint4.Task7.V24.Lib;

namespace Tyuiu.NikolaichukVS.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int rows = 3;
            int colums = 5;

            int[,] mtrx = new int[rows, colums];
            string str = "651827384219648";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, colums, str);
            int wait = 1179648;

            Assert.AreEqual(wait, res);
        }
    }
}
