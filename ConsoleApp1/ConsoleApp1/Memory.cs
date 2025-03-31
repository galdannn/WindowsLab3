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
            Console.WriteLine($"Stored: {value} at index {memoryItems.Count - 1}");
        }
        public void AddToMemory(int index, double value)
        {
            if (IsValidIndex(index))
            {
                memoryItems[index] = new MemoryItem(memoryItems[index].Value + value);
                Console.WriteLine($"Added {value} to memory at index {index}. New value: {memoryItems[index].Value}");
            }
        }
        public void DisplayMemory()
        {
            if (memoryItems.Count == 0)
            {
                Console.WriteLine("Memory is empty.");
                return;
            }

            Console.WriteLine("Memory Items:");
            for (int i = 0; i < memoryItems.Count; i++)
            {
                Console.WriteLine($"[{i}] {memoryItems[i].Timestamp}: {memoryItems[i].Value}");
            }
        }
        private bool IsValidIndex(int index)
        {
            if (index >= 0 && index < memoryItems.Count)
                return true;

            Console.WriteLine($"Invalid index: {index}");
            return false;
        }
    }
}