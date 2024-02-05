using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string selection = "";
            Console.Write("HELLO WELCOME !! \nWHAT WOULD YOU LIKE TO SELECT DOG(D) or CAT(C): "); 
            selection = Console.ReadLine();

            if (selection == "d")
            {
                Console.WriteLine("Wonderfull !! You have selected DOG. please provide the following info : ");
                string name;
                string colour;
                int age;
                Console.Write("ENTER THE Name: ");
                name = Console.ReadLine();
                Console.Write("ENTER THE Colour: ");
                colour = Console.ReadLine();
                Console.Write("ENTER THE Age: ");
                age = int.Parse(Console.ReadLine());
                Dog dog1 = new Dog(name, colour, age);
                dog1.Eat();
            }

            if (selection == "c")
            {
                Console.WriteLine("Wonderfull !! You have selected CAT. please provide the following info : ");
                string name;
                string colour;
                int age;
                Console.Write("ENTER THE Name: ");
                name = Console.ReadLine();
                Console.Write("ENTER THE Colour: ");
                colour = Console.ReadLine();
                Console.Write("ENTER THE Age: ");
                age = int.Parse(Console.ReadLine());
                Cat cat1 = new Cat(name,colour,age);
                cat1.Eat();

            }
            Console.ReadLine();
        }
    }
}
