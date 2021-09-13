using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter number 1 of 2:");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine ("Enter number 2 of 2:");
    double num2 = Convert.ToDouble(Console.ReadLine());

    double sum = num1 + num2;
    Console.WriteLine ("The sum of numer 1 and number 2 is " + sum);

    double diff = num1 - num2;
    Console.WriteLine ("The difference of number 1 and number 2 is " + diff);

    double product = num1 * num2;
    Console.WriteLine ("The product of number 1 and number 2 is " + product);

    double quotient = num1 / num2;
    Console.WriteLine ("The quotient of number 1 and number 2 is " + quotient);

    double remainder = num1 % num2;
    Console.WriteLine ("The remainder between number 1 and number 2 is " + remainder);
  }
}