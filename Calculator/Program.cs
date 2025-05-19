
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello!");

Console.Write("Input the first number: ");
var userInputOne = Console.ReadLine();
int number1 = int.Parse(userInputOne);

Console.Write("Input the second number: ");
var userInputTwo = Console.ReadLine();
int number2 = int.Parse(userInputTwo);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var choice = Console.ReadLine().ToUpper();

if (EqualsCaseInsensitive(choice, "A"))
{
    var sum = number1 + number2;
    PrintFinalEquation(number1, number2, sum, "+");
}
else if (EqualsCaseInsensitive(choice, "S"))
{
    var difference = number1 - number2;
    PrintFinalEquation(number1, number2, difference, "-");
}
else if (EqualsCaseInsensitive(choice, "M"))
{
    var multiplied = number1 * number2;
    PrintFinalEquation(number1, number2, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid Option");
}

Console.Write("Press any key to close ");
var closeInput = Console.ReadKey();


void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}