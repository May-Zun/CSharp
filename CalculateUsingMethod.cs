using System;

class CalculateUsingMehod
{
    static void Main()
    {
    
        Console.Write("Enter a number1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a number2: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter operator(+,-,x,/,%): ");
        string opera = Console.ReadLine();
        int result = 0;

        switch(opera)
        {
            case "+": result = addProcess(num1,num2); break;
            case "-": result = subtractProcess(num1,num2); break;
            case "x": result = multiplyProcess(num1,num2); break;
            case "/": result = divisionProcess(num1,num2); break;
            case "%": result = getRemainerProcess(num1,num2); break;
            default: Console.WriteLine("Please enter correct opreator!"); break;
        }

        if(opera=="+" || opera=="-" || opera=="*" || opera=="/" || opera=="%")
        {
            Console.WriteLine("The result of Number1 " + opera + "Number2 is: " + result);
        }

    }

    static int addProcess(int num1,int num2)
    {
        int result = num1+num2;
        return result;
    }

    static int subtractProcess(int num1,int num2)
    {
        int result = num1-num2;
        return result;
    }

    static int multiplyProcess(int num1,int num2)
    {
        int result = num1*num2;
        return result;
    }

    static int divisionProcess(int num1,int num2)
    {
        int result = num1/num2;
        return result;
    }

    static int getRemainerProcess(int num1,int num2)
    {
        int result = num1%num2;
        return result;
    }
}