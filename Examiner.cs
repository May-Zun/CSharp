using System;

class Examiner
{
    static void Main()
    {
        Console.Write("Enter number of student : ");
        int num = int.Parse(Console.ReadLine());
        
        string[] name = {"Name","Gender","Myanmar","Math","English","Total","Pass/Fail"};
        string[] students = new string[num];
        string[] gender = new string[num];
        int[,] marks = new int[num,3];
        int[] total = new int[num];
        bool[,] status = new bool[num,3];
        string[] finalStatus = new string[num];

        int count = 0;
        float averageTotalMarks = 0.0F;
        float averageMyanmarMarks = 0.0F;
        float averageMathMarks = 0.0F;
        float averageEnglishMarks = 0.0F;
        float rate;
        int highestMark = 0;
        string highestStName = null;


        for(int i=0; i<num; i++)
        {
            // for student name
            if(i+1 == 1){
                Console.Write("Enter " + (i+1) + "st student name : ");
            }else if(i+1 == 2){
                Console.Write("Enter " + (i+1) + "nd student name : ");
            }else{
                Console.Write("Enter " + (i+1) + "rd student name : ");
            }
            students[i] = Console.ReadLine();

            // for gender
            Console.Write("Enter gender : ");
            gender[i] = Console.ReadLine();

            // for marks
            for(int j=0; j<3; j++)
            {
                Console.Write("Enter " + students[i] + "\'s " + name[j+2] + " mark : ");
                marks[i,j] = int.Parse(Console.ReadLine());
                if(marks[i,j] < 40)
                {
                    status[i,j] = false;
                }
                else
                {
                    status[i,j] = true;
                }

                total[i] += marks[i,j];
            } //col

            averageTotalMarks += total[i];
            averageMyanmarMarks += marks[i,0];
            averageMathMarks += marks[i,1];
            averageEnglishMarks += marks[i,2];

            // for total marks
            Console.Write("Total mark of " + students[i] + " : " + total[i]);
            
            // for pass/fail
            if(status[i,0]==true && status[i,1]==true && status[i,2]==true)
            {
                finalStatus[i] = "Pass";
                count++;
            }
            else
            {
                finalStatus[i] = "Fail";
            }
            Console.Write( "(" + finalStatus[i] + ")" );

            Console.WriteLine();
        } //row


        Console.WriteLine("All students passed the exam/" + count + " out of " + num + " students passed the exam");
        rate = (100/num) * count;
        Console.WriteLine("Passed Rate : " + rate + "% / 100%");
        Console.WriteLine("Average Mark(All Subjects) : " + averageTotalMarks/num);
        Console.WriteLine("Average Myanmar Marks : " + averageMyanmarMarks/num);
        Console.WriteLine("Average Math Marks : " + averageMathMarks/num);
        Console.WriteLine("Average English Marks : " + averageEnglishMarks/num);

        for(int i=0; i<num; i++)
        {
            if(total[i] > highestMark)
            {
                highestMark = total[i];
                highestStName = students[i];
            }
        }
        Console.WriteLine(highestStName + " got highest mark with " + highestMark + ".");


        // for student summary
        Console.WriteLine("Student Summary");
        for(int i=0; i<name.Length; i++)
        {
            Console.Write(name[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("==== ====== ======= ==== ======= ===== =========");

        for(int i=0; i<num; i++)
        {
            Console.Write(students[i] + " ");
            Console.Write(gender[i] + "  ");
            for(int j=0; j<3; j++)
            {
                Console.Write(marks[i,j] + "    ");
            }
            Console.Write(total[i] + "      ");
            Console.Write(finalStatus[i]);
            Console.WriteLine();
        }

        
    }
}