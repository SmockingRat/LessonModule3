using System;

namespace LessonModule3
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "George";
            byte MyAge = 19;
            bool MyPet = true;
            float MySizeOfShoes = 37.5f;

            Console.WriteLine(MyName);

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("I'm" + MyAge);
            Console.WriteLine("Do you have a pet" + MyPet);
            Console.WriteLine("My shoes size is " + MySizeOfShoes);

            Console.ReadKey();


        }
    }
    
}
