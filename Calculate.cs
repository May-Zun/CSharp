using System;

class Calculate
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
            case "+": result = num1+num2; break;
            case "-": result = num1-num2; break;
            case "x": result = num1*num2; break;
            case "/": result = num1/num2; break;
            case "%": result = num1%num2; break;
            default: Console.WriteLine("Please enter correct opreator!"); break;
        }

        if(opera=="+" || opera=="-" || opera=="*" || opera=="/" || opera=="%")
        {
            Console.WriteLine("The result of Number1 " + opera + "Number2 is: " + result);
        }
    }
}