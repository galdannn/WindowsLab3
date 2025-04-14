using CalculatorLibrary;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new BasicCalculator();

            calculator.Add(10);
            calculator.StoreToMemory();
            calculator.Subtract(5);
            calculator.StoreToMemory();
            calculator.Add(25);
            calculator.StoreToMemory();
            calculator.ShowMemory();
            calculator.AddToMemory(0, 5);
            calculator.SubtractFromMemory(1, 10);
            calculator.ShowMemory();
            calculator.RecallMemory(1);
            calculator.ClearMemory(0);
            calculator.ShowMemory();
            calculator.ClearAllMemory();
            calculator.ShowMemory();

        }
    }
}
