using System;

class FindMinMaxTotalAverage
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number of values: ");
            int numCount = int.Parse(Console.ReadLine());
            int[] numArr = new int[numCount];
        
        
            for(int i=0; i<numArr.Length; i++)
            {
                Console.Write("Enter value " + (i+1) + ": ");
                numArr[i] = int.Parse(Console.ReadLine());
            }

            int maximum = numArr[0];
            int minimum = numArr[0];
            int total = 0;
            int average = 0;

            Console.Write("You enter values are : ");
            for(int i=0; i<numArr.Length; i++)
            {
                Console.Write(numArr[i] + " ");

                if(numArr[i] > maximum)
                {
                    maximum = numArr[i];
                }
            
                if(numArr[i] < minimum)
                {
                    minimum = numArr[i];
                }

                total += numArr[i];
            } //end of for loop

            average = total / numArr.Length;

            Console.WriteLine();

            Console.Write("Maximun : " + maximum);
            Console.WriteLine();
            Console.Write("Minimum : " + minimum);
            Console.WriteLine();
            Console.Write("Total : " + total);
            Console.WriteLine();
            Console.Write("Average : " + average);
        } //end of try

        catch(Exception e)
        {
            Console.WriteLine("Invalid value! You can enter only numeric value.");
        } //end of catch

    }
}