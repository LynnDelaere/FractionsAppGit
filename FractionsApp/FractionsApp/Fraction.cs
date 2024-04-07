namespace FractionsLibrary
{
    public class Fraction
    {
        // Attributes
        private int numerator;
        private int denominator;

        //Getters and setters
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    throw new DivideByZeroException("Denominator cannot be zero.");
                }
            }
        }
        //Constructors 
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Methodes
        public Fraction Add(Fraction right)
        {
            Fraction result = new Fraction();
            result.Numerator = (Numerator * right.Denominator) + (Denominator * right.Numerator);
            result.Denominator = Denominator * right.Denominator;
            return result.Simplify();
        }
        public Fraction Subtract(Fraction right)
        {
            Fraction result = new Fraction();
            result.Numerator = (Numerator * right.Denominator) - (Denominator * right.Numerator);
            result.Denominator = Denominator * right.Denominator;
            return result.Simplify();
        }
        public Fraction Multiply(Fraction right)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * right.Numerator;
            result.Denominator = Denominator * right.Denominator;
            return result.Simplify();
        }
        public Fraction Divide(Fraction right)
        {
            Fraction result = new Fraction();

            if (right.Numerator == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            result.Numerator = Numerator * right.Denominator;
            result.Denominator = Denominator * right.Numerator;
            return result.Simplify();
        }
        public Fraction Reciprocal()
        {
            Fraction result = new Fraction();
            if (Numerator < 0)
            {
                result.Numerator = -Denominator;
                result.Denominator = -Numerator;
                return result;
            }
            result.Numerator = Denominator;
            result.Denominator = Numerator;
            return result;
        }
        public Fraction Invert()
        {
            Fraction result = new Fraction();
            if (Denominator < 0)
            {
                result.Numerator = Numerator;
                result.Denominator = -Denominator;
                return result;
            }
            result.Numerator = -Numerator;
            result.Denominator = Denominator;
            return result;
        }
        public Fraction Simplify()
        {
            int a = Math.Abs(Numerator);
            int b = Math.Abs(Denominator);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            int gcd = a;
            int sign = Math.Sign(Numerator) * Math.Sign(Denominator);

            Fraction result = new Fraction();
            result.Numerator = sign * Math.Abs(Numerator) / gcd;
            result.Denominator = Math.Abs(Denominator) / gcd;

            return result;
        }
        public double Result()
        {
            return (double)Numerator / Denominator;
        }
        public override string ToString()
        {
            if (Denominator == 1 || Numerator == 0)
            {
                return $"{Numerator}";
            }

            return $"{Numerator}/{Denominator}";
        }
    }
}
