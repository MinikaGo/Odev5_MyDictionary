using System;
using System.Collections.Generic;

namespace Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(123, "Ümit Sinanoğlu");
            myDictionary.Add(345, "Kerem Tunçyürek");
            myDictionary.Add(999, "Mine Sinanoğlu");
           
            

        }
    }

}
