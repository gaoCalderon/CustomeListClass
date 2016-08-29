using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class List
    {
        string hairpins { get; set; }
        int numberOfHairPins { get; set; }

        List<List> typesOfPins;

        public override string ToString()
        {
            return "Hair Pin Type: " + hairpins + " = " + numberOfHairPins + "Pins";
        }

        public void listOfHairPinTypes()
        {
            typesOfPins = new List<List>();
            typesOfPins.Add(new List() { hairpins = "flower", numberOfHairPins = 6 });
            typesOfPins.Add(new List() { hairpins = "dragonfly", numberOfHairPins = 4 });
            typesOfPins.Add(new List() { hairpins = "drops", numberOfHairPins = 8 });
        }

        public void addToHairPinList(int lineNumberInsert, int numberOfPins, string pinType)
        {
            new List<List>();
            Console.WriteLine("\nInsert{0}, \"{1}\")", lineNumberInsert, numberOfPins);
            typesOfPins.Add(new List() { hairpins = pinType, numberOfHairPins = numberOfPins});
        }
        
        public void removeFromHairPinList(int numberOfPins, string pinType)
        {
            new List<List>();
            Console.WriteLine("\nRemove(\"{0}\")", numberOfPins);
            typesOfPins.Remove(new List() { numberOfHairPins = numberOfPins, hairpins = pinType });
        }

        public void printListOfHairPins()
        {
            typesOfPins = new List<List>();
            foreach(List here in typesOfPins)
            {
                Console.WriteLine(here);
            }
        }
        
    }

}
