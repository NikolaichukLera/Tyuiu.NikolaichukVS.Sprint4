using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint4.Task2.V15.Lib;

namespace Tyuiu.NikolaichukVS.Sprint4.Task2.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 3, 2, 4, 5, 6, 4, 5, 3, 7, 5, 4 };

            int res = ds.Calculate(numsArray);
            int wait = 20;

            Assert.AreEqual(wait, res);

        }
    }
}
