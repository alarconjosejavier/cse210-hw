using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment first = new Assignment("Samuel Bennett","Multiplication");
        Console.WriteLine(first.GetSummary());

        Console.WriteLine();

        MathAssignment first1 = new MathAssignment("Joselito","Fraction","7.3","8-19");
        Console.WriteLine(first1.GetSummary());
        Console.WriteLine(first1.GetHomeworkList());

        Console.WriteLine();

        WrittingAssignment first2 = new WrittingAssignment("Mary Waters","European History","The Causes of World War II");
        Console.WriteLine(first2.GetSummary());
        Console.WriteLine(first2.GetWrittingInformation());
    }
}