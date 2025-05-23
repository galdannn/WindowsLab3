using CalculatorLibrary;

namespace CalculatorApp
{
    internal class Program
    {
       /// <summary>
       /// Toonii mashiniig ashiglaj baigaa undsen programm.
       /// </summary>
        static void Main()
        {
            BasicCalculator calculator = new BasicCalculator();

            calculator.Add(10); //memory item  1
            calculator.MS();
            calculator.Subtract(5); // memory item 2
            calculator.MS();
            calculator.Add(25); // memory item 3 
            calculator.MS();
            calculator.ShowMemory();
            calculator.MAdd(5);
            calculator.MSubtract(10);
            calculator.ShowMemory(); // memory item 3 deer l uildlee hiine 
            calculator.MR();
            calculator.MClear(); // memory item 3 ustsan esehiig shalgana 
            calculator.ShowMemory();
            calculator.MClearAll();
            calculator.ShowMemory();

        }
    }
}
