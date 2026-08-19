using System;

class University
{
    // Nested class
    public class Department
    {
        public string DepartmentName;
        public string HODName;
        public int FacultyMembers;

        public Department(string departmentName, string hodName, int facultyMembers)
        {
            DepartmentName = departmentName;
            HODName = hodName;
            FacultyMembers = facultyMembers;
        }

        public void Display()
        {
            Console.WriteLine("Department Name: " + DepartmentName);
            Console.WriteLine("HOD Name: " + HODName);
            Console.WriteLine("Number of Faculty Members: " + FacultyMembers);
        }
    }
}

class Program8
{
    static void Main8()
    {
        University.Department dept =
            new University.Department("Computer Science", "Dr. Sharma", 15);

        dept.Display();

        Console.ReadLine();
    }
}