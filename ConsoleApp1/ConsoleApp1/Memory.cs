using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Calculator
{
    internal class Memory
    {
        private List<MemoryItem> memoryItems;

        public Memory()
        {
            memoryItems = new List<MemoryItem>();

        }
        public void Store(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }
        public void DisplayMemory()
        {
            Console.WriteLine("Memory:");
            foreach (var item in memoryItems)
            {
                Console.WriteLine($"{item.Timestamp}: {item.Value}");
            }
        }
    }
}