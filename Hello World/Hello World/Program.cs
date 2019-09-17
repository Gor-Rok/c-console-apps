using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World!";
            //Variables
            string firstname = "Jacob Sampson Mann";
            byte Age = 17;
            string favoritesubject = "History";





            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello Sampson Mann");
            Console.WriteLine("Name: "+ firstname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("In two months and elevne days you will be:" + (Age+1));
            Console.WriteLine("Favorite school subject: " + favoritesubject);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
