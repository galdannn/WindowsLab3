using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CalculatorLibrary
{   /// <summary>
/// odoohondoo console deer hiij baigaa bolhoor m+, m-, mr, c zereg uildluud ni hamgiin suuliin memoryItem deer hiigdene 
/// </summary>
    internal class Memory
    {
        private List<MemoryItem> memoryItems;

        public Memory()
        {
            memoryItems = new List<MemoryItem>();
        }
        /// <summary>
        /// ms
        /// </summary>
        /// <param name="value"></param>
        public void Store(double value)
        {
            memoryItems.Add(new MemoryItem(value));
        }
        /// <summary>
        /// m+
        /// </summary>
        /// <param name="value"></param>
        public void MAddLast(double value) 
        {
            if (HasMemoryItem())
            {
                memoryItems.Last().Add(value);
            }
            
        }

        /// <summary>
        /// m-
        /// </summary>
        /// <param name="value"></param>
        public void MSubtractLast(double value)
        {
            if (HasMemoryItem())
            {

                memoryItems.Last().Subtract(value);
            }
        }
        /// <summary>
        /// mr
        /// </summary>
        /// <returns></returns>
        public double MRLast()
        {
            if (HasMemoryItem())
            {
                return memoryItems.Last().Value;
            }
            return 0;
               
            
        }
        /// <summary>
        /// mc
        /// </summary>
        public void ClearLast()
        {
            if (HasMemoryItem())
            {
                memoryItems.RemoveAt(memoryItems.Count - 1);
            }
        }
        /// <summary>
        /// mcAll
        /// </summary>
        public void ClearAll()
        {
            memoryItems.Clear();
        }
        /// <summary>
        /// Delgets
        /// </summary>
        public void DisplayMemory()
        {
            if (!HasMemoryItem())
            {
                Console.WriteLine("Memory empty");
                return;
            }

            Console.WriteLine("Memory Items:");
            foreach (var item in memoryItems)
            {
                Console.WriteLine($"{item.Value}");   
            }
        }
        /// <summary>
        /// MemoryItem baigaa esehiig shalgadag tuslah function
        /// </summary>
        /// <returns></returns>
        private bool HasMemoryItem()
        {
            return memoryItems.Count > 0;       
        }

        
    }
}
