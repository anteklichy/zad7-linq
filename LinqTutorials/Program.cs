﻿using System;
using System.Collections.Generic;
using System.Linq;
using LinqTutorials.Models;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Task1
            Console.WriteLine("Task 1:");
            foreach (var emp in LinqTasks.Task1())
            {
                Console.WriteLine($"Name: {emp.Ename}, Job: {emp.Job}");
            }

            // Task2
            Console.WriteLine("\nTask 2:");
            foreach (var emp in LinqTasks.Task2())
            {
                Console.WriteLine($"Name: {emp.Ename}, Job: {emp.Job}, Sal: {emp.Salary}");
            }

            // Task3
            Console.WriteLine("\nTask 3: Max salary is " + LinqTasks.Task3());

            // Task4
            Console.WriteLine("\nTask 4:");
            foreach (var emp in LinqTasks.Task4())
            {
                Console.WriteLine(emp);
            }

            // Task5
            Console.WriteLine("\nTask 5:");
            foreach (var item in LinqTasks.Task5().Cast<dynamic>())
            {
                Console.WriteLine($"Nazwisko: {item.Nazwisko}, Praca: {item.Praca}");
            }

            // Task6
            Console.WriteLine("\nTask 6:");
            foreach (var item in LinqTasks.Task6().Cast<dynamic>())
            {
                Console.WriteLine($"Employee Name: {item.Ename}, Job: {item.Job}, Department: {item.Dname}");
            }

            // Task7
            Console.WriteLine("\nTask 7:");
            foreach (var job in LinqTasks.Task7().Cast<dynamic>())
            {
                Console.WriteLine($"Praca: {job.Praca}, ma {job.LiczbaPracownikow} pracownikow");
            }

            // Task8
            Console.WriteLine("\nTask 8: Is there any backend programmer? " + (LinqTasks.Task8() ? "Yes" : "No"));

            // Task9
            var result9 = LinqTasks.Task9();
            Console.WriteLine($"\nTask 9: Latest frontend programmer hired: {result9?.Ename}");

            // Task10
            Console.WriteLine("\nTask 10:");
            foreach (var item in LinqTasks.Task10().Cast<dynamic>())
            {
                Console.WriteLine($"Name: {item.Ename}, Job: {item.Job}, Hire Date: {item.HireDate}");
            }

            // Task11
            Console.WriteLine("\nTask 11:");
            foreach (var dept in LinqTasks.Task11().Cast<dynamic>())
            {
                Console.WriteLine($"Department: {dept.name}, Number of Employees: {dept.numOfEmployees}");
            }

            // Task12
            Console.WriteLine("\nTask 12:");
            foreach (var emp in LinqTasks.Task12())
            {
                Console.WriteLine($"Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }

            // Task13 
            int[] numbers = {1,1,1,1,1,1,10,1,1,1,1};
            Console.WriteLine("\nTask 13: Number appearing odd number of times: " + LinqTasks.Task13(numbers));
            
            // Task 14
            Console.WriteLine("\nTask 14 Results:");
            foreach (var dept in LinqTasks.Task14())
            {
                Console.WriteLine($"Dept: {dept.Dname}, Location: {dept.Loc}");
            }

            // Task 15
            Console.WriteLine("\nTask 15 Results:");
            foreach (var job in LinqTasks.Task15())
            {
                //Console.WriteLine($"Job: {job.Job}, Number of Employees: {job.NumberOfEmployees}");
            }

            // Task 16
            Console.WriteLine("\nTask 16 Results:");
            foreach (var pair in LinqTasks.Task16())
            {
                //Console.WriteLine($"Employee: {pair.Emp.Ename}, Department: {pair.Dept.Dname}");
            }
        }
    }
}
