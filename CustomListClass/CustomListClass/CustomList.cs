using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class CustomList<T>
    {


        T[] array;
        int capacity;
        int count;
        int index;
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
        
           if(this.Count == 0)
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
            
            if( capacityCheck >= .80)
            {
                IncreaseCapacity();
            }
           
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

        public void Remove()
        {
            
        }

        








    }
}
