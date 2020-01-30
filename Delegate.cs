using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        #region "Declaration of multicast delegate"
        /// <summary>
        /// Delegate used for any purpose with 2 float arugument
        /// </summary>
        /// <param name="a">Float type of augmentment</param>
        /// <param name="b">Float type of augmentment</param>
        public delegate void Operation(float a, float b);
        #endregion

        #region "Declaration of Single delegate"
        /// <summary>
        /// Single delegate used to display the data of integer type.
        /// </summary>
        /// <param name="a">Integer date type</param>
        public delegate void displayInt(int a);

        /// <summary>
        /// Single delegate used to display the data of float type.
        /// </summary>
        /// <param name="a">Float date type</param>
        public delegate void displayFloat(float a);

        /// <summary>
        /// Single delegate used to display the data of string type.
        /// </summary>
        /// <param name="a">String date type</param>
        public delegate void displayString(String a);
        #endregion
        static void Main(string[] args)
        {
            #region "Initialization and invokation of multicast delegate"
            MulticastDelegate multicastDelegate = new MulticastDelegate();
            Operation operation = new Operation(multicastDelegate.add);
            operation += multicastDelegate.sub;
            operation += multicastDelegate.mul;
            operation += multicastDelegate.div;
            Console.WriteLine("Multicast Delegate");
            operation.Invoke(10, 20);
            #endregion

            #region "Initialization and invokation single delegate"
            SingleDelegate singleDelegate = new SingleDelegate();
            displayInt printInt = new displayInt(singleDelegate.printInt);
            displayFloat printFloat = new displayFloat(singleDelegate.printFloat);
            displayString printString = new displayString(singleDelegate.printString);
            Console.WriteLine("\n\nSingle Delegate");
            printInt(10);
            printFloat(99f);
            printString("HelloWorld");
            #endregion

            #region "Comparison"
            Console.WriteLine("\n\n Comparison : ");
            string[] array ={"bird","elephant","dog","cat","mouse"};
            Console.WriteLine("Data Before sorting according to length");
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("\n Data After sorting according to length");

            Comparision sort = new Comparision();
            Comparison<string> comparison = new Comparison<string>(sort.CompareLength);
            Array.Sort(array, comparison);
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }
            #endregion
        }
    }
}
