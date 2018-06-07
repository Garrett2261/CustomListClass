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


        //add method
      
        // c# indexer google it
        // T value --> methods?
        public CustomList()
        {
            capacity = 5;
            array = new T[capacity];
            count = 0;
            
        }

        // indexer

        public void Add()
        {
            
        }



    }
}
