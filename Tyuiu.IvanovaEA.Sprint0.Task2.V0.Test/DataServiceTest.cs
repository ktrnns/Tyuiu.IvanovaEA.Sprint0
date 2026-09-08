using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovaEA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IvanovaEA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Екатерина";

            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Екатерина", res);
        }
    }
}
