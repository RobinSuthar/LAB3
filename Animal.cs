using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double height { get; set; }
        public int age { get; set; }


        public virtual  void Eat()
        {
            Console.WriteLine("No one is eating meating");
        }
    }
}
