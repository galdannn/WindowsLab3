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
            Console.WriteLine($"Result: {Result}");
        }

        public void Subtract(double value)
        {
            Result -= value;
            Console.WriteLine($"Result: {Result}");
        }

        public void StoreToMemory()  // MS
        {
            memory.Store(Result);
        }

        public void AddToMemory(int index, double value) // M+
        {
            memory.AddToMemory(index, value);
        }

        public void SubtractFromMemory(int index, double value) // M-
        {
            memory.SubtractFromMemory(index, value);
        }

        public void RecallMemory(int index) // MR
        {
            Result = memory.Recall(index);
        }

        public void ClearMemory(int index) // MC (specific item)
        {
            memory.Clear(index);
        }

        public void ClearAllMemory() // MC (all)
        {
            memory.ClearAll();
        }

        public void ShowMemory()
        {
            memory.DisplayMemory();
        }
    }
}
