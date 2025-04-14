using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CalculatorLibrary
{
    internal class Memory
    {
        private List<MemoryItem> memoryItems;

        public Memory()
        {
            memoryItems = new List<MemoryItem>(); /// shine hooson memoryitem-iin list uusgene  

        }
        public void Store(double value)
        {
            memoryItems.Add(new MemoryItem(value)); ///MemoryItem uusgeed ehend uusgesen listendee nemne
            Console.WriteLine($"Stored: {value} at index {memoryItems.Count - 1}");
        }
        public void AddToMemory(int index, double value) ///M+
        {
            if (IsValidIndex(index))
            {
                memoryItems[index] = new MemoryItem(memoryItems[index].Value + value);
                Console.WriteLine($"Added {value} to memory at index {index}. New value: {memoryItems[index].Value}");
            }
        }
        public void SubtractFromMemory(int index, double value) ///M-
        {
            if (IsValidIndex(index))
            {
                memoryItems[index] = new MemoryItem(memoryItems[index].Value - value);
                Console.WriteLine($"Subtracted {value} from memory at index {index}. New value: {memoryItems[index].Value}");
            }
        }
        public double Recall(int index) ///MR
        {
            if (IsValidIndex(index))
            {
                Console.WriteLine($"Recalled value at index {index}: {memoryItems[index].Value}");
                return memoryItems[index].Value;
            }
            return 0;
        }
        public void Clear(int index) ///MC
        {
            if (IsValidIndex(index))
            {
                Console.WriteLine($"Cleared memory at index {index}");
                memoryItems.RemoveAt(index);
            }
        }
        public void ClearAll() ///MC ALL
        {
            memoryItems.Clear();
            Console.WriteLine("Memory cleared.");
        }
        public void DisplayMemory() ///Medeellee haruulah
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
        private bool IsValidIndex(int index) ///uildel hiihiig hussen item ni listend baigaa esehiig shalgana.
        {
            if (index >= 0 && index < memoryItems.Count)
                return true;

            Console.WriteLine($"Invalid index: {index}");
            return false;
        }
    }
}