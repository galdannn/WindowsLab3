using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    internal class MemoryItem
    {
        public double Value { get; private set; }
        public DateTime Timestamp { get; private set; }

        public MemoryItem(double value)
        {
            Value = value;
            Timestamp = DateTime.Now;
        }

        public void Add(double value)
        {
            Value += value;
            Timestamp = DateTime.Now; 
        }

        public void Subtract(double value)
        {
            Value -= value;
            Timestamp = DateTime.Now;
        }

        public void Clear()
        {
            Value = 0;
            Timestamp = DateTime.Now;
        }
    }
}
