using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int [] array = new int [20];

            Console.WriteLine("フィボナッチ数列");

            Console.Write("数値のみ入力し、Enterを押してください \n" + "数値1 ＝　");
            array[0] = int.Parse(Console.ReadLine());



            Console.Write("数値2 ＝　");
            array[1] = int.Parse(Console.ReadLine()); 

            for(int i=2; i<array.Length; ++i)
            {
            array[i] = array[i-1] + array[i-2];
            
            }


            for(int i=0; i<array.Length-1; ++i)
            {
            
                Console.Write(array[i] + ",");
            }

        }
    }
}
