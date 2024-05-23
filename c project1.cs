// Create a C# program that requests three names of people from the user and stores them in an array of objects 
// of type Person. To do this, first create a Person class that has a Name property of type string and override 
// the ToString() method.

// End the program by reading people and executing the ToString() method on the screen.
// Hello! My name is Juan
// Hello! My name is Sara
// Hello! My name is Carlos


// using System;

// namespace MyNamespace
// {
//     class Person
//     {
//         public string Name { get; set; }

//         public override string ToString()
//         {
//             return "Hello, my name is " + Name;
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int total = 3;
//             Person[] persons = new Person[total];

//             for (int i = 0; i < persons.Length; i++)
//             {
//                 Console.WriteLine($"Lütfen {i + 1}. kişinin adını girin:");
//                 string name = Console.ReadLine();
//                 persons[i] = new Person { Name = name };
//             }

//             foreach (Person person in persons)
//             {
//                 Console.WriteLine(person.ToString());
//             }
//         }
//     }
// }









// using System;
// using System.Net.Sockets;
// using System.Security.Cryptography.X509Certificates;

// public class Person
// {

//     public string Name { get; set; }
//     public DateOnly Birthday { get; set; }
//     public string Address { get; set; }
//   public int ID { get; set; }
//     public int Age { get; set; }

//     public Person(string name, DateOnly birthday, string address, int age)
//     {
//         Name =name;
//         Birthday = birthday;
//         Address = address;
//         Age = age;
//         ID = GenerateRandomID();
//     }

//     private int GenerateRandomID()
//     {

//         Random random = new Random();
//         return random.Next(1000,10000);
//     }
    
//         public void Greet()
//         {
//             Console.WriteLine("hello");
//         }

//         public void GetInfo()
//         {
//             Console.WriteLine($"Name: {Name}, DateOnly: {Birthday}, Address: {Address}, ID: {ID}, Age:{Age} ");
//         }

      
// }
    

//     class Student : Person
//     {
//         public Student(string Name, DateOnly Birthday, string Address, int Age): base(Name,Birthday,Address,Age)
//         {
//             Console.WriteLine("hello I am studying");
//     }
//     public new void GetInfo()
//     {
//         Console.WriteLine($"My name is {Name}, I was born in {Birthday} and I am {Age}. I am from {Address}. My Id is {ID}. ");
//     }


//     }


//     class Teacher : Person
//     {
//         public Teacher (string Name, DateOnly Birthday, string Address, int Age): base(Name,Birthday,Address,Age)
//         {
//             Console.WriteLine("hello I am teaching");
//     }
//     public new void GetInfo()
//     {
//         Console.WriteLine($"My name is {Name}, I was born in {Birthday} and I am {Age}. I am from {Address}. My Id is {ID}. ");
//     }


//     }



//     public class TeacherandStudent
//     {
//         public static void Main(string[]args)
//         {

//             Console.WriteLine("are you student or teacher?");
//             string role = Console.ReadLine();
            
//             Console.WriteLine("enter your name:");
//             string name = Console.ReadLine();

//             Console.WriteLine("enter your birthday yyyy-mm-dd");
//             DateOnly birthday = DateOnly.Parse(Console.ReadLine());

//             Console.WriteLine("enter your address");
//             string address= Console.ReadLine();

//             Console.WriteLine("enter your age");
//             int age = Convert.ToInt32(Console.ReadLine());

//             if (role.ToLower() == "student")
//             {
//                 Student student = new Student(name,birthday,address,  age );
//                 student.GetInfo();
//             }
//             else if (role.ToLower() == "teacher")
//             {
//                 Teacher teacher = new Teacher(name,birthday,address,age);
//                 teacher.GetInfo();
                
//             }
//             else
//             {
//                 Console.WriteLine("invalid role");
//             }

            
    //     }
    // }




// using System;

// public class PhotoBook
// {
//     private int numPages { get; set; }
//     public int GetNumberPages { get; set; }

//     public PhotoBook(int numPages, int GetNumberPages)
//     {
//         for (int i = 0; i < numPages; i++)
//         {
//             i = 16;
//             Console.WriteLine(i);
//         }


//     }

// }

// public class BigPhotoBook
// {
//     public BigPhotoBook(int numPages, int GetNumberPages)
//     {


//     }
// }



//CREATE STUDENT AND TEACHER CLASS AND THEIR PET

// using System;

// public class Person
// {
//     public string Name { get; set; }
//     public int ID { get; set; }
//     public int Age { get; set; }
//     public DateOnly BirthDay { get; set; }
//     public string Address { get; set; }
    
//     public Person(string name, int age, DateOnly birthday, string address)
//     {
//         Name = name;
//         Age = age;
//         BirthDay = birthday;
//         Address = address;
//         ID = GenerateRandomID();
//     }

//     private int GenerateRandomID()
//     {
//         Random random = new Random();
//         return random.Next(1000, 10000);
//     }

//     public virtual void Greet()
//     {
//         Console.WriteLine("hello");
//     }

//     public virtual void GetInfo()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}, BirthDay: {BirthDay}, Address: {Address}, Id: {ID}");
//     }
// }

// class Student : Person
// {
//     public Student(string name, int age, DateOnly birthday, string address) : base(name, age, birthday, address)
//     {
//        Console.WriteLine("hello i am studying");
//     }

//     public override void GetInfo()
//     {
//         Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old. My birthday is {BirthDay}. I am from {Address}. My ID is {ID}");
//     }
// }

// class Teacher : Person
// {
//     public Teacher(string name, int age, DateOnly birthday, string address) : base(name, age, birthday, address)
//     {
//         Console.WriteLine("I am explaining");
//     }

//     public override void GetInfo()
//     {
//         Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old. My birthday is {BirthDay}. I am from {Address}. My ID is {ID}");
//     }
// }

// class TeacherAndStudent
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Are you a teacher or a student?");
//         string role = Console.ReadLine();

//         Console.WriteLine("Enter your name:");
//         string name = Console.ReadLine();

//         Console.WriteLine("Enter your address:");
//         string address = Console.ReadLine();

//         Console.WriteLine("Enter your birth date (yyyy-mm-dd):");
//         DateOnly birthDay = DateOnly.Parse(Console.ReadLine());

//         Console.WriteLine("Enter your age:");
//         int age = Convert.ToInt32(Console.ReadLine());

//         if (role.ToLower() == "teacher")
//         {
//             Teacher teacher = new Teacher(name, age, birthDay, address);
//             teacher.GetInfo();
//         }
//         else if (role.ToLower() == "student")
//         {
//             Student student = new Student(name, age, birthDay, address);
//             student.GetInfo();
//         }
//         else
//         {
//             Console.WriteLine("Invalid role. Please try again.");
//         }
//     }
// }





// using System;

// public class Person
// {
//     public string Name { get; set; }
//     public int ID { get; set; }
//     public int Age { get; set; }
//     public DateOnly BirthDay { get; set; }
//     public string Address { get; set; }
    
//     public Person(string name, int age, DateOnly birthday, string address)
//     {
//         Name = name;
//         Age = age;
//         BirthDay = birthday;
//         Address = address;
//         ID = GenerateRandomID();
//     }

//     private int GenerateRandomID()
//     {
//         Random random = new Random();
//         return random.Next(1000, 10000);
//     }

//     public virtual void Greet()
//     {
//         Console.WriteLine("hello");
//     }

//     public virtual void GetInfo()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}, BirthDay: {BirthDay}, Address: {Address}, Id: {ID}");
//     }
// }

// class Student : Person
// {
//     public Student(string name, int age, DateOnly birthday, string address) : base(name, age, birthday, address)
//     {
//        Console.WriteLine("hello i am studying");
//     }

//     public override void GetInfo()
//     {
//         Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old. My birthday is {BirthDay}. I am from {Address}. My ID is {ID}");
//     }
// }

// class Teacher : Person
// {
//     public Teacher(string name, int age, DateOnly birthday, string address) : base(name, age, birthday, address)
//     {
//         Console.WriteLine("I am explaining");
//     }

//     public override void GetInfo()
//     {
//         Console.WriteLine($"Hello, my name is {Name}. I am {Age} years old. My birthday is {BirthDay}. I am from {Address}. My ID is {ID}");
//     }
// }

// class TeacherAndStudent
// {
//     public static void Main(string[] args)
//     {
//         Teacher teacher = new Teacher("ecem ozgoncu", 28, new DateOnly(1999,09,09), "seattle");
//         teacher.GetInfo();
//         Console.WriteLine();

//         Student student = new Student("jaspreet singh", 32, new DateOnly(1991,09,03), "aydin");
//         student.GetInfo();
//         Console.WriteLine();
//     }
// }



using System;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    public DateOnly Birthday { get; set; }

    public Student()
    {
        Name = "ecem";
        ID = GenerateID();

        Birthday = DateOnly.Parse(Console.ReadLine());
    }

    public static int GenerateID()
    {
        Random random = new Random();
        return random.Next(1000,10000);
    }
    


    
    
}

class Teacher
{
    

    public string Job { get; set; }
    public int Age { get; set; }
    public int ID { get; set; } 

    public Teacher(string job, int age, int Id)
    {
        Job = job;
        Age = age;
        ID = GenerateId();
        

    }

    static int GenerateId()
    {
        Random random = new Random();
        return random.Next(1000,10000);
    }

    public void GetInfo()
    {
        Console.WriteLine($"hello my job is {Job} i am {Age} old. this is my {ID}");
    }
}
