using System;
using System.Collections;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee(){Id = 101,Name = "alf", Gender = "M", Salary = 20000};
            Employee employee2 = new Employee(){Id = 102,Name = "alice",Gender = "F",Salary = 21000};
            Employee employee3 = new Employee(){Id = 103,Name = "bert",Gender = "O",Salary = 24000};
            Employee employee4 = new Employee(){Id = 104,Name = "carl",Gender = "M",Salary = 22000};
            Employee employee5 = new Employee(){Id = 105,Name = "ella",Gender = "F",Salary = 24000};

            Stack<Employee> myStack = new Stack<Employee>();
            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);

            foreach (Employee stackemp in myStack)
            {
                Console.WriteLine($"{stackemp.Id} - {stackemp.Name} - {stackemp.Gender} - {stackemp.Salary}");
                Console.WriteLine($"items left in the stack = {myStack.Count}");
            }
            Console.WriteLine("------------------------------------------------------------");
            while (myStack.Count > 0)
            {
                Employee myemp = myStack.Pop();
                Console.WriteLine($"items left in the stack = {myStack.Count}");
                Console.WriteLine($"{myemp.Id} - {myemp.Name} - {myemp.Gender} - {myemp.Salary}"); 
            }
            myStack.Push(employee1);
            myStack.Push(employee2);
            myStack.Push(employee3);
            myStack.Push(employee4);
            myStack.Push(employee5);
            Console.WriteLine("------------------------------------------------------------");
            if (myStack.Count > 0)
            {
                Employee peekemp = myStack.Peek();
                Console.WriteLine($"{peekemp.Id} - {peekemp.Name} - {peekemp.Gender} - {peekemp.Salary}");
                Console.WriteLine($"items left in the stack = {myStack.Count}");
                Console.WriteLine($"{peekemp.Id} - {peekemp.Name} - {peekemp.Gender} - {peekemp.Salary}");
                Console.WriteLine($"items left in the stack = {myStack.Count}");
            }
            else
            {
                Console.WriteLine("stack is empty");
            }
            Console.WriteLine("------------------------------------------------------------");

            if (myStack.Contains(employee3))
            {
                Console.WriteLine($"mystack has a employee3 {employee3.Name}");
            }
            Console.WriteLine("------------------------------------------------------------");
            //del 2
            List<Employee> emp = new List<Employee>();

            emp.Add(employee1);
            emp.Add(employee2);
            emp.Add(employee3);
            emp.Add(employee4);
            emp.Add(employee5);

            if (emp.Contains(employee2))
            {
                Console.WriteLine(" employee2 exists");
            }
            else
            {
                Console.WriteLine("employee2 is not in the list");
            }
            Console.WriteLine("------------------------------------------------------------");

            Employee employee = emp.Find(x => x.Gender == "M");
            Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary} ");

            Console.WriteLine("------------------------------------------------------------");

            List<Employee> maleemployees = emp.FindAll(x => x.Gender == "M");
            foreach (Employee e in maleemployees)
            {
                Console.WriteLine($"{e.Id} - {e.Name} - {e.Gender} - {e.Salary} ");
            } 
        }
    }
}