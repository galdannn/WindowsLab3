using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MemoryItem
    {
        public double Value { get; }
        public DateTime Timestamp { get; }

        public MemoryItem(double value)
        {
            Value = value;  
            Timestamp = DateTime.Now;   
        }
    }
}
