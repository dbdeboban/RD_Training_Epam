using System;

namespace CustomCollections

{

    class CustomCollectionClass<Object>

        {

            #region "Declaration"
            //Declaration of data members
            public Object[] DataArray;

            private int StepSize;
            private int Counter;

            #endregion

            #region "Constructor Declaration"
            //Constructor Declaration
            public CustomCollectionClass ()

            {

                StepSize = 4;

                Counter = 0;

            }
            #endregion

            #region "Initialization"
            //Initializing the dataArray
            private void init () {
                DataArray = new Object[StepSize];
            }
            #endregion

            #region "Insertion of two types"
            //The Insert Methord
            public void add (Object Obj)

            {

                if (Counter == 0)

                {

                    init ();

                }

                if (Counter == StepSize)

                {

                    StepSize *= 2;

                    Array.Resize<Object> (ref DataArray, StepSize);

                }

                DataArray[Counter] = Obj;

                Counter++;

            }

            public void insert (Object Obj, int position)

            {
                if (Counter == 0)

                {

                    init ();

                }

                if (Counter == StepSize)

                {

                    StepSize *= 2;

                    Array.Resize<Object> (ref DataArray, StepSize);

                }

                for (int i = Counter; i > position; i--)

                {

                    DataArray[i] = DataArray[i - 1];

                }

                DataArray[position] = Obj;

            }

            #endregion

            #region "Deletion of given Object"
            //Deleting the given Object
            public void delete (Object a)

            {

                if (Counter == 0)

                {

                    throw new Exception ("The ArrayList is Empty");

                } else

                {

                    int indexAt = find (a) - 1;

                    if (indexAt == -1)

                    {

                        throw new Exception ("The Element is not present in the ArrayList");

                    } else

                    {

                        for (int i = indexAt; i < (Counter - 1); i++)

                        {

                            DataArray[i] = DataArray[i + 1];

                        }

                        Counter--;

                        Array.Copy (DataArray, 0, DataArray, 0, Counter);

                    }

                }

            }

            #endregion

            #region "Capacity"
            //Returns Capacity
            public int capacity ()

            {

                if (DataArray == null)

                {

                    return 0;

                } else

                    return StepSize;

            }
            #endregion

            #region "Number of Elements"
            //Returning the number of elements
            public int length ()

            {

                return Counter;

            }
            #endregion
            
            #region "Finding if object present(Contains)"
            //Finding that the given object uis contained in the ArrayList
            public bool contains (Object Obj)

            {

                for (int i = 0; i < Counter; i++)

                {

                    if (Obj.Equals (DataArray[i]))

                    {

                        return true;

                    }

                }

                return false;

            }
            #endregion

            #region "Find element position"
            //Returning position of element if present
            public int find (Object a)

            {

                for (int i = 0; i < Counter; i++)

                {

                    if (a.Equals (DataArray[i]))

                    {

                        return (i + 1);

                    }

                }

                return -1;

            }

            #endregion

            #region "Sorting"
            //sorting the given list

            public void sort ()

            {

                for (int i = 0; i < Counter; i++)

                {

                    for (int j = 1; j < (Counter - i); j++)

                    {

                        if (int.Parse (DataArray[j - 1].ToString ()) > int.Parse (DataArray[j].ToString ()))

                        {

                            Object temp = DataArray[j - 1];

                            DataArray[j - 1] = DataArray[j];

                            DataArray[j] = temp;

                        }

                    }

                }

            }
            #endregion

            #region "Display"
            //Displaying the whole ArrayList
            public void show ()

            {

                for (int i = 0; i < Counter; i++)

                {

                    Console.WriteLine (DataArray[i]);

                }

                Console.WriteLine ("\n");

            }
            #endregion

            #region "Get object at given Index"
            //Getting the object at the given Index
            public Object objectAtIndex (int Index)

            {

                return DataArray[a];

            }
            #endregion

        }

}