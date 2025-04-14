using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal class MemoryItem
    {
        public double Value { get; }
        public DateTime Timestamp { get; }

        public MemoryItem(double value) ///constructor oor ajillana.
        {
            Value = value;
            Timestamp = DateTime.Now;
        }
    }
}
