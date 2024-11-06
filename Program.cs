using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            //            Assignment 1.Abstract Class
            //  Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method
            //StopEngine(). Create derived classes Car and Motorcycle that implement the StartEngine()
            //method and override it to show specific behavior for each type of vehicle.


            //Vehicle vehicle = new Vehicle();// object for abstract class cannot be created
            //vehicle.StartEngine();
            //vehicle.StopEngine();

            //Car car = new Car();    
            //car.StartEngine();
            //car.StopEngine();

            //Motorcycle motorcycle = new Motorcycle();
            //motorcycle.StartEngine();
            //motorcycle.StopEngine();




            //----------------------------------------------------------------------------------------------------------


            //            Assignment 2.Virtual Functions
            //Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that
            //override the MakeSound() method to provide their specific implementation.

            //Animal animal = new Animal();
            //animal.MakeSound();

            //Dog dog = new Dog();
            //dog.MakeSound();

            //Cat cat = new Cat();    
            //cat.MakeSound();




            //----------------------------------------------------------------------------------------------------------




            //    Assignment 3. Interface
            //Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck
            //class, with each class having its own implementation of Drive(). 



            //Car car = new Car();        //object for class Car
            //car.Drive();

            //Truck truck = new Truck();  //object for class Truck
            //truck.Drive();


            //----------------------------------------------------------------------------------------------------------

            //            Assignment 4.Interface vs.Abstract Class
            //Write a program that demonstrates the difference between an abstract class and an interface by
            //creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a
            //method Swim(). 



            //Swan swan = new Swan();                 //object declared
            //swan.Fly();                             //method implemented in class Swan
            //swan.Swim();                             //method implemented in class Swan
            //swan.Sky();                              //method called directly




            //----------------------------------------------------------------------------------------------------------


            //            Assignment 5.Static Class
            //Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
            //calling these methods without creating an instance of the class. 


            //Console.WriteLine(MathOperations.Add(4, 4)+"\n");                //Calling the methods without creating an object
            //Console.WriteLine(MathOperations.Multiply(4, 4));


            //----------------------------------------------------------------------------------------------------------



            //            Assignment 6.Extension Methods
            //Create an extension method IsEven() for the int type that returns true if the number is even and
            //false if it is odd.

            //Number num = new Number(25);
            //num.DisplayNumber();

            //bool answer = num.Num1.IsEven();            //the variable num in static receives the value stored in the Num1 variable in the base class
            //Console.WriteLine("Number is even : " +answer);



            //----------------------------------------------------------------------------------------------------------


            //            Assignment 7.Partial Class
            //Create a partial class Person that is defined in two files.One file should have the property Name,
            //and the other file should have the method ShowDetails().


            //Person person = new Person("Maria", 21);            //object created and values are given
            //person.ShowDetails();                  //Displaying the details



            //----------------------------------------------------------------------------------------------------------

            //            Assignment 8.Partial Methods
            //Create a partial class Employee with a partial method CalculateSalary(). Implement the partial
            //method in another part of the class and demonstrate its usage.

            //Employee employee = new Employee();           //created the objext
            //employee.CalculateSalary(2000);               //Displayed the method salary 






            //----------------------------------------------------------------------------------------------------------

            //            Assignment 9.Indexer
            //Create a Library class that contains an array of Book objects.Implement an indexer that allows
            //accessing the books by index.Write a method to display all the books in the library. 

            //Library library = new Library(5);
            // library[0] = new Book("AAA", 101, 200);
            // library[1] = new Book("BBB", 102, 300);
            // library[2] = new Book("CCC", 103, 400);
            // library[3] = new Book("DDD", 104, 500);
            // library[4] = new Book("EEE", 104, 600);

            // library.Display();





            //----------------------------------------------------------------------------------------------------------

            //Assignment 10. Exception Handling 
            //Write a method Divide that takes two integers as input and returns their division. If a division by 
            //zero occurs, catch the exception and display a custom error message. Demonstrate exception 
            //handling with a try-catch-finally block. 

            //ExceptionHandling exception = new ExceptionHandling();
            //try                                                             //try block contains the code to be executed
            //{
            //    exception.Divide(10, 5);

            //    exception.Divide(10, 0);
            //}
            //catch (DivideByZeroException ex)                        //catch block contains the code to be executed when an exception happens
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("he finally block which gets executed in all scenario");
            //}




            //----------------------------------------------------------------------------------------------------------
            //Assignment 11. Enum 
            //Create an enum CarType with values Sedan, SUV, Truck, and Coupe. Write a Car class with a
            //property Type of type CarType. Write a method that takes a CarType value and displays a 
            //message specific to that type of car. 



            //Car car = new Car(CarType.SUV);
            //car.Display();


            //----------------------------------------------------------------------------------------------------------


            //Assignment 12. Attributes 
            //Define a custom attribute DeveloperAttribute that takes the name of the developer and the date 
            //when the code was last modified. Apply this attribute to a class Calculator and its method Add. 
            //Retrieve and display the attribute information at runtime.
            
            
            Type type = typeof(Calculator);
            object[] classAttributes = type.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in classAttributes)
            {
                Console.WriteLine($"Class Developed by : {attr.Name}, Date modified {attr.Date}");
            }

            var methodInfo = type.GetMethod("Add");
            object[] methodAttributes = methodInfo.GetCustomAttributes(false);
            foreach (DeveloperAttribute attr in methodAttributes)
            {
                Console.WriteLine($"Class Developed by : {attr.Name}, Date modified {attr.Date}");
            }
            //----------------------------------------------------------------------------------------------------------





            Console.ReadLine();
        }
    }
}
