using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter number 1 of 2:");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine ("Enter number 2 of 2:");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int sum = num1 + num2;
    Console.WriteLine ("The sum of number 1 and number 2 is " + sum);

    int diff = num1 - num2;
    Console.WriteLine ("The difference of number 1 and number 2 is " + diff);

    int product = num1 * num2;
    Console.WriteLine ("The product of number 1 and number 2 is " + product);

    int quotient = num1 / num2;
    Console.WriteLine ("The quotient of number 1 and number 2 is " + quotient);

    int remainder = num1 % num2;
    Console.WriteLine ("The remainder between number 1 and number 2 is " + remainder);
  }
}