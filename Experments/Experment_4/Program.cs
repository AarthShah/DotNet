using System;

class Program
{
    delegate int MathOperation(int firstNumber, int secondNumber);

    static void Main()
    {
        MathOperation addOperation = AddNumbers;
        MathOperation subtractOperation = delegate (int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        };
        MathOperation multiplyOperation = (firstNumber, secondNumber) => firstNumber * secondNumber;

        Console.WriteLine("Delegates and Lambda Expressions");
        Console.WriteLine("Addition using named method: " + addOperation(10, 5));
        Console.WriteLine("Subtraction using anonymous method: " + subtractOperation(10, 5));
        Console.WriteLine("Multiplication using lambda expression: " + multiplyOperation(10, 5));
    }

    static int AddNumbers(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}
