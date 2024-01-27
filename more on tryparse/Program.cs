namespace more_on_tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberAsString = "128";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);
            if (success) { Console.WriteLine("parsing successful " +parsedValue); }
            else { Console.WriteLine("parsing failed"); }
        }
    }
}
