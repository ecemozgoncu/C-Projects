using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace C_exercises
{/*
    internal class Program
    {                
        static void Main(string[] args)
        {
            //Write a C# Sharp program that stores elements in an array and prints them.

            
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 } ;
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            

            int[] nums = { 10, 1, 2, 2, 3, 2, 4, 2 };
            int val = 2;
            int k = RemoveElement(nums, val);

            Console.WriteLine($"Output: {k}, nums = [{string.Join(",", nums.Take(k))}]");
        }

            static int RemoveElement(int[] nums, int val) {
                
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;    
                }
                

            }
                return k;
        }
            

        static void Main(string[] args)
        {


            List<string> names = new List<string> { "ali", "ayse", "murat" };
            string NewName = "ecem";

            AddName(names, NewName);

            foreach (string name in names)
            {
                Console.WriteLine(name);

            }

            static void AddName(List<string> names, string NewName)
            {
                names.Add(NewName);
            }



        }

        


        public static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 3, 4, 5, 6, 77, 8, 9 };

            int NewNumb = 5;


            AddName(nums, NewNumb);

            foreach (int num in nums)
            {
                Console.WriteLine(nums);

            }

            static void AddName(List<int> nums, int NewNumb)
            {
                nums.Add(NewNumb);

            }

        }
        

        public static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 2, 3, 3, 5, 3, 4, 7, 1, 1, 2 };
            int[] expectedNums = { 1, 2, 3, 4, 5, 7 };
            int k = RemoveDublicates(array, expectedNums); //call my implementation

            Console.WriteLine($"output: {k},nums=[{string.Join(",", array.Take(k))}]");

            static int RemoveDublicates(List<int> array, int[ ]expectedNums)
            {
                if(array == null || expectedNums == null) return 0;

                int k = 0;

                for (global::System.Int32 i = 0; i < expectedNums.Length; i++)

                {
                    if (array.Contains(expectedNums[i]))
                    {
                        array[k] = expectedNums[i];
                        k++;
                    }


                }
                return k;
            }

        }
      

            static void Main(string[] args)
            {
                List<string> names = new List<string> { "ecem", "ada", "firuze", "ecem", "ada", "ege" };
                string[] expectedList = { "ecem", "ada", "firuze", "ege" };

                int k = RemoveDuplicates(names, expectedList);
                Console.WriteLine($"output: {k}, names = [{string.Join(",", names.Take(k))},_]");
            }

            static int RemoveDuplicates(List<string> names, string[] expectedList)
            {
                if (names == null || expectedList == null) return 0;

                int k = 0;

                for (int i = 0; i < expectedList.Length; i++)
                {
                    if (names.Contains(expectedList[i]))
                    {
                        names[k] = expectedList[i];
                        k++;
                    }
                }

                return k;
            }
        
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 1, 1, 2, 3, 3, 3, 4, 5, 6, 7, 7, 7 };
            int[] expectedNums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = RemoveDublicates(nums, expectedNums);
            Console.WriteLine($"output: {k}, nums= [{string.Join(",", nums.Take(k))}]");

        }
        static int RemoveDuplicates(List<int> nums, int[] expectedNums)
        {
            if (expectedNums.Length == 0 || nums.Count == 0) return 0;

            int k = 0;

            for (int i = 0; i < expectedNums.Length; i++)
            {
                if (nums.Contains(expectedNums[i]))
                {
                    nums[k] = expectedNums[i];

                    k++;


                }
            }
            return k;




        //REMOVE DUBLICATES

        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 1, 1, 2, 2, 2, 3, 3, 4, 5 };
            int k = RemoveDuplicates(list);
            Console.WriteLine($"output: {k}, list: [{string.Join(",", list.Take(k))}]");
        }

        static int RemoveDuplicates(List<int> list)
        {
            if (list == null || list.Count == 0) return 0;

            int k = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (i < 2 || list[i] != list[k - 2])
                {
                    list[k] = list[i];
                    k++;
                }
            }

            return k;
        }
        

        //ROTATE ARRAY


        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int k = 3;
            int[] newNums = RotateNumbers(nums,k);

            Console.WriteLine($"output : {k} , nums: {newNums}");
        }

        static int RotateNumbers(int[] nums)
        {
            if (nums == null || nums.Length == 0) return nums;
            int num = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i<= 0 || nums[i] != nums[]
                {
                    
                }
            }
        }
        

        //ROTATE ARRAY SOLUTION


        using System;
using System.Linq;

namespace RotateArrayExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] nums = { 1, 2, 3, 4, 5 };
                int k = 3;
                int[] newNums = RotateNumbers(nums, k);

                Console.WriteLine($"output : {k} , nums: [{string.Join(", ", newNums)}]");
            }

            static int[] RotateNumbers(int[] nums, int k)
            {
                if (nums == null || nums.Length == 0) return nums;
                int n = nums.Length;
                k = k % n; // Eğer k dizinin uzunluğundan büyükse, modunu alarak küçült.

                // Yeni dizi oluştur ve elemanları k'ya göre döndür
                int[] rotatedNums = new int[n];
                for (int i = 0; i < n; i++)
                {
                    rotatedNums[(i + k) % n] = nums[i];
                }
                return rotatedNums;
            } 


    //Write a C# Sharp program to create a nested struct that stores two data for an employee.

    using System;
    public class Employee

    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int ID { get; set; }
        public DateOnly Birthdate { get; set; }

        public Employee(string name, int age, DateOnly birthdate)
        {
            Name = name;
            Age = age;
            ID = GenerateId();
            Birthdate = birthdate;

        }

        private int GenerateId()
        {
            Random random = new Random();
            return random.Next(100, 999);
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"hello, my name is {Name}, I am {Age} and my bdate is {Birthdate} my id is {ID}");
        }


    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Ecem", 35, new DateOnly(1990, 09, 09));
            employee.GetInfo();

            Console.WriteLine("enter your name ");

            string name = Console.ReadLine();
            int age = 34;

            Employee employee2 = new Employee(name, age, new DateOnly());
            employee2.GetInfo();
        }


    }
}
    */


    public class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7,5, 8 };

            int num = 5;
            int newNum = 10;

            list = list.Where(x => x != num).ToList();


            /*
            while (list.Contains(num))
            {
                list.Remove(num);
                list.Add(newNum);
            }
            */

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is an even number");
            }
            else
            {
                Console.WriteLine($"{num1} is an odd number");
            }

        }

  
    }
}

 







