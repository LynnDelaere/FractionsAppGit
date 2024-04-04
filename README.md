# Fractions App

## Project description

In the whole solution you can find a console application, "FractionsConsoleApp", a library "FractionsLibrary", a unit test "FractionsUnitTest" and a WPF application "FractionsWPFApp".

This section provides a short explanation about every part in the solution.

### FractionsConsoleApp

The console application utilizes the custom library called "FractionsLibrary" to function as a fraction calculator. The application asks the user to input the numerator and denominator of two fractions, which are validated to ensure the input is a valid integer and that the denominators are not zero.

Upon valid inputs, the application creates two fraction objects based on the user's input.

The application then preforms arithmetic operations on the two fractions such as addition, subtraction, multiplication, and division on these fractions. Additionally, it computes the reciprocal, where the numerator and denominator are swapped, and the invert of the first fraction. The application also provides a floating-point approximation of the two fractions.

The applications ensures input validity by employing two methodes that continuously prompt the user for input until valid values are provided, preventing the program from crashing due to invalid input.

### FractionsLibrary

In this library the class 'Fractions' is provided, the class represents fractions and provides methods for arithmetic operations such as addition, subtraction, multiplication, and division on fractions.

The class encapsulates the numerator and denominator as private attributes and provides methodes to access and manipulate them.
The propertie methodes allow controlled access to the private attributes. The denominator setter ensures it's never zero by throwing an exception.

The class includes constructors for creating Fraction objects with default values or specified numerator and denominator values.
Methods like Add, Subtract, Multiply, and Divide perform arithmetic operations between fractions. Each method takes another Fraction object as input and returns a new Fraction object representing the result.

The reciprocal method returns a new Fraction object where the numerator and denominator swapped, the invert methode where the numerator had the opposite sign.

The methode simplyfy finds the greatest common divisor of the numerator and denominator and reduces the fraction to its lowest terms. The result method converts the fraction to a double-precision floating-point number.

The ToString method overrides the default behavior and provides a human-readable string representation of the fraction. It considers special cases like whole numbers (denominator of 1) and zero.


### Unit Test

### WPF App

## Author

## Screenshots

## Setup and Usage

## Unit Tests

## UML Class Diagram

## Future Improvements
