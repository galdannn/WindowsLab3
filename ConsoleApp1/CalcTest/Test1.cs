using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;



namespace CalculatorTests
{
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
            calc.StoreToMemory();

            calc.Add(5); ///result = 17
            calc.RecallMemory(0);
            Assert.AreEqual(12, calc.Result);
        }

        [TestMethod]
        public void TestAddToMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(10);
            calc.StoreToMemory();

            calc.AddToMemory(0, 5);
            calc.RecallMemory(0);
            
            
            Assert.AreEqual(15, calc.Result);
        }

        [TestMethod]
        public void TestSubtractFromMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(20);
            calc.StoreToMemory();
            
            calc.SubtractFromMemory(0, 7);
            calc.RecallMemory(0);
            
            Assert.AreEqual(13, calc.Result);
        }

        [TestMethod]
        public void TestClearSpecificMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(30);
            calc.StoreToMemory();

            calc.ClearMemory(0);

            calc.RecallMemory(0);
            Assert.AreEqual(0, calc.Result);
        }

        [TestMethod]
        public void TestClearAllMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(10); 
            calc.StoreToMemory(); 
            calc.Add(20); 
            calc.StoreToMemory();


            calc.ClearAllMemory();

            
            var stringWriter = new StringWriter();
            var originalConsoleOut = Console.Out; 

            try
            {
                Console.SetOut(stringWriter);  

               
                calc.ShowMemory();  

               
                var output = stringWriter.ToString().Trim(); 
                Assert.AreEqual("Cleared memory at index 0\r\nInvalid index: 0\r\nMemory is empty.", output);
            }
            finally
            {
                
                Console.SetOut(originalConsoleOut);
            }
        }
        public void TestRecallMemory()
        {
            var calc = new BasicCalculator();
            calc.Add(30);
            calc.StoreToMemory();

            calc.Add(5);
            calc.RecallMemory(0);

            Assert.AreEqual(10, calc.Result);
        }
    }
}