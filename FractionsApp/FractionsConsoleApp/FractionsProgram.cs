using FractionsLibrary;

namespace FractionsConsoleApp
{
    public class FractionsProgram
    {
        private static int numerator1;
        private static int denominator1;
        private static int numerator2;
        private static int denominator2;
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Fraction Calculator!");
                // Get input for first fraction
                Console.Write("Enter numerator for fraction 1: ");
                numerator1 = GetValidNumerator();
                Console.Write("Enter denominator for fraction 1: ");
                denominator1 = GetValidDenominator();

                // Get input for second fraction
                Console.Write("Enter numerator for fraction 2: ");
                numerator2 = GetValidNumerator();
                Console.Write("Enter denominator for fraction 2: ");
                denominator2 = GetValidDenominator();

                // Create Fraction objects
                Fraction fraction1 = new Fraction(numerator1, denominator1);
                Fraction fraction2 = new Fraction(numerator2, denominator2);

                // Perform operations
                Console.WriteLine($"Fraction 1: {fraction1}");
                Console.WriteLine($"Fraction 2: {fraction2}");

                Console.WriteLine($"Addition: {fraction1.Add(fraction2)}");
                Console.WriteLine($"Subtraction: {fraction1.Subtract(fraction2)}");
                Console.WriteLine($"Multiplication: {fraction1.Multiply(fraction2)}");
                Console.WriteLine($"Division: {fraction1.Divide(fraction2)}");
                Console.WriteLine($"Reciprocal of fraction 1: {fraction1.Reciprocal()}");
                Console.WriteLine($"Invert of fraction 1: {fraction1.Invert()}");

                Console.WriteLine($"Fraction 1 result: {fraction1.Result()}");
                Console.WriteLine($"Fraction 2 result: {fraction2.Result()}");
            }
        }
        public static int GetValidNumerator()
        {
            int numerator;
            while (!int.TryParse(Console.ReadLine(), out numerator) || numerator == 0)
            {
                if (numerator == 0)
                    Console.WriteLine("Numerator cannot be zero.");
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return numerator;
        }
        public static int GetValidDenominator()
        {
            int denominator;
            while (!int.TryParse(Console.ReadLine(), out denominator) || denominator == 0)
            {
                if (denominator == 0)
                    Console.WriteLine("Denominator cannot be zero.");
                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return denominator;
        }
    }
}

