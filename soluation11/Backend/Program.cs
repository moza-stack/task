using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Calculator();
    }

    static void Calculator()
    {
        Console.Write("Enter first number");
        string input1 = Console.ReadLine();

        Console.Write("Enter operation (+, -, *, /) ");
        string opInput = Console.ReadLine();

        Console.Write("Enter second number");
        string input2 = Console.ReadLine();

        if (!double.TryParse(input1, out double fnum))
        {
            Console.WriteLine("Invalid first number!");
            return;
        }

        if (!double.TryParse(input2, out double snum))
        {
            Console.WriteLine("Invalid second number!");
            return;
        }

        if (string.IsNullOrEmpty(opInput) || opInput.Length != 1)
        {
            Console.WriteLine("Operation must be a single character!");
            return;
        }

        char op = opInput[0];

        if (char.IsLetter(op))
        {
            Console.WriteLine("Error: letters are not allowed!");
            return;
        }

        if (op != '+' && op != '-' && op != '*' && op != '/')
        {
            Console.WriteLine("Unsupported operation!");
            return;
        }

        switch (op)
        {
            case '+':
                Console.WriteLine($"{fnum} + {snum} = {fnum + snum}");
                break;

            case '-':
                Console.WriteLine($"{fnum} - {snum} = {fnum - snum}");
                break;

            case '*':
                Console.WriteLine($"{fnum} * {snum} = {fnum * snum}");
                break;

            case '/':
                if (snum == 0)
                {
                    Console.WriteLine("Cannot divide by zero!");
                    return;
                }
                Console.WriteLine($"{fnum} / {snum} = {fnum / snum}");
                break;
        }
    }
}
