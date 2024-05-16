// // See https://aka.ms/new-console-template for more information
// using System.Data.Common;
// using System.Threading.Tasks.Dataflow;
// using System.Xml.XPath;

// Console.WriteLine("Hello, Ecem!");

// string firstBaby = "sylvia";

// string firstFriend = "Maria";

// firstFriend = firstFriend.Trim();  

// string secondFriend = "Jaspreet";


// string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

// Console.WriteLine(friends);

// Console.WriteLine(friends.Replace("Maria","Ecem"));

// Console.WriteLine(friends);

// Console.WriteLine(friends.Contains("Ecem"));

// Console.WriteLine(friends.ToUpper());

// Console.WriteLine(friends.Length);


// Console.WriteLine(friends);

// Console.WriteLine(friends.StartsWith("My      "));




// int a = 1800000000;
// int b =6;
// // int c= a + b;
// long c = (long)a + (long)b; //if you have massive numbers use this otherwise use the upper one
// //or use long c = checked(a+b) and if you used massive number you'll get information 
// Console.WriteLine(c);


// decimal x = 45.9M; //explicit type
// decimal y = 67.3M;
// decimal z = x + y;

// Console.WriteLine($"The answer is {c}");


// int d = 5;
// int e = 6;

// if (d+e>10) //true 
//             {
//     Console.WriteLine("The answer is greater than 10");
// } //otherwise
// else
// {
//     Console.WriteLine("The answer is less than 10");
// }


// int f = 4;
// int g = 9;
// int h = 11;

// if ((f + g + h>10) && (a==b))
// {
//     Console.WriteLine("The answer is greater than 10");
//     Console.WriteLine("And the first number is equal to the second.");
// }

// else 
// {
//     Console.WriteLine("The answer is npt greater than 10");
//     Console.WriteLine("Or the first number is not equal to the second");
// }





//LOOPS


// int counter = 0;

// counter++; //counter = counter +1 ile ayni
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);
// counter++;
// Console.WriteLine(counter);

// or


// int counter = 0;
// while(counter < 5)
// {

//      Console.WriteLine(counter);
//      counter++;
// }



// int counter = 10;
// while(counter < 5)
// {

//      Console.WriteLine(counter);
//      counter++;
// }
// result would be 10





// int counter = 0;
// do
// {
//     Console.WriteLine(counter);
//     counter++;
// }
// while (counter<5);

// // same result 


// for (int i = 0; i < 5; i++)
// {
//     if (i == 3)
//     {
//         Console.WriteLine(i);
//     }
// }



// for (int row = 1; row <11; row++)
// {
//     for (char column = 'a'; column < 'k'; column++)
//     {
//         Console.WriteLine($"The cell is ({row}, {column})");
//     }
// }



// // LISTS


// var names = new List<string>  {"scott",  "Ana", "Felipe" };

// names.Add("David");
// names.Add("Damian");
// names.Add("Maria");
// foreach ( var name in names) //or var i in names 

// {
//     Console.WriteLine($"Hello {name.ToUpper()}"); //i.ToUpper
// }



// for (int i = 0; i < names.Count; i++)

// {
//     Console.WriteLine($"Hello {names[i].ToUpper()}");
// }



// Console.WriteLine(names[0]);
// Console.WriteLine(names[3]);
// Console.WriteLine(names[names.Count - 1]);  //son ismi buluruz
// Console.WriteLine(names[^1]); //ustekinin kisa hali-count from the back of the array
// Console.WriteLine(names[^2]);



// foreach (var name in names[2..4])
// {
//     Console.WriteLine($"Hello {name.ToUpper()}"); // in this case 2. and 3. number included not 4.
// }



// ARRAY



// var foods = new string[] {"iskender", "adana" , "manti", "sarma"};

// foods = [..foods, "dolma"];

// foreach (var food in foods)
// {
//     Console.WriteLine($"I love {food.ToUpper()}");
// }



//LISTS


// var fruits = new List<string> {"banana", "apple" , "blueberry"};

// fruits.Sort();

// foreach (var fruit in fruits)
// {
//     Console.WriteLine($"My favorite fruit is {fruit.ToLower()}");
// }


// var numbers = new List<int> {45,56,90,29,51,46,11};

// numbers.Sort();
// Console.WriteLine($"I found 90 at index {numbers.IndexOf(90)}");

// foreach (var number in numbers)
// {
//     Console.WriteLine($"My lucky number is {number}") ;

// }



//LINQ


//SPECIFY THE DATA SOURCE.

//int[] scores = [97, 92, 81, 60]; or

// int[] scores = {90, 71, 82, 93, 75, 82};

// for (int i = 0; i < scores.Length; i++)


// {
//     if(scores[i] > 80)
//     {
//         Console.WriteLine($"Found a score over 80 {scores[i]}");

//     }
//

// //DEFINE THE QUERY EXPRESSION

// IEnumerable<int> scoreQuery =  // query variable
//     from score in scores //required
//     where score > 80 // optional
//     orderby score descending //optional
//     select score; //must end with selact or group




// //EXUCUTE THE QUERY TO PRODUCE THE RESULLTS

// foreach (int i in scoreQuery)
// {
//     Console.Write(i + "");

// }

// //output: 93 90 82 82


// namespace Variables
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//            Console.WriteLine("Lutfen ilk sayi degeri giriniz");
//            int number1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("Please give value to the second number");
//            int number2 = int.Parse(Console.ReadLine());

//            Console.WriteLine($"Your total is {number1 + number2}"); 

// }
//     }

// }



// using System.Security.Cryptography;
// using System.Security.Cryptography.X509Certificates;

// using System.IO.Pipes;
// using System.Security.Cryptography;
// using System.Security.Cryptography.X509Certificates;

// namespace Name
// {
//     class program
//     {
//         public static void Main()
//         {
//             Console.WriteLine("Hello OOP");
//             var p1 = new Person("Ecem", "Ozgoncu",DateOnly(1996,2,4));
//             var p2 = new Person("Jaspreet", "Singh", DateOnly(1991,11,13));

//             p1.pets Add (New Dog("fred"));
//             p1.pets Add (New Cat ("Sylvia"));

//             p2.pets Add (New Snake ("Louis"));

//             List <Person> people = [p1, p2];

//             foreach (var person in people)
//             {
//                 Console.WriteLine($"   {person}");
//                 foreach (var pet in person.pets);

//                 Console.WriteLine($"   {pet}");}

//                 PublicKey class person(string firstname, string lastname, DateOnly birthday)
//                 {
//                     public string First { get; } = firstname;
//                     public string Last { get; } = lastname;
//                     public  DateOnly birthday { get; } = birthday;

//                     public List<Pet>Pets{get;} = new();
//                 }

//         public override string ToString()
//         {
//             return $"Human {First} {Last}";
//         }


//         public abstract class Pet(string Firstname)
//             {
//                 public string First { get; } = Firstname;
//                 public abstract string MakeNoise();

//             public override string ToString()
//             {
//                 return $"Human {First} {Last}";
//             }


//         public abstract class Pet(string Firstname)
//         {


//         }    

//         }    



//             }

//         }
//     }
// }


//MULAKAT

// Console.WriteLine("hello World");


// var st1 = new person("Ecem",);

// give the id define the person.




// public class person(string firstname, int id);

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Hello World");

//         // Creating a person with a name and ID
//         var person1 = new Person("Ecem", 123);

//         // Accessing the person's properties
//         Console.WriteLine($"Name: {person1.FirstName}, ID: {person1.ID}");
//     }
// }

// public class Person
// {
//     public string FirstName { get; }
//     public int ID { get; }

//     public Person(string firstName, int id)
//     {
//         FirstName = firstName;
//         ID = id;
//     }
// }


//ALGORITM QUESTIONS

//iki sayinin toplaini veren uygulamayi yaziniz.

// using System.Data;

// Console.WriteLine("iki sayiyi giriniz.");

// Console.WriteLine("sayi 1:");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("ikinci sayi lutfen");

// int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number1 + number2;

// Console.WriteLine(result);



//iki sayinin karelerinin toplami?
//COZUM 1

// Console.WriteLine("please enter two numbers");
// Console.WriteLine("first number please");

// int num1 = Convert.ToInt32(Console.ReadLine());

// int square1 = num1 * num1;

// Console.WriteLine("second number please");

// int num2 = int.Parse(Console.ReadLine());

// int square2 = num2 * num2;

// int result = square1 + square2;

// Console.WriteLine($"Your total is {result}");


// //Math.Pow(2,3) : 2 nin 3uncu kuvveti
// //COZUM2 

// double sonuc = Math.Pow(num1,2) + Math.Pow(num2,2);

// Console.WriteLine(sonuc);

// //COZUM 3

// Console.WriteLine("lutfen birinci ve ikinci sayiyi girniz");

// double sonu = Math.Pow(Convert.ToInt32(Console.ReadLine()),2) + Math.Pow( int.Parse(Console.ReadLine()),2);

// Console.WriteLine(sonuc);


//1'den 10'a kadar olan sayilarin kuplerinin toplami?

//COZUM 1
// double toplamSonuc = 0;
// for (int i = 1; i < 11 ; i++)
// {
//     toplamSonuc += Math.Pow(i,3);
// }
// Console.WriteLine(toplamSonuc);




//COZUM2
// double toplamSonuc = 0;
// int sayac = 1;
// while (true)
// {
//     toplamSonuc += Math.Pow(sayac, 3);
//     if (sayac == 10)
//         break;

//     sayac++;
// }

// Console.WriteLine(toplamSonuc);



//COZUM3

// double toplamSonuc = 0;
// int sayac = 1;

// while (sayac <= 10)
// {
//     toplamSonuc += Math.Pow(sayac,3);
//     sayac ++;
// }

// Console.WriteLine(toplamSonuc);


//COZUM3

// double toplamSonuc = 0;
// int sayac = 1;

// do
// {
//     toplamSonuc += Math.Pow(sayac,3);

//     if (sayac==10)
//     break;
//     sayac ++;

// } while (true);

// Console.WriteLine(toplamSonuc);


// using System;
// using System.Runtime.CompilerServices;

// public class Program
// {


//     public static void Main()
//     {
//         // int age = 31;
//         // string name = "Ecem";
//         // int exp = 5;

//         // Console.WriteLine("Hello my name is {0}, I am {1} years old, I have {2} years of experience", name, age, exp);


// string myName;
// Console.WriteLine("please enter your name");
// myName = Console.ReadLine();

// string myNAmeUpperCase = String.Format("upper case : {0}", myName.ToUpper());
// Console.WriteLine(myNAmeUpperCase);




// public partial class Program
// {
//     public static void Main()
//     {
//         string temparature = Console.ReadLine();
//         int numTemp = int.Parse(temparature);



//         if (numTemp < 10)
//         {
//             Console.WriteLine("take your coat");
//         }

//     }
// }



//EVEN OR ODD NUMBER EXC

// using System;

// namespace Coding.Exercise
// {
//     public class Exercise
//     {
//         public static void Main(string[] args)
//         {

//             Console.WriteLine("enter a number");
//             int number = Convert.ToInt32(Console.ReadLine());

//             if (number % 2 == 0)
//             {
//                 Console.WriteLine($"{number} is even number");
//             }

//             else
//             {
//                 Console.WriteLine($"{number} is odd number.");
//             }
//         }
//     }
// }



//NESTED IF STATEMENT

// using System;

// namespace Coding.Exercise
// {
//     public class Exercise
//     {
//         public static void Main(string[]args){

//         Console.WriteLine("please neter a number");
//         int number = Convert.ToInt32(Console.ReadLine());
//         {
//             if (number%3 == 0)
//             {
//                 Console.WriteLine("Divisible by 3.");
//             }
//             else if (number%7 == 0){
//                 Console.WriteLine("Divisible by 7.");
//             }
//             else{
//                 if (number%2 != 0)
//                     Console.WriteLine("Odd number.");
//                 else
//                 Console.WriteLine("Even number.");
//             }
//         }
//     }
//     }
// }

// using System.Diagnostics.CodeAnalysis;
// using Microsoft.VisualBasic;
// using System;

//Create an application with a score, highscore and a highscorePlayer.
// Create a method which has two parameters, one for the score and one for the playerName.
// When ever that method is called, it should be checked if the score of the player is higher than the highscore,
//  if so, "New highscore is + " score" and in another line "New highscore holder is 
//  " + playerName - should be written onto the console, if not "The old highscore of " + highscore + " 
//  could not be broken and is still held by " + highscorePlayer.
// Consider which variables are required globally and which ones locally.


// namespace HighScoreClculator
// {
//     using System;
//     using System.Security.Cryptography.X509Certificates;

//     class Program
//     {
//         static int highScore = 300;
//         static string highScorePlayer = " ";

//         public static void Main(string[]args)
//     {

//         Console.WriteLine("Welcome! Please enter your name");
//          string PlayerName = Console.ReadLine();

//          Console.WriteLine("please enter your score");
//          int score = Convert.ToInt32(Console.ReadLine());

//          ScoreFinder(score, PlayerName );



//     }


//         static void ScoreFinder(int score, string PlayerName)

//          {
//             if(score>highScore)
//             {
//                 highScore = score;
//                 highScorePlayer = PlayerName;


//                 Console.WriteLine($"New high score! player name is {PlayerName}");

//             }

//          }
//     }
//     }





// Create a user Login System, where the user can first register and then Login in. The Program should check 
// if the user has entered the correct user4 and password, wenn login in (so the same ones that he used when
//  registering).
// As we haven't covered storing data yet, just create the program in a way, that registering and logging in, 
// happen in the same execution of it.
// User If statements and User Input and Methods to solve the challenge.

// using System;

// class UserLoginSystem
// {
//     static string UserName = "";
//     static string PassWord = "";

//     public static void Main(string[] args)
//     {
//         Register();
//         Login();
//     }

//     public static void Register()
//     {
//         Console.WriteLine("Welcome, please create an account");
//         Console.WriteLine("Please enter your name");

//         UserName = Console.ReadLine();

//         Console.WriteLine("Please enter your password");

//         PassWord = Console.ReadLine();
//     }

//     public static void Login()
//     {
//         Console.WriteLine("Login to your account");
//         Console.WriteLine("Enter your username");

//         string inputUsername = Console.ReadLine();

//         Console.WriteLine("Enter your password");
//         string inputPassword = Console.ReadLine();

//         if (inputUsername == UserName && inputPassword == PassWord)
//         {
//             Console.WriteLine($"Login successful. Welcome {UserName}");
//         }
//         else
//         {
//             Console.WriteLine("Wrong username or password. Please try again.");

//             Console.Read();
//         }
//     }
// }














// using System;

// class HighScoreTracker
// {
//     static int highScore = 0;
//     staticstring highScorePlayer = "";

//     public static void Main(string[] args)
//     {

//         Console.WriteLine("Please enter your name:");
//         string playerName = Console.ReadLine();

//         Console.WriteLine("Please enter your score:");
//         int score = Convert.ToInt32(Console.ReadLine());

//         // Method call to update the high score
//         if (score > highScore)
//         {
//             highScore = score;
//             highScorePlayer = playerName;
//             Console.WriteLine("New high score: " + score);
//             Console.WriteLine("New high score holder: " + playerName);
//         }
//         else
//         {
//             Console.WriteLine("The old high score could not be broken and is still held by " + highScorePlayer + ".");
//         }
//     }
// }


// using System;

// class HighScoreTracker
// {

//     // Method to update the high score
//     public static void UpdateHighScore(int score, string playerName)
//     {
//         if (score > highScore)
//         {
//             highScore = score;
//             highScorePlayer = playerName;
//             Console.WriteLine("New high score: " + score);
//             Console.WriteLine("New high score holder: " + playerName);
//         }
//         else
//         {
//             Console.WriteLine("The old high score could not be broken and is still held by " + highScorePlayer + ".");
//         }
//     }
//     static int highScore = 0;
//     static string highScorePlayer = "";

//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Please enter your name:");
//         string playerName = Console.ReadLine();

//         Console.WriteLine("Please enter your score:");
//         int score = Convert.ToInt32(Console.ReadLine());

//         // Method call to update the high score
//         UpdateHighScore(score, playerName);
//     }
// }

// class CoffeeShop
// {
//     static int expresso_shots = 3;
//     public static void MakeCoffee(int expresso_shots, string milk, string how)
//     {
//         10 lines
//     }
//     public static void MakeMocha(int shots, string milk, string how)
//     {
//         int mocha_shots = expresso_shots + 1;
//         MakeCoffee(mocha_shots, milk, how);
//     }
// }


// Design a class called Stopwatch. The job of this class is to simulate a stopwatch. 
// It should provide two methods: Start and Stop. We call the start method ﬁrst, and the
//  stop method next. Then we ask the stopwatch about the duration between start and stop.
//   Duration should be a value in TimeSpan. Display the duration on the console. 
// We should also be able to use a stopwatch multiple times. So we may start and stop it 
// and then start and stop it again. Make sure the duration value each time is calculated 
// properly. 
// We should not be able to start a stopwatch twice in a row (because that may overwrite 
// the initial start time). So the class should throw an InvalidOperationException if 
// its started twice. 

// using System;
// namespace MynameSpace
// {
//     //KRONOMETRE SINIFI TANIMI
// public class Stopwatch
// {

//     //KRONOMETRE OZELLIKLERI
//     public string TimeLine { get; set; }
//     public string Duration { get; set; }


//      public void Start()
//     {
//         Console.WriteLine("the stopwatch is started.");
//     }

//      public void Stop()
//     {
//         Console.WriteLine("the stopwatch is stopped.");
//     }


// }
// //PROGRAMIN ANA SINIFI
// class Program
// {
//     static void Main(string[]args)
//     {

//         //KRONOMETRENIN NESNESINI OLUSTUR.
//         Stopwatch newWatch = new Stopwatch();

//         //KRONOMETRENIN OZELLIKLERININ AYARLAMA

//         newWatch.TimeLine = DateTime.Now.ToString();
//         newWatch.Duration = "00:00:00";

//         //KRONOMETEREYI BASLATMA
//         newWatch.Start();








//     }
// }    

// }



// Create a C# program that requests three names of people from the user and stores them in an array of objects 
// of type Person. To do this, first create a Person class that has a Name property of type string and override 
// the ToString() method.

// End the program by reading people and executing the ToString() method on the screen.
// Hello! My name is Juan
// Hello! My name is Sara
// Hello! My name is Carlos





    
    
