using FractionsLibrary;

namespace FractionsUnitTest
{
    public class FractionsUnitTest
    {
        private Fraction fraction = new Fraction();
        
        [Fact]
        public void TestHasPropertyNumerator() //test if the class has a property called Numerator
        {
            fraction.Numerator = 2;
            //set the value of the property Numerator to 2
            Assert.Equal(2, fraction.Numerator);
            //check if the value of the property Numerator is 2
            Assert.NotNull(fraction.GetType().GetProperty("Numerator"));
        }
        [Fact]
        public void TestHasPropertyDenominator() //test if the class has a property called Denominator
        {
            fraction.Denominator = 5;
            //set the value of the property Denominator to 5
            Assert.Equal(5, fraction.Denominator);
            //check if the value of the property Denominator is 5
            Assert.NotNull(fraction.GetType().GetProperty("Denominator"));
        }
        [Fact]
        public void TestDenominatorNotZero() //test if the denominator is not zero
        {
            Assert.Throws<DivideByZeroException>(() => new Fraction(1, 0));
        }
        [Fact]
        public void TestAdd() //test if the add method works
        {
            //test if the add method works with positive numbers
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Add(fractionTest2);
            Assert.Equal(5, result.Numerator);
            Assert.Equal(4, result.Denominator);

            //test if the add method works with negative numbers
            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(-29, result.Numerator);
            Assert.Equal(21, result.Denominator);

            //test if the add method works with a negative and a positive number
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(1, result.Numerator);
            Assert.Equal(5, result.Denominator);

            //test if the add method works with a negative number and zero
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(2, result.Denominator);

            //test if the add method works with zero and zero
            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Add(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        public void TestSubtract() //test if the subtract method works
        {
            //test if the subtract method works with positive numbers
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(4, result.Denominator);

            //test if the subtract method works with negative numbers
            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(1, result.Numerator);
            Assert.Equal(21, result.Denominator);

            //test if the subtract method works with a negative and a positive number
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(-6, result.Numerator);
            Assert.Equal(5, result.Denominator);

            //test if the subtract method works with a negative number and zero
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(2, result.Denominator);

            //test if the subtract method works with zero and zero
            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Subtract(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        public void TestMultiply() //test if the multiply method works
        {
            //test if the multiply method works with positive numbers
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(3, result.Numerator);
            Assert.Equal(8, result.Denominator);

            //test if the multiply method works with negative numbers
            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(10, result.Numerator);
            Assert.Equal(21, result.Denominator);

            //test if the multiply method works with a negative and a positive number
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(-7, result.Numerator);
            Assert.Equal(20, result.Denominator);

            //test if the multiply method works with a negative number and zero
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);

            //test if the multiply method works with zero and zero
            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            result = fractionTest1.Multiply(fractionTest2);
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);
        }
        [Fact]
        public void TestDivide() //test if the divide method works
        {
            //test if the divide method works with positive numbers
            Fraction fractionTest1 = new Fraction(1, 2);
            Fraction fractionTest2 = new Fraction(3, 4);
            Fraction result = fractionTest1.Divide(fractionTest2);
            Assert.Equal(2, result.Numerator);
            Assert.Equal(3, result.Denominator);

            //test if the divide method works with negative numbers
            fractionTest1 = new Fraction(-2, 3);
            fractionTest2 = new Fraction(-5, 7);
            result = fractionTest1.Divide(fractionTest2);
            Assert.Equal(14, result.Numerator);
            Assert.Equal(15, result.Denominator);

            //test if the divide method works with a negative and a positive number
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(7, 10);
            result = fractionTest1.Divide(fractionTest2);
            Assert.Equal(-5, result.Numerator);
            Assert.Equal(7, result.Denominator);

            //test if the divide method works with a negative number and zero
            fractionTest1 = new Fraction(-4, 8);
            fractionTest2 = new Fraction(0, 10);
            Assert.Throws<DivideByZeroException>(() => fractionTest1.Divide(fractionTest2));

            //test if the divide method works with zero and zero
            fractionTest1 = new Fraction(0, 8);
            fractionTest2 = new Fraction(0, 10);
            Assert.Throws<DivideByZeroException>(() => fractionTest1.Divide(fractionTest2));
        }
        [Fact]
        public void TestReciprocal() //test if the reciprocal method works
        {
            //test if the reciprocal method works with positive numbers
            Fraction fractionTest = new Fraction(1, 2);
            Fraction result = fractionTest.Reciprocal();
            Assert.Equal(2, result.Numerator);
            Assert.Equal(1, result.Denominator);

            //test if the reciprocal method works with negative numbers
            fractionTest = new Fraction(-2, 3);
            result = fractionTest.Reciprocal();
            Assert.Equal(-3, result.Numerator);
            Assert.Equal(2, result.Denominator);

            //test if the reciprocal method works with zero
            fractionTest = new Fraction(0, 8);
            Assert.Throws<DivideByZeroException>(() => fractionTest.Reciprocal());
        }
        [Fact]
        public void TestInvert() //test if the invert method works
        {
            //test if the invert method works with positive numbers
            Fraction fractionTest = new Fraction(1, 2);
            Fraction result = fractionTest.Invert();
            Assert.Equal(-1, result.Numerator);
            Assert.Equal(2, result.Denominator);

            //test if the invert method works with negative numbers
            fractionTest = new Fraction(-2, 3);
            result = fractionTest.Invert();
            Assert.Equal(2, result.Numerator);
            Assert.Equal(3, result.Denominator);

            //test if the invert method works with two negative numbers
            fractionTest = new Fraction(-2, -3);
            result = fractionTest.Invert();
            Assert.Equal(-2, result.Numerator);
            Assert.Equal(3, result.Denominator);

            //test if the invert method works with zero
            fractionTest = new Fraction(0, 8);
            result = fractionTest.Invert();
            Assert.Equal(0, result.Numerator);
        }
        [Fact]
        public void TestSimplify() //test if the simplify method works
        {
            //test if the simplify method works with positive numbers
            Fraction fractionTest = new Fraction(150, 66);
            Fraction result = fractionTest.Simplify();
            Assert.Equal(25, result.Numerator);
            Assert.Equal(11, result.Denominator);

            //test if the simplify method works with negative numbers
            fractionTest = new Fraction(-246, 2);
            result = fractionTest.Simplify();
            Assert.Equal(-123, result.Numerator);
            Assert.Equal(1, result.Denominator);

            //test if the simplify method works with zero
            fractionTest = new Fraction(0, 8);
            result = fractionTest.Simplify();
            Assert.Equal(0, result.Numerator);
            Assert.Equal(1, result.Denominator);

        }
        [Fact]
        public void TestResult() //test if the result method works
        {
            //test if the result method works with positive numbers
            Fraction fractionTest = new Fraction(1, 2);
            double result = fractionTest.Result();
            Assert.Equal(0.5, result);

            //test if the result method works with negative numbers
            fractionTest = new Fraction(-2, 3);
            result = fractionTest.Result();
            Assert.Equal(-0.6666666666666666, result);

            //test if the result method works with zero
            fractionTest = new Fraction(0, 8);
            result = fractionTest.Result();
            Assert.Equal(0, result);
        }
        [Fact]
        public void TestToString() //test if the ToString method works
        {
            //test if the ToString method works with positive numbers
            Fraction fractionTest = new Fraction(1, 2);
            string result = fractionTest.ToString();
            Assert.Equal("1/2", result);

            //test if the ToString method works with negative numbers
            fractionTest = new Fraction(-2, 3);
            result = fractionTest.ToString();
            Assert.Equal("-2/3", result);

            //test if the ToString method works with zero
            fractionTest = new Fraction(0, 8);
            result = fractionTest.ToString();
            Assert.Equal("0", result);
        }
    }
}