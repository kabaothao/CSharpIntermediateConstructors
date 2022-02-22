// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace CSharpIntermediateConstructors // Note: actual namespace depends on the project name.
{   

    internal class Program
    {
        static void Main(string[] args)
        {   
            //Customer customer = new Customer(); //a better way is to use var
            var customer = new Customer(1, "John");


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name); //cw for short cut as a code snippet

        }
    }
}




/*
 
What is a Constructor?

 Constructor is a method that is called when an instance of a class is created.

Why do we need a constructor.

The intention is to put an object in an earlier state that is to initialize some of the fields in the

class.


public class Customer
{
    public Customer()
    {
    
    }
}
 */