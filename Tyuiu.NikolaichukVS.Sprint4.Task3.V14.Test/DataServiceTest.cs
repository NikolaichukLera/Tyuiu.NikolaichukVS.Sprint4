using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint4.Task3.V14.Lib;

namespace Tyuiu.NikolaichukVS.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }, };

            int res = ds.Calculate(array);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
