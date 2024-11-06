using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{

    //            Assignment 1.Abstract Class
    //  Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method
    //StopEngine(). Create derived classes Car and Motorcycle that implement the StartEngine()
    //method and override it to show specific behavior for each type of vehicle.



    //    public abstract class Vehicle
    //    {
    //        public abstract void StartEngine();

    //        public void StopEngine()
    //        {
    //            Console.WriteLine("The engine is stopping");
    //        }

    //    }

    //    public class Car : Vehicle    //derived class
    //    {
    //        public override void StartEngine()
    //        {
    //            Console.WriteLine("The Car engine is starting");
    //        }        
    //    }

    //    public class Motorcycle : Vehicle        //derived class
    //    {
    //        public override void StartEngine()
    //        {
    //            Console.WriteLine("The Motorcycle engine is starting");
    //        }
    //    }



    //}





    //----------------------------------------------------------------------------------------------------------





    //            Assignment 2.Virtual Functions
    //Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that
    //override the MakeSound() method to provide their specific implementation.



    //    public class Animal               //Base class
    //    {
    //        public virtual void MakeSound()
    //        {
    //            Console.WriteLine("Animal is making sound");
    //        }
    //    }

    //    public class Dog : Animal         //Derived class from Animal
    //    {
    //        public override void MakeSound()          //Method Overriding the base class method
    //        {
    //            Console.WriteLine("Dog is making sound : Bark");
    //        }

    //    }

    //    public class Cat : Animal         //Derived class from Animal
    //    {
    //        public override void MakeSound()              //Method Overriding the base class method
    //        {
    //            Console.WriteLine("Cat is making sound : Meow");
    //        }

    //    }
    //}



    //----------------------------------------------------------------------------------------------------------




    //    Assignment 3. Interface
    //Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck
    //class, with each class having its own implementation of Drive(). 


    //    interface IDrive                //interface create
    //    {
    //        void Drive();
    //    }

    //    public class Car : IDrive                   //
    //    {
    //        public void Drive()
    //        {
    //            Console.WriteLine("The Car is driving");            //Drive method implemented
    //        }
    //    }

    //    public class Truck : IDrive                   //
    //    {
    //        public void Drive()
    //        {
    //            Console.WriteLine("The Truck is driving");            //Drive method implemented
    //        }
    //    }
    //}




    //----------------------------------------------------------------------------------------------------------

    //            Assignment 4.Interface vs.Abstract Class
    //Write a program that demonstrates the difference between an abstract class and an interface by
    //creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a
    //method Swim(). 

    //    public abstract class Bird          //abstract class
    //    {
    //        public abstract void Fly();             //abstract method declared
    //        public void Sky()                       //Concrete method
    //        {
    //            Console.WriteLine("The bird flies in the sky");
    //        }
    //    }

    //    interface ISwim                         //Interface declared
    //    {
    //        void Swim();                    //method declared
    //    }

    //    public class Swan : Bird, ISwim          //the derived class implements both methods declared in abstract class and interface
    //    {

    //        public override void Fly()
    //        {
    //            Console.WriteLine("The abstract method is implemented here");
    //        }
    //        public void Swim()
    //        {
    //            Console.WriteLine("The method in interface is implemented here");
    //        }
    //    }
    //}





    //----------------------------------------------------------------------------------------------------------


    //            Assignment 5.Static Class
    //Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
    //calling these methods without creating an instance of the class. 


    //    public static class MathOperations                           //Static class declared       
    //    {
    //        public static int Add(int a, int b)                     //static method implemented
    //        {
    //            Console.WriteLine($"{a}  +  {b}");
    //            Console.WriteLine("Sum = ");
    //            return a + b;
    //        }

    //        public static int Multiply(int c, int d)                //static method implemented
    //        {
    //            Console.WriteLine($"{c}  x  {d}");
    //            Console.WriteLine("Product = ");
    //            return c * d;
    //        }
    //    }
    //}





    //----------------------------------------------------------------------------------------------------------



    //            Assignment 6.Extension Methods
    //Create an extension method IsEven() for the int type that returns true if the number is even and
    //false if it is odd.


    //    public class Number                 //Declared a class
    //    {
    //        public int Num1 { get; }
    //        public Number(int num1)
    //        {
    //            Num1 = num1;
    //        }
    //        public void DisplayNumber()            //Method inside class
    //        {
    //            Console.WriteLine($"The number is : {Num1}");
    //        }
    //    }

    //    public static class ExtentsionMethod
    //    {
    //        public static bool IsEven(this int number)             //this keyword makes it an extension
    //        {
    //            return number % 2 == 0;
    //        }
    //    }
    //}






    //----------------------------------------------------------------------------------------------------------


    //            Assignment 7.Partial Class
    //Create a partial class Person that is defined in two files.One file should have the property Name,
    //and the other file should have the method ShowDetails().

    public partial class Person                 //Created a class and consructer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}



//----------------------------------------------------------------------------------------------------------

//            Assignment 8.Partial Methods
//Create a partial class Employee with a partial method CalculateSalary(). Implement the partial
//method in another part of the class and demonstrate its usage.


//public partial class Employee                               //partial class
//{
//    public void CalculateSalary(int salary)                     //partial method
//    {

//    }
//}






//----------------------------------------------------------------------------------------------------------





//            Assignment 9.Indexer
//Create a Library class that contains an array of Book objects.Implement an indexer that allows
//accessing the books by index.Write a method to display all the books in the library. 



//public class Book
//{
//    public string BookName { get; set; }
//    public int Id { get; set; }
//    public int Price { get; set; }

//    public Book(string bookName, int id, int price)
//    {
//        BookName = bookName;
//        Id = id;
//        Price = price;
//    }

//    public override string ToString()           //to display in the given format
//    {
//        return $"Name of Book  : {BookName}   BookID : {Id}  Price : {Price} ";      
//    }


//}

//public class Library
//{
//    public Book[] books;               //Array book to hold Book object

//    public Library(int  bookCount)
//    {
//        books = new Book[bookCount];
//    }

//    public Book this[int index]
//    {
//        get
//        {
//            return books[index];
//        }
//        set
//        {
//            books[index] = value;
//        }
//    }
//    public void Display()
//    {
//        foreach (var book in books)
//        {
//            Console.WriteLine(book);
//        }
//    }

//}



//----------------------------------------------------------------------------------------------------------

//Assignment 10. Exception Handling 
//Write a method Divide that takes two integers as input and returns their division. If a division by 
//zero occurs, catch the exception and display a custom error message. Demonstrate exception 
//handling with a try-catch-finally block. 

//public class ExceptionHandling            // 
//{
//    public void Divide(int Num1, int Num2)              //method to divide two numbers
//    {
//        Console.WriteLine($"{Num1} / {Num2} = {Num1 / Num2} ");

//    }

//}






//----------------------------------------------------------------------------------------------------------
//Assignment 11. Enum 
//Create an enum CarType with values Sedan, SUV, Truck, and Coupe. Write a Car class with a
//property Type of type CarType. Write a method that takes a CarType value and displays a 
//message specific to that type of car. 



//// enum created
//public enum CarType
//{
//    Sedan,
//    SUV,
//    Truck,
//    Coupe
//}

////created class car

//public class Car
//{
//    public CarType Type { get; set; }

//    public Car(CarType type)
//    {
//        Type = type;
//    }

//    public void Display()
//    {
//        switch (Type)                                   //switch case helps to dislpay the required message
//        {
//            case CarType.Sedan:
//                Console.WriteLine("Sedan is chosen");
//                break;
//            case CarType.SUV:
//                Console.WriteLine("SUV is chosen");
//                break;
//            case CarType.Truck:
//                Console.WriteLine("Truck is chosen");
//                break;
//            case CarType.Coupe:
//                Console.WriteLine("Coupe is chosen");
//                break;
//            default:
//                Console.WriteLine("Default is chosen");
//                break;
//        }
//    }
//}



//----------------------------------------------------------------------------------------------------------


//Assignment 12. Attributes 
//Define a custom attribute DeveloperAttribute that takes the name of the developer and the date 
//when the code was last modified. Apply this attribute to a class Calculator and its method Add. 
//Retrieve and display the attribute information at runtime.


[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]

public class DeveloperAttribute : Attribute
{
    public string Name { get; }
    public string Date { get; }

    public DeveloperAttribute(string name, string date)
    {
        Name = name;
        Date = date;
    }
}

[Developer ("Ann" , "27/10/2024")]
class Calculator
{
    [Developer("Maria", "28/11/2024")]
    public int Add(int a, int b)
    {
        return a + b;
    }
}


