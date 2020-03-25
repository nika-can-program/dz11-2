using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            
            cat.eat();
            cat.walk();
            

            Dog dog = new Dog();
            
            dog.eat();
            dog.walk();


            Girrafe giraffe = new Girrafe();

            giraffe.eat();
            giraffe.walk();

            Console.ReadLine();
        }
    }
}