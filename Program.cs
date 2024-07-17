using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassVsStructApp.Models;

namespace ClassVsStructApp
{
    internal class Program
    {
        //Structs are value types , each instance has its own copy of data and operates independently.

        //Classes are reference types , multiple variable refer can refer to same object
        //Modifying the object through one variable affects all references to that object.

        static void Main(string[] args)
        {
            Manager manager1 = new Manager();
            Manager manager2 = manager1;

            Employee employee1 = new Employee();
            Employee employee2 = employee1;

            manager1.Salary = 20000;
            employee1.Salary = 10000;

            //Proved by value difference - In class updated value reflected for both objects ,
            //in struct value updated for only 1 instance.

            Console.WriteLine("Employee (Class) vs Manager (Struct)");
            Console.WriteLine("\nDifference proved by Value : ");

            Console.WriteLine($"Employee1 Salary : {employee1.Salary} \nEmployee2 Salary : {employee2.Salary}");
            Console.WriteLine($"manager1 Salary : {manager1.Salary} \nmanager2 Salary : {manager2.Salary}");
 
    
            //Proved by Hashcode difference - for class pointing to same memory location , for struct different.
            Console.WriteLine("\nDifference proved by Hashcode : ");

            Console.WriteLine($"Employee1 : {employee1.GetHashCode()} \nEmployee2 : {employee2.GetHashCode()}");
            Console.WriteLine($"manager1 : {manager1.GetHashCode()} \nmanager2 : {manager2.GetHashCode()}");

            //Proved by Equals 
            Console.WriteLine("\nDifference proved by Equals : ");
            Console.WriteLine("Refernce Type Manager : " + Equals(manager1, manager2));  // Outputs: False
            Console.WriteLine("Value Type Employee :  " + Equals(employee1 , employee2));    // Outputs: True (same reference)


        }
    }
}
