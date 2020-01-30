using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{/// <summary>
/// Custom Collection consist of integer element.
/// </summary>
    class CustomCollectionArray
    {
        #region "Declaration"
        public Int32[] array = null;
        int n,count;
        #endregion

        #region "Constructor"
        public CustomCollectionArray()
        {
            n = 4;
            count = 0;
        }
        #endregion

        #region "Init Method"
        /// <summary>
        /// Initialization of array.
        /// </summary>
        private void init()
        {
            array = new Int32[n];
        }
        #endregion

        #region "Insert Method"
        /// <summary>
        /// Insert an element into array.
        /// <code>insert(int element)</code>
        /// </summary>
        /// <param name="a">Element to be inserted into array.</param>
        public void insert(int a)
        {
            if(count==0)
            {
                init();
            }

            if(count==n)
            {
                n = n * 2;
                Array.Resize<Int32>(ref array, n);
                
            }

            array[count] = a;
            count++;
        }
        #endregion

        #region "Element At Index Method"
        /// <summary>
        /// Used to find the location or index of the element 
        /// <code>indexof(int element)</code>
        /// </summary>
        /// <param name="a">Element of the array whose index to be found.</param>
        /// <returns>Returns the location in string.</returns>
        public string elementAtIndex(int a)
        {
            if (a > count)
                return "Index not available";
            else
                return array[a].ToString();
        }
        #endregion

        #region "Capacity Method"
        /// <summary>
        /// Prvoide the capacity of the array list.
        /// <code>capacity()</code>
        /// </summary>
        /// <returns>Returns integer value. </returns>
        public int capacity()
        {
            if(array==null)
            {
                return 0;
            }

            return n;
        }
        #endregion

        #region "Find Method"
        /// <summary>
        /// Used find whether the element is present in the array or not.
        /// <code>find(int element)</code>
        /// </summary>
        /// <param name="a">Element to be found.</param>
        /// <returns>String value whether it is present in array or not with its location.</returns>
        public string find(int a)
        {
            int flag = 0;
            int i;
            for (i = 0; i < count; i++)
            {
                if(a==array[i])
                {
                    flag = 1;
                    break;
                }
            }

            if(flag==1)
            {
                return a+" found at location "+i+". ";
            }
            else
            {
                return a + " is not in the arraylist.";
            }

        }
        #endregion

        #region "Find Method for other function"
        /// <summary>
        /// Used to find the element in array list. Used by delete function.
        /// <code>deleteFind(int element)</code>
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Return integer value of element's location.</returns>
        private int Find(int a)
        {
            int flag = 0;
            int i;
            for (i = 0; i < count; i++)
            {
                if (a == array[i])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                return i;
            }
            else
            {
                return -1;
            }

        }
        #endregion

        #region "Sort Method"
        /// <summary>
        /// Sort the elements in ascending order.
        /// <code>sort()</code>
        /// </summary>
        public void sort()
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < (count - i); j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }

                }
            }
            Console.WriteLine("List after sorting the elements. ");
            display();
        }
        #endregion

        #region "Display Method"
        /// <summary>
        /// Used to display the elements from the array.
        /// </summary>
        public void display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region "Delete Method"
        /// <summary>
        /// Used to delete the element from the array.
        /// <code>delete(int element)</code>
        /// </summary>
        /// <param name="a">Element to be deleted </param>
        public string delete(int a)
        {
            if (count == 0)
            {
                return "List is empty";
            }
            else
            {
                int result = Find(a);

                if (result == -1)
                    Console.WriteLine("Element is not present in the array. ");
                else
                {
                    for (int i = result; i < (count - 1); i++)
                    {
                        array[i] = array[i + 1];
                    }
                    count--;

                    Int32[] copyarray = new Int32[count];
                    Array.Copy(array, 0, copyarray, 0, count);

                    array = null;
                    array = new Int32[n];
                    Array.Copy(copyarray, 0, array, 0, count);

                    Console.WriteLine("List after deleting the element. ");
                    display();
                }
                return "Deleted successfully.";
            }

        }
        #endregion

        #region "Count Method"
        /// <summary>
        /// Number elements in the array list.
        /// </summary>
        /// <returns>Integer Value.</returns>
        public int Count()
        {
            return count;
        }
        #endregion
    }
}
