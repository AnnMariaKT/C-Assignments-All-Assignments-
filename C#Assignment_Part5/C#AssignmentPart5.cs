using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace C_Assignment_Part5
{
    //Assignment 1.Identify the need for single and multidimensional arrays as
    //properties of a class
    //Question : Create a Library class to store and manage books in a single-dimensional array where
    //each element represents a book title.Also, use a two-dimensional array in a Classroom class
    //where each element represents the seat of a student based on rows and columns.




    //        public class Library
    //    {
    //        public string[] books;                  //array for book

    //        public Library(int bookCount)
    //        {
    //            books = new string[bookCount];
    //        }

    //        public void Book(int index, string title)
    //        {
    //            books[index] = title;
    //        }

    //        public void DisplayBook()
    //        {
    //            foreach (var book in books)
    //            {
    //                Console.WriteLine(book);
    //            }
    //        }
    //    }

    //    // Class Claaroom
    //    public class Classroom
    //    {
    //        public string[,] seats;                         //Multidimensional array

    //        public Classroom(int row, int columns)
    //        {
    //            seats = new string[row, columns];
    //        }

    //        public void SetSeat(int row, int columns, string StudentName)
    //        {
    //            seats[row, columns] = StudentName;
    //        }
    //        public void DisplaySeat()
    //        {
    //            for (int i = 0; i < seats.GetLength(0); i++)
    //            {
    //                for (int j = 0; j < seats.GetLength(1); j++)
    //                {
    //                    Console.Write(seats[i, j] + "\t");

    //                }
    //                Console.WriteLine();
    //            }
    //        }
    //    }
    //}


    //-------------------------------------------------------------------------------------------------------------------------------------------------------------


    //            Assignment 2.Identify the need for an array of objects
    //Question: Define a Movie class with properties like Title and Year.Create a MovieLibrary class
    //that stores an array of Movie objects and displays each movie’s information.



    //    //class Movie
    //    public class Movie
    //    {
    //        public string Title { get; set; }
    //        public int Year { get; set; }



    //        public Movie(string title, int year)
    //        {
    //            Title = title;
    //            Year = year;
    //        }

    //        //Display the movie Details
    //        public void DisplayMovie()
    //        {
    //            Console.WriteLine($"Tile : {Title}  Year : {Year}");
    //        }

    //    }

    //    //Class MovieLibrary

    //    public class MovieLibrary
    //    {
    //        private Movie[] movies;             //Array to store Movie Object
    //        public int MovieCount;              //Count of Moviess
    //        public MovieLibrary(int size)
    //        {
    //            movies = new Movie[size];
    //            MovieCount = 0;
    //        }

    //        //Method to add Movie to Library
    //        public void AddMovie(Movie movie)
    //        {
    //            if (MovieCount < movies.Length)
    //            {
    //                movies[MovieCount] = movie;
    //                MovieCount++;
    //            }
    //        }

    //        public void DisplayMovieDetails()
    //        {
    //            Console.WriteLine("All Movies : ");
    //            foreach (Movie movie in movies)
    //            {
    //                if (movie != null)
    //                {
    //                    movie.DisplayMovie();
    //                }
    //            }
    //        }
    //    }
    //}


    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Assignment 3. Identify the need for enumerations
    //Question: Create an enumeration OrderStatus with values Pending, Shipped, and Delivered.
    //Define an Order class with an OrderStatus property to manage the status of each order.


    //    //Enum createion
    //    public enum OrderStatus
    //    {
    //        Pending,
    //        Shipped,
    //        Delivered
    //    }

    //    //Class Order
    //    public class Order
    //    {
    //        public OrderStatus Status { get; set; }

    //        public Order(OrderStatus status)
    //        {
    //            Status = status;
    //        }


    //        //Display current status
    //        public void Display()
    //        {
    //            Console.WriteLine("Order Status : " + Status);
    //        }

    //       // Display updated staus
    //        public void DisplayStatus(OrderStatus orderStatus)
    //        {
    //            Status = orderStatus;
    //            Console.WriteLine("Updated Status : " + Status);
    //        }
    //    }
    //}




    //-------------------------------------------------------------------------------------------------------------------------------------------------------------



    //Assignment 4. Identify the need for value types and reference types
    //Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
    //represent a reference type.Show how changing values affects each.

    //struct created
    //    public struct Circle
    //    {
    //        public int Radius { get; set; }

    //        public Circle(int radius)
    //        {
    //            Radius = radius;
    //        }
    //    }


    //    //Class Shape created
    //    public class Shape
    //    {
    //        public int Radius { get; set; }

    //        public Shape(int radius)
    //        {
    //            Radius = radius;
    //        }
    //    }
    //}


    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Assignment 5. Identify the need for pass by reference using ref keyword
    //Question: Create a method IncreaseScore that takes a ref integer parameter representing a
    //player’s score and increases it by 10. 

    //    public class IncreaseScore
    //    {
    //        public void Increase(ref int score)
    //        {
    //            score += 10;
    //            Console.WriteLine("score after increasing : " + score);
    //        }

    //    }
    //}


    //-------------------------------------------------------------------------------------------------------------------------------------------------------------




    //            Assignment 6.Identify the need for out parameters
    //Question: Create a method Divide that takes two integers, calculates their quotient and
    //remainder, and returns both values using the out keyword.



    //    public class Division
    //    {
    //        public void Divide(int num1, int num2, out int Quotient, out int remainder)
    //        {
    //            Quotient = num1 / num2;
    //            remainder = num1 % num2;
    //            Console.WriteLine($"num1 : {num1}  num2 : {num2}");
    //            Console.WriteLine($"Quotient : {Quotient}  remainder : {remainder}");

    //        }
    //    }
    //}






    //-------------------------------------------------------------------------------------------------------------------------------------------------------------



    //Assignment 7.What is Exception and its Types
    //Question: Write a C# program that demonstrates a FileNotFoundException and an 
    //IndexOutOfRangeException. Explain what causes these exceptions.



    //    public class Exceptions
    //    {
    //        public int[] array = { 1, 2, 3, 4, 5 };

    //        public void DisplayArray()
    //        {
    //            {
    //                for (int i = 0; i < array.Length; i++)
    //                {
    //                    Console.WriteLine(array[i]);
    //                }
    //            }
    //        }
    //    }
    //    public class FileDemo
    //    {
    //        public void ReadFile(string filePath)
    //        {
    //            try
    //            {
    //                // Attempt to read a file that doesn't exist
    //                string content = File.ReadAllText(filePath);
    //                Console.WriteLine("File Content: " + content);
    //            }
    //            catch (FileNotFoundException ex)
    //            {
    //                Console.WriteLine("Exception Message: " + ex.Message);
    //            }
    //        }
    //    }
    //}



    //-------------------------------------------------------------------------------------------------------------------------------------------------------------


    //Assignment 8.How to Handle Exception
    //Question: Create a method GetUserInput that prompts the user to enter an integer. If the input is
    //invalid, catch the exception and prompt the user again until they enter a valid integer.


    //    public class ExceptionHandling
    //    {
    //        public int GetUserInput()
    //        {
    //            Console.WriteLine("Enter input : ");
    //            int UserInput;
    //            while (true)
    //            {
    //                try
    //                {
    //                    UserInput = int.Parse(Console.ReadLine());          //Converting it to int
    //                    break;
    //                }

    //                catch (FormatException ex)
    //                {
    //                    Console.WriteLine("Invalid input");
    //                    Console.WriteLine(ex.Message);
    //                }
    //                catch (Exception ex)
    //                {
    //                    Console.WriteLine("Invalid input");
    //                    Console.WriteLine(ex.Message);
    //                }
    //            }
    //            return UserInput;
    //        }
    //    }
    //}



    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    //            Assignment 9.Multiple Catch Blocks
    //Question: Create a method that calculates the division of two integers. Use multiple catch blocks
    //to handle DivideByZeroException and FormatException. 

    //    public class Division
    //    {
    //        public void Divide(int num1, int num2)
    //        {
    //            Console.WriteLine($"num1 = {num1} \tnum2 = {num2}");
    //            Console.WriteLine($"Quotient = {num1 / num2}");
    //        }
    //    }
    //}


    //-------------------------------------------------------------------------------------------------------------------------------------------------------------


    //Assignment 10.Finally Block
    //Question: Write a method ReadFile that opens a file, reads its contents, and closes it. Use a 
    //finally block to ensure the file is closed, even if an exception occurs. 

    //    public class FileHandler
    //    {
    //        // Method to open, read, and close a file, using a finally block to ensure the file is closed

    //        public void ReadFile(string filePath)
    //        {
    //            StreamReader reader = null;
    //            try
    //            {
    //                // Attempt to open the file
    //                reader = new StreamReader(filePath);
    //                Console.WriteLine("File contents:");

    //                // Read and display the file content line by line
    //                string line;
    //                while ((line = reader.ReadLine()) != null)
    //                {
    //                    Console.WriteLine(line);
    //                }
    //            }
    //            catch (FileNotFoundException ex)
    //            {
    //                Console.WriteLine("FileNotFoundException caught!");
    //                Console.WriteLine("Error: The specified file was not found.");
    //                Console.WriteLine("Exception Message: " + ex.Message);
    //            }
    //            catch (Exception ex)
    //            {
    //                Console.WriteLine("An error occurred while reading the file.");
    //                Console.WriteLine("Exception Message: " + ex.Message);
    //            }
    //            finally
    //            {
    //                // Ensure the file is closed, even if an exception occurred
    //                if (reader != null)
    //                {
    //                    reader.Close();
    //                    Console.WriteLine("File closed successfully.");
    //                }
    //            }
    //        }
    //    }
    //}
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    //Assignment 11.Difference between throw and throws
    //Question: Explain the purpose of the throw keyword in C#. Create a method ValidateAge that 
    //throws an exception if the age is below 18, and handle it in the calling method.

    //    public class CheckAge
    //    {
    //        //method to show throw
    //        public void ValidateAge(int Age)
    //        {
    //            if (Age < 18)
    //            {
    //                throw new ArgumentException("Age must be abouve 18");
    //            }
    //            Console.WriteLine("Age is abouve 18");
    //        }
    //    }
    //}

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------



    //Assignment 12. Custom Exception 
    //Question: Create a custom exception class NegativeNumberException to handle negative inputs. 
    //Write a method CheckNumber that throws this exception if the number is negative. 

    //    //Create a custom exception class

    //    public class NegativeNumberException : Exception
    //    {
    //        public NegativeNumberException() : base("Number must be positive") { }
    //        public NegativeNumberException(string message) : base(message)
    //        {
    //            Console.WriteLine("Number Negative");
    //        }
    //    }
    //    //class that checks the number
    //    public class NumberChecking
    //    {
    //        public void CheckNumber(int Number)
    //        {
    //            if (Number < 0)
    //            {
    //                throw new NegativeNumberException("Negative number is Detected");
    //            }
    //            Console.WriteLine("Number is positive");
    //        }
    //    }
    //}



    //-------------------------------------------------------------------------------------------------------------------------------------------------------------



    //            Assignment 13.Logging Exceptions
    //Question: Write a method Divide that performs division and logs any DivideByZeroException
    //using the Logger class.


    //    using System;
    //    public class LoggingExample
    //    {
    //        public static void Divide(int a, int b)
    //        {
    //            try
    //            {
    //                int result = a / b;
    //                Console.WriteLine("Result: " + result);
    //            }
    //            catch (DivideByZeroException ex)
    //            {
    //                Loggerr.LogError("Attempted to divide by zero.", ex);
    //                Console.WriteLine("DivideByZeroException caught and logged.");
    //            }
    //        }
    //    }
    //}



    ////-------------------------------------------------------------------------------------------------------------------------------------------------------------



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

    public class FileProcessor
    {
        // Method to open, read, and close a file, using a finally block to ensure the file is closed
        public void ReadFile(string filePath)
        {
            StreamReader reader = null;
            try
            {
                // Attempt to open the file
                reader = new StreamReader(filePath);
                Console.WriteLine("File contents:");

                // Read and display the file content line by line
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
            }
        }
    }


    //2. Math Operation with Exception Handling: 
    //o Create a class MathOperations with a method Divide(int a, int b). 
    //o This method should return the result of dividing a by b. 
    //o Handle DivideByZeroException and print "Cannot divide by zero". 


    public class MathOperations
    {
        public void Divide(int a, int b)
        {
            Console.WriteLine($"a = {a} b = {b}");
            Console.WriteLine($"Result : {a / b}");
        }

    }


    //    //3. Custom Exception for Age Validation: 
    //    //o Create a custom exception called InvalidAgeException that inherits from 
    //    //Exception. 
    //    //o Create a class Person with a property Age. 
    //    //o Add a method SetAge(int age) in Person that throws an InvalidAgeException if 
    //    //age is less than 0 or greater than 120. 
    //    //o Print "Invalid age provided" if the exception is thrown.


    public class InvalidAgeException : Exception
    {

        public InvalidAgeException(string message) : base(message)
        {
            Console.WriteLine("The age must be between 0 and 120");
        }
    }

    public class Person
    {
        public int Age { get; set; }

        public void CheckAge(int Age)
        {
            if (Age < 0 || Age > 120)
            {
                throw new ArgumentException("The Age is invalid");
            }
            Console.WriteLine("Age is valid");
        }
    }
}
    




