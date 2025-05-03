using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;



namespace CalculatorTests
{
    /// <summary>
    /// Calculator-iin undsen functionality-g shalgah testuudiin tsugluulga
    /// </summary>
    [TestClass]
    
    public class BasicCalculatorTests 
    {
        [TestMethod]
        public void TestAddition()
        {
            var calc = new BasicCalculator();
            calc.Add(100);
            calc.Add(50);
            Assert.AreEqual(150, calc.Result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            var calc = new BasicCalculator();
            calc.Add(20);
            calc.Subtract(8);
            Assert.AreEqual(12, calc.Result);
        }

        [TestMethod]
        public void TestMSandMR()
        {
            var calc = new BasicCalculator();
            calc.Add(12);
            calc.MS();

            calc.Add(5); ///result = 17
            calc.MR();
            Assert.AreEqual(12, calc.Result);
        }

        [TestMethod]
        public void TestAddToMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(10);
            calc.MS();

            calc.MAdd(5);
            calc.MR();
            
            
            Assert.AreEqual(15, calc.Result);
        }

        [TestMethod]
        public void TestSubtractFromMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(20);
            calc.MS();
            
            calc.MSubtract( 7);
            calc.MR();
            
            Assert.AreEqual(13, calc.Result);
        }
        /// <summary>
        /// MC test
        /// </summary>
        [TestMethod]
        
        public void TestClearMemory()
        {
            var calculator = new BasicCalculator();
            calculator.Add(10);
            calculator.MS();
            calculator.MClear();

            
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                calculator.ShowMemory();
                var output = sw.ToString().Trim();
                Assert.AreEqual("Memory empty", output);
            }
        }


        /// <summary>
        /// MemoryClearAll functionality-g shalgah test. Zovhon hooson uyd hevleh stringiig shalgana.
        /// </summary>
        [TestMethod]
        public void TestClearAllMemory()
        {
            var calculator = new BasicCalculator();
            calculator.Add(10);
            calculator.MS();
            calculator.Add(20);
            calculator.MS();
            calculator.MClearAll();

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                calculator.ShowMemory();
                var output = sw.ToString().Trim();
                Assert.AreEqual("Memory empty", output);
            }
        }

        /// <summary>
        /// MRTest
        /// </summary>
        public void TestRecallMemory()

        {
            var calc = new BasicCalculator();
            calc.Add(30);
            calc.MS();

            calc.Add(5);
            calc.MR();

            Assert.AreEqual(30, calc.Result);
        }
    }
}