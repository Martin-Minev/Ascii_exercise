using System;

namespace ascii_exercise
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int asciiValue = int.Parse(Console.ReadLine());
            char letter = (char)asciiValue;

            Console.WriteLine(letter);
        }
    }
}
