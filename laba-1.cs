using System;

class Program {
  static long CalculatePower(int base, int degree) {
    const int number = 1;
    const int numberLength = 2;
    long result = 1;
    for (int exponentiationCounter = 0; exponentiationCounter < degree; ++exponentiationCounter) {
      result *= base;
    }
    return result;
  }

  static bool TryTransformNumber(string theEnteredNumber, out string transformedNumber) {
    transformedNumber = string.Empty;

    if (theEnteredNumber.Length <= numberLength) {
      return false;
    }

    char secondDigit = theEnteredNumber[number];
    string newNumber = theEnteredNumber.Remove(1, 1);
    transformedNumber = newNumber + secondDigit;

    return true;
  }

  static void Main() {
    Console.Write("\nTask 1:\n");
    Console.Write("Enter the base a: ");
    int base = int.Parse(Console.ReadLine());

    Console.Write("Enter the degree indicator n: ");
    int degree = int.Parse(Console.ReadLine());

    long powerResult = CalculatePower(base, degree);
    Console.WriteLine($"Result: {base} to the extent of {degree} = {powerResult}");

    Console.Write("\nTask 2:\n");
    Console.Write("Enter a number x (more than 2 digits): ");
    string theEnteredNumber = Console.ReadLine();

    if (TryTransformNumber(theEnteredNumber, out string transformedNumber)) {
      Console.WriteLine($"The original number: {theEnteredNumber}");
      Console.WriteLine($"Conversion result: {transformedNumber}");
    }
    else {
      Console.WriteLine($"Mistake: The number must contain more than two digits");
    }

    Console.WriteLine("\nPress any key to exit...");
    Console.ReadKey();
  }
}