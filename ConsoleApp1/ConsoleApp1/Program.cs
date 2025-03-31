namespace Calculator

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
            calculator.AddToMemory(1, 5);
            calculator.SubtractFromMemory(2, 10);
            calculator.ShowMemory();
            calculator.RecallMemory(1);
            calculator.ClearMemory(0);
            calculator.ShowMemory();
            calculator.ClearAllMemory();
            calculator.ShowMemory();

        }
    }
}
