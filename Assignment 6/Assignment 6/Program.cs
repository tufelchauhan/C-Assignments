using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using Assignment_6;

public class Program
{
    List<Employee> employeeList;
    List<Salary> salaryList;

    public Program()
    {
        employeeList = new List<Employee>() {
            new Employee(){ EmployeeID = 1, EmployeeFirstName = "Rajiv", EmployeeLastName = "Desai", Age = 49},
            new Employee(){ EmployeeID = 2, EmployeeFirstName = "Karan", EmployeeLastName = "Patel", Age = 32},
            new Employee(){ EmployeeID = 3, EmployeeFirstName = "Sujit", EmployeeLastName = "Dixit", Age = 28},
            new Employee(){ EmployeeID = 4, EmployeeFirstName = "Mahendra", EmployeeLastName = "Suri", Age = 26},
            new Employee(){ EmployeeID = 5, EmployeeFirstName = "Divya", EmployeeLastName = "Das", Age = 20},
            new Employee(){ EmployeeID = 6, EmployeeFirstName = "Ridhi", EmployeeLastName = "Shah", Age = 60},
            new Employee(){ EmployeeID = 7, EmployeeFirstName = "Dimple", EmployeeLastName = "Bhatt", Age = 53}
        };

        salaryList = new List<Salary>() {
            new Salary(){ EmployeeID = 1, Amount = 1000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 1, Amount = 500, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 1, Amount = 100, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 2, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 2, Amount = 1000, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 3, Amount = 1500, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 4, Amount = 2100, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 2800, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 5, Amount = 600, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 5, Amount = 500, Type = SalaryType.Bonus},
            new Salary(){ EmployeeID = 6, Amount = 3000, Type = SalaryType.Monthly},
            new Salary(){ EmployeeID = 6, Amount = 400, Type = SalaryType.Performance},
            new Salary(){ EmployeeID = 7, Amount = 4700, Type = SalaryType.Monthly}
        };
    }

    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Task 1");
        program.Task1();
        Console.WriteLine("Task 2");
        program.Task2();
        Console.WriteLine("Task 3");
        program.Task3();
    }

    public void Task1()
    {
        //Implementation
        var query =
            salaryList.Join(employeeList,
                            s => s.EmployeeID,
                            e => e.EmployeeID,
                            (s, e) => new
                            {
                                s.EmployeeID,
                                e.EmployeeFirstName,
                                s.Amount,
                            }
                            ).GroupBy(s => s.EmployeeFirstName)
                            .Select(s => new
                            {
                                s.Key,
                                totalAmount = s.Sum(q => q.Amount)
                            })
                            .OrderBy(t => t.totalAmount);

        foreach (var item in query)
        {
            Console.WriteLine($"{item.Key} | {item.totalAmount}");
        }
    }
    public void Task2()
    {
        var query = employeeList.OrderByDescending(e => e.Age)
                                .Skip(1)
                                .Take(1)
                                .Join(salaryList,
                                      e => e.EmployeeID,
                                      s => s.EmployeeID,
                                      (e, s) => new
                                      {
                                          e.EmployeeID,
                                          e.EmployeeFirstName,
                                          e.EmployeeLastName,
                                          s.Amount,
                                          s.Type
                                      })
                                .Where(q => q.Type.Equals(SalaryType.Monthly));
        foreach (var item in query)
        {
            Console.WriteLine($"{item.EmployeeID} || {item.EmployeeFirstName} || {item.EmployeeLastName} || {item.Amount} || {item.Type}");
        }
        //Implementation
    }

    public void Task3()
    {
        var query = employeeList.Where(e => e.Age > 30)
                                .Join(salaryList,
                                      e => e.EmployeeID,
                                      s => s.EmployeeID,
                                      (e, s) => new
                                      {
                                          e.EmployeeID,
                                          s.Amount,
                                      }
                                      )
                                .GroupBy(s => s.EmployeeID)
                                .Select(s => new
                                {
                                    mean = s.Average(q => q.Amount)
                                });
        foreach (var item in query)
        {
            Console.WriteLine($"{item.mean}");
        }
    }
}
