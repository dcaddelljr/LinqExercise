using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!*/

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of numbers");
            Console.WriteLine($"{numbers.Sum()}\n");

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers");
            Console.WriteLine($"{numbers.Average()}\n");

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order");
            var ascNum = numbers.OrderBy(x => x);
            {
                foreach (var num in ascNum)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Numbers in descending order");
            var desNum = numbers.OrderByDescending(num => num);
            {
                foreach (var item in desNum)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6");
            var greaterThansix = numbers.Where(num => num > 6);

            foreach (var item in greaterThansix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("4 descending numbers");
            var numsFour = numbers.OrderByDescending(x => x).Take(4);

            foreach (var item in numsFour)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            Console.WriteLine("Change value at index 4 to your age");
            
            numbers.SetValue(42, 4);
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("First names that begin with C or S in ascending order");
            var firstName = employees.Where((n => n.FirstName.StartsWith('C')
            || n.FirstName.StartsWith('S'))).
            OrderBy(n => n.FirstName).ToList();

            foreach (var item in firstName)
            {
                Console.WriteLine(item.FirstName + " ");
            }
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Employees over 26 in order by first name");
            var fullName = employees.Where(n => n.Age > 26).OrderBy(n => n.Age).ThenBy(n => n.FirstName);

            foreach (var item in fullName)
            {
                Console.WriteLine(item.FullName);
            }
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum and Average of employees with experience <= 10 and age > 35");
            var exper = employees.Where(n => n.YearsOfExperience <= 10 && n.Age > 35);
            var sumYears = exper.Sum(n => n.YearsOfExperience);
            var avgYears = exper.Average(n => n.YearsOfExperience);

            Console.WriteLine(sumYears + avgYears);
            Console.WriteLine();
            
            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Adding new employee");
            employees = employees.Append(new Employee("Dwight", "Caddell", 42, 20)).ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.Age} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
