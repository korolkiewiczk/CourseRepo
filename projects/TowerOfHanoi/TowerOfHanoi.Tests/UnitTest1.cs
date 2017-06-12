using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TowerOfHanoi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var algorithm = new TowerOfHanoi.Logic.Algorithm();
            algorithm.Solve(5, "A", "B", "C");

            Console.WriteLine(string.Join(" ",algorithm.OperationsList));
        }
    }
}
