// See https://aka.ms/new-console-template for more information

// Calling method of Class1
using MainApp;
using MainApp.Calculator;
using MainApp.Week2;

// Class1 myobj = new Class1();

// MyCalculator calculator = new MyCalculator();
// calculator.Calc();

// myobj.week0();
// Console.WriteLine("Hello, World!");


// Week2
Console.WriteLine("Enter 1st num: ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd num: ");
var num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Choose your option");
Console.WriteLine("Press 1 for If-Else Statement Example");
Console.WriteLine("Press 2 for Switch-Case Statement Example");
Console.WriteLine("Press 3 for While Statement Example");
Console.WriteLine("Press 4 for Do-While Statement Example");
Console.WriteLine("Press 5 for For Statement Example");
Console.WriteLine("Press 6 for For-Each Statement Example");
Console.WriteLine("Enter option: ");
var option = Console.ReadLine();


switch (option)
{
    case "1":
        SelectStatement.IfElse(num1, num2);
        break;

    case "2":
        JumpStatement.SwitchCase();
        break;

    case "3":
        IterationStatement.WhileStatement(num1);
        break;

    case "4":
        IterationStatement.DoWhileStatement(num1);
        break;

    case "5":
        IterationStatement.ForLoop(num1);
        break;

    case "6":
        IterationStatement.ForEachLoop();
        break;

    default:
        Console.WriteLine("Nothing");
        break;
}
