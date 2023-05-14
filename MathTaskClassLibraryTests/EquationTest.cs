using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class EquationTest
    {
        [TestMethod]
        public void Discriminant()
        {
            //исходные данные
            int a = 1;
            int b = 5;
            int c = 4;
            string expected = "корни уравнения: -3, -4";

            //получение значения с помощью тестируемого метода
            Equation e = new Equation();
            string actual = e.FindValue(a, b, c);

            //сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, actual);
        }
    }
}
