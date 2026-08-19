using System;
using System.Collections.Generic;

// Generic Repository Class
class Repository<T>
{
    private List<T> items = new List<T>();

    // Store object
    public void Add(T item)
    {
        items.Add(item);
    }

    // Retrieve all objects
    public List<T> GetAll()
    {
        return items;
    }
}

// Student Class
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

// Employee Class
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        // Repository for Student
        Repository<Student> studentRepo = new Repository<Student>();

        studentRepo.Add(new Student(1, "Adarsh"));
        studentRepo.Add(new Student(2, "Rahul"));

        Console.WriteLine("Students:");
        foreach (Student s in studentRepo.GetAll())
        {
            Console.WriteLine("ID: " + s.Id + ", Name: " + s.Name);
        }

        // Repository for Employee
        Repository<Employee> employeeRepo = new Repository<Employee>();

        employeeRepo.Add(new Employee(1001, "Amit"));
        employeeRepo.Add(new Employee(1002, "Ravi"));

        Console.WriteLine("\nEmployees:");
        foreach (Employee e in employeeRepo.GetAll())
        {
            Console.WriteLine("ID: " + e.Id + ", Name: " + e.Name);
        }

        Console.ReadLine();
    }
}