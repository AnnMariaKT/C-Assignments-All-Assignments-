using Inheritance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{


    //    Lab 1. Single Inheritance
    //In Single Inheritance, a derived class inherits from a single base class.
    //Problem:
    //Create a base class Person with properties like Name and Age.Derive a class Student from
    //Person and add a property Grade.Create objects and display the data.

    //public class Person
    //{
    //    public string Name;
    //    public int Age;

    //    public void Persons()
    //    {
    //        Name = "ABCD";
    //        Age = 25;
    //        Console.WriteLine("Name = " + Name + "\t Age = " + Age);

    //    }

    //}

    //public class Student : Person
    //{
    //    public int Grade;
    //    public void Students()
    //    {
    //        Grade = 85;
    //        Console.WriteLine("Grade = " + Grade);
    //        Console.WriteLine("Name = " + Name + "\t Age = " + Age);

    //    }
    //}



    //--------------------------------------------------------------------------------------------------------------



    //            Lab 2.Multilevel Inheritance
    //In Multilevel Inheritance, a class is derived from another derived class. 
    //Problem: 
    //Create a base class Animal with a method Eat(). Derive a class Dog that inherits Animal and add
    //a method Bark(). Further derive a class Puppy from Dog and add a method Weep(). Show the
    //behavior.



    //public class Animal
    //{
    //    public void Eat()
    //    {
    //        Console.WriteLine("The Animal is eating");
    //    }
    //}

    //public class Dog : Animal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("The Dog is Barking");
    //    }
    //}

    //public class Puppy : Dog
    //{
    //    public void Weep()
    //    {
    //        Console.WriteLine("The Puppy is weeping");
    //    }
    //}



    //--------------------------------------------------------------------------------------------------------------


    //    Lab 3. Multiple Inheritance(via Interfaces)
    //C# does not support multiple inheritance directly, but it can be achieved using interfaces. 
    //Problem: 
    //Create two interfaces IPrintable and IScannable with respective methods Print() and Scan(). 
    //Implement both interfaces in a class PrinterScanner. 

    //interface IPrintable
    //{
    //    void Print();
    //}
    //interface IScannable
    //{
    //    void Scan();
    //}


    //public class PrinterScanner : IPrintable , IScannable
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("Printing");
    //    }

    //    public void Scan()
    //    {
    //        Console.WriteLine("Scanning");
    //    }
    //}



    //--------------------------------------------------------------------------------------------------------------


    //    Lab 4. Hierarchical Inheritance
    //In Hierarchical Inheritance, multiple derived classes inherit from a single base class. 
    //Problem: 
    //Create a base class Shape with a method Draw(). Create two derived classes Circle and
    //Rectangle, both inheriting from Shape, and override the Draw() method to show specific
    //behavior.



    //public class Shape
    //{
    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("Drawing");
    //    }
    //}

    //public class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Derived class Circle overrides the class Shape");
    //    }
    //}

    //public class Rectangle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Derived class Rectangle overrides the class Shape");
    //    }
    //}



    //--------------------------------------------------------------------------------------------------------------

    //    Lab 5. Hybrid Inheritance(Using Interfaces)
    //Hybrid inheritance combines multiple types of inheritance.Since C# doesn't support direct 
    //multiple inheritance, hybrid inheritance is implemented using interfaces. 
    //Problem: 
    //Create two interfaces IMovable and IRechargeable.Create a class Vehicle implementing
    //IMovable and derive ElectricCar from Vehicle implementing both interfaces.




    //    interface IMovable
    //    {
    //        void Move();
    //    }

    //    interface IRechargeable
    //    {
    //        void Recharg();
    //    }


    //    public class Vehicle : IMovable
    //    {
    //        public void Move()
    //        {
    //            Console.WriteLine("The car is moving");

    //        }
    //    }

    //    public class ElectricCar : Vehicle, IRechargeable
    //    {
    //        public new void Move()
    //        {
    //            Console.WriteLine("The car is moving");

    //        }
    //        public void Recharg()
    //        {
    //            Console.WriteLine("The car is recharging");

    //        }
    //    }
    //}




    //--------------------------------------------------------------------------------------------------------------



    //            Lab 6.Overriding Methods in Inheritance
    //Demonstrate method overriding where a base class method is overridden in the derived class. 
    //Problem: 
    //Create a class Employee with a method Work(). Derive a class Manager that overrides the
    //Work() method to show a different implementation.



    //    public class Employee
    //    {
    //        public virtual void Work()
    //        {
    //            Console.WriteLine("The Base class is called heree");
    //        }
    //    }

    //    public class Manager : Employee
    //    {
    //        public override void Work()
    //        {
    //            Console.WriteLine("The derived class overrides the base class");
    //        }
    //    }
    //}






    //--------------------------------------------------------------------------------------------------------------

    //            Lab 7.Abstract Classes
    //Create an abstract class and demonstrate inheritance with abstract methods.
    //Problem: 
    //Create an abstract class Vehicle with an abstract method Drive(). Create two derived classes Car
    //and Bike that implement the Drive() method.



    //    public abstract class Vehicle1
    //    {

    //        public abstract void Drive();

    //    }


    //    public class Car : Vehicle1
    //    {
    //        public override void Drive()

    //        {
    //            Console.WriteLine("The car is Driving");
    //        }
    //    }

    //    public class Bike : Vehicle1
    //    {
    //        public override void Drive()

    //        {
    //            Console.WriteLine("The bike is Driving");
    //        }
    //    }
    //}



    //--------------------------------------------------------------------------------------------------------------


    //Lab 8. Sealed Classes 
    //Create a class that cannot be inherited using the sealed keyword.
    //Problem: 
    //Create a sealed class MathOperations with a method Add(). Show that it cannot be inherited. 




    //    public sealed class MathOperations
    //    {
    //        public int Add(int a, int b)
    //        {

    //            return a + b;

    //        }
    //    }

    //    public class inherited : MathOperations
    //    {
    //        public void Display()
    //        {
    //            Console.WriteLine(" Cannot inherit sealed class");
    //        }
    //    }


    //}

    //--------------------------------------------------------------------------------------------------------------


    //            Lab 9.Constructor Chaining
    //Demonstrate how constructors are called in a class hierarchy. 
    //Problem: 
    //Create a base class Person with a parameterized constructor.Create a derived class Employee
    //that calls the base class constructor. 


    //public class Person
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public string City { get; set; }

    //    public Person(string name, int age, string city)
    //    {
    //        Name = name;
    //        Age = age;
    //        City = city;
    //    }

    //    public void DisplayBase()
    //    {
    //        Console.WriteLine($"Name = {Name} Age = {Age} City = {City}");
    //    }
    //}


    //public class Employee1 : Person
    //{

    //    public string Derpartment {  get; set; }
    //    public Employee1(string name, int age, string city, string department) : base(name, age, city)
    //    {
    //        Derpartment = department;
    //    }
    //         public void DisplayDerived()
    //        {
    //            Console.WriteLine($"Name = {Name} Age = {Age} City = {City} Department = {Derpartment}");
    //        }
    //    }

    //}






    //--------------------------------------------------------------------------------------------------------------



    //            Lab 10.Interface Inheritance
    //Demonstrate that one interface can inherit from another.
    //Problem: 
    //Create an interface IDriveable with a method Drive(). Create another interface IRaceable that
    //inherits from IDriveable and adds a method Race(). 







    //   public interface IDriveable
    //    {
    //        void Drive();
    //    }

    //    public interface IRaceable : IDriveable
    //    {
    //        void Race();
    //    }



    //    public class Cars : IRaceable
    //    {
    //        public void Drive()
    //        {
    //            Console.WriteLine("The car is driving");
    //        }

    //        public void Race()
    //        {
    //            Console.WriteLine("The car is racing");
    //        }
    //    }
    //}





    //--------------------------------------------------------------------------------------------------------------



    //Lab 11. IS-A Relationship(Inheritance)
    //Problem: 
    //Create a base class Animal with properties like Name and methods like Eat(). Create a derived class
    //Dog that inherits from Animal and adds its own method Bark(). Show how the IS-A relationship
    //works.


    //    public class Animal
    //    {
    //        public string Name { get; set; }

    //        public void Eat()
    //        {
    //            Console.WriteLine($"The {Name} is eating");
    //        }
    //    }

    //    public class Dog : Animal
    //    {
    //        public void Bark()
    //        {
    //            Console.WriteLine($"{Name} is barking");
    //        }
    //    }
    //}





    //--------------------------------------------------------------------------------------------------------------



    //Lab 12.HAS-A Relationship(Composition)
    //Problem: 
    //Create a class Engine with properties like HorsePower.Create a class Car that contains an instance
    //of Engine and shows the HAS-A relationship.Demonstrate how the Car can use its Engine to show
    //engine-related details. 

    //    public class Engine
    //    {
    //        public int HorsePower { get; set; }

    //    }

    //    public class Car1 : Engine
    //    {
    //        public void Display()
    //        {
    //            Console.WriteLine($" The car has a horse power of {HorsePower}");
    //        }
    //    }
    //}

    //--------------------------------------------------------------------------------------------------------------





    //Lab 13. Calling Base Class Method Using base 
    //Problem: 
    //Create a base class Person with a method DisplayInfo(). Derive a class Employee that overrides
    //DisplayInfo() but still calls the base class's DisplayInfo() using base. 


    //    public class Person1
    //    {
    //        public virtual void DisplayInfo()
    //        {
    //            Console.WriteLine("Person: Displaying basic information.");
    //        }
    //    }

    //    public class Employee : Person1
    //    {
    //        public override void DisplayInfo()
    //        {
    //            base.DisplayInfo();
    //            Console.WriteLine("Employee: Displaying employee information.");

    //        }
    //    }
    //}


    //--------------------------------------------------------------------------------------------------------------





    //Lab 14. Accessing Base Class Variable Using base  
    //Problem: 
    //Create a base class Person with a property Name.In the derived class Student, hide the Name
    //property using the new keyword and use base to access the base class's Name property. 

    //    public class Person
    //    {
    //        public string Name { get; set; }
    //    }

    //    public class Student : Person
    //    {
    //        public new string Name { get; set; }
    //        public void Display()
    //        {
    //            Console.WriteLine($"Base class Name: {base.Name}");
    //            Console.WriteLine($"Derived class Name: {Name}");
    //        }
    //    }
    //}


    //--------------------------------------------------------------------------------------------------------------




    //Lab 15. Calling Base Class Constructor Using base 
    //This assignment demonstrates how to use the base keyword to call the base class constructor
    //from the derived class constructor. 
    //Problem: 
    //Create a base class Vehicle with a constructor that accepts brand.Derive a class Car that passes
    //values to the base class constructor using base.



    public class Vehicle
    {
        public string Brand { get; set; }

        public Vehicle(string brand)
        {
            Brand = brand;
            Console.WriteLine($"Vehicle constructor: Brand set to {brand}");
        }
    }

    public class Car : Vehicle
    {
        public string Model { get; set; }

        public Car(string brand, string model) : base(brand)
        {
            Model = model;
            Console.WriteLine($"Car constructor: Model set to {model}");
        }
    }
}


//--------------------------------------------------------------------------------------------------------------


















