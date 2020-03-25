using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    class Person : IPrint
    {
        public void Print()
        {
            Console.WriteLine($"\\Человек\\Здравствуйте, добрый вечер.");
        }

    }
}
