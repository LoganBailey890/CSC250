using System;

namespace Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            int[] items = { 2, 10, 13, 15, 17, 32, 36, 45, 67, 69, 420 };
            int target = 69;

            watch.Start();
            //int indexFound = Linear.SearchLinear(items, target);
            int indexFound = BianarySearch.SearchBianary(items, target, 0, items.Length - 1);
            watch.Stop();

            if(indexFound != -1)
            {
                Console.WriteLine(target + " was found at Index: " + indexFound);
                Console.WriteLine("Item at the index is: " +items[indexFound]);
            }
            else
            {
                Console.WriteLine(target + " was not found in the array");
            }
            var watchElapshe = watch.ElapsedMilliseconds != 0 ? watch.ElapsedMilliseconds : watch.ElapsedTicks;
            Console.ReadLine();
        }
    }
}
