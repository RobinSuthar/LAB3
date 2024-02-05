using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Cat : Animal
    {
        public Cat(string a, string b , int c)
        {
            this.Name = a;
            this.Colour = b;
            this.age = c;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name}\n" +
                $"{Colour}\n" +
                $"{age}\n" +
                $"CAT EATS MICE!");
        }

        public void Cry()
        {

        }
    }
}
