using System;

namespace DsAlgoQuestion
{
    class MainDriverCode
    {
        static void Main(string[] args)
        {
           
            int[] arr = { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            int res = BinarySearchProgram.BinarySearch(arr,45);
            Console.WriteLine(res);
             Console.ReadLine();
        }
    }
}
