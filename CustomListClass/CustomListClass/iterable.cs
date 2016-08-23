using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class iterable<T>
    {

        List<string> typesOfShoes;
        List<int> numberOfShoes;
        T shoes;

        public iterable(T itemToPrint)
        {
            shoes = itemToPrint;

        }

        public void shoeList()
        {
            List<string> types = new List<string>();
            types.Add("classy");
            types.Add("skimpy");
            types.Add("casual");
            types.Add("winter");
            types.Add("comfy");
            types.Add("summer");

            Console.WriteLine("I love my {0} & {1} shoes.", types[0], types[2]);
        }

        public void addShoes()
        {

        }
    }
}
