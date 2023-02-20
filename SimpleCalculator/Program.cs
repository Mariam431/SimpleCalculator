namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter the first number:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = double.Parse(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Result: " + result);
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: division by zero");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine("Result: " + result);
                    }
                    break;
                default:
                    Console.WriteLine("Error: invalid operation");
                    break;
            }

            Console.ReadLine();
        }
    }
}


