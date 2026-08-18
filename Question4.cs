using System;

sealed class EmployeePayroll
{
    public double CalculateSalary(double basicSalary, double allowance)
    {
        return basicSalary + allowance;
    }

    public double CalculateTax(double salary)
    {
        return salary * 0.10; // 10% tax
    }

    public double CalculateNetSalary(double salary, double tax)
    {
        return salary - tax;
    }
}

class Program
{
    static void Main()
    {
        EmployeePayroll employee = new EmployeePayroll();

        double basicSalary = 30000;
        double allowance = 5000;

        double salary = employee.CalculateSalary(basicSalary, allowance);
        double tax = employee.CalculateTax(salary);
        double netSalary = employee.CalculateNetSalary(salary, tax);

        Console.WriteLine("Gross Salary: " + salary);
        Console.WriteLine("Tax: " + tax);
        Console.WriteLine("Net Salary: " + netSalary);

        Console.ReadLine();
    }
}