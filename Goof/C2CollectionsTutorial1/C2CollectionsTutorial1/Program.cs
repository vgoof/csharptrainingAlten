using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // needed for arraylist

namespace C2CollectionsTutorial1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrList = new ArrayList();
            myArrList.Add("First Item");
            myArrList.Add(3);
            myArrList.Add(4.5);

            foreach (object obj in myArrList)
            {
                Console.WriteLine(obj.ToString());
            }

            // myArrList.Sort(); // this will throw an exception because it cannot sort objects of different type

            ArrayList newArrList = new ArrayList();
            newArrList.Add("First Item");
            newArrList.Add("Third Item");
            newArrList.Add("Second Item");
            newArrList.Sort();
            int itemIndex = newArrList.IndexOf("Third Item");

            foreach (object obj in newArrList)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine();
            Console.WriteLine($"Third Item is at index {itemIndex}.");

        }
    }
}
