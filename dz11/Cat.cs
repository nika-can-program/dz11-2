using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    class Cat : IAnimalEnergy
    {
        int energy = 0;

        public void eat()
        {
            int e;
            e = energy + 51;
            Console.WriteLine($"Ваш котик подкрепился. Энергия: {e}");
        }

        public void walk()
        {
            int w;
            w = energy + 24;
            Console.WriteLine($"Ваш котик хорошо погулял. Энергия: {w}");
        }
    }
}

