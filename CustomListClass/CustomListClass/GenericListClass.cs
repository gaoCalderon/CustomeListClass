using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    class GenericListClass<T> 
    {
        T[] randomArrayList;


        public GenericListClass(T[] randomArrayList)
        {
            this.randomArrayList = randomArrayList;
        }

        public string ToString(T[] randomArrayList)
        {
            return "Listing: " + randomArrayList;
        }

        public void addToMyArrayList(T input)
        {
            T[] myNewArrayList = new T[randomArrayList.Length + 1];
            for (int i = 0; i < randomArrayList.Length; i++)
            {
                myNewArrayList[i] = randomArrayList[i];
            }
            myNewArrayList[myNewArrayList.Length - 1] = input;
            randomArrayList = myNewArrayList;
        }

        public void removeFromArrayList(T thingToRemove)
        {
            T[] myNewArrayList = new T[randomArrayList.Length - 1];
            for (int i = 0; i < randomArrayList.Length; i++)
            {
                if (i == thingToRemove)
                {
                    continue;
                }
                myNewArrayList[i] = randomArrayList[i];
            }
            randomArrayList = myNewArrayList;

            // if statement to do a bool, for continue to skip copy
            //for (int i = locationOfRowToTakeOut; i < totalRowsBeingUsed - 1; i++)
            //    randomArrayList[i] = randomArrayList[i + 1];
            //totalRowsBeingUsed--;
        }



    }
    
}
