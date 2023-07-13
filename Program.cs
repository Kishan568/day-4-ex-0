using System;

class Program
{
    static void Main()
    {
        // Create a rectangular array to store student marks
        int[,] studMarks = new int[4, 5];

        // Input roll numbers and marks for each student and semester
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Enter roll number for student {0}:", i + 1);
            studMarks[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for semester 1:");
            studMarks[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for semester 2:");
            studMarks[i, 2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for semester 3:");
            studMarks[i, 3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks for semester 4:");
            studMarks[i, 4] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate the total marks for each student
        int[] totalMarks = new int[4];
        for (int i = 0; i < 4; i++)
        {
            totalMarks[i] = studMarks[i, 1] + studMarks[i, 2] + studMarks[i, 3] + studMarks[i, 4];
        }

        // Display the roll numbers, marks, and total marks for each student
        Console.WriteLine("Roll No\tSem1\tSem2\tSem3\tSem4\tTotal");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", studMarks[i, 0], studMarks[i, 1], studMarks[i, 2], studMarks[i, 3], studMarks[i, 4], totalMarks[i]);
        }
        Console.ReadLine();
    }
}