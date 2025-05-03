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
        /// <summary>
        /// tfhfhgfghfhg
        /// </summary>
        /// <param name="value"></param>
        public void Add(double value)
        {
            Result += value; ///gart baigaa utgiig avan ur dundee nemne
        }

        public void Subtract(double value)
        {
            Result -= value; ///gart baigaa utgiig avan ur dungees hasna
        }

        public void MS()  /// MS uildliig hiideg
        {
            memory.Store(Result); 
        }

        public void MAdd(double value) /// M+ uildliig hiideg
        {
            memory.MAddLast( value);
        }

        public void MSubtract(double value) /// M- uildliig hiideg
        {
            memory.MSubtractLast(value);
        }

        public void MR() /// MR uildliig hiideg
        { 
            Result = memory.MRLast( );
        }

        public void MClear() ///  ali neg item-iig MC hiine 
        {
            memory.ClearLast( );
        }

        public void MClearAll() /// Bugdiig ni MC hiine
        {
            memory.ClearAll();
        }

        public void ShowMemory() /// Memorynd bgaga haruulna
        {
            memory.DisplayMemory();
        }
    }
}
