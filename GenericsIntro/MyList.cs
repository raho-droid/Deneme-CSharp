using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>                 //Buradaki T listede kullanılacak elemanların int string ... çeşitli olmasını sağlar.
    {
        T[] items;
        public MyList()             //Classı her newlediğimizde burası otomatik çalışır. Buraya constucter denir classla aynı isimdedir.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; 
        }
    }
}
