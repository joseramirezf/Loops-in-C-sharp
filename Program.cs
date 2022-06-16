Console.WriteLine("C# Loops");
Console.WriteLine("Printing even numbers between two numbers\n");

Console.Write("Enter the first number:");
int firstNumber = Int32.Parse (Console.ReadLine() ?? "0");

Console.Write("Enter the second number:");
int secondNumber = Int32.Parse (Console.ReadLine() ?? "1000");

for (int i = firstNumber; i <= secondNumber; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
    }
}

Console.WriteLine("End of program");