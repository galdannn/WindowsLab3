using CalculatorLibrary;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new BasicCalculator();

            calculator.Add(10);
            calculator.MS();
            calculator.Subtract(5);
            calculator.MS();
            calculator.Add(25);
            calculator.MS();
            calculator.ShowMemory();
            calculator.MAdd(5);
            calculator.MSubtract(10);
            calculator.ShowMemory();
            calculator.MR();
            calculator.MClear();
            calculator.ShowMemory();
            calculator.MClearAll();
            calculator.ShowMemory();

        }
    }
}
