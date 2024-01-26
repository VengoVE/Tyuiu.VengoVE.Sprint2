using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.VengoVE.Sprint2.Task7.V12.Lib;

namespace Tyuiu.VengoVE.Sprint2.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
