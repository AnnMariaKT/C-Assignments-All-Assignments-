//C# LAB ASSIGNMENT SEPT 2

//Lab 1: Multiplication table of a given number
//Assignment:
//Write a C# program to print the multiplication table of a given number using the for loop.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(" Enter the number : ");
//            int a = int.Parse(Console.ReadLine());

//            for (int i = 1; i <= 10; i++)
//            {
//                int mul = a * i;
//                Console.WriteLine($"{a} * {i} = {mul}");
//            }
          

//         Console.ReadLine();
//        }
//    }
// }




//Lab: 2 Display a right-angled triangle
//Assignment:
//Write a C# program to display a right-angled triangle pattern using nested for loops.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            for (int i = 0; i <= 4; i++)
//            {
//                for (int j = 0; j <= i; j++)
//                {
//                    Console.Write("* ");
//                }
//                Console.WriteLine();
//            }


//         Console.ReadLine();
//        }
//    }
// }


//Lab 3: Sum of all even numbers between 1 and 100
//Assignment:
//Write a C# program to calculate the sum of all even numbers between 1 and 100 using a while
//loop.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//             int sum = 0;
//             int i = 1;
//             while (i <= 100)
//             {
//             if (i % 2 == 0)
//             {
//                 sum = sum + i;
//             }
//             i++;
//             }
//             Console.WriteLine($"Sum of numbers is :{sum}");

//         Console.ReadLine();
//        }
//    }
// }



//Lab 4: Multiplication table from 1 to 5
//Assignment:
//Write a C# program to print a multiplication table from 1 to 5 using nested while loops.




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//         {
//             for (int i = 1; i <= 5; i++)
//             {
//             Console.WriteLine($"Multiplication table of {i}");

//             for (int j = 1; j <= 10; j++)
//             {
//                 int mul = i * j;
//                 Console.WriteLine($"{i} * {j} = {mul}");

//             }

//             }
            
//         Console.ReadLine();
//        }
//    }
// }





//Lab 5: Print Positive Number
//Assignment:
//Write a C# program to keep asking the user to enter a positive number and print it. The program
//should stop when the user enters a negative number.



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//             while (true)
//             {
//             Console.WriteLine("Enter a positive number :");
//             int num = int.Parse(Console.ReadLine());

//             if (num >= 0)
//             {
//                 Console.WriteLine($"{num}");
//             }
//             else if (num < 0)
//             {
//                 break;
//             }

//             }

//         Console.ReadLine();
//        }
//    }
// }







//Lab 6: Create Menu Driven Calculator
//Assignment:
//Write a C# program to create a basic menu-driven calculator using nested do-while loops. The
//calculator should continue to ask the user for two numbers and an operation (+, -, *, /) until the
//user chooses to exit.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//             int num;
//             do
//             {
//             Console.WriteLine("menu calculator");
//             Console.WriteLine("1. Add");
//             Console.WriteLine("2. Subtract");
//             Console.WriteLine("3. Multiply");
//             Console.WriteLine("4. Divide");
//             Console.WriteLine("5. Exit");
//             Console.Write("Enter your choice: ");
//             num = Convert.ToInt32(Console.ReadLine());

//             if (num >= 1 && num <= 4)
//             {
//                 Console.Write("Enter first number: ");
//                 double a = Convert.ToDouble(Console.ReadLine());
//                 Console.Write("Enter second number: ");
//                 double b = Convert.ToDouble(Console.ReadLine());

//                 switch (num)
//                 {
//                     case 1:
//                         Console.WriteLine("Result: " + (a + b));
//                         break;
//                     case 2:
//                         Console.WriteLine("Result: " + (a - b));
//                         break;
//                     case 3:
//                         Console.WriteLine("Result: " + (a * b));
//                         break;
//                     case 4:
//                         if (b != 0)
//                         {
//                             Console.WriteLine("Result: " + (a / b));
//                         }
//                         else
//                         {
//                             Console.WriteLine("Error! Division by zero is not allowed.");
//                         }
//                         break;
//                 }
//             }
//             else if (num != 5)
//             {
//                 Console.WriteLine("Invalid choice. Please choose a valid option.");
//             }
//             } while (num != 5);

//         Console.ReadLine();
//        }
//    }
// }





//Lab 7: Print All Numbers From 1 to 100
//Assignment:
//Write a C# program to print all numbers from 1 to 100. Use the continue statement to skip
//numbers that are divisible by 3, and use the break statement to stop the loop if the number
//exceeds 50.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//             for (int i = 1; i <= 100; i++)
//             {
//             if (i % 3 != 0)
//             {
//                 Console.WriteLine(i);
//                 continue;
//             }
//             else if (i > 50)
//             {
//                 break;
//             }
//             }
//             Console.WriteLine("");

//         Console.ReadLine();
//        }
//    }
// }

           


//Lab 8: Sum of Odd Numbers
//Assignment:
//Write a C# program to calculate the sum of all odd numbers between 1 and 100 using a for loop.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//             int sum = 0;
//             for (int i = 1; i < 100; i++)
//             {
//             if (i % 2 != 0)
//             {
//                 sum = sum + i;
//             }
//             }
//             Console.WriteLine($"sum of all odd numbers between 1 and 100 = {sum}");


//         Console.ReadLine();
//        }
//    }
// }







//Lab 9: Factorial Calculation
//Assignment:
//Write a C# program to calculate the factorial of a given number using a while loop.




// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//             Console.WriteLine("Enter the number : ");
//             int fact = 1;
//             int num = int.Parse(Console.ReadLine());
//             for (int i = 1; i <= num; i++)
//             {
//             fact = fact * i;
//             }
//             Console.WriteLine($"the factorial of {num} = {fact}");

//         Console.ReadLine();
//        }
//    }
// }







//Lab 10: Number Pyramid
//Assignment:
//Write a C# program to print a number pyramid using a nested while loop. Example for 5 rows:
//1
//2 2
//3 3 3
//4 4 4 4
//5 5 5 5 5



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//             Console.WriteLine("enter the number; ");
//             int num = Convert.ToInt32(Console.ReadLine());

//             for (int i = 1; i <= num; i++)
//             {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write($"{i}");
//             }
//             Console.WriteLine();
//             }


//         Console.ReadLine();
//        }
//    }
// }





//Lab 11: Guess the Number Game
//Assignment:
//Write a C# program that generates a random number between 1 and 100. The user has to guess
//the number, and the program should give hints ("too high" or "too low") until the user guesses
//correctly. Use a nested do-while loop to allow the user to play multiple rounds.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true) { 
//            int num = new Random().Next(1, 100);
//            Console.WriteLine(num);
//            Console.WriteLine("enter the guess ");
            
//            while (true)
//            {
//                int guess = int.Parse(Console.ReadLine());
//                if (num == guess)
//                {
//                    Console.WriteLine("Correct guessing");
//                    break;
//                }
//                else if (num < guess)
//                {
//                    Console.WriteLine("Wrong guess. Too high");
//                }
//                else if (num > guess)
//                {
//                    Console.WriteLine("Wrong guess. too low");
//                }
//            }
//            Console.WriteLine("Do you want to play again?");
//            string reply = Console.ReadLine();
//            if (reply.ToLower() == "yes")
//            {
//                continue;
//            }
//            else
//            {
//                break;
//            }
//        }
//            Console.ReadLine();
//        }
//    }
//}



//Lab 12: Simple Calculator
//Assignment:
//Write a C# program to create a simple calculator using a switch-case statement. The program
//should handle addition, subtraction, multiplication, and division.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//             Console.WriteLine("Enter the two numbers :");
//             int a = int.Parse(Console.ReadLine());
//             int b = int.Parse(Console.ReadLine());
//             int ans = 0;
//             Console.WriteLine(" Enter the operation required (+, -, *, /) : ");
//             string oper = Console.ReadLine();


//             switch (oper)
//             {
//             case "+":
//                 ans = a + b;
//                 Console.WriteLine($"{a} + {b} = {ans} ");
//                 break;

//             case "-":
//                 ans = a - b;
//                 Console.WriteLine($"{a} - {b} = {ans}");
//                 break;

//             case "*":
//                 ans = a * b;
//                 Console.WriteLine($"{a} * {b} =  {ans}   ");
//                 break;

//             case "/":
//                 ans = a + b;
//                 Console.WriteLine($"{a} / {b} =  {ans}   ");
//                 break;

//             default:
//                 Console.WriteLine("Error");
//                 break;
//             }


//         Console.ReadLine();
//        }
//    }
// }





// Lab 13: Sum of Digits
// Assignment:
// Write a C# program that accepts a number from the user and calculates the sum of its digits using
// a do-while loop.



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//             Console.WriteLine("Enter the number");
//             int num = int.Parse(Console.ReadLine());
//             int rem = 0;
//             int sum = 0;
//             do
//             {
//             rem = num % 10;
//             num = num / 10;
//             sum = sum + rem;
//             }

//             while (num > 0);
//             Console.WriteLine($"The sum of the digits are ; {sum}");

//         Console.ReadLine();
//        }
//    }
// }







//Lab 14: Finding the Largest Number
//Assignment:
//Write a C# program that accepts 10 numbers from the user and finds the largest number using a
//for loop.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = new int[10];
//            Console.WriteLine("the numbers are : ");
//            for (int i = 0; i < 10; i++)
//            {

//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            int largest = arr[0];
//            for (int i = 0; i < 10; i++)
//            {
//                if (arr[i] > largest)
//                {
//                    largest = arr[i];
//                }
//            }
//            Console.WriteLine($"the largest number in the array is : {largest}");

//            

//         Console.ReadLine();
//        }
//    }
// }












//Lab 15: Sum of Squares
//Assignment:
//Write a C# program to calculate the sum of squares of all numbers from 1 to a user-provided
//number using a while loop.



// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("enter a number : ");
//            int i = 1;
//            int square = 1;
//            int squaresum = 0;
//            int num = int.Parse(Console.ReadLine());
//            while (i <= num)
//            {
//                square = i * i;
//                Console.WriteLine($"The square of {i} = {square}");
//                squaresum = squaresum + square;
//                i++;
//            }
//            Console.WriteLine($"the sum of squares = {squaresum}");
//            

//         Console.ReadLine();
//        }
//    }
// }







//Lab 16: Countdown Timer
//Assignment:
//Write a C# program to simulate a countdown timer from 10 to 1 using a do-while loop,
//displaying each second.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = 10;
//            do
//            {
//                Console.WriteLine(count);
//                count--;
//                Thread.Sleep(1000);
//            }while(count >= 1);
//            Console.WriteLine("Countdown complete");

//         Console.ReadLine();
//        }
//    }
// }






//Lab 17: Finding the First Multiple of 5
//Assignment:
//Write a C# program to find and print the first multiple of 5 in a given list of numbers. Use the
//break statement to exit the loop once a multiple of 5 is found.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int[] arr = new int[10];
//            Console.WriteLine("the numbers are : ");
//            for (int i = 0; i < 5; i++)
//            {

//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            for (int i = 0; i < 5; i++)
//            {
//                if (arr[i] % 5 == 0)
//                {
//                    Console.WriteLine($"{arr[i]} is amultiple of 5 ");
//                    break;
//                }
//            }
//           
//            Console.ReadLine();
//        }
//    }
// }




//Lab 18: Print Non-Multiples of 3
//Assignment:
//Write a C# program to print numbers from 1 to 20, but skip numbers that are divisible by 3 using
//the continue statement.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("numbers from 1 to 20, but skiped numbers that are divisible by 3");
//            for (int i = 1; i <= 20; i++)
//            {
//                if (i % 3 == 0)
//                {
//                    continue;
//                }
//                else
//                {
//                    Console.WriteLine($"{i}");
//                }
//            
//            Console.ReadLine();
//        }
//    }
// }






//Lab 19: Checking for Palindrome

//Assignment:
//Write a C# program to check if a given number is a palindrome using a while loop.


// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace C__Lab_Assignments_sept2
// {
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//             Console.WriteLine("Enter the number : ");
//             int num = int.Parse(Console.ReadLine());
//             int rev = 0;
//             int rem = 0;
//             int a = num;
//             while (num > 0)
//             {
//                rem = num % 10;
//                num = num / 10;
//                rev = rev*10 + rem;
//             }
//             if (rev == a)
//             {
//                Console.WriteLine("The number is a palindrome");
//             }
//             else
//             {
//                Console.WriteLine("not palindrome");
//             }
//            Console.ReadLine();
//        }
//    }
// }





//Lab 20: Average of Positive Numbers
//Assignment:
//Write a C# program to calculate the average of positive numbers entered by the user. The
//program should stop when the user enters a negative number using a do -while loop.



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            int avg = 0;
//            int i = 1;

//            while (true)
//            {

//                Console.WriteLine("Enter the number :");
//                int num = int.Parse(Console.ReadLine());

//                if (num >= 0)
//                {
//                    Console.WriteLine($"{num}");
//                    avg = (avg + num) / i;
//                    i++;

//                }
//                else if (num < 0)
//                {
//                    break;
//                }
//                Console.WriteLine($"The average is : {avg}");


//            }

//            Console.ReadLine();
//        }
//    }
//}







//Lab 21: Reverse a Number
//Assignment:
//Write a C# program to reverse a given number using a do-while loop.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number :");
//            int num = int.Parse(Console.ReadLine());
//            int rev = 0;
//            int rem = 0;
//            do
//            {
//                rem = num % 10;
//                num = num / 10;
//                rev = (rev*10) + rem;

//            }
//            while (num>0);
//            Console.WriteLine($"The reverse number = {rev}");


//            Console.ReadLine();
//        }
//    }
//}







//Lab 22: Menu - Driven String Operations
//Assignment:
//Write a C# program that presents a menu to the user for various string operations:
//1. Reverse the string
//2. Convert to uppercase
//3. Convert to lowercase
//4. Find the length of the string
//Use a switch-case statement to implement this.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter the string : ");
//            string input = Console.ReadLine();
//            Console.WriteLine("1. Reverse the string");
//            Console.WriteLine("2. Convert to uppercase");
//            Console.WriteLine("3. Convert to lowercase");
//            Console.WriteLine("4. Find the length of the string");
//            Console.WriteLine("5. Exit");
//            Console.Write("Enter your choice: ");
//            int choice = int.Parse(Console.ReadLine());



//            switch (choice)
//                {
//                    case 1:
//                    char[] arr = input.ToCharArray();
//                    Array.Reverse(arr);
//                        Console.WriteLine($"Reverse : {new string(arr)} ");
//                        break;
//                    case 2:

//                        Console.WriteLine($"To upper case : {input.ToUpper()} ");
//                        break;
//                    case 3:
//                        Console.WriteLine($"To lower case : {input.ToLower()} ");
//                        break;
//                    case 4:

//                        Console.WriteLine($"Length of string = {input.Length}");                       
//                        break;
//                    case 5:
//                        Console.WriteLine("Exit  ");
//                        break;  
//                    default:
//                        Console.WriteLine("Enter valid option");
//                        break;
//                }
//                Console.ReadLine();
//        }
//    }
//}





//Lab 23: Skip Multiples of 4
//Assignment:
//Write a C# program to print numbers from 1 to 50 but skip numbers that are divisible by 4 using
//the continue statement.



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 50; i++)
//            {
//                if (i % 4 == 0)
//                {
//                    continue;
//                }
//                Console.WriteLine(i);
//            }
//            Console.ReadLine();
//        }
//    }
//}







//Lab 24: Fibonacci Sequence
//Assignment:
//Write a C# program to print the first 10 numbers in the Fibonacci sequence using a for loop.



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 0;
//            int num2 = 1;
//            Console.Write("Fibonacci sequence: \n");

//            for (int i = 0; i <= 10; i++)
//            {
//                Console.WriteLine(num1 + " ");

//                int sum = num1 + num2;
//                num1 = num2;
//                num2 = sum;
//            }
//            Console.ReadLine();
//        }
//    }
//}






//Lab 25: Find All Armstrong Numbers
//Assignment:

//Write a C# program to find all Armstrong numbers between 1 and 500 using a while loop. (An
//Armstrong number is a number that is equal to the sum of the cubes of its digits).



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int rem = 0;

//            for (int j = 1; j <=500; j++)
//            {
//                int sum = 0;
//                int num = j;
//                while (num != 0)
//                {
//                    rem = num % 10;
//                    sum = sum + (rem * rem * rem);
//                    num = num / 10;
//                }
//                if (sum == j)
//                {
//                    Console.WriteLine(j);
//                }


//            }          

//            Console.ReadLine();
//        }
//    }
//}





//Lab 26: Menu - Driven Number System Conversion
//Assignment:
//Write a C# program to create a menu-driven system for number conversions:
//1. Binary to Decimal
//2. Decimal to Binary
//3. Decimal to Hexadecimal
//Use a switch-case statement to implement this.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("1. Binary to Decimal ");
//            Console.WriteLine("2. Decimal to Binary");
//            Console.WriteLine("3. Decimal to Hexadecimal");
//            Console.WriteLine("4. Exit");
//            Console.WriteLine("Choose an option : ");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Enter the number : ");
//                    string num = Console.ReadLine();
//                    int dec = Convert.ToInt32(num, 2);
//                    Console.WriteLine($" Binary to Decimal : {dec} ");
//                    break;

//                case 2:
//                    Console.WriteLine("Enter the number : ");
//                    dec = int.Parse(Console.ReadLine());
//                    string bin = Convert.ToString(dec, 2);
//                    Console.WriteLine($"Decimal to Binary : {bin}");
//                    break;

//                case 3:
//                    Console.WriteLine("Enter the number : ");
//                    int number = int.Parse(Console.ReadLine());
//                    string hexa = Convert.ToString(number, 16);
//                    Console.WriteLine($"Decimal to Hexadecimal: {hexa}");
//                    break;

//                case 4:
//                    Console.WriteLine("Exit");
//                    break;

//                default:
//                    Console.WriteLine("Enter valid case. ");
//                    break;
//            }



//            Console.ReadLine();
//        }
//    }
//}



//Lab 27: Reverse a String
//Assignment:
//Write a C# program to reverse a given string using a for loop.



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the string : ");
//            string input  = Console.ReadLine();
//            string output = " ";
//            for (int i = input.Length - 1; i >= 0; i--)
//            {
//                 output = output +input[i];
//            }
//            Console.WriteLine($"reversed string : {output}");
//            Console.ReadLine();
//        }
//    }
//}


//Lab 28: Count Vowels and Consonants in a String
//Assignment:
//Write a C# program to count the number of vowels and consonants in a given string using a for
//loop.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the sentence :");
//            string input = Console.ReadLine();
//            string lower = input.ToLower();
//            char[] arr = input.ToCharArray();
//            int vowel = 0;
//            int consonant = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
//                {
//                    vowel++;
//                }
//                else
//                {
//                    consonant++;
//                }
//            }
//                Console.WriteLine($"Vowel : {vowel} \nConsonant = {consonant}");
//            Console.ReadLine();
//        }
//    }
//}



//Lab 29: Find Maximum and Minimum
//Assignment:
//Write a C# program to find the maximum and minimum of 5 numbers entered by the user using a
//for loop.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            int[] arr = new int[5];
//            Console.WriteLine("the numbers are : ");
//            for (int i = 0; i < 5; i++)
//            {
//                arr[i] = int.Parse(Console.ReadLine());
//            }

//            int max = arr[0];
//            int min = arr[0];
//            for (int i = 0; i < 5; i++)
//            {
//                if (arr[i] > max)
//                {
//                    max = arr[i];
//                }
//            }
//            for (int i = 0; i < 5; i++)
//            {
//                if (arr[i] < min)
//                {
//                    min = arr[i];
//                }
//            }
//            Console.WriteLine($"the biggest number in the array is : {max}");

//            Console.WriteLine($"the smallest number in the array is : {min}");


//            Console.ReadLine();
//        }
//    }
//}



//Lab 30: Count Digits of a Number
//Assignment:
//Write a C# program to count the number of digits in a given number using a while loop.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int num = int.Parse(Console.ReadLine());
//            int count = 0;
//            while (num > 0)
//            {
//                num = num / 10;
//                count++;
//            }
//            Console.WriteLine($"The number of digits in the number : {count}");
//            Console.ReadLine();
//        }
//    }
//}











