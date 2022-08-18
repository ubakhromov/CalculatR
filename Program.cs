System.Console.Write("Type 1st number: ");
int firstNumber = int.Parse(Console.ReadLine());
System.Console.Write("\nType 2nd number: ");
int secondNumber = int.Parse(Console.ReadLine());

System.Console.WriteLine("Choose the operations: +,-,*,/,%");
string operation = Console.ReadLine();

string result = operation switch 
{
    "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
    "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
    "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
    "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
    "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}"
};
System.Console.WriteLine(result);