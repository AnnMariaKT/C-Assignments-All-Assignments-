using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Assignment_Part5
{
    public class Program
    {

        static void Main(string[] args)
        {

            //            Assignment 1.Identify the need for single and multidimensional arrays as
            //properties of a class
            //Question : Create a Library class to store and manage books in a single-dimensional array where
            //each element represents a book title.Also, use a two-dimensional array in a Classroom class
            //where each element represents the seat of a student based on rows and columns.


            //Console.WriteLine("Single Dimensional Array");
            //Library library = new Library(4);
            //library.Book(0, "Book1");
            //library.Book(1, "Book2");
            //library.Book(2, "Book3");
            //library.Book(3, "Book4\n");
            //library.DisplayBook();

            //Console.WriteLine("Multi-Dimensional Array");

            //Classroom classroom = new Classroom(2, 2);
            //classroom.SetSeat(0, 0, "Seat1");
            //classroom.SetSeat(0, 1, "Seat2");
            //classroom.SetSeat(1, 0, "Seat3");
            //classroom.SetSeat(1, 1, "Seat4");

            //classroom.DisplaySeat();





            //-------------------------------------------------------------------------------------------------------------------------------------------------------------


            //            Assignment 2.Identify the need for an array of objects
            //Question: Define a Movie class with properties like Title and Year.Create a MovieLibrary class
            //that stores an array of Movie objects and displays each movie’s information.

            //try
            //{
            //    MovieLibrary movieLibrary = new MovieLibrary(4);
            //    movieLibrary.AddMovie(new Movie("Venom", 2024));
            //    movieLibrary.AddMovie(new Movie("Iron Man", 2015));
            //    movieLibrary.AddMovie(new Movie("The Exorcist", 2002));
            //    movieLibrary.DisplayMovieDetails();
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Assignment 3. Identify the need for enumerations
            //Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
            //Define an Order class with an OrderStatus property to manage the status of each order.


            //Order order = new Order(OrderStatus.Pending);
            //order.Display();
            //order.DisplayStatus(OrderStatus.Shipped);
            //order.DisplayStatus(OrderStatus.Delivered);

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------



            //Assignment 4. Identify the need for value types and reference types
            //Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
            //represent a reference type.Show how changing values affects each.


            ////Cicle struct(value type)
            //Circle circle1 = new Circle(5);
            //Circle circle2 = circle1;           //a copy of circle1

            //Console.WriteLine("Actual circle struct :");
            //Console.WriteLine($"Circle1 : {circle1.Radius}");
            //Console.WriteLine($"Circle2 : {circle2.Radius}\n");


            ////Changing Circle2 Value
            //circle2.Radius = 10;
            //Console.WriteLine("After editing circle2 value :");
            //Console.WriteLine($"Circle1 : {circle1.Radius}");
            //Console.WriteLine($"Circle2 : {circle2.Radius}\n");                 //Only changes here


            ////Shape class (ref type)
            //Shape shape1 = new Shape(25);
            //Shape shape2 = shape1;

            //Console.WriteLine("Actual Shape class :");
            //Console.WriteLine($"shape1 : {shape1.Radius}");
            //Console.WriteLine($"shape2 : {shape2.Radius}\n");

            ////Changing shape2 Value(Both value changed)
            //shape2.Radius = 50;
            //Console.WriteLine("After editing circle2 value :");
            //Console.WriteLine($"shape1 : {shape1.Radius}");
            //Console.WriteLine($"shape2 : {shape2.Radius}");

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Assignment 5. Identify the need for pass by reference using ref keyword
            //Question: Create a method IncreaseScore that takes a ref integer parameter representing a
            //player’s score and increases it by 10. 


            ////Initial player score
            //int number = 25;
            //Console.WriteLine("Score : " + number);

            //IncreaseScore increaseScore = new IncreaseScore();                //Creating object
            //increaseScore.Increase(ref number);                               //Calling with ref keyword



            //-------------------------------------------------------------------------------------------------------------------------------------------------------------


            //            Assignment 6.Identify the need for out parameters
            //Question: Create a method Divide that takes two integers, calculates their quotient and
            //remainder, and returns both values using the out keyword.

            //try
            //{
            //    Division division = new Division();
            //    division.Divide(25, 5, out int Quotient, out int remainder);

            //}

            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}






            //-------------------------------------------------------------------------------------------------------------------------------------------------------------



            //Assignment 7.What is Exception and its Types
            //Question: Write a C# program that demonstrates a FileNotFoundException and an 
            //IndexOutOfRangeException. Explain what causes these exceptions.


            ////IndexOutOfRangeException  
            //try
            //{
            //    Exceptions exceptions = new Exceptions();
            //    exceptions.DisplayArray();
            //    Console.WriteLine(exceptions.array[10]);

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            ////FileNotFoundException
            //FileDemo fileDemo = new FileDemo();

            //// Provide a path to a non-existent file
            //string filePath = "non_existent_file.txt";
            //fileDemo.ReadFile(filePath);


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------


            //Assignment 8.How to Handle Exception
            //Question: Create a method GetUserInput that prompts the user to enter an integer. If the input is
            //invalid, catch the exception and prompt the user again until they enter a valid integer.


            //ExceptionHandling exceptionHandling = new ExceptionHandling();
            //int checkinput = exceptionHandling.GetUserInput();
            //Console.WriteLine("Entered valid data");

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //            Assignment 9.Multiple Catch Blocks
            //Question: Create a method that calculates the division of two integers. Use multiple catch blocks
            //to handle DivideByZeroException and FormatException. 

            //try
            //{
            //    Division division = new Division();
            //    division.Divide(25, 5);
            //    division.Divide(25, 0);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------


            //Assignment 10.Finally Block
            //Question: Write a method ReadFile that opens a file, reads its contents, and closes it. Use a 
            //finally block to ensure the file is closed, even if an exception occurs. 


            //FileHandler fileHandler = new FileHandler();

            //// Specify a path to a file (change this path if needed)
            //string filePath = "Finally .txt";

            //// Call the ReadFile method
            //fileHandler.ReadFile(filePath);




            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Assignment 11.Difference between throw and throws
            //Question: Explain the purpose of the throw keyword in C#. Create a method ValidateAge that 
            //throws an exception if the age is below 18, and handle it in the calling method.

            //try
            //{
            //    CheckAge checkAge = new CheckAge();
            //    checkAge.ValidateAge(19);

            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //-------------------------------------------------------------------------------------------------------------------------------------------------------------



            //Assignment 12. Custom Exception 
            //Question: Create a custom exception class NegativeNumberException to handle negative inputs. 
            //Write a method CheckNumber that throws this exception if the number is negative. 


            ////Checks the number
            //try
            //{
            //    NumberChecking numberChecking = new NumberChecking();
            //    numberChecking.CheckNumber(-5);
            //}

            //catch(NegativeNumberException ex)               //Custom exceptiom
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------

            //            Assignment 13.Logging Exceptions
            //Question: Write a method Divide that performs division and logs any DivideByZeroException
            //using the Logger class.



            //LoggingExample.Divide(10, 0);






            //-------------------------------------------------------------------------------------------------------------------------------------------------------------



            //Assignment 15. Explain the Difference between Exception (Checked Exceptions) 
            //and RuntimeException (Unchecked Exceptions) 
            //Objective: 
            // Understand how to handle runtime exceptions (DivideByZeroException,
            //FileNotFoundException). 
            // Learn to create and use custom exceptions for specific scenarios. 
            //Tasks: 

            //1.File Reading with Exception Handling: 
            //o Create a class FileProcessor with a method ReadFileContent(string filePath). 
            //o In this method, attempt to read content from the file located at filePath using 
            //StreamReader. 
            //o Handle FileNotFoundException by printing a message that says "File not found: 
            //<filePath>". 


            FileProcessor processor = new FileProcessor();
            string filepath = "eapmle.txt";
            processor.ReadFile(filepath);




            //2. Math Operation with Exception Handling: 
            //o Create a class MathOperations with a method Divide(int a, int b). 
            //o This method should return the result of dividing a by b. 
            //o Handle DivideByZeroException and print "Cannot divide by zero". 

            try
            {
                MathOperations operations = new MathOperations();
                operations.Divide(25, 5);
                operations.Divide(25, 0);
            }
            catch(DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
            }



            //3. Custom Exception for Age Validation: 
            //o Create a custom exception called InvalidAgeException that inherits from 
            //Exception. 
            //o Create a class Person with a property Age. 
            //o Add a method SetAge(int age) in Person that throws an InvalidAgeException if 
            //age is less than 0 or greater than 120. 
            //o Print "Invalid age provided" if the exception is thrown.

            try
            {
                Person person = new Person();
                person.CheckAge(15);
            }

            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
