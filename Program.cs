// Author name: Justin Rodriguez 
// Course name: COMP003A-L01 
// Faculty name: Jonathan Cruz
// Purpose of the program: List 10 Things About Me 
using System.Runtime.CompilerServices;

namespace COMP003A.Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! My name is Justin Rodriguez");


            Console.WriteLine("Here are 10 things about me:");
            Console.WriteLine("\t1. I am a Computer Science major at WHCL");
            Console.WriteLine("\t2. I love gaming on my Personal Computer");
            Console.WriteLine("\t3. I am an Uncle to two handsome nephews");
            Console.WriteLine("\t4. I love to travel to other countries");
            Console.WriteLine("\t5. I listen to rock music");
            Console.WriteLine("\t6. I watch a lot of anime");
            Console.WriteLine("\t7. I am a blue belt in Brazilian Jiu Jitsu");
            Console.WriteLine("\t8. I like to train hypertrophy/strength in the gym");
            Console.WriteLine("\t9. I am into men's fashion");
            Console.WriteLine("\t10. I love eating pizza");
        }
    }
}
