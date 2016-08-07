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


            try
            {
                Console.WriteLine("フィボナッチ数列");

                Console.Write("数値のみ入力し、Enterを押してください \n" + "数値1 ＝　");


                array[0] = int.Parse(Console.ReadLine());

            }

            catch(System.FormatException e)
            {
                Console.WriteLine("Error\n/全角で入力されました\n/半角の数字で入力してください");
            }


            try
            {

                Console.Write("数値2 ＝　");
                array[1] = int.Parse(Console.ReadLine());
            }

            catch(System.FormatException e)
            {
                Console.WriteLine("Error\n/全角で入力されました\n/半角の数字で入力してください");
            }

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
