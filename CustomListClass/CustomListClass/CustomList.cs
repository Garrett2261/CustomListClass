using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>:IEnumerable
    {


        T[] array;
        int capacity;
        int count;
        //int index;
        double capacityCheck;




        //add method

        // c# indexer google it
        // T value --> methods?
        public CustomList()
        {
            capacity = 5;
            array = new T[capacity];
            count = 0;

        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public bool Contains(T valueInArray)
        {
            CustomList<T> list = new CustomList<T>();
            for(int i = 0; i < list.Count; i++)
            {
                if (valueInArray.Equals(list[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public int Index(T indexValue)
        {
            int index = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(indexValue))
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public void Add(T valueToAdd)
        {
            if (this.Count == 0)
            {
                array[0] = valueToAdd;
                count++;
            }
            else
            {
                array[Count] = valueToAdd;
                count++;
            }
            // cast an int to a double
            capacityCheck = ((double)count / capacity);
            if (capacityCheck >= .80)
            {
                IncreaseCapacity();
            }
        }

        

        

        public void Remove(T valueToRemove)
        {
            //For the remove function, take in a value to remove and if that value is equal to a value in the array list, then that value will be removed. 
            T[] newArray = new T[capacity];
            if (true)
            {

            }
            if(this.Count > 0)
            {
                
                for(int i = 0; i < Count; i++)
                {
                    if (this.Index(valueToRemove) == i)
                    {
                        count--;
                    }
                    else
                    {
                        if(this.Index(valueToRemove) < i)
                        {

                        }
                    }
                }
                count--;
            }
            
            //possibly think of making a new array 
        }
        public void IncreaseCapacity()
        {
            capacity = capacity * 2;
            T[] newArray = new T[capacity];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
            capacityCheck = 0;
        }
        //public void DecreaseCapacity()
        //{

        //}

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < Count; i++)
            {
                stringBuilder.Append(array[i] + " ");
            }
            return stringBuilder.ToString();
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = new CustomList<T>();
            for(int i = 0; i < list1.Count; i++)
            {
                list.Add(list1[i]);
            }
            for(int i = 0; i < list2.Count; i++)
            {
                list.Add(list2[i]);
            }
            return list;
        }
        public static CustomList<T> operator-(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list = list1;
            for(int i = 0; i < list1.Count && i < list2.Count; i++)
            {
                if (list1.Contains(list2[i]))
                {
                    list.Remove(list2[i]);
                }
            }
            return list;
        }
    }
}
