using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    class Girrafe : IAnimalEnergy
    {
        int energy=0;

        public void eat()
        {
            int e;
            e = energy + 23;
            Console.WriteLine($"Ваш жираф подкрепился. Энергия: {e}");
        }

        public void walk()
        {
            int w;
            w = energy + 12;
            Console.WriteLine($"Ваш жираф хорошо погулял. Энергия: {w}");
        }

    }
}
