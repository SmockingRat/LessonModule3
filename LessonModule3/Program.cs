using System;

namespace LessonModule3
{
    class Program
    {
        static void Main(string[] args)
        {
           
         

            Console.WriteLine("What is your name? ");
            var MyName = Console.ReadLine();
            Console.WriteLine("How old are you? ");
            var MyAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and your age is {1}", MyName, MyAge);
            Console.WriteLine("Enter your birthday: ");
            var DayOfBirth = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Your birthday is " + DayOfBirth);

            Console.ReadKey();




        }
        enum Semaphore
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        
        enum DaysOfWeek
        {
            Mondae = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sundae = 7

        }

    }


    
}
