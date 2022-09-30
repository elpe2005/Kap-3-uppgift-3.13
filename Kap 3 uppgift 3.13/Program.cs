using System;
namespace Uppgift313
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du i heltal?");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 16 && ålder <= 19) 
            {
                Console.WriteLine("Du får delta i tävlingen");
            }

            else if (ålder < 16) 
            {
                Console.WriteLine("Du är för ung för att delta");
            }

            else
            {
                Console.WriteLine("Du är för gammal för att delta");
            }
        }  
    }  
}