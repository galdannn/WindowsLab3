using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class BasicCalculator : AbsCalcs, ICalculations
    {
        private Memory memory;
        public BasicCalculator()
        {
            memory = new Memory();
        }
        public void Add(double value)
        {
            Result += value;
            memory.Store(Result);
        }
        public void Subtract(double value) { 
            Result -= value;
            memory.Store(Result);


        }
        public void ShowMemory()
        {
            memory.DisplayMemory();
        }
    }
}
