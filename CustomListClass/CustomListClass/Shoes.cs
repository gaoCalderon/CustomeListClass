using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class Shoes : IEquatable<Shoes>
    {
        public string shoeType { get; set; }
        public int numberPairOfShoes { get; set; }

        public override string ToString()
        {
            return "Shoe Type: " + shoeType + " = " + numberPairOfShoes + " pairs";
        }

        public override bool Equals(object shoe)
        {
            if (shoe == null) return false;
            Shoes shoeAsShoes = shoe as Shoes;
            if (shoeAsShoes == null) return false;
            else return Equals(shoeAsShoes);
        }

        public override int GetHashCode()
        {
            return numberPairOfShoes;
        }

        public bool Equals(Shoes other)
        {
            if (other == null) return false;
            return (this.numberPairOfShoes.Equals(other.numberPairOfShoes));
        }













        //public void printShoeTypeList()
        //{
        //    foreach (object here in styleType)
        //    {
        //        Console.WriteLine(here); ;
        //    }
        //}

        //public void addToShoeList()
        //{
        //    Console.WriteLine("ADDING TO SHOE LIST:");
        //    Console.WriteLine("Please TYPE in shoe style and [ENTER]");
        //    shoeType = Console.ReadLine();
        //    Console.WriteLine("Please TYPE in pairs in stock of that style and [ENTER]");
        //    string input = Console.ReadLine();
        //    numberPairOfShoes = int.Parse(input);
        //    styleType.Add(new { shoeType, numberPairOfShoes });
        //}

        //public void removeShoeTypeFromList()
        //{
        //    Console.WriteLine("REMOVING SHOE LIST:");
        //    Console.WriteLine("Select line number to be REMOVED from options 0 through and [ENTER] ");
        //    string input = Console.ReadLine();
        //    int number = int.Parse(input);
        //    styleType.RemoveAt(number);
        //}

        //public void changeShoeTypeQuanity()
        //{

        //}

        //public void changeShoeType()
        //{

        //}

        //public void runOptionsToList()
        //{
        //    Console.WriteLine("List of Shoe Styles and Quanity of Pairs available: [ENTER]");
        //    Console.Read();
        //    Console.WriteLine("OPTIONS:");
        //    Console.WriteLine("a.) View List and Quanity");
        //    Console.WriteLine("b.) Add to List and Quanity amount");
        //    Console.WriteLine("c.) Remove a Shoe Style");
        //    Console.WriteLine("d.) Change Quanity amount to a Style");
        //    Console.WriteLine("e.) Save Changes & Exit");
        //    Console.WriteLine("f.) Exit - Do Not Save");
        //    Console.WriteLine("g.) Rename Shoe Style");
        //    string input = Console.ReadLine();
        //    switch (input)
        //    {
        //        case "a":
        //            Console.WriteLine("");
        //            printShoeTypeList();
        //            runOptionsToList();
        //            break;
        //        case "b":
        //            Console.WriteLine("");
        //            addToShoeList();
        //            runOptionsToList();
        //            break;
        //        case "c":
        //            Console.WriteLine("");
        //            removeShoeTypeFromList();
        //            runOptionsToList();
        //            break;
        //        case "d":
        //            Console.WriteLine("");
        //            changeShoeTypeQuanity();
        //            runOptionsToList();
        //            break;
        //        case "e":
        //            Console.WriteLine("");

        //            runOptionsToList();
        //            break;
        //        case "f":
        //            Console.WriteLine("");

        //            runOptionsToList();
        //            break;
        //        case "g":
        //            Console.WriteLine("");
        //            passwordProtected();
        //            runOptionsToList();
        //            break;
        //        default:
        //            Console.WriteLine("INVALID");
        //            runOptionsToList();
        //            break;
        //    }
        //}

        //    public void passwordProtected()
        //{
        //    Console.WriteLine("Need Password to change this Option");
        //    Console.WriteLine("Password:");
        //    string input = Console.ReadLine();
        //    switch (input)
        //    {
        //        case "dontcheat":
        //            changeShoeType();
        //            break;
        //        default:
        //            goBackTryAgain();
        //            break;
        //    }
        //}

        //public void goBackTryAgain()
        //{
        //    Console.WriteLine("Incorrect Password!");
        //    Console.WriteLine("a.) Try Again");
        //    Console.WriteLine("b.) Go Back");
        //    string input2 = Console.ReadLine();
        //    switch (input2)
        //    {
        //        case "a":
        //            passwordProtected();
        //            break;
        //        case "b":
        //            Console.WriteLine();
        //            break;
        //        default:
        //            Console.WriteLine("INVALID");
        //            goBackTryAgain();
        //            break;
        //    }
        //}


    }
}
