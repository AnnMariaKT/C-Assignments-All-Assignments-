using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphis
{


    //            Assignment 1: To demonstrate Polymorphism and its Advantages
    //Create a C# program demonstrating polymorphism by using a base class Shape and derived 
    //classes Circle and Rectangle.Each derived class should implement a method Draw(). Show
    //how polymorphism helps in calling the correct method based on the object type.


    //    public class Shape
    //    {
    //        public virtual void Draw()
    //        {
    //            Console.WriteLine("The Base Class Method");
    //        }
    //    }

    //    public class Circle : Shape
    //    {
    //        public override void Draw()
    //        {
    //            Console.WriteLine("The method in derived class Circle ");
    //        }

    //    }

    //    public class Rectangle : Shape
    //    {
    //        public override void Draw()
    //        {
    //            Console.WriteLine("The method in derived class Rectangle ");

    //        }

    //    }
    //}









    //----------------------------------------------------------------------------------------------------------------------------------------------------------

    //Assignment 2. Method Overloading and its uses
    //Create a C# program to show method overloading by implementing a Multiply method with 
    //different parameter types, numbers and order.

    //    public class multiply
    //    {
    //        public int x;
    //        public int y;
    //        public int z;

    //        public int Multiply(int x, int y, int z)
    //        {
    //            return x * y * z;
    //        }
    //        public int Multiply(int x, int y)
    //        {
    //            return x * y;
    //        }

    //        public void Display()
    //        {
    //            Console.WriteLine("Product = ");
    //        }
    //    }
    //}

    //----------------------------------------------------------------------------------------------------------------------------------------------------------

    //Assignment 3. Method Overriding
    //Write a program demonstrating method overriding by creating a base class Vehicle and a derived
    //class Car that overrides the Drive() method.

    //    public class Vehicle
    //    {
    //        public virtual void Drive()
    //        {
    //            Console.WriteLine(" The base class method of drive is called");
    //        }
    //    }
    //    public class Car : Vehicle
    //    {
    //        public override void Drive()
    //        {
    //            Console.WriteLine(" The derived class method of drive is called");
    //        }
    //    }
    //}


    //----------------------------------------------------------------------------------------------------------------------------------------------------------

    //polymorphism assignment question

    //Assignment 4. Scenario of Overriding
    //Consider a scenario of payment processing where different payment methods (e.g., CreditCardPayment,
    //PayPalPayment) override the ProcessPayment() method of a base class Payment. Write a C# program to
    //demonstrate this scenario.

    //public class Payment
    //{
    //    public virtual void ProcessPayment(int amount)
    //    {
    //        Console.WriteLine("base payment");
    //    }
    //}

    //public class CreditCardPayment : Payment
    //{
    //    public override void ProcessPayment(int amount)
    //    {
    //        Console.WriteLine("Payment by credit Card : " +amount);
    //    }
    //}
    //public class PayPalPayment : Payment
    //{
    //    public override void ProcessPayment(int amount)
    //    {
    //        Console.WriteLine("Payment by PayPal : " + amount);

    //    }
    //}


    //----------------------------------------------------------------------------------------------------------------------------------------------------------


    //Assignment 5. Polymorphism with Static Data and Methods. 
    //Create a C# program that demonstrates polymorphism using a base class Employee and derived 
    //classes Manager and Developer. Include a static field to keep track of the total number of 
    //employees and a static method to display the total count. Use method overriding to demonstrate 
    //polymorphism, while also explaining the need for static members in this context.



    //public class Employee
    //{
    //    public static int totalEmployees = 0;

    //    public Employee()
    //    {
    //        totalEmployees++;
    //    }

    //    public static void DisplayTotalEmployees()
    //    {
    //        Console.WriteLine($"Total Employees: {totalEmployees}");
    //    }

    //    public virtual void ShowDetails()
    //    {
    //        Console.WriteLine("Employee Details:");
    //    }
    //}

    //public class Manager : Employee
    //{
    //    public override void ShowDetails()
    //    {
    //        Console.WriteLine("Manager Details");
    //    }
    //}

    //public class Developer : Employee
    //{
    //    public override void ShowDetails()
    //    {
    //        Console.WriteLine("Developer Details");
    //    }
    //}



    //----------------------------------------------------------------------------------------------------------------------------------------------------------




    //Assignment 6. Polymorphism with Arrays as Properties in a Class 
    //Create a C# program demonstrating polymorphism using a base class Employee and derived 
    //classes Manager and Developer. In this program, each employee should have a collection of 
    //tasks (stored in an array) assigned to them. Use arrays as properties in the class to handle this
    //data, and demonstrate how polymorphism and arrays work together in the solution. 


    //public class Employee
    //{
    //    public string[] Task { get; set; }
    //    public Employee(string[] task)
    //    {
    //        Task = task;
    //    }

    //    public virtual void Display()
    //    {
    //        Console.WriteLine("Employee Task");
    //        foreach (string task in Task)
    //        {
    //            Console.WriteLine("Task : " + task);
    //        }
    //    }

    //    public class Manager : Employee
    //    {
    //        public Manager(string[] task) : base(task)
    //        {
    //        }
    //        public override void Display()
    //        {
    //            Console.WriteLine("Manager Task");
    //            foreach (string task in Task)
    //            {
    //                Console.WriteLine("Task : " + task);
    //            }
    //        }
    //    }
    //    public class Developer : Employee
    //    {
    //        public Developer(string[] task) : base(task)
    //        {
    //        }
    //        public override void Display()
    //        {
    //            Console.WriteLine("Developer Task");
    //            foreach (string task in Task)
    //            {
    //                Console.WriteLine("Task : " + task);
    //            }
    //        }
    //    }
    //}




    //----------------------------------------------------------------------------------------------------------------------------------------------------------

    //            Assignment 7: Understanding Early Binding and Late Binding in C# 
    //Create a C# program that demonstrates early binding (compile-time polymorphism) using 
    //method overloading and late binding(runtime polymorphism) using method overriding. This
    //will help illustrate the differences between the two concepts in the context of polymorphism. 


    //    public class CompileTimePolymorphism
    //    {
    //        public int Num1;
    //        public int Num2;
    //        public int Num3;


    //        public int Add(int Num1, int Num2)
    //        {
    //            return Num1 + Num2;
    //        }


    //        public int Add(int Num1, int Num2, int Num3)
    //        {
    //            return Num1 + Num2 + Num3;
    //        }
    //        public void Displayoverloading()
    //        {
    //            Console.WriteLine("Sum = ");
    //        }

    //    }


    //    public class RunTimePolymorphism
    //    {
    //        public virtual void DisplayContent()
    //        {
    //            Console.WriteLine("This is the base class");
    //        }
    //    }

    //    public class Derived : RunTimePolymorphism
    //    {
    //        public override void DisplayContent()
    //        {
    //            Console.WriteLine("This is the derived class class");

    //        }
    //    }
    //}




    //----------------------------------------------------------------------------------------------------------------------------------------------------------

    //    Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and
    //Interfaces in C# 
    //Create a C# program that demonstrates how runtime polymorphism is achieved using abstract 
    //classes and interfaces.Define an abstract class Shape and an interface IShape, implementing
    //these in derived classes to showcase polymorphism.

    //    public abstract class Shape
    //    {
    //        public abstract void Mark();
    //    }

    //    interface IShape
    //    {
    //        void IMark();
    //    }

    //    public class Derive : Shape, IShape
    //    {
    //        public void IMark()
    //        {
    //            Console.WriteLine("Derived class method from interface");
    //        }
    //        public override void Mark()
    //        {
    //            Console.WriteLine("Derived class method from the abstract class");
    //        }
    //    }
    //}



    //----------------------------------------------------------------------------------------------------------------------------------------------------------



    //    Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces
    //Create a C# program that demonstrates the concept of multiple inheritance through interfaces. 
    //The program will define two interfaces, IMovable and IDrawable, and implement them in a class
    //Car that showcases how a class can inherit from multiple interfaces.


    interface IMovable
    {
        void Move();
    }

    interface IDrawable
    {
        void Draw();
    }


    public class Inherit
    {
        public void Move()
        {
            Console.WriteLine("The object is mving");
        }
        public void Draw()
        {
            Console.WriteLine("The image is being Drawn");
        }
    }
}


//----------------------------------------------------------------------------------------------------------------------------------------------------------

//            Assignment 10.Polymorphism in C# with Readonly Property 
//Create a C# program that demonstrates polymorphism with a readonly property. Define a base 
//class and derived classes where each class provides specific behavior for a method, while using a 
//readonly property to ensure that certain values cannot be modified after initialization.


public class Basic
{
    public readonly string Name;

    public Basic(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("Name : " + Name);
    }
}

public class DerivedClass : Basic
{
    public DerivedClass(): base("Alana") { }
    public override void Display()
    {
        Console.WriteLine("Hello " + Name);
    }
}














