
    //"Abbygail Martinez 7/7/2026 COP2360-001 Lab 1: Hello World Program"

    using System.Expressions;
public static void Main()
{
    Console.WriteLine("Addition Calcultion");

    Console.WriteLine("Enter first operand: ");
    int number1 = 2; // Choose the first number to add
    number1 = Convert.ToInt32(Console.ReadLine());// Read the first integer from the user

    Console.WriteLine("Enter operator: ");
    strig caseswitch = (Console.ReadLine();

    Console.WriteLine("Enter second operand");
    int number2 = 2; // Choose the second number to add
    number2 = Convert.ToInt32(Console.ReadLine());// Read the first second from the user

    int sum = 0; // Calculate the sum of the two numbers


    switch (caseswitch)
     case "+":
        sum = number1 + number2;
        Console.WriteLine("Result: " + sum);
        break;
    case "-":
        sum = number1 - number2;
        Console.WriteLine("Result: " + sum);
        break;
    case "*":
        sum = number1 * number2;
        Console.WriteLine("Result: " + sum);
        break;
    case "/":
        sum = number1 / number2;
        Console.WriteLine("Result: " + sum);
        break;
    default:
        Console.WriteLine("You did not enter a correct operator, no calculation was done.");
        break;
    }
