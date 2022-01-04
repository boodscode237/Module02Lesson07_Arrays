using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Array creation
            string[] firstNames = new string[5];
            
            // // MainApp.exe
            firstNames[0] = "Brice";
            firstNames[1] = "Donny";
            firstNames[2] = "July";
            firstNames[3] = "Conan";
            firstNames[4] = "Math";
            
            Console.WriteLine($"My array has \n->{firstNames[0]}, \n->{firstNames[1]}, \n->{firstNames[2]}, \n->{firstNames[3]}, \n->{firstNames[4]}");

            string data = "Brice,Donny,July,Conan,Matthew";
            string[] firsnames = data.Split(',');
            Console.WriteLine($"The third name is {firsnames[2]}");

            int[] ages = new int[3];
            ages[0] = 4;
            ages[1] = 27;
            ages[2] = 30;

            string[] lastNames = new string[] { "Brice", "Donny", "July", "Conan", "Matthew" };
            lastNames[2] = "Jeremy";

            Console.ReadLine();
        }
    }
}
