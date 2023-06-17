using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your grade percentage: ");
        string gradeObtained = Console.ReadLine();

        int gradeValue = int.Parse(gradeObtained);
        string letterGrade = "";

        if (gradeValue >= 90 )
        {
            letterGrade = "A";
        }
        else if (gradeValue >= 80 )
        {
            letterGrade = "B";
        }
        else if (gradeValue >= 70 )
        {
            letterGrade = "C";
        }
        else if (gradeValue >= 60 )
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your grade is: {letterGrade}");
        
        
        if (gradeValue >= 70)
        {
            Console.WriteLine("You have approved this course. Congrats!! ");
        }
        else
        {
            Console.WriteLine("You didn't meet the requirements to aprove the course. Try again next term!");
        }
    }
}