// LAB ASSIGNMENT SEPT 1

//Lab 1: Hello, World! and Basic Input/output

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World");
//            Console.WriteLine("Enter username:");
//            string userName = Console.ReadLine();
//            Console.WriteLine("Hello, " + userName);

//            Console.ReadLine();

//        }
//    }
//}


//Lab 2: Input / output with Strings


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter name:");
//            string Name = Console.ReadLine();
//            Console.WriteLine("ENter Age :");
//            int age = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter favourite color:");
//            string color = Console.ReadLine();


//            Console.WriteLine($"Hello { Name} ! You are {age} years old your favourite color is {color}");

//            Console.ReadLine();

//        }
//    }
//}

//Lab 3: Input/output with Arithmetic Operations

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the numbers :");
//            int a = Convert.ToInt32(Console.ReadLine());
//            int b = Convert.ToInt32(Console.ReadLine());

//            int sum = a + b;
//            Console.WriteLine($"Sum: {a}+{b} = {sum}");
//            int difference = a - b;
//            Console.WriteLine($"Difference: {a}-{b} = {difference}");
//            int mul = a * b;
//            Console.WriteLine($"Multiplication: {a}*{b} = {mul}");

//            if ((a == 0) || (b == 0))
//            {
//                Console.WriteLine("Division by zero attempted");
//            }
//            else
//            {
//                int div = a / b;
//                Console.WriteLine($"Division : {a}/{b} = {div}");
//            }
//            Console.ReadLine();
//        }
//    }
//}




//Lab 4: Temperature Conversion


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the temperature in celcius");
//            double celcius = Convert.ToDouble32(Console.ReadLine());
//            double faren = (celcius * 9 / 5) + 32;
//            Console.WriteLine($"celcius = {celcius}");
//            Console.WriteLine($"Farenheight = {faren}");
//            Console.ReadLine();
//        }
//    }
//}




//Lab 5: Simple Interest Calculation

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Enter the values: ");
//            double P = Convert.ToDouble(Console.ReadLine());
//            double R = Convert.ToDouble(Console.ReadLine());
//            double T = Convert.ToDouble(Console.ReadLine());

//            double SI = (P * R * T) / 100;
//            Console.WriteLine($"The Simple Interest is : {SI}");
//            Console.ReadLine();
//        }
//    }
//}





//Lab 6: Calculating the Area of a Circle


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter radius:");
//            double R = Convert.ToDouble(Console.ReadLine());
//            double Area = 3.14 * R * R;
//            Console.WriteLine($"Area of the circle is: {Area}");
//            Console.ReadLine();


//        }
//    }
//}



//Lab 7: Input / output with Time Calculation

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the seconds: ");
//            int sec = Convert.ToInt32(Console.ReadLine());
//            int hour = sec / 3600;
//            int min = (sec % 3600) / 60;
//            int Sec = sec % 60;
//            Console.WriteLine($"In seconds : {sec}");
//            Console.WriteLine($"In minutes : {min}");
//            Console.WriteLine($"In Hours : {hour}");

//            Console.ReadLine();

//        }
//    }
//}




//Lab 8: String Length and Character Count

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//Console.WriteLine("Enter the string: ");
//string A = Console.ReadLine();
//int chara = A.Replace(" ","").Length;
//Console.WriteLine($"CHaracter Length is {char}");
//Console.ReadLine();


//        }
//    }
//}





//Lab 9: Body Mass Index (BMI) Calculator

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the values:");
//            double W = double.Parse(Console.ReadLine());
//            double H = double.Parse(Console.ReadLine());

//            double BMI = W / (H * H);
//            Console.WriteLine($"The BMI is {BMI}");
//            Console.ReadLine();


//        }
//    }
//}





//Lab 10: Variables and Constants

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine();
//            int a = 10;
//            float b = 3.11111f;
//            double c = 10.35;
//            char d = 'a';
//            string e = "Hello";
//            bool f = true;

//            Console.WriteLine($"Integer : {a}");
//            Console.WriteLine($"Float : {b}");
//            Console.WriteLine($"Double : {c}");
//            Console.WriteLine($"Character : {d}");
//            Console.WriteLine($"String : {e}");
//            Console.WriteLine($"Bool : {f}");
//            Console.ReadLine(); 
//        }
//    }
//}



//Lab 11: Variables and Constants


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the Radius, length and breadth: ");
//    double R = Convert.ToDouble(Console.ReadLine());
//            double L = Convert.ToDouble(Console.ReadLine());
//            double B = Convert.ToDouble(Console.ReadLine());

//            double circle = 3.14 * R * R;
//            double rect = L * B;
//            Console.WriteLine($"Area of circlr = {circle}");
//            Console.WriteLine($"Area of rectangle = {rect}");
//            Console.ReadLine();
//        }
//    }
//}







// Lab 12: Using Constants


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the radius: ");
//            int radius = Convert.ToInt32(Console.ReadLine());
//            const double PI = 3.14159;
//            const int DAYS_IN_WEEK = 7;
//            double area = 2 * PI * radius;
//            Console.WriteLine($"Area of the circle = {area}");
//            Console.WriteLine($"Number of Days in a week = {DAYS_IN_WEEK}");

//            Console.ReadLine();
//        }
//    }
//}



//Lab 13: Calculating Area of Rectangle

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the width and height: ");
//            double W = Convert.ToDouble(Console.ReadLine());
//            double H = Convert.ToDouble(Console.ReadLine());
//            double areaCM = W * H;
//            double areaIN = areaCM / (2.54*2.54);
//            Console.WriteLine($"area in square centimeters = {areaCM}");
//            Console.WriteLine($"area in square centimeters = {areaIN}");



//            Console.ReadLine();
//        }
//    }
//}






//Lab 14: C# Coding Standards



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the employee name, age and salary: ");
//            string Name = Console.ReadLine();
//            int age = int.Parse(Console.ReadLine());
//            double salary = double.Parse(Console.ReadLine());

//            Console.WriteLine($"Name of employee : {Name}");
//            Console.WriteLine($"Age of Employee : {age}");
//            Console.WriteLine($"Salary of employee : {salary}");

//            Console.ReadLine();
//        }
//    }
//}








//Lab 15: C# Coding Standards


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 5;
//            int num2 = 3;
//            int sum = num1+num2;
//            Console.WriteLine($"The sum of {num1} and {num2} = {sum}");
//            Console.ReadLine();
//        }
//    }
//}






//Lab 16: Assignment Operator


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 25; int b = 30;
//            Console.WriteLine($"a = {a} and b = {b}");
//            Console.ReadLine();
//        }
//    }
//}






//Lab 17: Find the Power of a Number


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the base and power: ");
//            double exp = double.Parse(Console.ReadLine());
//            double Base = double.Parse(Console.ReadLine());
//            double power = Math.Pow(Base, exp);
//            Console.WriteLine($" the value of {Base}^{exp} = {power}");

//            Console.ReadLine();
//        }
//    }
//}



//Lab 18: Check Voting Eligibility


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("ENter the age and citizenship : ");
//            int age = int.Parse(Console.ReadLine());
//            string citizen = Console.ReadLine();

//            if ((age > 18) && (citizen.ToLower() == "indian"))
//            {
//                Console.WriteLine("ELigible for voting");
//            }
//            else
//            {
//                Console.WriteLine("Not eligible for voting");
//            }



//            Console.ReadLine();
//        }
//    }
//}




//Lab 19: Determine if a Person is Eligible for a Loan


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ENter the age,salary and does the person hhave any outstanding loans: ");
//            int age = int.Parse(Console.ReadLine());
//            int salary = int.Parse(Console.ReadLine());
//            string loan = Console.ReadLine();

//            if ((age > 21) && (salary > 30000) && (loan.ToLower() == "no"))
//            {
//                Console.WriteLine("ELigible for Loan");
//            }

//            else
//            {
//                Console.WriteLine("Not eligible for Loan");
//            }



//            Console.ReadLine();
//        }
//    }
//}






//Lab 20: Eligibility Check

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the age,experience and if the person has adegree: ");
//            int age = int.Parse(Console.ReadLine());
//            int experience = int.Parse(Console.ReadLine());
//            string degree = Console.ReadLine();

//            if ((age > 18 && age<35) && (experience> 2)  && ((degree.ToLower() == "yes") || (experience>=5)))
//            {
//                Console.WriteLine("ELigible for Job");
//            }

//            else
//            {
//                Console.WriteLine("Not eligible for Job");
//            }

//            Console.ReadLine();
//        }
//    }
//}





//Lab 21: Check if a Character is a Vowel or Consonant


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the alphabet");
//            char alphabet = char.Parse(Console.ReadLine());

//            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
//            {
//                Console.WriteLine("The alphabet is a vowel");
//            }
//            else
//            {
//                Console.WriteLine("the alphabet is a consonant");
//            }
//                Console.ReadLine();
//        }
//    }
//}

//Lab 22: Check If a Number is Positive, Negative, or Zero 


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int a = Convert.ToInt32(Console.ReadLine());
//            if (a == 0)
//            {
//                Console.WriteLine("the number is zero ");
//            }
//            else if (a > 0)
//            {
//                Console.WriteLine("the number is positive");
//            }
//            else
//            {
//                Console.WriteLine("the number is negative");
//            }
//            Console.ReadLine();
//        }
//    }
//}




//Lab 23: Check if a Number is Divisible by 5 and 11 



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("enter the number :");
//            int a = int.Parse(Console.ReadLine());
//            if ((a % 11 == 0) && (a % 5 == 0))
//            {
//                Console.WriteLine("the number is  divisible by 5 and 11 ");
//            }

//            else
//            {
//                Console.WriteLine("the number is not divisible by both 5 and 11");
//            }

//            Console.ReadLine();
//        }
//    }
//}


////Lab 24: Simple Calculator 
//Assignment:
//Write a C# program that takes two numbers and an operator (+, -, *, /) as input, and performs the 
//corresponding operation. Use an if-else statement to determine which operation to perform 



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter the two numbers :");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int ans = 0;
//            Console.WriteLine(" Enter the operation required (+, -, *, /) : ");
//            char oper = Convert.ToChar(Console.ReadLine());

//            if (oper == '+')
//            {
//                ans = a + b;
//                Console.WriteLine($"{a} + {b} = {ans} ");
//            }
//            else if (oper == '-')
//            {
//                ans = a - b;
//                Console.WriteLine($"{a} - {b} = {ans}");
//            }
//            else if (oper == '*')    
//            {
//                ans = a * b;
//                Console.WriteLine($"{a} * {b} =  {ans}   ");
//            }
//            else if (oper == '/')
//            {
//                ans = a + b;
//                Console.WriteLine($"{a} / {b} =  {ans}   ");
//            }  


//            Console.ReadLine();
//        }
//    }
//}




//Lab 25: Grading System 
//Assignment: 
//Write a C# program that accepts the marks of a student in a subject and assigns a grade based on 
//the following criteria: 
//1.If the marks are greater than or equal to 90, the grade is 'A'. 
//2. If the marks are between 80 and 89, the grade is 'B'. 
//3. If the marks are between 70 and 79, the grade is 'C'. 
//4. If the marks are between 60 and 69, the grade is 'D'. 
//5. If the marks are below 60, the grade is 'F'. 
//Your program should: 
// Prompt the user to enter the marks (out of 100). 
// Use nested if statements to determine and print the grade based on the marks entered.


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine("Enter the marks out of 100 : ");
//            int marks = int.Parse(Console.ReadLine());
//            if (marks >= 90)
//            {
//                Console.WriteLine("The Grade is A");
//            }
//            else if (marks >= 80 && marks <= 89)
//            {
//                Console.WriteLine("The Grade is B");
//            }
//            else if (marks >= 70 && marks <= 79)
//            {
//                Console.WriteLine("The Grade is C");
//            }
//            else if (marks >= 60 && marks <= 69)
//            {
//                Console.WriteLine("The Grade is D");
//            }
//            else if(marks <60)
//            {
//                Console.WriteLine("The grade id F");
//            }
//            Console.ReadLine();
//        }
//    }
//}



//Lab 26: Swap two values 
//Assignment: 
//Write a program that swaps the values of two variables using a third variable and without using a
//third variable.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the two nmbers");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            Console.WriteLine($"The values before swapping \n a = {a} \n b = {b} ");

//            a = a+b;
//            b = a-b; 
//            a = a-b;

//            Console.WriteLine($"The values after swapping \n a = {a} \n b = {b}  ");
//            Console.ReadLine();
//        }
//    }
//}




//Lab 27: Arithmetic Operations 
//Assignment: 
//Write a program that takes two numbers as input and performs all arithmetic operations on them 
//(addition, subtraction, multiplication, division, modulus, increment, and decrement). 



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the two numbers :");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());

//            int add = a + b;
//            Console.WriteLine($"{a} + {b} = {add} ");

//            int diff = a - b;
//            Console.WriteLine($"{a} - {b} = {diff} ");

//            int mul = a * b;
//            Console.WriteLine($"{a} * {b} =  {mul} ");

//            int div = a + b;
//            Console.WriteLine($"{a} / {b} =  {div} ");

//            Console.ReadLine();
//        }
//    }
//}


//Lab 28: Find the Average of Three Numbers 
//Assignment: 
//Write a C# program that takes three numbers as input from the user and calculates the average of 
//those numbers. The result should be displayed with two decimal places 



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the numbers : ");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int c = int.Parse(Console.ReadLine());
//            double avg = (a+b+c)/3;
//            Console.WriteLine($"The average of the three numbers is = {avg}");

//            Console.ReadLine();
//        }
//    }
//}


//Lab 29: Currency Conversion 
//Assignment: 
//Write a C# program to convert a given amount of money from USD to another currency (e.g., 
//EUR). Assume a conversion rate, for example, 1 USD = 0.85 EUR. The program should take the 
//amount in USD as input and display the equivalent amount in EUR.



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the amount in USD : ");
//            int dollar = int.Parse(Console.ReadLine());

//            double eur = dollar * 0.85;
//            Console.WriteLine($"USD = {dollar} \nEuro = {eur}");


//            Console.ReadLine();
//        }
//    }
//}




//Lab 30: Input is within a range
//Assignment: 
//Write a program that checks if the input number is within a certain range (e.g., between 1 and 
//100) and also checks if it is even or odd using relational and logical operators. 

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number :");
//            int num = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter the minimum and maximum value of the range : ");
//            int min = int.Parse(Console.ReadLine());
//            int max = int.Parse(Console.ReadLine());

//            if (num <= max && num >= min)
//            {
//                if (num % 2 == 0)
//                {
//                    Console.WriteLine("The number is even and within range ");
//                }
//                else
//                {
//                    Console.WriteLine("The number is odd and within range");
//                }
//            }
//            else
//            {
//                Console.WriteLine("The number is not within range");
//            }

//            Console.ReadLine();
//        }
//    }
//}



//Lab 31: Check a number is divisible by 3 & 5 
//Assignment: 
//Write a program to check whether a number is divisible by both 3 and 5 using an if statement.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number ");
//            int num = int.Parse(Console.ReadLine());
//            if (num % 3 == 0 && num % 5 == 0)
//            {
//                Console.WriteLine($"{num} is divisible by both 3 and 5");
//            }
//            else
//            {
//                Console.WriteLine($"{num} is not divisible by 3 and 5");
//            }
//                Console.ReadLine();
//        }
//    }
//}



//Lab 32: Check whether a given year is leap year 
//Assignment: 
//Write a program to check whether a year is a leap year or not using an if-else statement.





//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the year :");
//            int year = Convert.ToInt32(Console.ReadLine());

//            if (year % 400 == 0)
//            {
//                Console.WriteLine($"{year} is aleap year");
//            }
//            else if(year % 100 ==0)
//            {
//                    Console.WriteLine($"{year} is not a leap year");
//            }
//            else if (year % 4 == 0)
//            {
//                Console.WriteLine($"{year} is a leap year");
//            }
//            else
//            {
//                Console.WriteLine($"{year} is not a leap year");
//            }
//            Console.ReadLine();
//        }
//    }
//}

//Lab 33: Check whether a number is positive, even and greater than 50 
//Assignment: 
//Write a program that checks whether an input number is positive, even, and greater than 50 using 
//nested if statements.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int num = int.Parse(Console.ReadLine());

//            if (num > 0)
//            {
//                if (num % 2 == 0)
//                {
//                    if (num > 50)
//                    {
//                        Console.WriteLine($"{num} is positive, even and greater than 50. ");
//                    }
//                }

//                else
//                {
//                    Console.WriteLine($"{num} is not positive, even and greater than 50. ");
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}



//Lab 34: Calculate student grade 
//Assignment: 
//Write a program that accepts the grades (marks) of a student in three subjects. The program 
//should determine the following: 
//1.If the student has passed in all subjects (passing mark is 40 in each subject). 
//2. If the student has passed, check if the average grade is 70 or above. If so, print 
//"Distinction". 
//3. If the student has not passed in any subject, print the number of subjects failed.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the marks of three subjects out of 100 for each :");
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int c = int.Parse(Console.ReadLine());
//            int fail = 0;

//            int avg = (a + b + c) / 3;
//            if (a >= 40 && b >= 40 && c >= 40)
//            {

//                if (avg > 70)
//                {
//                    Console.WriteLine("Distinction");
//                    Console.WriteLine($"Average = {avg}");
//                }
//                else
//                {
//                    Console.WriteLine("No distinction");
//                    Console.WriteLine($"Average = {avg}");
//                }
//            }
//            else
//            {
//                if (a < 40)
//                {
//                    fail = a;
//                }
//                else if (b < 40)
//                {
//                    fail = b;
//                }
//                else if (c < 40)
//                {
//                    fail = c;
//                }
//                Console.WriteLine($"The student has failed in the subject with marks {fail}");
//            }

//            Console.ReadLine();
//        }
//    }
//}






//Lab 35: Salary and Tax Calculation  
//Assignment: 
//Write a program that calculates the tax to be paid based on the annual salary of an employee. The 
//tax rules are as follows: 
//1.If the salary is less than $10,000, no tax is applied. 
//2. If the salary is between $10,000 and $50,000, a 10% tax is applied. 
//3. If the salary is above $50,000, a 20% tax is applied. 
//4. If the employee is a senior citizen (aged 60 or above), they get an additional tax 
//exemption of $5,000 from their taxable income. 
//5. Your program should 
// Prompt the user to enter their annual salary and age. 
// Use nested if statements to calculate the appropriate tax based on the salary and age. 
// Print the tax amount to be paid.




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__Lab_Assignments_sept1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the salary and age of the employee: ");
//            int salary = int.Parse(Console.ReadLine());
//            int age = int.Parse(Console.ReadLine());
//            double tax = 0;

//            if (salary < 10000)
//            {
//                Console.WriteLine("No tax ");
//            }
//            else if(salary>=10000 && salary <= 50000)
//            {
//                if (age >= 60)
//                {
//                    tax = (salary * 0.1) - 5000;
//                    Console.WriteLine($"Tax = {tax}");
//                }
//                else
//                {
//                    tax = (salary * 10) / 100;
//                    Console.WriteLine($"Tax = {tax}");
//                }
//            }
//            else if (salary >= 50000)
//            {
//                if (age >= 60)
//                {
//                    tax = ((salary * 20) / 100) - 5000;
//                    Console.WriteLine($"Tax = {tax}");
//                }
//                else
//                {
//                    tax = (salary * 20) / 100;
//                    Console.WriteLine($"Tax = {tax}");
//                }
//            }

//            Console.ReadLine();
//        }
//    }
//}

