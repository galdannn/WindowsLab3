namespace Calculator

{
    internal class Program
    {
        static void Main()
        {
            BasicCalculator calculator = new BasicCalculator();

            calculator.Add(10);
            calculator.Subtract(5);
            calculator.Add(20);
            calculator.ShowMemory();//sanah oindoo hadgalsan Result aa heden tsagt hiisen medeeleltei ni tsug hevlene.
        }
    }
}
