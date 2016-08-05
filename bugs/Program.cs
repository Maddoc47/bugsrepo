using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace bugs
{

    class myContainer<T>
    {
        private T[] nameList;

        //indexers allow accessing a class through an index to retrieve data in the connected backingfield

        public myContainer()
        {
            nameList = new T[1];
        }

        public myContainer(int length)
        {
            nameList = new T[length];
        }

        public T this[int i]
        {
            get
            {
                return nameList[i];
            }
            set
            {
                nameList[i] = value;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            myContainer<string> BugList = new myContainer<string>(3);

            BugList[0] = "Ant";
            BugList[1] = "Fly";
            BugList[2] = "Wasp";

            Console.WriteLine("{0} - {1}", BugList[0], BugList[1]);
            Console.WriteLine("{0} - {1}", BugList[1], BugList[2]);

            Console.WriteLine("{0} - {1}", BugList[1], BugList[2]);
            Console.WriteLine("{0} - {1}", BugList[1], BugList[2]);
            Console.WriteLine("Wooooop wooop wooop");
            Console.WriteLine("Wooooop wooop wooop");
            Console.WriteLine("Wooooop wooop wooop");
            Console.WriteLine("Wooooop wooop wooop");
            Console.WriteLine("Wooooop wooop wooop");
            Console.WriteLine("Wooooop wooop wooop");
            Console.ReadLine();
        }
    }
}

