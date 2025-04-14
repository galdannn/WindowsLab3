using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class BasicCalculator : AbsCalcs, ICalculations
    {
        private Memory memory;
        public BasicCalculator()
        {
            memory = new Memory(); ///hereglegdeh memory object-ee shineer uusgej baigaa constructor
        }

        public void Add(double value)
        {
            Result += value; ///gart baigaa utgiig avan ur dundee nemne
            Console.WriteLine($"Result: {Result}");
        }

        public void Subtract(double value)
        {
            Result -= value; ///gart baigaa utgiig avan ur dungees hasna
            Console.WriteLine($"Result: {Result}");
        }

        public void StoreToMemory()  /// MS uildliig hiideg
        {
            memory.Store(Result); 
        }

        public void AddToMemory(int index, double value) /// M+ uildliig hiideg
        {
            memory.AddToMemory(index, value);
        }

        public void SubtractFromMemory(int index, double value) /// M- uildliig hiideg
        {
            memory.SubtractFromMemory(index, value);
        }

        public void RecallMemory(int index) /// MR uildliig hiideg
        {
            Result = memory.Recall(index);
        }

        public void ClearMemory(int index) ///  ali neg item-iig MC hiine 
        {
            memory.Clear(index);
        }

        public void ClearAllMemory() /// Bugdiig ni MC hiine
        {
            memory.ClearAll();
        }

        public void ShowMemory() /// Memorynd bgaga haruulna
        {
            memory.DisplayMemory();
        }
    }
}
