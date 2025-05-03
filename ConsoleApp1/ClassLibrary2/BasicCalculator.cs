using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// property-toi, interface ee heregjuulsen undsen toonii mashin
    /// 
    /// </summary>
    public class BasicCalculator : AbsCalcs, ICalculations
    {
        private Memory memory;
        /// <summary>
        /// memory objectoo uusgesen , hereglegdeh toonii mashin
        /// </summary>
        public BasicCalculator()
        {
            memory = new Memory(); ///hereglegdeh memory object-ee shineer uusgej baigaa constructor
           
        }
        /// <summary>
        /// gart baigaa utgiig avan ur dundee nemeh function
        /// </summary>
        /// <param name="value"></param>
        public void Add(double value)
        {
            Result += value; ///gart baigaa utgiig avan ur dundee nemne
        }
        /// <summary>
        /// gart baigaa utgiig avan ur dungees hasah function
        /// </summary>
        /// <param name="value"></param>
        public void Subtract(double value)
        {
            Result -= value; ///gart baigaa utgiig avan ur dungees hasna
        }
        /// <summary>
        /// MemoryItem-iig memory-doo hadgalna.
        /// </summary>
        public void MS()  /// MS uildliig hiideg
        {
            memory.Store(Result); 
        }
        /// <summary>
        /// hamgiin suuliin memoryItem-daa utga nemne
        /// </summary>
        /// <param name="value"></param>
        public void MAdd(double value) /// M+ uildliig hiideg
        {
            memory.MAddLast( value);
        }
        /// <summary>
        /// hamgiin suuliin memoryItem-aas utga hasna
        /// </summary>
        /// <param name="value"></param>
        public void MSubtract(double value) /// M- uildliig hiideg
        {
            memory.MSubtractLast(value);
        }
        /// <summary>
        /// Hamgiin suuliin memory-g duudna
        /// </summary>
        public void MR() /// MR uildliig hiideg
        { 
            Result = memory.MRLast( );
        }
        /// <summary>
        /// Suuliin memoryItem-iig tseverlene buyu 0 bolgono
        /// </summary>
        public void MClear() ///  item-iig MC hiine 
        {
            memory.ClearLast( );
        }
        /// <summary>
        /// listee hoosolno
        /// </summary>
        public void MClearAll() /// Bugdiig ni MC hiine
        {
            memory.ClearAll();
        }
        /// <summary>
        /// Memory buyu listee haruulna
        /// </summary>
        public void ShowMemory() /// Memorynd bgaga haruulna
        {
            memory.DisplayMemory();
        }
    }
}
