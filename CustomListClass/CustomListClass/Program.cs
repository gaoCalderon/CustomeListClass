using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Program
    {


        static void Main()
        {
            int[] test = new int[] { 1, 2, 3 };
            GenericListClass<int> genericListClass = new GenericListClass<int>(test);
            genericListClass.addToMyArrayList(4);
            genericListClass.removeFromArrayList(2);
            
            
            
            
            
            
            
            
            
            
            
            
            //List<Shoes> styleType = new List<Shoes>();

            //styleType.Add(new Shoes() { shoeType = "classy", numberPairOfShoes = 5 });
            //styleType.Add(new Shoes() { shoeType = "formal", numberPairOfShoes = 5 });
            //styleType.Add(new Shoes() { shoeType = "casual", numberPairOfShoes = 7 });
            //styleType.Add(new Shoes() { shoeType = "comfort", numberPairOfShoes = 4 });


            //Console.WriteLine();
            //foreach (Shoes here in styleType)
            //{
            //    Console.WriteLine(here);
            //}


            //Console.WriteLine("\nContains(\"3\"): {0}",
            //styleType.Contains(new Shoes() { numberPairOfShoes = 3, shoeType = "" }));


            //Console.WriteLine("\nInsert(2, \"6\")");
            //styleType.Insert(2, new Shoes() { shoeType = "skimpy", numberPairOfShoes = 6 });
            //Console.WriteLine("\nInsert(4, \"4\")");
            //styleType.Insert(4, new Shoes() { shoeType = "winter", numberPairOfShoes = 4 });


            //foreach (Shoes here in styleType)
            //{
            //    Console.WriteLine(here);
            //}


            //Console.WriteLine("\nShoes[3]: {0}", styleType[3]);

            //Console.WriteLine("\nRemove(\"5\")");
            //styleType.Remove(new Shoes() { numberPairOfShoes = 5, shoeType = "boots" });


            //Console.WriteLine();
            //foreach (Shoes here in styleType)
            //{
            //    Console.WriteLine(here);
            //}
            //Console.WriteLine("\nRemoveAt(4)");
            //styleType.RemoveAt(4);

            //Console.WriteLine();
            //foreach (Shoes here in styleType)
            //{
            //    Console.WriteLine(here);
            //}

          





            //Shoes shoes = new Shoes();

            //shoes.runOptionsToList();

        }
    }
}
