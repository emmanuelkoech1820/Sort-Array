using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] array = new string [5] { "1", "2", "3", "4", "5" };
            for(int i = array.Length-1; i>=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            for(int i =0; i<array.Length-1; i++)
            {
                for (int j = i+1; j<array.Length; j++)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

            }
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }

}
