using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    class ImplementCustomClass
    {
        static void Main(string[] args)

        {

            CustomCollectionClass<int> CustomColl = new CustomCollectionClass<int>();

            //Added the elements in the ArrayList
            CustomColl.add(74);
            CustomColl.add(759);
            CustomColl.add(47);
            CustomColl.add(569);
            CustomColl.add(548);
            CustomColl.add(441);
            CustomColl.add(54);
            CustomColl.insert(41,2);


            //Display the elements
            CustomColl.show();

            //Deleting
            CustomColl.delete(32);
            CustomColl.show();


            //Displaying Capacity and length(size)
            Console.WriteLine(CustomColl.capacity());
            Console.WriteLine(CustomColl.length());
            Console.WriteLine("\n");

            // Implementing Sort
            CustomColl.sort();
            CustomColl.show();

            //Checking Contains method
            Console.WriteLine(CustomColl.contains(54));

            //Getting object at a given position
            Console.WriteLine(CustomColl.get(5));

            //Finding an element
            Console.WriteLine(CustomColl.find(47));
            Console.ReadLine();

        }
    }
}
