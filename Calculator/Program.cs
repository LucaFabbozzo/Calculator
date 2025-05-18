
Console.WriteLine("Hello!");

Console.Write("Input the first number: ");
var userInputOne = Console.ReadLine();
int numberOne = int.Parse(userInputOne);

Console.Write("Input the second number: ");
var userInputTwo = Console.ReadLine();
int numberTwo = int.Parse(userInputTwo);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var userInput = Console.ReadLine().ToUpper();
if (userInput == "A")
{
    Console.WriteLine((numberOne + numberTwo));
}
else if (userInput == "S")
{
    Console.WriteLine((numberOne - numberTwo));
}
else if (userInput == "M")
{
    Console.WriteLine((numberOne * numberTwo));
}

Console.Write("Press any key to close ");
var closeInput = Console.ReadKey();
