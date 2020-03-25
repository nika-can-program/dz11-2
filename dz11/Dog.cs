using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz11
{
    class Dog : IAnimalEnergy
    {
        int energy=0;

        public void eat()
        {
            int e;
            e = energy + 74;
            Console.WriteLine($"Ваш хороший мальчик подкрепился. Энергия: {e}");
        }

        public void walk()
        {
            int w;
            w = energy + 999999;
            Console.WriteLine($"Ваш хороший мальчик хорошо погулял. Энергия: {w}");
        }

    }
}
