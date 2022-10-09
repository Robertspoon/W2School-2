using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace W2School_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int x = 47;
            int y = 23;
            Console.WriteLine("---> C# MATH <---");
            Console.WriteLine();
            Console.WriteLine( x > 5 && y < 55);


            Console.WriteLine(Math.Max(6, 20));
            Console.WriteLine(Math.Min(6, 20));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.4));
            Console.WriteLine(Math.Round(75.847));
            Console.WriteLine();
            Console.WriteLine("---> C# STRINGS <---");

            string greeting = "Hello";
            string greeting2 = "I want to strangle you to death i hate you :)))))))))))";
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string help = "This is a cry for help";
            string murder = "THEYLL NEVER FIND HIS BODY :)";
            string firstName = "Chuck ";
            string lastName = "Mcgill";
            string name = $"The voices are gettign louder, btw, my full name is: {firstName} {lastName}";
            int x2 = 726;
            int y2 = 1;
            int z2 = x2 + y2;
            string x3 = "72";
            string y3 = "7";
            string z3 = x3 + y3;
            string myString = "Goodbye cruel world";
            string fullName = "Charles Mcgill";
            int charPos = name.IndexOf("g");
            string lastName2 = name.Substring(charPos);
            string threat = "We shall destroy Italian \"People\" tonigh!";
            string balls = "Give me Ted\'s balls!";
            
            Console.WriteLine(name);
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            Console.WriteLine(help.ToUpper());
            Console.WriteLine(murder.ToLower());
            Console.WriteLine(z2);
            Console.WriteLine(z3);
            Console.WriteLine(myString.IndexOf("b"));
            Console.WriteLine(lastName2);
            Console.WriteLine(threat);
            Console.WriteLine(balls);
            






            Console.ReadKey(true);
        }
    }
}
