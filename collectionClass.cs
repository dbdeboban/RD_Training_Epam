using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ImplementAllCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region"Non - Generic Collections"
            Console.WriteLine("Non - Generic Collections");

            #region "ArrayList"
            Console.WriteLine("ArrayList");
            ArrayList arr = new ArrayList();
            string str = "abc";
            int x = 7;
            float y = 8.66f;
            arr.Add(str);
            arr.Add(x);
            arr.Add(y);

            foreach (object o in arr)
            {
                Console.WriteLine(o);
            }
            #endregion


            #region "Hashtable"
            Console.WriteLine("Hashtable");
            // Create a hashtable 
            // Using Hashtable class 
            Hashtable my_hashtable1 = new Hashtable();

            // Adding key/value pair 
            // in the hashtable 
            // Using Add() method 

            Hashtable my_hashtable2 = new Hashtable() {
                                    {1, "one"},
                                        {2, "two"},
                                        {3, "three"},
                                        {4, "four"}};

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine(ele2);
            }
            #endregion


            #region"SortedList"
            Console.WriteLine("SortedList");
            SortedList SL = new SortedList();
            SL.Add("5", "abc");
            SL.Add("4", "absafg");
            SL.Add("55", "sgasgfr");
            foreach (var ele2 in SL.Keys)
            {
                Console.WriteLine(ele2);
            }

            #endregion


            #region "Stack"
            Console.WriteLine("Stack");
            Stack St = new Stack();
            St.Push("A");
            St.Push("B");
            St.Push("C");
            Console.WriteLine(St.Pop());

            #endregion


            #region "Queue"
            Console.WriteLine("Queue");
            Queue q = new Queue();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            Console.WriteLine(q.Count);
            Console.WriteLine(q.Dequeue());
            #endregion

            #endregion


            #region "Generic Collections"
            Console.WriteLine("Generic Collections");

            #region "List"
            Console.WriteLine("List");
            List<int> a = new List<int>();

            a.Add(12);
            a.Add(44);
            a.Add(99);
            a.Add(15);
            a.Add(3);

            Console.WriteLine(a.Count);
            a.RemoveAt(0);
            foreach (int obj in a)
            {
                Console.WriteLine(obj);
            }
            #endregion


            #region "Dictionary"
            Console.WriteLine("Dictionary");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("abc", 1);
            dict.Add("bcd", 2);
            dict.Add("cad", 4);

            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            #endregion


            #region"SortedList"
            Console.WriteLine("SortedList");
            SortedList<string, int> SortedL = new SortedList<string, int>();

            SortedL.Add("Abc", 7);
            SortedL.Add("AAA", 9);
            SortedL.Add("bbb", 3);

            foreach (KeyValuePair<String, int> SLObj in SortedL)
            {
                Console.WriteLine(SLObj.Key + " " + SLObj.Value);
            }
            #endregion


            #region"Stack"
            Console.WriteLine("Stack");
            Stack<int> GCStack = new Stack<int>();
            GCStack.Push(58);
            GCStack.Push(47);
            GCStack.Push(44);
            GCStack.Push(51);

            Console.WriteLine(GCStack.Count);
            Console.WriteLine(GCStack.Pop());
            Console.WriteLine(GCStack.Count);
            Console.WriteLine(GCStack.Peek());
            #endregion


            #region "Queue"
            Console.WriteLine("Queue");
            Queue<int> GCQueue = new Queue<int>();

            GCQueue.Enqueue(478);
            GCQueue.Enqueue(745);
            GCQueue.Enqueue(63);
            GCQueue.Enqueue(453);
            GCQueue.Enqueue(456);

            Console.WriteLine(GCQueue.Dequeue());

            Console.WriteLine(GCQueue.Count);

            Console.WriteLine(GCQueue.Peek());

            #endregion

            #endregion

            #region"Concurrent Collections"
            Console.WriteLine("Concurrent Classes");


            #region"BlockingCollection"
            Console.WriteLine("Blocking Collection");

            BlockingCollection<int> BColl = new BlockingCollection<int>(boundedCapacity:3);

            BColl.Add(45);
            BColl.Add(54);
            BColl.Add(86);
            BColl.Add(548);

            //foreach (int item in BColl.GetConsumingEnumerable())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region"ConcurrentBag"
            Console.WriteLine("ConcurrentBag");


            #endregion

            #region"ConcurrentStack"
            Console.WriteLine("ConcurrentStack");

            ConcurrentStack<int> ConnStack = new ConcurrentStack<int>();
            ConnStack.Push(1);
            ConnStack.Push(2);
            ConnStack.Push(3);


            foreach (var item in ConnStack)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region"ConcurrentQueue"
            Console.WriteLine("Concurrent Queue");

            ConcurrentQueue<int> ConnQueue = new ConcurrentQueue<int>();

            ConnQueue.Enqueue(487);
            ConnQueue.Enqueue(543);
            ConnQueue.Enqueue(251);

            ConnQueue.TryDequeue(543);

            foreach(int item in ConnQueue)
            {
                Console.WriteLine("item");
            }
            #endregion

            #region"ConcurrentDictionary"
            Console.WriteLine("ConcurrentDictionary");


            #endregion

            #region"Partitioner       "
            Console.WriteLine("");
            #endregion

            #region"OrderablePartition"
            Console.WriteLine("");
            #endregion

            #endregion


        }

    }
}
