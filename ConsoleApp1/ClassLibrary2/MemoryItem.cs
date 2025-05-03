using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    /// <summary>
    /// memory-d haryalagdah object
    /// </summary>
    internal class MemoryItem
    {
        /// <summary>
        /// property
        /// </summary>
        public double Value { get; private set; }
        
        /// <summary>
        /// memory-d haryalagdah object
        /// </summary>
        /// <param name="value"></param>
        public MemoryItem(double value)
        {
            Value = value;
            
        }
        /// <summary>
        /// nemeh uildel
        /// </summary>
        /// <param name="value"></param>
        public void Add(double value)
        {
            Value += value;
           
        }
        /// <summary>
        /// hasah uildel
        /// </summary>
        /// <param name="value"></param>
        public void Subtract(double value)
        {
            Value -= value;
            
        }
        
    }
}
