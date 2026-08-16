using System;

class StudentUtility
{
    public static double CalculatePercentage(int totalMarks, int obtainedMarks)
    {
        return (obtainedMarks * 100.0) / totalMarks;
    }
    public static string CalculateGrade(double percentage)
    {
        if (percentage >= 90)
            return "A+";
        else if (percentage >= 80)
            return "A";
        else if (percentage >= 70)
            return "B";
        else if (percentage >= 60)
            return "C";
        else if (percentage >= 50)
            return "D";
        else
            return "F";
    }

   
    public static double CalculateAttendance(int presentDays, int totalDays)
    {
        return (presentDays * 100.0) / totalDays;
    }
}

class Question1
{
    static void Main()
    {
        int totalMarks = 500;
        int obtainedMarks = 390;

        // Calling static methods without creating object
        double percentage =
            StudentUtility.CalculatePercentage(totalMarks, obtainedMarks);

        string grade =
            StudentUtility.CalculateGrade(percentage);

        double attendance =
            StudentUtility.CalculateAttendance(85, 100);

        Console.WriteLine("Percentage: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Attendance: " + attendance + "%");
    }
}