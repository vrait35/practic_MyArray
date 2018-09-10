using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMas;
using static System.Console;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
           MyArray<string> myArray = new MyArray<string>(3);
            WriteLine(myArray.Count);
            WriteLine(myArray.Capacity);

            myArray.Add("asd");
            WriteLine(myArray.Count);
            WriteLine(myArray.Capacity);

            myArray.Resize(0);
            WriteLine(myArray.Count);
            WriteLine(myArray[2]);
        }
    }
}
